namespace calc {
    partial class frmColorPickerDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnSystemColorPicker = new System.Windows.Forms.Button();
            this.pnDialogOptions = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnDisplayColor = new System.Windows.Forms.Panel();
            this.lbKnownColor = new System.Windows.Forms.Label();
            this.cbKnownColors = new System.Windows.Forms.ComboBox();
            this.lbRGB = new System.Windows.Forms.Label();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.numBlue = new System.Windows.Forms.NumericUpDown();
            this.pnDialogOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSystemColorPicker
            // 
            this.btnSystemColorPicker.Location = new System.Drawing.Point(12, 8);
            this.btnSystemColorPicker.Name = "btnSystemColorPicker";
            this.btnSystemColorPicker.Size = new System.Drawing.Size(96, 23);
            this.btnSystemColorPicker.TabIndex = 0;
            this.btnSystemColorPicker.Text = "System picker...";
            this.btnSystemColorPicker.UseVisualStyleBackColor = true;
            this.btnSystemColorPicker.Click += new System.EventHandler(this.btnSystemColorPicker_Click);
            // 
            // pnDialogOptions
            // 
            this.pnDialogOptions.BackColor = System.Drawing.SystemColors.Menu;
            this.pnDialogOptions.Controls.Add(this.btnOK);
            this.pnDialogOptions.Controls.Add(this.btnSystemColorPicker);
            this.pnDialogOptions.Controls.Add(this.btnCancel);
            this.pnDialogOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDialogOptions.Location = new System.Drawing.Point(0, 123);
            this.pnDialogOptions.Name = "pnDialogOptions";
            this.pnDialogOptions.Size = new System.Drawing.Size(324, 42);
            this.pnDialogOptions.TabIndex = 29;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(156, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 27;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(237, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnDisplayColor
            // 
            this.pnDisplayColor.BackColor = System.Drawing.Color.Black;
            this.pnDisplayColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDisplayColor.Location = new System.Drawing.Point(12, 12);
            this.pnDisplayColor.Name = "pnDisplayColor";
            this.pnDisplayColor.Size = new System.Drawing.Size(104, 104);
            this.pnDisplayColor.TabIndex = 30;
            // 
            // lbKnownColor
            // 
            this.lbKnownColor.AutoSize = true;
            this.lbKnownColor.Location = new System.Drawing.Point(136, 16);
            this.lbKnownColor.Name = "lbKnownColor";
            this.lbKnownColor.Size = new System.Drawing.Size(66, 13);
            this.lbKnownColor.TabIndex = 31;
            this.lbKnownColor.Text = "Known color";
            // 
            // cbKnownColors
            // 
            this.cbKnownColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKnownColors.FormattingEnabled = true;
            this.cbKnownColors.Items.AddRange(new object[] {
            "Custom",
            "ActiveBorder",
            "ActiveCaption",
            "ActiveCaptionText",
            "AppWorkspace",
            "Control",
            "ControlDark",
            "ControlDarkDark",
            "ControlLight",
            "ControlLightLight",
            "ControlText",
            "Desktop",
            "GrayText",
            "Highlight",
            "HighlightText",
            "HotTrack",
            "InactiveBorder",
            "InactiveCaption",
            "InactiveCaptionText",
            "Info",
            "InfoText",
            "Menu",
            "MenuText",
            "ScrollBar",
            "Window",
            "WindowFrame",
            "WindowText",
            "Transparent",
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagenta",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuchsia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGray",
            "LightGreen",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "SeaShell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen",
            "ButtonFace",
            "ButtonHighlight",
            "ButtonShadow",
            "GradientActiveCaption",
            "GradientInactiveCaption",
            "MenuBar",
            "MenuHighlight"});
            this.cbKnownColors.Location = new System.Drawing.Point(148, 36);
            this.cbKnownColors.Name = "cbKnownColors";
            this.cbKnownColors.Size = new System.Drawing.Size(155, 21);
            this.cbKnownColors.TabIndex = 32;
            this.cbKnownColors.SelectedIndexChanged += new System.EventHandler(this.cbKnownColors_SelectedIndexChanged);
            // 
            // lbRGB
            // 
            this.lbRGB.AutoSize = true;
            this.lbRGB.Location = new System.Drawing.Point(136, 66);
            this.lbRGB.Name = "lbRGB";
            this.lbRGB.Size = new System.Drawing.Size(59, 13);
            this.lbRGB.TabIndex = 33;
            this.lbRGB.Text = "RGB value";
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(148, 86);
            this.numRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRed.Name = "numRed";
            this.numRed.Size = new System.Drawing.Size(43, 20);
            this.numRed.TabIndex = 34;
            this.numRed.ValueChanged += new System.EventHandler(this.numRed_ValueChanged);
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(197, 86);
            this.numGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreen.Name = "numGreen";
            this.numGreen.Size = new System.Drawing.Size(43, 20);
            this.numGreen.TabIndex = 35;
            this.numGreen.ValueChanged += new System.EventHandler(this.numGreen_ValueChanged);
            // 
            // numBlue
            // 
            this.numBlue.Location = new System.Drawing.Point(246, 86);
            this.numBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlue.Name = "numBlue";
            this.numBlue.Size = new System.Drawing.Size(43, 20);
            this.numBlue.TabIndex = 36;
            this.numBlue.ValueChanged += new System.EventHandler(this.numBlue_ValueChanged);
            // 
            // frmColorPickerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(324, 165);
            this.Controls.Add(this.numBlue);
            this.Controls.Add(this.numGreen);
            this.Controls.Add(this.numRed);
            this.Controls.Add(this.lbRGB);
            this.Controls.Add(this.cbKnownColors);
            this.Controls.Add(this.lbKnownColor);
            this.Controls.Add(this.pnDisplayColor);
            this.Controls.Add(this.pnDialogOptions);
            this.Icon = global::calc.Properties.Resources.ProgramIcon;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 200);
            this.MinimumSize = new System.Drawing.Size(340, 200);
            this.Name = "frmColorPickerDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Picking color...";
            this.pnDialogOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSystemColorPicker;
        private System.Windows.Forms.Panel pnDialogOptions;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnDisplayColor;
        private System.Windows.Forms.Label lbKnownColor;
        private System.Windows.Forms.ComboBox cbKnownColors;
        private System.Windows.Forms.Label lbRGB;
        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.NumericUpDown numGreen;
        private System.Windows.Forms.NumericUpDown numBlue;
    }
}