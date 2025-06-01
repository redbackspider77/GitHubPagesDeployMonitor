namespace GitHubDeployMonitor
{
    partial class SettingsForm
    {
        private Label label1;
        private Label label2;
        private TextBox repoTextBox;
        private RadioButton publicKeyRadio;
        private RadioButton privateKeyRadio;
        private TextBox apiKeyTextBox;
        private Button saveButton;
        private Button infoButton;

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.repoTextBox = new TextBox();
            this.publicKeyRadio = new RadioButton();
            this.privateKeyRadio = new RadioButton();
            this.apiKeyTextBox = new TextBox();
            this.saveButton = new Button();
            this.infoButton = new Button();
            this.SuspendLayout();
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(260, 15);
            this.label1.Text = "GitHub Page To Monitor Directory (owner/repo):";
            // repoTextBox
            this.repoTextBox.Location = new Point(12, 27);
            this.repoTextBox.Size = new Size(260, 23);
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 60);
            this.label2.Size = new Size(117, 15);
            this.label2.Text = "Use private API key?";
            // publicKeyRadio
            this.publicKeyRadio.AutoSize = true;
            this.publicKeyRadio.Location = new Point(12, 78);
            this.publicKeyRadio.Text = "No";
            // privateKeyRadio
            this.privateKeyRadio.AutoSize = true;
            this.privateKeyRadio.Location = new Point(12, 100);
            this.privateKeyRadio.Text = "Yes (enter below)";
            // apiKeyTextBox
            this.apiKeyTextBox.Location = new Point(12, 125);
            this.apiKeyTextBox.Size = new Size(260, 23);
            // saveButton
            this.saveButton.Location = new Point(12, 160);
            this.saveButton.Size = new Size(120, 23);
            this.saveButton.Text = "Save and Start";
            this.saveButton.Click += saveButton_Click;
            // infoButton
            this.infoButton.Location = new Point(200, 75);
            this.infoButton.Size = new Size(24, 24);
            this.infoButton.Text = "?";
            this.infoButton.Click += infoButton_Click;
            // SettingsForm
            this.ClientSize = new Size(284, 195);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.apiKeyTextBox);
            this.Controls.Add(this.privateKeyRadio);
            this.Controls.Add(this.publicKeyRadio);
            this.Controls.Add(this.repoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}