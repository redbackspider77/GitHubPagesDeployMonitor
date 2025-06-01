using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubDeployMonitor
{
    public partial class Form1 : Form
    {
        private readonly NotifyIcon trayIcon;
        private readonly System.Windows.Forms.Timer checkTimer;
        private readonly AppConfig config;
        private string lastSha = string.Empty;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        public Form1(AppConfig loadedConfig)
        {
            config = loadedConfig;
            InitializeComponent();

            trayIcon = new NotifyIcon
            {
                Icon = SystemIcons.Application,
                Text = "GitHub Pages Monitor",
                Visible = true,
                ContextMenuStrip = new ContextMenuStrip()
            };
            trayIcon.ContextMenuStrip.Items.Add("Settings", null, OpenSettings);
            trayIcon.ContextMenuStrip.Items.Add("Exit", null, (s, e) => Application.Exit());
            trayIcon.BalloonTipClicked += TrayIcon_BalloonTipClicked;

            checkTimer = new System.Windows.Forms.Timer { Interval = Properties.Settings.Default.CheckInterval };
            checkTimer.Tick += async (s, e) => await CheckGitHub();

            // Pre-load SHA and start timer
            _ = InitializeMonitorAsync();
        }

        private async Task InitializeMonitorAsync()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "GitHubDeployMonitor");
            if (config.UsePrivateKey && !string.IsNullOrWhiteSpace(config.ApiKey))
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {config.ApiKey}");

            try
            {
                var url = $"https://api.github.com/repos/{Properties.Settings.Default.RepoDirectory}/commits/main";
                var response = await client.GetAsync(url);

                if (response.StatusCode == HttpStatusCode.Forbidden)
                {
                    trayIcon.BalloonTipTitle = "❌ Rate Limited";
                    trayIcon.BalloonTipText = "GitHub API rate limit exceeded. Use an API key to avoid this.";
                    trayIcon.ShowBalloonTip(3000);
                    return;
                }

                var content = await response.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(content);
                lastSha = doc.RootElement.GetProperty("sha").GetString() ?? string.Empty;
                checkTimer.Start();
            }
            catch
            {
                ShowRepoError();
            }
        }

        private void OpenSettings(object? sender, EventArgs e)
        {
            checkTimer.Stop();
            using var form = new SettingsForm(config);
            form.ShowDialog();
            InitializeMonitorAsync().ConfigureAwait(false);
        }

        private async Task CheckGitHub()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "GitHubDeployMonitor");

            if (config.UsePrivateKey && !string.IsNullOrWhiteSpace(config.ApiKey))
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {config.ApiKey}");

            try
            {
                var url = $"https://api.github.com/repos/{Properties.Settings.Default.RepoDirectory}/commits/main";
                var response = await client.GetAsync(url);

                // ✅ Rate limit = HTTP 403 and contains "documentation_url"
                if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    trayIcon.BalloonTipTitle = "❌ Rate Limited";
                    trayIcon.BalloonTipText = "GitHub API rate limit exceeded. Use an API key to avoid this.";
                    trayIcon.ShowBalloonTip(3000);
                    return;
                }

                // ✅ Safe to parse now
                var content = await response.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(content);
                var sha = doc.RootElement.GetProperty("sha").GetString();

                if (!string.IsNullOrEmpty(sha) && sha != lastSha)
                {
                    lastSha = sha;
                    trayIcon.ShowBalloonTip(1000, "📦 New Push", "New push detected.", ToolTipIcon.Info);
                    _ = MonitorChecksAsync(sha);
                }
            }
            catch
            {
                ShowRepoError();
            }
        }

        private void ShowRepoError()
        {
            trayIcon.BalloonTipTitle = "❌ Repo Error";
            trayIcon.BalloonTipText = "Repository not found or private. Click to update settings.";
            trayIcon.ShowBalloonTip(3000);
        }

        private async Task MonitorChecksAsync(string sha)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "GitHubDeployMonitor");
            if (config.UsePrivateKey && !string.IsNullOrWhiteSpace(config.ApiKey))
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {config.ApiKey}");

            while (true)
            {
                await Task.Delay(5000);
                try
                {
                    var url = $"https://api.github.com/repos/{Properties.Settings.Default.RepoDirectory}/commits/{sha}/check-runs";
                    var resp = await client.GetStringAsync(url);
                    var doc = JsonDocument.Parse(resp);
                    var checks = doc.RootElement.GetProperty("check_runs");
                    int total = checks.GetArrayLength();
                    int completed = checks.EnumerateArray().Count(c => c.GetProperty("status").GetString() == "completed");
                    if (completed == total && total > 0)
                    {
                        trayIcon.ShowBalloonTip(1000, "✅ Deploy Complete", "Your GitHub Page has been updated.", ToolTipIcon.Info);
                        break;
                    }
                }
                catch
                {
                    // ignore
                }
            }
        }

        private void TrayIcon_BalloonTipClicked(object? sender, EventArgs e)
        {
            OpenSettings(sender, e);
        }
    }
}