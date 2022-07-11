using System.Diagnostics;
using System.Windows.Forms;

namespace calc {
    public partial class frmAbout : Form {
        public frmAbout() {
            InitializeComponent();
            LoadLanguage();
            pbIcon.Image = Properties.Resources.Icon32;
            lbVersion.Text = $"v{(Program.IsBetaVersion ? Program.BetaVersion : Program.CurrentVersion)}";
        }

        private void LoadLanguage() {
            lbAboutBody.Text = string.Format("calc by murrty\ndebug date {0}\nperhaps text will occupy this space.\nmaybe some day.\n\nyeah.", Properties.Resources.BuildDate);
            llbCheckForUpdates.Text = "Check for update";
            this.Text = "About calc";
        }

        private void llbCheckForUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://github.com/murrty/calc/releases");
        }

        private void pbIcon_Click(object sender, EventArgs e) =>
            Process.Start("https://github.com/murrty/calc/");

        private void llbGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            Process.Start("https://github.com/murrty/calc/");
    }
}
