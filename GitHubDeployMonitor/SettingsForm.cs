using System;
using System.Drawing;
using System.Windows.Forms;

namespace GitHubDeployMonitor
{
    public partial class SettingsForm : Form
    {
        private readonly AppConfig config;

        public SettingsForm(AppConfig currentConfig)
        {
            config = currentConfig;
            InitializeComponent();
            
            apiKeyTextBox.Text = config.ApiKey;
            privateKeyRadio.Checked = config.UsePrivateKey;
            publicKeyRadio.Checked = !config.UsePrivateKey;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(repoTextBox.Text))
            {
                MessageBox.Show("Please enter a GitHub repo like 'username/repo'.");
                return;
            }
            if (privateKeyRadio.Checked && string.IsNullOrWhiteSpace(apiKeyTextBox.Text))
            {
                MessageBox.Show("Please enter your GitHub API key when using private mode.");
                return;
            }

            Properties.Settings.Default.RepoDirectory = repoTextBox.Text.Trim();
            Properties.Settings.Default.CheckInterval = (int)numInterval.Value;
            Properties.Settings.Default.Save();
            config.ApiKey = apiKeyTextBox.Text.Trim();
            config.UsePrivateKey = privateKeyRadio.Checked;
            config.Save();

            MessageBox.Show("Settings saved.");
            Close();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            using (var info = new infoForm())
                info.ShowDialog();
        }
    }
}