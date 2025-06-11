using System;
using System.Drawing;
using System.Windows.Forms;

namespace GitHubDeployMonitor
{
    public partial class SettingsForm : Form
    {

        public SettingsForm()
        {
            InitializeComponent();

            repoTextBox.Text = Properties.Settings.Default.RepoDirectory;
            apiKeyTextBox.Text = Properties.Settings.Default.ApiKey;
            privateKeyRadio.Checked = Properties.Settings.Default.UsePrivateKey;
            publicKeyRadio.Checked = !Properties.Settings.Default.UsePrivateKey;
            listBox.Items.Clear();
            if (Properties.Settings.Default.NamesToIgnore != null)
            {
                foreach (var item in Properties.Settings.Default.NamesToIgnore)
                {
                    listBox.Items.Add(item);
                }
            }
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
                MessageBox.Show("Please enter your GitHub API key.");
                return;
            }

            var ignoreList = new System.Collections.Specialized.StringCollection();
            foreach (var item in listBox.Items)
            {
                ignoreList.Add(item.ToString());
            }

            Properties.Settings.Default.NamesToIgnore = ignoreList;
            Properties.Settings.Default.RepoDirectory = repoTextBox.Text.Trim();
            Properties.Settings.Default.CheckInterval = (int)numInterval.Value;
            Properties.Settings.Default.ApiKey = apiKeyTextBox.Text.Trim();
            Properties.Settings.Default.UsePrivateKey = privateKeyRadio.Checked;
            Properties.Settings.Default.Save();

            MessageBox.Show("Settings saved and program started monitoring!");
            Close();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            using (var info = new infoForm())
                info.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(addString.Text))
            {
                listBox.Items.Add(addString.Text.Trim());
                addString.Clear();
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}