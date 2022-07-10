namespace calc {
    partial class frmMain {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.mMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mSettings = new System.Windows.Forms.MenuItem();
            this.mBigEndian = new System.Windows.Forms.MenuItem();
            this.mTopMost = new System.Windows.Forms.MenuItem();
            this.mThousandths = new System.Windows.Forms.MenuItem();
            this.mSystemCalculator = new System.Windows.Forms.MenuItem();
            this.mAbout = new System.Windows.Forms.MenuItem();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.chkSigned = new System.Windows.Forms.CheckBox();
            this.lbTypeSeparator4 = new System.Windows.Forms.Label();
            this.chkHex = new System.Windows.Forms.CheckBox();
            this.lb8Byte = new System.Windows.Forms.Label();
            this.lb4Byte = new System.Windows.Forms.Label();
            this.lb2Byte = new System.Windows.Forms.Label();
            this.lbTypeSeparator3 = new System.Windows.Forms.Label();
            this.lbTypeSeparator2 = new System.Windows.Forms.Label();
            this.lbTypeSeparator1 = new System.Windows.Forms.Label();
            this.rbDouble = new System.Windows.Forms.RadioButton();
            this.rbInt64 = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbInt32 = new System.Windows.Forms.RadioButton();
            this.rbInt16 = new System.Windows.Forms.RadioButton();
            this.rbByte = new System.Windows.Forms.RadioButton();
            this.lbLower = new System.Windows.Forms.Label();
            this.lbUpper = new System.Windows.Forms.Label();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMulitply = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.pnOuput = new System.Windows.Forms.Panel();
            this.lbAction = new System.Windows.Forms.Label();
            this.gbBits = new System.Windows.Forms.GroupBox();
            this.pnBits = new System.Windows.Forms.Panel();
            this.lbBytesLittle4 = new System.Windows.Forms.Label();
            this.lbBytesBig1 = new System.Windows.Forms.Label();
            this.lbBytesLittle8 = new System.Windows.Forms.Label();
            this.lbBytesBig5 = new System.Windows.Forms.Label();
            this.lbBytesBig7 = new System.Windows.Forms.Label();
            this.lbBytesBig6 = new System.Windows.Forms.Label();
            this.lbBytesBig3 = new System.Windows.Forms.Label();
            this.lbBytesBig2 = new System.Windows.Forms.Label();
            this.lbBytesLittle7 = new System.Windows.Forms.Label();
            this.lbBytesLittle2 = new System.Windows.Forms.Label();
            this.lbBytesLittle3 = new System.Windows.Forms.Label();
            this.lbBytesLittle6 = new System.Windows.Forms.Label();
            this.lbBytesLittle5 = new System.Windows.Forms.Label();
            this.lbBytesLittle1 = new System.Windows.Forms.Label();
            this.lbBytesBig8 = new System.Windows.Forms.Label();
            this.lbBytesBig4 = new System.Windows.Forms.Label();
            this.cmUpper = new System.Windows.Forms.ContextMenu();
            this.mCopyUpper = new System.Windows.Forms.MenuItem();
            this.cmLower = new System.Windows.Forms.ContextMenu();
            this.mCopyLower = new System.Windows.Forms.MenuItem();
            this.btnClearCalculation = new System.Windows.Forms.Button();
            this.btnPositive = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnRemainder = new System.Windows.Forms.Button();
            this.btnTangent = new System.Windows.Forms.Button();
            this.btnCosine = new System.Windows.Forms.Button();
            this.btnSine = new System.Windows.Forms.Button();
            this.btnSqRt = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnExponent = new System.Windows.Forms.Button();
            this.btnUnused1 = new System.Windows.Forms.Button();
            this.btnUnused2 = new System.Windows.Forms.Button();
            this.btnUnused3 = new System.Windows.Forms.Button();
            this.bcBytes1 = new calc.ByteContainer();
            this.bcBytes4 = new calc.ByteContainer();
            this.bcBytes5 = new calc.ByteContainer();
            this.bcBytes8 = new calc.ByteContainer();
            this.bcBytes2 = new calc.ByteContainer();
            this.bcBytes6 = new calc.ByteContainer();
            this.bcBytes7 = new calc.ByteContainer();
            this.bcBytes3 = new calc.ByteContainer();
            this.gbType.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.pnOuput.SuspendLayout();
            this.gbBits.SuspendLayout();
            this.pnBits.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mSettings,
            this.mSystemCalculator,
            this.mAbout});
            // 
            // mSettings
            // 
            this.mSettings.Index = 0;
            this.mSettings.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mBigEndian,
            this.mTopMost,
            this.mThousandths});
            this.mSettings.Text = "Settings";
            // 
            // mBigEndian
            // 
            this.mBigEndian.Checked = true;
            this.mBigEndian.Index = 0;
            this.mBigEndian.Text = "&Big endian";
            this.mBigEndian.Click += new System.EventHandler(this.mBigEndian_Click);
            // 
            // mTopMost
            // 
            this.mTopMost.Index = 1;
            this.mTopMost.Text = "&Top-most";
            this.mTopMost.Click += new System.EventHandler(this.mTopMost_Click);
            // 
            // mThousandths
            // 
            this.mThousandths.Checked = true;
            this.mThousandths.Index = 2;
            this.mThousandths.Text = "Thousandths";
            this.mThousandths.Click += new System.EventHandler(this.mThousandths_Click);
            // 
            // mSystemCalculator
            // 
            this.mSystemCalculator.Index = 1;
            this.mSystemCalculator.Text = "System calculator";
            // 
            // mAbout
            // 
            this.mAbout.Index = 2;
            this.mAbout.Text = "About";
            this.mAbout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.chkSigned);
            this.gbType.Controls.Add(this.lbTypeSeparator4);
            this.gbType.Controls.Add(this.chkHex);
            this.gbType.Controls.Add(this.lb8Byte);
            this.gbType.Controls.Add(this.lb4Byte);
            this.gbType.Controls.Add(this.lb2Byte);
            this.gbType.Controls.Add(this.lbTypeSeparator3);
            this.gbType.Controls.Add(this.lbTypeSeparator2);
            this.gbType.Controls.Add(this.lbTypeSeparator1);
            this.gbType.Controls.Add(this.rbDouble);
            this.gbType.Controls.Add(this.rbInt64);
            this.gbType.Controls.Add(this.rbSingle);
            this.gbType.Controls.Add(this.rbInt32);
            this.gbType.Controls.Add(this.rbInt16);
            this.gbType.Controls.Add(this.rbByte);
            this.gbType.Location = new System.Drawing.Point(6, 127);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(74, 230);
            this.gbType.TabIndex = 24;
            this.gbType.TabStop = false;
            // 
            // chkSigned
            // 
            this.chkSigned.AutoSize = true;
            this.chkSigned.Checked = true;
            this.chkSigned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSigned.Location = new System.Drawing.Point(7, 191);
            this.chkSigned.Name = "chkSigned";
            this.chkSigned.Size = new System.Drawing.Size(61, 17);
            this.chkSigned.TabIndex = 63;
            this.chkSigned.Text = "Signed";
            this.chkSigned.UseVisualStyleBackColor = true;
            this.chkSigned.CheckedChanged += new System.EventHandler(this.chkSigned_CheckedChanged);
            // 
            // lbTypeSeparator4
            // 
            this.lbTypeSeparator4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTypeSeparator4.Location = new System.Drawing.Point(7, 184);
            this.lbTypeSeparator4.Name = "lbTypeSeparator4";
            this.lbTypeSeparator4.Size = new System.Drawing.Size(61, 2);
            this.lbTypeSeparator4.TabIndex = 62;
            this.lbTypeSeparator4.Text = "-";
            // 
            // chkHex
            // 
            this.chkHex.AutoSize = true;
            this.chkHex.Location = new System.Drawing.Point(7, 209);
            this.chkHex.Name = "chkHex";
            this.chkHex.Size = new System.Drawing.Size(44, 17);
            this.chkHex.TabIndex = 61;
            this.chkHex.Text = "Hex";
            this.chkHex.UseVisualStyleBackColor = true;
            this.chkHex.CheckedChanged += new System.EventHandler(this.chkHex_CheckedChanged);
            // 
            // lb8Byte
            // 
            this.lb8Byte.AutoSize = true;
            this.lb8Byte.Location = new System.Drawing.Point(19, 126);
            this.lb8Byte.Name = "lb8Byte";
            this.lb8Byte.Size = new System.Drawing.Size(38, 13);
            this.lb8Byte.TabIndex = 11;
            this.lb8Byte.Text = "8 byte";
            // 
            // lb4Byte
            // 
            this.lb4Byte.AutoSize = true;
            this.lb4Byte.Location = new System.Drawing.Point(19, 68);
            this.lb4Byte.Name = "lb4Byte";
            this.lb4Byte.Size = new System.Drawing.Size(38, 13);
            this.lb4Byte.TabIndex = 10;
            this.lb4Byte.Text = "4 byte";
            // 
            // lb2Byte
            // 
            this.lb2Byte.AutoSize = true;
            this.lb2Byte.Location = new System.Drawing.Point(19, 32);
            this.lb2Byte.Name = "lb2Byte";
            this.lb2Byte.Size = new System.Drawing.Size(38, 13);
            this.lb2Byte.TabIndex = 9;
            this.lb2Byte.Text = "2 byte";
            // 
            // lbTypeSeparator3
            // 
            this.lbTypeSeparator3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTypeSeparator3.Location = new System.Drawing.Point(7, 131);
            this.lbTypeSeparator3.Name = "lbTypeSeparator3";
            this.lbTypeSeparator3.Size = new System.Drawing.Size(61, 2);
            this.lbTypeSeparator3.TabIndex = 8;
            this.lbTypeSeparator3.Text = "-";
            // 
            // lbTypeSeparator2
            // 
            this.lbTypeSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTypeSeparator2.Location = new System.Drawing.Point(7, 73);
            this.lbTypeSeparator2.Name = "lbTypeSeparator2";
            this.lbTypeSeparator2.Size = new System.Drawing.Size(61, 2);
            this.lbTypeSeparator2.TabIndex = 7;
            this.lbTypeSeparator2.Text = "-";
            // 
            // lbTypeSeparator1
            // 
            this.lbTypeSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTypeSeparator1.Location = new System.Drawing.Point(7, 38);
            this.lbTypeSeparator1.Name = "lbTypeSeparator1";
            this.lbTypeSeparator1.Size = new System.Drawing.Size(61, 2);
            this.lbTypeSeparator1.TabIndex = 6;
            this.lbTypeSeparator1.Text = "-";
            // 
            // rbDouble
            // 
            this.rbDouble.AutoSize = true;
            this.rbDouble.Location = new System.Drawing.Point(6, 162);
            this.rbDouble.Name = "rbDouble";
            this.rbDouble.Size = new System.Drawing.Size(62, 17);
            this.rbDouble.TabIndex = 5;
            this.rbDouble.Text = "Double";
            this.rbDouble.UseVisualStyleBackColor = true;
            this.rbDouble.CheckedChanged += new System.EventHandler(this.rbDouble_CheckedChanged);
            // 
            // rbInt64
            // 
            this.rbInt64.AutoSize = true;
            this.rbInt64.Location = new System.Drawing.Point(6, 143);
            this.rbInt64.Name = "rbInt64";
            this.rbInt64.Size = new System.Drawing.Size(50, 17);
            this.rbInt64.TabIndex = 4;
            this.rbInt64.Text = "Int64";
            this.rbInt64.UseVisualStyleBackColor = true;
            this.rbInt64.CheckedChanged += new System.EventHandler(this.rbInt64_CheckedChanged);
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(6, 104);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(56, 17);
            this.rbSingle.TabIndex = 3;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            this.rbSingle.CheckedChanged += new System.EventHandler(this.rbSingle_CheckedChanged);
            // 
            // rbInt32
            // 
            this.rbInt32.AutoSize = true;
            this.rbInt32.Checked = true;
            this.rbInt32.Location = new System.Drawing.Point(6, 85);
            this.rbInt32.Name = "rbInt32";
            this.rbInt32.Size = new System.Drawing.Size(50, 17);
            this.rbInt32.TabIndex = 2;
            this.rbInt32.TabStop = true;
            this.rbInt32.Text = "Int32";
            this.rbInt32.UseVisualStyleBackColor = true;
            this.rbInt32.CheckedChanged += new System.EventHandler(this.rbInt32_CheckedChanged);
            // 
            // rbInt16
            // 
            this.rbInt16.AutoSize = true;
            this.rbInt16.Location = new System.Drawing.Point(6, 49);
            this.rbInt16.Name = "rbInt16";
            this.rbInt16.Size = new System.Drawing.Size(50, 17);
            this.rbInt16.TabIndex = 1;
            this.rbInt16.Text = "Int16";
            this.rbInt16.UseVisualStyleBackColor = true;
            this.rbInt16.CheckedChanged += new System.EventHandler(this.rbInt16_CheckedChanged);
            // 
            // rbByte
            // 
            this.rbByte.AutoSize = true;
            this.rbByte.Location = new System.Drawing.Point(6, 11);
            this.rbByte.Name = "rbByte";
            this.rbByte.Size = new System.Drawing.Size(45, 17);
            this.rbByte.TabIndex = 0;
            this.rbByte.Text = "Byte";
            this.rbByte.UseVisualStyleBackColor = true;
            this.rbByte.CheckedChanged += new System.EventHandler(this.rbByte_CheckedChanged);
            // 
            // lbLower
            // 
            this.lbLower.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbLower.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLower.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbLower.Location = new System.Drawing.Point(176, 26);
            this.lbLower.Name = "lbLower";
            this.lbLower.Size = new System.Drawing.Size(204, 17);
            this.lbLower.TabIndex = 33;
            this.lbLower.Text = "0x0";
            this.lbLower.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbUpper
            // 
            this.lbUpper.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbUpper.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpper.Location = new System.Drawing.Point(7, 4);
            this.lbUpper.Name = "lbUpper";
            this.lbUpper.Size = new System.Drawing.Size(373, 19);
            this.lbUpper.TabIndex = 34;
            this.lbUpper.Text = "0";
            this.lbUpper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(135, 145);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(75, 30);
            this.btnBackspace.TabIndex = 35;
            this.btnBackspace.Text = "←";
            this.btnBackspace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(216, 145);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(36, 30);
            this.btnClearAll.TabIndex = 36;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.Location = new System.Drawing.Point(257, 145);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(36, 30);
            this.btnClearEntry.TabIndex = 37;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(135, 178);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(36, 30);
            this.btn7.TabIndex = 38;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(176, 178);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(36, 30);
            this.btn8.TabIndex = 39;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(216, 178);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(36, 30);
            this.btn9.TabIndex = 40;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(257, 178);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(36, 30);
            this.btnDivide.TabIndex = 41;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMulitply
            // 
            this.btnMulitply.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulitply.Location = new System.Drawing.Point(257, 211);
            this.btnMulitply.Name = "btnMulitply";
            this.btnMulitply.Size = new System.Drawing.Size(36, 30);
            this.btnMulitply.TabIndex = 45;
            this.btnMulitply.Text = "*";
            this.btnMulitply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMulitply.UseVisualStyleBackColor = true;
            this.btnMulitply.Click += new System.EventHandler(this.btnMulitply_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(216, 211);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(36, 30);
            this.btn6.TabIndex = 44;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(176, 211);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(36, 30);
            this.btn5.TabIndex = 43;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(135, 211);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(36, 30);
            this.btn4.TabIndex = 42;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(257, 244);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(36, 30);
            this.btnSubtract.TabIndex = 49;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(216, 244);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(36, 30);
            this.btn3.TabIndex = 48;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(176, 244);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(36, 30);
            this.btn2.TabIndex = 47;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(135, 244);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(36, 30);
            this.btn1.TabIndex = 46;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(256, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 30);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(216, 277);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(36, 30);
            this.btnDecimal.TabIndex = 51;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(135, 277);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 30);
            this.btn0.TabIndex = 50;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(298, 244);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(36, 63);
            this.btnCalculate.TabIndex = 53;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(94, 145);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(36, 30);
            this.btnA.TabIndex = 54;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Enabled = false;
            this.btnB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(94, 178);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(36, 30);
            this.btnB.TabIndex = 55;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Enabled = false;
            this.btnC.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(94, 211);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(36, 30);
            this.btnC.TabIndex = 56;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Enabled = false;
            this.btnD.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(94, 244);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(36, 30);
            this.btnD.TabIndex = 57;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnE
            // 
            this.btnE.Enabled = false;
            this.btnE.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(94, 277);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(36, 30);
            this.btnE.TabIndex = 58;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnF
            // 
            this.btnF.Enabled = false;
            this.btnF.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(94, 310);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(36, 30);
            this.btnF.TabIndex = 59;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // gbOutput
            // 
            this.gbOutput.BackColor = System.Drawing.SystemColors.Control;
            this.gbOutput.Controls.Add(this.pnOuput);
            this.gbOutput.Location = new System.Drawing.Point(4, -5);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(386, 57);
            this.gbOutput.TabIndex = 60;
            this.gbOutput.TabStop = false;
            // 
            // pnOuput
            // 
            this.pnOuput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnOuput.Controls.Add(this.lbUpper);
            this.pnOuput.Controls.Add(this.lbAction);
            this.pnOuput.Controls.Add(this.lbLower);
            this.pnOuput.Location = new System.Drawing.Point(3, 9);
            this.pnOuput.Name = "pnOuput";
            this.pnOuput.Size = new System.Drawing.Size(381, 46);
            this.pnOuput.TabIndex = 0;
            // 
            // lbAction
            // 
            this.lbAction.AutoSize = true;
            this.lbAction.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAction.Location = new System.Drawing.Point(1, 30);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(13, 13);
            this.lbAction.TabIndex = 63;
            this.lbAction.Text = "...";
            // 
            // gbBits
            // 
            this.gbBits.BackColor = System.Drawing.SystemColors.Control;
            this.gbBits.Controls.Add(this.pnBits);
            this.gbBits.Location = new System.Drawing.Point(2, 49);
            this.gbBits.Name = "gbBits";
            this.gbBits.Size = new System.Drawing.Size(390, 79);
            this.gbBits.TabIndex = 62;
            this.gbBits.TabStop = false;
            // 
            // pnBits
            // 
            this.pnBits.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnBits.Controls.Add(this.lbBytesLittle4);
            this.pnBits.Controls.Add(this.lbBytesBig1);
            this.pnBits.Controls.Add(this.lbBytesLittle8);
            this.pnBits.Controls.Add(this.lbBytesBig5);
            this.pnBits.Controls.Add(this.lbBytesBig7);
            this.pnBits.Controls.Add(this.lbBytesBig6);
            this.pnBits.Controls.Add(this.lbBytesBig3);
            this.pnBits.Controls.Add(this.lbBytesBig2);
            this.pnBits.Controls.Add(this.lbBytesLittle7);
            this.pnBits.Controls.Add(this.lbBytesLittle2);
            this.pnBits.Controls.Add(this.lbBytesLittle3);
            this.pnBits.Controls.Add(this.lbBytesLittle6);
            this.pnBits.Controls.Add(this.lbBytesLittle5);
            this.pnBits.Controls.Add(this.lbBytesLittle1);
            this.pnBits.Controls.Add(this.lbBytesBig8);
            this.pnBits.Controls.Add(this.lbBytesBig4);
            this.pnBits.Controls.Add(this.bcBytes1);
            this.pnBits.Controls.Add(this.bcBytes4);
            this.pnBits.Controls.Add(this.bcBytes5);
            this.pnBits.Controls.Add(this.bcBytes8);
            this.pnBits.Controls.Add(this.bcBytes2);
            this.pnBits.Controls.Add(this.bcBytes6);
            this.pnBits.Controls.Add(this.bcBytes7);
            this.pnBits.Controls.Add(this.bcBytes3);
            this.pnBits.Location = new System.Drawing.Point(3, 10);
            this.pnBits.Name = "pnBits";
            this.pnBits.Size = new System.Drawing.Size(384, 66);
            this.pnBits.TabIndex = 0;
            // 
            // lbBytesLittle4
            // 
            this.lbBytesLittle4.AutoSize = true;
            this.lbBytesLittle4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesLittle4.Location = new System.Drawing.Point(367, 1);
            this.lbBytesLittle4.Name = "lbBytesLittle4";
            this.lbBytesLittle4.Size = new System.Drawing.Size(17, 13);
            this.lbBytesLittle4.TabIndex = 28;
            this.lbBytesLittle4.Text = "32";
            this.lbBytesLittle4.Visible = false;
            // 
            // lbBytesBig1
            // 
            this.lbBytesBig1.AutoSize = true;
            this.lbBytesBig1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesBig1.Location = new System.Drawing.Point(1, 1);
            this.lbBytesBig1.Name = "lbBytesBig1";
            this.lbBytesBig1.Size = new System.Drawing.Size(19, 13);
            this.lbBytesBig1.TabIndex = 14;
            this.lbBytesBig1.Text = "64";
            // 
            // lbBytesLittle8
            // 
            this.lbBytesLittle8.AutoSize = true;
            this.lbBytesLittle8.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesLittle8.Location = new System.Drawing.Point(367, 32);
            this.lbBytesLittle8.Name = "lbBytesLittle8";
            this.lbBytesLittle8.Size = new System.Drawing.Size(19, 13);
            this.lbBytesLittle8.TabIndex = 29;
            this.lbBytesLittle8.Text = "64";
            this.lbBytesLittle8.Visible = false;
            // 
            // lbBytesBig5
            // 
            this.lbBytesBig5.AutoSize = true;
            this.lbBytesBig5.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesBig5.Location = new System.Drawing.Point(1, 32);
            this.lbBytesBig5.Name = "lbBytesBig5";
            this.lbBytesBig5.Size = new System.Drawing.Size(17, 13);
            this.lbBytesBig5.TabIndex = 15;
            this.lbBytesBig5.Text = "32";
            // 
            // lbBytesBig7
            // 
            this.lbBytesBig7.AutoSize = true;
            this.lbBytesBig7.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesBig7.Location = new System.Drawing.Point(193, 32);
            this.lbBytesBig7.Name = "lbBytesBig7";
            this.lbBytesBig7.Size = new System.Drawing.Size(17, 13);
            this.lbBytesBig7.TabIndex = 17;
            this.lbBytesBig7.Text = "16";
            // 
            // lbBytesBig6
            // 
            this.lbBytesBig6.AutoSize = true;
            this.lbBytesBig6.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesBig6.Location = new System.Drawing.Point(97, 32);
            this.lbBytesBig6.Name = "lbBytesBig6";
            this.lbBytesBig6.Size = new System.Drawing.Size(18, 13);
            this.lbBytesBig6.TabIndex = 18;
            this.lbBytesBig6.Text = "24";
            // 
            // lbBytesBig3
            // 
            this.lbBytesBig3.AutoSize = true;
            this.lbBytesBig3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesBig3.Location = new System.Drawing.Point(193, 1);
            this.lbBytesBig3.Name = "lbBytesBig3";
            this.lbBytesBig3.Size = new System.Drawing.Size(19, 13);
            this.lbBytesBig3.TabIndex = 20;
            this.lbBytesBig3.Text = "48";
            // 
            // lbBytesBig2
            // 
            this.lbBytesBig2.AutoSize = true;
            this.lbBytesBig2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesBig2.Location = new System.Drawing.Point(97, 1);
            this.lbBytesBig2.Name = "lbBytesBig2";
            this.lbBytesBig2.Size = new System.Drawing.Size(18, 13);
            this.lbBytesBig2.TabIndex = 21;
            this.lbBytesBig2.Text = "56";
            // 
            // lbBytesLittle7
            // 
            this.lbBytesLittle7.AutoSize = true;
            this.lbBytesLittle7.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesLittle7.Location = new System.Drawing.Point(271, 32);
            this.lbBytesLittle7.Name = "lbBytesLittle7";
            this.lbBytesLittle7.Size = new System.Drawing.Size(18, 13);
            this.lbBytesLittle7.TabIndex = 30;
            this.lbBytesLittle7.Text = "56";
            this.lbBytesLittle7.Visible = false;
            // 
            // lbBytesLittle2
            // 
            this.lbBytesLittle2.AutoSize = true;
            this.lbBytesLittle2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesLittle2.Location = new System.Drawing.Point(175, 1);
            this.lbBytesLittle2.Name = "lbBytesLittle2";
            this.lbBytesLittle2.Size = new System.Drawing.Size(17, 13);
            this.lbBytesLittle2.TabIndex = 26;
            this.lbBytesLittle2.Text = "16";
            this.lbBytesLittle2.Visible = false;
            // 
            // lbBytesLittle3
            // 
            this.lbBytesLittle3.AutoSize = true;
            this.lbBytesLittle3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesLittle3.Location = new System.Drawing.Point(271, 1);
            this.lbBytesLittle3.Name = "lbBytesLittle3";
            this.lbBytesLittle3.Size = new System.Drawing.Size(18, 13);
            this.lbBytesLittle3.TabIndex = 27;
            this.lbBytesLittle3.Text = "24";
            this.lbBytesLittle3.Visible = false;
            // 
            // lbBytesLittle6
            // 
            this.lbBytesLittle6.AutoSize = true;
            this.lbBytesLittle6.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesLittle6.Location = new System.Drawing.Point(175, 32);
            this.lbBytesLittle6.Name = "lbBytesLittle6";
            this.lbBytesLittle6.Size = new System.Drawing.Size(19, 13);
            this.lbBytesLittle6.TabIndex = 31;
            this.lbBytesLittle6.Text = "48";
            this.lbBytesLittle6.Visible = false;
            // 
            // lbBytesLittle5
            // 
            this.lbBytesLittle5.AutoSize = true;
            this.lbBytesLittle5.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesLittle5.Location = new System.Drawing.Point(79, 32);
            this.lbBytesLittle5.Name = "lbBytesLittle5";
            this.lbBytesLittle5.Size = new System.Drawing.Size(19, 13);
            this.lbBytesLittle5.TabIndex = 32;
            this.lbBytesLittle5.Text = "40";
            this.lbBytesLittle5.Visible = false;
            // 
            // lbBytesLittle1
            // 
            this.lbBytesLittle1.AutoSize = true;
            this.lbBytesLittle1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesLittle1.Location = new System.Drawing.Point(85, 1);
            this.lbBytesLittle1.Name = "lbBytesLittle1";
            this.lbBytesLittle1.Size = new System.Drawing.Size(13, 13);
            this.lbBytesLittle1.TabIndex = 25;
            this.lbBytesLittle1.Text = "8";
            this.lbBytesLittle1.Visible = false;
            // 
            // lbBytesBig8
            // 
            this.lbBytesBig8.AutoSize = true;
            this.lbBytesBig8.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesBig8.Location = new System.Drawing.Point(289, 32);
            this.lbBytesBig8.Name = "lbBytesBig8";
            this.lbBytesBig8.Size = new System.Drawing.Size(13, 13);
            this.lbBytesBig8.TabIndex = 16;
            this.lbBytesBig8.Text = "8";
            // 
            // lbBytesBig4
            // 
            this.lbBytesBig4.AutoSize = true;
            this.lbBytesBig4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBytesBig4.Location = new System.Drawing.Point(290, 1);
            this.lbBytesBig4.Name = "lbBytesBig4";
            this.lbBytesBig4.Size = new System.Drawing.Size(19, 13);
            this.lbBytesBig4.TabIndex = 19;
            this.lbBytesBig4.Text = "40";
            // 
            // cmUpper
            // 
            this.cmUpper.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mCopyUpper});
            // 
            // mCopyUpper
            // 
            this.mCopyUpper.Index = 0;
            this.mCopyUpper.Text = "Copy data";
            this.mCopyUpper.Click += new System.EventHandler(this.mCopyUpper_Click);
            // 
            // cmLower
            // 
            this.cmLower.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mCopyLower});
            // 
            // mCopyLower
            // 
            this.mCopyLower.Index = 0;
            this.mCopyLower.Text = "Copy data";
            this.mCopyLower.Click += new System.EventHandler(this.mCopyLower_Click);
            // 
            // btnClearCalculation
            // 
            this.btnClearCalculation.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCalculation.Location = new System.Drawing.Point(298, 145);
            this.btnClearCalculation.Name = "btnClearCalculation";
            this.btnClearCalculation.Size = new System.Drawing.Size(36, 30);
            this.btnClearCalculation.TabIndex = 64;
            this.btnClearCalculation.Text = "CC";
            this.btnClearCalculation.UseVisualStyleBackColor = true;
            this.btnClearCalculation.Click += new System.EventHandler(this.btnClearCalculation_Click);
            // 
            // btnPositive
            // 
            this.btnPositive.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositive.Location = new System.Drawing.Point(298, 178);
            this.btnPositive.Name = "btnPositive";
            this.btnPositive.Size = new System.Drawing.Size(36, 30);
            this.btnPositive.TabIndex = 65;
            this.btnPositive.Text = "P";
            this.btnPositive.UseVisualStyleBackColor = true;
            this.btnPositive.Click += new System.EventHandler(this.btnPositive_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegative.Location = new System.Drawing.Point(298, 211);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(36, 30);
            this.btnNegative.TabIndex = 66;
            this.btnNegative.Text = "N";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnRemainder
            // 
            this.btnRemainder.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemainder.Location = new System.Drawing.Point(256, 310);
            this.btnRemainder.Name = "btnRemainder";
            this.btnRemainder.Size = new System.Drawing.Size(36, 30);
            this.btnRemainder.TabIndex = 67;
            this.btnRemainder.Text = "%";
            this.btnRemainder.UseVisualStyleBackColor = true;
            this.btnRemainder.Click += new System.EventHandler(this.btnRemainder_Click);
            // 
            // btnTangent
            // 
            this.btnTangent.Enabled = false;
            this.btnTangent.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangent.Location = new System.Drawing.Point(216, 310);
            this.btnTangent.Name = "btnTangent";
            this.btnTangent.Size = new System.Drawing.Size(36, 30);
            this.btnTangent.TabIndex = 70;
            this.btnTangent.Text = "TAN";
            this.btnTangent.UseVisualStyleBackColor = true;
            this.btnTangent.Click += new System.EventHandler(this.btnTangent_Click);
            // 
            // btnCosine
            // 
            this.btnCosine.Enabled = false;
            this.btnCosine.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosine.Location = new System.Drawing.Point(176, 310);
            this.btnCosine.Name = "btnCosine";
            this.btnCosine.Size = new System.Drawing.Size(36, 30);
            this.btnCosine.TabIndex = 69;
            this.btnCosine.Text = "COS";
            this.btnCosine.UseVisualStyleBackColor = true;
            this.btnCosine.Click += new System.EventHandler(this.btnCosine_Click);
            // 
            // btnSine
            // 
            this.btnSine.Enabled = false;
            this.btnSine.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSine.Location = new System.Drawing.Point(135, 310);
            this.btnSine.Name = "btnSine";
            this.btnSine.Size = new System.Drawing.Size(36, 30);
            this.btnSine.TabIndex = 68;
            this.btnSine.Text = "SIN";
            this.btnSine.UseVisualStyleBackColor = true;
            this.btnSine.Click += new System.EventHandler(this.btnSine_Click);
            // 
            // btnSqRt
            // 
            this.btnSqRt.Enabled = false;
            this.btnSqRt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqRt.Location = new System.Drawing.Point(298, 310);
            this.btnSqRt.Name = "btnSqRt";
            this.btnSqRt.Size = new System.Drawing.Size(36, 30);
            this.btnSqRt.TabIndex = 71;
            this.btnSqRt.Text = "√";
            this.btnSqRt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSqRt.UseVisualStyleBackColor = true;
            this.btnSqRt.Click += new System.EventHandler(this.btnSqRt_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(339, 145);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(40, 30);
            this.btnSquare.TabIndex = 72;
            this.btnSquare.Text = "x²";
            this.btnSquare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCube
            // 
            this.btnCube.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCube.Location = new System.Drawing.Point(339, 178);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(40, 30);
            this.btnCube.TabIndex = 73;
            this.btnCube.Text = "x³";
            this.btnCube.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // btnExponent
            // 
            this.btnExponent.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponent.Location = new System.Drawing.Point(339, 211);
            this.btnExponent.Name = "btnExponent";
            this.btnExponent.Size = new System.Drawing.Size(40, 30);
            this.btnExponent.TabIndex = 74;
            this.btnExponent.Text = "xʸ";
            this.btnExponent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExponent.UseVisualStyleBackColor = true;
            this.btnExponent.Click += new System.EventHandler(this.btnExponent_Click);
            // 
            // btnUnused1
            // 
            this.btnUnused1.Enabled = false;
            this.btnUnused1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnused1.Location = new System.Drawing.Point(339, 244);
            this.btnUnused1.Name = "btnUnused1";
            this.btnUnused1.Size = new System.Drawing.Size(40, 30);
            this.btnUnused1.TabIndex = 75;
            this.btnUnused1.UseVisualStyleBackColor = true;
            this.btnUnused1.Visible = false;
            // 
            // btnUnused2
            // 
            this.btnUnused2.Enabled = false;
            this.btnUnused2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnused2.Location = new System.Drawing.Point(339, 277);
            this.btnUnused2.Name = "btnUnused2";
            this.btnUnused2.Size = new System.Drawing.Size(40, 30);
            this.btnUnused2.TabIndex = 76;
            this.btnUnused2.UseVisualStyleBackColor = true;
            this.btnUnused2.Visible = false;
            // 
            // btnUnused3
            // 
            this.btnUnused3.Enabled = false;
            this.btnUnused3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnused3.Location = new System.Drawing.Point(340, 310);
            this.btnUnused3.Name = "btnUnused3";
            this.btnUnused3.Size = new System.Drawing.Size(40, 30);
            this.btnUnused3.TabIndex = 77;
            this.btnUnused3.UseVisualStyleBackColor = true;
            this.btnUnused3.Visible = false;
            // 
            // bcBytes1
            // 
            this.bcBytes1.BigEndian = true;
            this.bcBytes1.Byte = ((byte)(0));
            this.bcBytes1.Enabled = false;
            this.bcBytes1.Font = new System.Drawing.Font("Consolas", 12F);
            this.bcBytes1.Location = new System.Drawing.Point(2, 8);
            this.bcBytes1.Name = "bcBytes1";
            this.bcBytes1.Size = new System.Drawing.Size(94, 27);
            this.bcBytes1.TabIndex = 13;
            this.bcBytes1.BytesParsed += new System.EventHandler<System.EventArgs>(this.BitSet);
            // 
            // bcBytes4
            // 
            this.bcBytes4.BigEndian = true;
            this.bcBytes4.Byte = ((byte)(0));
            this.bcBytes4.Enabled = false;
            this.bcBytes4.Font = new System.Drawing.Font("Consolas", 12F);
            this.bcBytes4.Location = new System.Drawing.Point(290, 8);
            this.bcBytes4.Name = "bcBytes4";
            this.bcBytes4.Size = new System.Drawing.Size(94, 27);
            this.bcBytes4.TabIndex = 10;
            this.bcBytes4.BytesParsed += new System.EventHandler<System.EventArgs>(this.BitSet);
            // 
            // bcBytes5
            // 
            this.bcBytes5.BigEndian = true;
            this.bcBytes5.Byte = ((byte)(0));
            this.bcBytes5.Font = new System.Drawing.Font("Consolas", 12F);
            this.bcBytes5.Location = new System.Drawing.Point(2, 39);
            this.bcBytes5.Name = "bcBytes5";
            this.bcBytes5.Size = new System.Drawing.Size(94, 27);
            this.bcBytes5.TabIndex = 9;
            this.bcBytes5.BytesParsed += new System.EventHandler<System.EventArgs>(this.BitSet);
            // 
            // bcBytes8
            // 
            this.bcBytes8.BigEndian = true;
            this.bcBytes8.Byte = ((byte)(0));
            this.bcBytes8.Font = new System.Drawing.Font("Consolas", 12F);
            this.bcBytes8.Location = new System.Drawing.Point(290, 39);
            this.bcBytes8.Name = "bcBytes8";
            this.bcBytes8.Size = new System.Drawing.Size(94, 27);
            this.bcBytes8.TabIndex = 0;
            this.bcBytes8.BytesParsed += new System.EventHandler<System.EventArgs>(this.BitSet);
            // 
            // bcBytes2
            // 
            this.bcBytes2.BigEndian = true;
            this.bcBytes2.Byte = ((byte)(0));
            this.bcBytes2.Enabled = false;
            this.bcBytes2.Font = new System.Drawing.Font("Consolas", 12F);
            this.bcBytes2.Location = new System.Drawing.Point(98, 8);
            this.bcBytes2.Name = "bcBytes2";
            this.bcBytes2.Size = new System.Drawing.Size(94, 27);
            this.bcBytes2.TabIndex = 12;
            this.bcBytes2.BytesParsed += new System.EventHandler<System.EventArgs>(this.BitSet);
            // 
            // bcBytes6
            // 
            this.bcBytes6.BigEndian = true;
            this.bcBytes6.Byte = ((byte)(0));
            this.bcBytes6.Font = new System.Drawing.Font("Consolas", 12F);
            this.bcBytes6.Location = new System.Drawing.Point(98, 39);
            this.bcBytes6.Name = "bcBytes6";
            this.bcBytes6.Size = new System.Drawing.Size(94, 27);
            this.bcBytes6.TabIndex = 8;
            this.bcBytes6.BytesParsed += new System.EventHandler<System.EventArgs>(this.BitSet);
            // 
            // bcBytes7
            // 
            this.bcBytes7.BigEndian = true;
            this.bcBytes7.Byte = ((byte)(0));
            this.bcBytes7.Font = new System.Drawing.Font("Consolas", 12F);
            this.bcBytes7.Location = new System.Drawing.Point(194, 39);
            this.bcBytes7.Name = "bcBytes7";
            this.bcBytes7.Size = new System.Drawing.Size(94, 27);
            this.bcBytes7.TabIndex = 1;
            this.bcBytes7.BytesParsed += new System.EventHandler<System.EventArgs>(this.BitSet);
            // 
            // bcBytes3
            // 
            this.bcBytes3.BigEndian = true;
            this.bcBytes3.Byte = ((byte)(0));
            this.bcBytes3.Enabled = false;
            this.bcBytes3.Font = new System.Drawing.Font("Consolas", 12F);
            this.bcBytes3.Location = new System.Drawing.Point(194, 8);
            this.bcBytes3.Name = "bcBytes3";
            this.bcBytes3.Size = new System.Drawing.Size(94, 27);
            this.bcBytes3.TabIndex = 11;
            this.bcBytes3.BytesParsed += new System.EventHandler<System.EventArgs>(this.BitSet);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(394, 385);
            this.Controls.Add(this.btnUnused3);
            this.Controls.Add(this.btnUnused2);
            this.Controls.Add(this.btnUnused1);
            this.Controls.Add(this.btnExponent);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnSqRt);
            this.Controls.Add(this.btnTangent);
            this.Controls.Add(this.btnCosine);
            this.Controls.Add(this.btnSine);
            this.Controls.Add(this.btnRemainder);
            this.Controls.Add(this.btnClearCalculation);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbBits);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.btnPositive);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMulitply);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnF);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::calc.Properties.Resources.ProgramIcon;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 420);
            this.Menu = this.mMenu;
            this.MinimumSize = new System.Drawing.Size(410, 420);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "calc";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.pnOuput.ResumeLayout(false);
            this.pnOuput.PerformLayout();
            this.gbBits.ResumeLayout(false);
            this.pnBits.ResumeLayout(false);
            this.pnBits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuItem mSystemCalculator;
        private System.Windows.Forms.MenuItem mTopMost;
        private System.Windows.Forms.MenuItem mSettings;
        private System.Windows.Forms.MenuItem mBigEndian;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbDouble;
        private System.Windows.Forms.RadioButton rbInt64;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbInt32;
        private System.Windows.Forms.RadioButton rbInt16;
        private System.Windows.Forms.RadioButton rbByte;
        private System.Windows.Forms.Label lb2Byte;
        private System.Windows.Forms.Label lbTypeSeparator3;
        private System.Windows.Forms.Label lbTypeSeparator2;
        private System.Windows.Forms.Label lbTypeSeparator1;
        private System.Windows.Forms.Label lb8Byte;
        private System.Windows.Forms.Label lb4Byte;
        private System.Windows.Forms.Label lbLower;
        private System.Windows.Forms.Label lbUpper;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMulitply;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.Panel pnOuput;
        private System.Windows.Forms.CheckBox chkHex;
        private System.Windows.Forms.GroupBox gbBits;
        private System.Windows.Forms.Label lbTypeSeparator4;
        private System.Windows.Forms.CheckBox chkSigned;
        private System.Windows.Forms.MenuItem mThousandths;
        private System.Windows.Forms.MainMenu mMenu;
        private System.Windows.Forms.ContextMenu cmUpper;
        private System.Windows.Forms.MenuItem mCopyUpper;
        private System.Windows.Forms.ContextMenu cmLower;
        private System.Windows.Forms.MenuItem mCopyLower;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.Button btnClearCalculation;
        private System.Windows.Forms.Panel pnBits;
        private System.Windows.Forms.Label lbBytesLittle4;
        private System.Windows.Forms.Label lbBytesLittle8;
        private ByteContainer bcBytes4;
        private ByteContainer bcBytes8;
        private System.Windows.Forms.Label lbBytesLittle7;
        private System.Windows.Forms.Label lbBytesLittle3;
        private ByteContainer bcBytes7;
        private ByteContainer bcBytes3;
        private System.Windows.Forms.Label lbBytesBig4;
        private System.Windows.Forms.Label lbBytesBig8;
        private ByteContainer bcBytes1;
        private System.Windows.Forms.Label lbBytesLittle1;
        private System.Windows.Forms.Label lbBytesLittle5;
        private ByteContainer bcBytes6;
        private System.Windows.Forms.Label lbBytesLittle6;
        private ByteContainer bcBytes2;
        private System.Windows.Forms.Label lbBytesLittle2;
        private System.Windows.Forms.Label lbBytesBig2;
        private System.Windows.Forms.Label lbBytesBig3;
        private System.Windows.Forms.Label lbBytesBig6;
        private ByteContainer bcBytes5;
        private System.Windows.Forms.Label lbBytesBig7;
        private System.Windows.Forms.Label lbBytesBig5;
        private System.Windows.Forms.Label lbBytesBig1;
        private System.Windows.Forms.Button btnPositive;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnRemainder;
        private System.Windows.Forms.Button btnTangent;
        private System.Windows.Forms.Button btnCosine;
        private System.Windows.Forms.Button btnSine;
        private System.Windows.Forms.Button btnSqRt;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnExponent;
        private System.Windows.Forms.Button btnUnused1;
        private System.Windows.Forms.Button btnUnused2;
        private System.Windows.Forms.Button btnUnused3;
        private System.Windows.Forms.MenuItem mAbout;
    }
}

