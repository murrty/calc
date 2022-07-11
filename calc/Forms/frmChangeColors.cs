using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc {
    public partial class frmChangeColors : Form {

        /// <summary>
        /// Gets or sets the background color for the output box.
        /// </summary>
        public Color SetBackgroundColor {
            get; set;
        } = Color.FromKnownColor(KnownColor.ControlLight);

        /// <summary>
        /// Gets or sets the background color for the bit box.
        /// </summary>
        public Color SetBitBackgroundColor {
            get; set;
        } = Color.FromKnownColor(KnownColor.ControlLight);

        /// <summary>
        /// Gets or sets the fore color for both bit and output boxes.
        /// </summary>
        public Color SetForeColor {
            get; set;
        } = Color.FromKnownColor(KnownColor.ControlText);

        /// <summary>
        /// Gets or sets the faded forecolor for both bit and output boxes.
        /// </summary>
        public Color SetFadedForeColor {
            get; set;
        } = Color.FromKnownColor(KnownColor.ControlDark);

        public frmChangeColors() {
            InitializeComponent();
        }
        private void frmChangeColors_Load(object sender, EventArgs e) {
            pnOutputBackgroundColor.BackColor = SetBackgroundColor;
            btnResetOutputBackgroundColor.Visible = btnResetOutputBackgroundColor.Enabled = !Ini.ColorsMatch(SetBackgroundColor, Color.FromKnownColor(KnownColor.ControlLight));
            pnBitBackgroundColor.BackColor = SetBitBackgroundColor;
            btnResetBitBackgroundColor.Visible = btnResetBitBackgroundColor.Enabled = !Ini.ColorsMatch(SetBitBackgroundColor, Color.FromKnownColor(KnownColor.ControlLight));
            pnForeColor.BackColor = SetForeColor;
            btnResetForeColor.Visible = btnResetForeColor.Enabled = !Ini.ColorsMatch(SetForeColor, Color.FromKnownColor(KnownColor.ControlText));
            pnFadedForeColor.BackColor = SetFadedForeColor;
            btnResetFadedForeColor.Visible = btnResetFadedForeColor.Enabled = !Ini.ColorsMatch(SetFadedForeColor, Color.FromKnownColor(KnownColor.ControlDark));
        }

        private void btnChangeOutputBackgroundColor_Click(object sender, EventArgs e) {
            using frmColorPickerDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK) {
                pnOutputBackgroundColor.BackColor = cd.Color;
            }
        }
        private void btnResetOutputBackgroundColor_Click(object sender, EventArgs e) {
            pnOutputBackgroundColor.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
        }

        private void btnChangeBitBackgroundColor_Click(object sender, EventArgs e) {
            using frmColorPickerDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK) {
                pnBitBackgroundColor.BackColor = cd.Color;
            }
        }
        private void btnResetBitBackgroundColor_Click(object sender, EventArgs e) {
            pnBitBackgroundColor.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
        }

        private void btnChangeForeColor_Click(object sender, EventArgs e) {
            using frmColorPickerDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK) {
                pnForeColor.BackColor = cd.Color;
            }
        }
        private void btnResetForeColor_Click(object sender, EventArgs e) {
            pnForeColor.BackColor = Color.FromKnownColor(KnownColor.ControlText);
        }

        private void btnChangeFadedForeColor_Click(object sender, EventArgs e) {
            using frmColorPickerDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK) {
                pnFadedForeColor.BackColor = cd.Color;
            }
        }
        private void btnResetFadedForeColor_Click(object sender, EventArgs e) {
            pnFadedForeColor.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
        }

        private void btnOK_Click(object sender, EventArgs e) {
            SetBackgroundColor = pnOutputBackgroundColor.BackColor;
            SetBitBackgroundColor = pnBitBackgroundColor.BackColor;
            SetForeColor = pnForeColor.BackColor;
            SetFadedForeColor = pnFadedForeColor.BackColor;
            this.DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
