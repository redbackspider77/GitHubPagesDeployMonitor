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
            using (var settings = new SettingsForm())
            {
                Application.Run(settings);
            }

            // Start tray monitor
            Application.Run(new Form1());
        }
    }
}