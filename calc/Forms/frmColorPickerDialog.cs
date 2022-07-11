using System.Drawing;
using System.Windows.Forms;

namespace calc {
    public partial class frmColorPickerDialog : Form {

        private bool SelectingKnownColor = false;

        public Color Color {
            get; set;
        } = Color.FromKnownColor(KnownColor.Control);

        public frmColorPickerDialog() {
            InitializeComponent();
            numRed.Value = Color.R;
            numGreen.Value = Color.G;
            numBlue.Value = Color.B;
            cbKnownColors.SelectedIndex = 0;
        }

        private void btnSystemColorPicker_Click(object sender, EventArgs e) {
            using ColorDialog cd = new();
            cd.AnyColor = false;
            cd.FullOpen = true;
            cd.SolidColorOnly = true;
            if (cd.ShowDialog() == DialogResult.OK) {
                Color = cd.Color;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cbKnownColors_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbKnownColors.SelectedIndex > 0) {
                SelectingKnownColor = true;
                pnDisplayColor.BackColor = Color.FromKnownColor((KnownColor)cbKnownColors.SelectedIndex);
                numRed.Value = pnDisplayColor.BackColor.R;
                numGreen.Value = pnDisplayColor.BackColor.G;
                numBlue.Value = pnDisplayColor.BackColor.B;
                SelectingKnownColor = false;
            }
            else {
                pnDisplayColor.BackColor = Color.FromArgb((int)numRed.Value, (int)numGreen.Value, (int)numBlue.Value);
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            Color = pnDisplayColor.BackColor;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void numRed_ValueChanged(object sender, EventArgs e) {
            if (!SelectingKnownColor) {
                pnDisplayColor.BackColor = Color.FromArgb((int)numRed.Value, (int)numGreen.Value, (int)numBlue.Value);
            }
        }

        private void numGreen_ValueChanged(object sender, EventArgs e) {
            if (!SelectingKnownColor) {
                pnDisplayColor.BackColor = Color.FromArgb((int)numRed.Value, (int)numGreen.Value, (int)numBlue.Value);
            }
        }

        private void numBlue_ValueChanged(object sender, EventArgs e) {
            if (!SelectingKnownColor) {
                pnDisplayColor.BackColor = Color.FromArgb((int)numRed.Value, (int)numGreen.Value, (int)numBlue.Value);
            }
        }

    }
}
