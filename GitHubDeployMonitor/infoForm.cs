using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GitHubDeployMonitor
{
    public partial class infoForm : Form
    {
        private const string apiUrl = "https://github.com/settings/personal-access-tokens/new?type=fine-grained";

        public infoForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = apiUrl,
                UseShellExecute = true
            });
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}