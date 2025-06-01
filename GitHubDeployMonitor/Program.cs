using System;
using System.Windows.Forms;

namespace GitHubDeployMonitor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load config and show settings first
            var config = AppConfig.Load();
            using (var settings = new SettingsForm(config))
            {
                Application.Run(settings);
            }

            // Start tray monitor
            Application.Run(new Form1(config));
        }
    }
}