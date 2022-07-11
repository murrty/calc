using System.Globalization;
using System.IO;
using System.Windows.Forms;

using murrty.extensions;

namespace calc {
    public partial class frmMain : Form {

        private readonly string DecimalIdentifier = ".";

        private byte[] DataBytes = new byte[8];
        private byte[] CalculationBytes;
        private byte[] CalculationBuffer;
        private string DataHex = "";
        private string DataValue = "";
        private string KeyDataValue = "";
        private IntegerType DataType = IntegerType.Int32;
        private CalculatorAction CalcAction = CalculatorAction.None;

        public frmMain() {
            InitializeComponent();
            mSystemCalculator.Visible = File.Exists("calc.exe") || File.Exists("calc1.exe");
            lbUpper.ContextMenu = cmUpper;
            lbLower.ContextMenu = cmLower;
            DecimalIdentifier = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            btnDecimal.Text = DecimalIdentifier;
            if (Program.DebugMode) {
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            this.Load += (s, e) => {
                if (!Program.DebugMode) {
                    if (Ini.KeyExists("SystemCalc") && Ini.ReadBool("SystemCalc")) {
                        this.Dispose();
                        return;
                    }
                    if (Ini.KeyExists("Location")) {
                        try {
                            // ReadPoint will throw if the point is a wrong value.
                            Ini.SavedLocation = Ini.ReadPoint("Location");
                            this.Location = Ini.SavedLocation;
                        }
                        catch { }
                    }
                    if (Ini.KeyExists("IntegerType")) {
                        try {
                            // ReadPoint will throw if the point is a wrong value.
                            Ini.SavedIntegerType = Ini.ReadIntType("IntegerType");
                            DataType = Ini.SavedIntegerType;
                            switch (Ini.SavedIntegerType) {
                                case IntegerType.Byte: {
                                    chkSigned.Checked = false;
                                    rbByte.Checked = true;
                                } break;
                                case IntegerType.SByte: {
                                    chkSigned.Checked = true;
                                    rbByte.Checked = true;
                                } break;
                                case IntegerType.Int16: {
                                    chkSigned.Checked = true;
                                    rbInt16.Checked = true;
                                } break;
                                case IntegerType.UInt16: {
                                    chkSigned.Checked = false;
                                    rbInt16.Checked = true;
                                } break;
                                case IntegerType.Int32: {
                                    chkSigned.Checked = true;
                                    rbInt32.Checked = true;
                                } break;
                                case IntegerType.UInt32: {
                                    chkSigned.Checked = false;
                                    rbInt32.Checked = true;
                                } break;
                                case IntegerType.Single: {
                                    chkSigned.Checked = false;
                                    rbSingle.Checked = true;
                                } break;
                                case IntegerType.Int64: {
                                    chkSigned.Checked = true;
                                    rbInt64.Checked = true;
                                } break;
                                case IntegerType.UInt64: {
                                    chkSigned.Checked = false;
                                    rbInt64.Checked = true;
                                } break;
                                case IntegerType.Double: {
                                    chkSigned.Checked = false;
                                    rbDouble.Checked = true;
                                } break;
                            }
                        }
                        catch { }
                    }
                    if (Ini.KeyExists("OutputBackColor")) {
                        try {
                            Ini.SavedOutputBackgroundColor = pnOutput.BackColor = Ini.ReadColor("OutputBackColor");
                        }
                        catch { }
                    }
                    if (Ini.KeyExists("BitsBackColor")) {
                        try {
                            Ini.SavedBitsBackgroundColor = pnBits.BackColor = Ini.ReadColor("BitsBackColor");
                        }
                        catch { }
                    }
                    if (Ini.KeyExists("ForeColor")) {
                        try {
                            Ini.SavedForeColor = lbUpper.ForeColor = lbAction.ForeColor = bcBytes1.ForeColor = bcBytes2.ForeColor = bcBytes3.ForeColor = bcBytes4.ForeColor = bcBytes5.ForeColor = bcBytes6.ForeColor = bcBytes7.ForeColor = bcBytes8.ForeColor = lbBytesBig1.ForeColor = lbBytesBig2.ForeColor = lbBytesBig3.ForeColor = lbBytesBig4.ForeColor = lbBytesBig5.ForeColor = lbBytesBig6.ForeColor = lbBytesBig7.ForeColor = lbBytesBig8.ForeColor = lbBytesLittle1.ForeColor = lbBytesLittle2.ForeColor = lbBytesLittle3.ForeColor = lbBytesLittle4.ForeColor = lbBytesLittle5.ForeColor = lbBytesLittle6.ForeColor = lbBytesLittle7.ForeColor = lbBytesLittle8.ForeColor = Ini.ReadColor("ForeColor");
                        }
                        catch { }
                    }
                    if (Ini.KeyExists("FadedForeColor")) {
                    try {
                        Ini.SavedFadedForeColor = lbLower.ForeColor = Ini.ReadColor("FadedForeColor");
                    }
                    catch { }
                }
                }
            };
            this.FormClosing += (s, e) => {
                if (!Program.DebugMode) {
                    if (this.Location != Ini.SavedLocation) {
                        Ini.Write("Location", this.Location);
                    }
                    if (DataType != Ini.SavedIntegerType) {
                        Ini.Write("IntegerType", DataType.ToString());
                    }
                    if (!Ini.ColorsMatch(Ini.SavedOutputBackgroundColor, pnOutput.BackColor)) {
                        Ini.Write("OutputBackColor", pnOutput.BackColor);
                    }
                    if (!Ini.ColorsMatch(Ini.SavedBitsBackgroundColor, pnBits.BackColor)) {
                        Ini.Write("BitsBackColor", pnBits.BackColor);
                    }
                    if (!Ini.ColorsMatch(Ini.SavedForeColor, lbUpper.ForeColor)) {
                        Ini.Write("ForeColor", lbUpper.ForeColor);
                    }
                    if (!Ini.ColorsMatch(Ini.SavedFadedForeColor, lbLower.ForeColor)) {
                        Ini.Write("FadedForeColor", lbLower.ForeColor);
                    }
                }
            };
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.D0 or Keys.NumPad0: {
                    btn0_Click(null, null);
                } break;

                case Keys.D1 or Keys.NumPad1: {
                    btn1_Click(null, null);
                } break;

                case Keys.D2 or Keys.NumPad2: {
                    btn2_Click(null, null);
                } break;

                case Keys.D3 or Keys.NumPad3: {
                    btn3_Click(null, null);
                } break;

                case Keys.D4 or Keys.NumPad4: {
                    btn4_Click(null, null);
                } break;

                case Keys.D5 or Keys.NumPad5: {
                    btn5_Click(null, null);
                } break;

                case Keys.D6 or Keys.NumPad6: {
                    btn6_Click(null, null);
                } break;

                case Keys.D7 or Keys.NumPad7: {
                    btn7_Click(null, null);
                } break;

                case Keys.D8 or Keys.NumPad8: {
                    btn8_Click(null, null);
                } break;

                case Keys.D9 or Keys.NumPad9: {
                    btn9_Click(null, null);
                } break;

                case Keys.A: {
                    btnA_Click(null, null);
                } break;

                case Keys.B: {
                    btnB_Click(null, null);
                } break;

                case Keys.C: {
                    btnC_Click(null, null);
                } break;

                case Keys.D: {
                    btnD_Click(null, null);
                } break;

                case Keys.E: {
                    btnE_Click(null, null);
                } break;

                case Keys.F: {
                    btnF_Click(null, null);
                } break;

                case Keys.Add: {
                    btnAdd_Click(null, null);
                } break;

                case Keys.Subtract: {
                    btnSubtract_Click(null, null);
                } break;

                case Keys.Divide: {
                    btnDivide_Click(null, null);
                } break;

                case Keys.Multiply: {
                    btnMulitply_Click(null, null);
                } break;

                case Keys.Return: {
                    btnCalculate_Click(null, null);
                } break;

                case Keys.Back: {
                    btnBackspace_Click(null, null);
                } break;

                case Keys.Decimal or Keys.OemPeriod: {
                    btnDecimal_Click(null, null);
                } break;

                case Keys.Control when e.KeyData == (Keys.V | Keys.Control):
                case Keys.V when e.KeyData == (Keys.V | Keys.Control): {
                    mPaste_Click(null, null);
                } break;
            }
        }

        private void BitSet(object sender, EventArgs e) {
            GetHex();
            GetValue();
        }
        private void GetValue() {
            if (mBigEndian.Checked) {
                DataBytes[0] = bcBytes8.Byte;
                DataBytes[1] = bcBytes7.Byte;
                DataBytes[2] = bcBytes6.Byte;
                DataBytes[3] = bcBytes5.Byte;
                DataBytes[4] = bcBytes4.Byte;
                DataBytes[5] = bcBytes3.Byte;
                DataBytes[6] = bcBytes2.Byte;
                DataBytes[7] = bcBytes1.Byte;
            }
            else {
                DataBytes[0] = bcBytes1.Byte;
                DataBytes[1] = bcBytes2.Byte;
                DataBytes[2] = bcBytes3.Byte;
                DataBytes[3] = bcBytes4.Byte;
                DataBytes[4] = bcBytes5.Byte;
                DataBytes[5] = bcBytes6.Byte;
                DataBytes[6] = bcBytes7.Byte;
                DataBytes[7] = bcBytes8.Byte;
            }

            object val;
            switch (DataType) {
                case IntegerType.Byte: {
                    val = DataBytes[0];
                    DataValue = val.ToString();
                } break;
                case IntegerType.SByte: {
                    val = unchecked((sbyte)DataBytes[0]);
                    DataValue = val.ToString();
                } break;
                case IntegerType.Int16: {
                    val = BitConverter.ToInt16(DataBytes, 0);
                    DataValue = ((Int16)val).ToString(mThousandths.Checked ? "#,##0" : "");
                } break;
                case IntegerType.UInt16: {
                    val = BitConverter.ToUInt16(DataBytes, 0);
                    DataValue = ((UInt16)val).ToString(mThousandths.Checked ? "#,##0" : "");
                } break;
                case IntegerType.Int32: {
                    val = BitConverter.ToInt32(DataBytes, 0);
                    DataValue = ((Int32)val).ToString(mThousandths.Checked ? "#,##0" : "");
                } break;
                case IntegerType.UInt32: {
                    val = BitConverter.ToUInt32(DataBytes, 0);
                    DataValue = ((UInt32)val).ToString(mThousandths.Checked ? "#,##0" : "");
                } break;
                case IntegerType.Single: {
                    val = BitConverter.ToSingle(DataBytes, 0);
                    DataValue = ((Single)val).ToString(mThousandths.Checked ? "#,##0.#########" : "");
                } break;
                case IntegerType.Int64: {
                    val = BitConverter.ToInt64(DataBytes, 0);
                    DataValue = ((Int64)val).ToString(mThousandths.Checked ? "#,##0" : "");
                } break;
                case IntegerType.UInt64: {
                    val = BitConverter.ToUInt64(DataBytes, 0);
                    DataValue = ((UInt64)val).ToString(mThousandths.Checked ? "#,##0" : "");
                } break;
                case IntegerType.Double: {
                    val = BitConverter.ToDouble(DataBytes, 0);
                    DataValue = ((Double)val).ToString(mThousandths.Checked ? "#,##0.###################" : "");
                } break;
                default: throw new ArgumentException(nameof(DataType));
            }

            KeyDataValue = val.ToString();

            if (chkHex.Checked) {
                lbLower.Text = DataValue;
            }
            else {
                lbUpper.Text = DataValue;
            }

        }
        private void GetHex() {
            if (mBigEndian.Checked) {
                DataHex = bcBytes8.ByteHexString;
                if (rbInt16.Checked) {
                    DataHex = bcBytes7.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                }
                else if (rbInt32.Checked || rbSingle.Checked) {
                    DataHex = bcBytes7.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes6.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes5.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                }
                else if (rbInt64.Checked || rbDouble.Checked) {
                    DataHex = bcBytes7.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes6.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes5.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes4.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes3.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes2.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes1.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                }
            }
            else {
                DataHex = bcBytes1.ByteHexString;
                if (rbInt16.Checked) {
                    DataHex = bcBytes2.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                }
                else if (rbInt32.Checked || rbSingle.Checked) {
                    DataHex = bcBytes2.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes3.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes4.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                }
                else if (rbInt64.Checked || rbDouble.Checked) {
                    DataHex = bcBytes2.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes3.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes4.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes5.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes6.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes7.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                    DataHex = bcBytes8.ByteHexString + (mThousandths.Checked ? "_" : "") + DataHex;
                }
            }

            DataHex = DataHex.TrimStart('0', '_');

            if (chkHex.Checked) {
                KeyDataValue = DataHex.Replace("_", "");
                lbUpper.Text = (mAppendHexIdentifier.Checked ? "0x" : "") + (DataHex == "" ? "0" : DataHex);
            }
            else {
                lbLower.Text = (mAppendHexIdentifier.Checked ? "0x" : "") + (DataHex == "" ? "0" : DataHex);
            }
        }
        private void CheckKeyData() {
            if (chkHex.Checked) {
                switch (DataType) {
                    case IntegerType.Byte: {
                        if (Byte.TryParse(KeyDataValue, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out Byte val)) {
                            DataBytes[0] = val;
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.SByte: {
                        if (SByte.TryParse(KeyDataValue, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out SByte val)) {
                            DataBytes[0] = (byte)val;
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.Int16: {
                        if (Int16.TryParse(KeyDataValue, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out Int16 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 8);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.UInt16: {
                        if (UInt16.TryParse(KeyDataValue, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out UInt16 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 8);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.Int32: {
                        if (Int32.TryParse(KeyDataValue, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out Int32 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 8);
                            DataBytes[2] = (byte)(val >> 16);
                            DataBytes[3] = (byte)(val >> 24);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.UInt32: {
                        if (UInt32.TryParse(KeyDataValue, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out UInt32 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 8);
                            DataBytes[2] = (byte)(val >> 16);
                            DataBytes[3] = (byte)(val >> 24);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.Single: {
                        if (Single.TryParse(KeyDataValue, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out Single val)) {
                            byte[] b = BitConverter.GetBytes(val);
                            DataBytes[0] = b[0];
                            DataBytes[1] = b[1];
                            DataBytes[2] = b[2];
                            DataBytes[3] = b[3];
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.Int64: {
                        if (Int64.TryParse(KeyDataValue, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out Int64 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 8);
                            DataBytes[2] = (byte)(val >> 16);
                            DataBytes[3] = (byte)(val >> 24);
                            DataBytes[0] = (byte)(val >> 32);
                            DataBytes[1] = (byte)(val >> 40);
                            DataBytes[2] = (byte)(val >> 48);
                            DataBytes[3] = (byte)(val >> 56);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.UInt64: {
                        if (UInt64.TryParse(KeyDataValue, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out UInt64 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 8);
                            DataBytes[2] = (byte)(val >> 16);
                            DataBytes[3] = (byte)(val >> 24);
                            DataBytes[0] = (byte)(val >> 32);
                            DataBytes[1] = (byte)(val >> 40);
                            DataBytes[2] = (byte)(val >> 48);
                            DataBytes[3] = (byte)(val >> 56);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.Double: {
                        if (Double.TryParse(KeyDataValue, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out Double val)) {
                            DataBytes = BitConverter.GetBytes(val);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;
                }
            }
            else {
                switch (DataType) {
                    case IntegerType.Byte: {
                        if (Byte.TryParse(KeyDataValue, out Byte val)) {
                            DataBytes[0] = val;
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.SByte: {
                        if (SByte.TryParse(KeyDataValue, out SByte val)) {
                            DataBytes[0] = (byte)val;
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.Int16: {
                        if (Int16.TryParse(KeyDataValue, out Int16 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 1);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.UInt16: {
                        if (UInt16.TryParse(KeyDataValue, out UInt16 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 1);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.Int32: {
                        if (Int32.TryParse(KeyDataValue, out Int32 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 8);
                            DataBytes[2] = (byte)(val >> 16);
                            DataBytes[3] = (byte)(val >> 24);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.UInt32: {
                        if (UInt32.TryParse(KeyDataValue, out UInt32 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 8);
                            DataBytes[2] = (byte)(val >> 16);
                            DataBytes[3] = (byte)(val >> 24);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.Single: {
                        if (Single.TryParse(KeyDataValue, out Single val)) {
                            byte[] b = BitConverter.GetBytes(val);
                            DataBytes[0] = b[0];
                            DataBytes[1] = b[1];
                            DataBytes[2] = b[2];
                            DataBytes[3] = b[3];
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.Int64: {
                        if (Int64.TryParse(KeyDataValue, out Int64 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 8);
                            DataBytes[2] = (byte)(val >> 16);
                            DataBytes[3] = (byte)(val >> 24);
                            DataBytes[0] = (byte)(val >> 32);
                            DataBytes[1] = (byte)(val >> 40);
                            DataBytes[2] = (byte)(val >> 48);
                            DataBytes[3] = (byte)(val >> 56);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.UInt64: {
                        if (UInt64.TryParse(KeyDataValue, out UInt64 val)) {
                            DataBytes[0] = (byte)(val >> 0);
                            DataBytes[1] = (byte)(val >> 8);
                            DataBytes[2] = (byte)(val >> 16);
                            DataBytes[3] = (byte)(val >> 24);
                            DataBytes[0] = (byte)(val >> 32);
                            DataBytes[1] = (byte)(val >> 40);
                            DataBytes[2] = (byte)(val >> 48);
                            DataBytes[3] = (byte)(val >> 56);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;

                    case IntegerType.Double: {
                        if (Double.TryParse(KeyDataValue, out Double val)) {
                            DataBytes = BitConverter.GetBytes(val);
                        }
                        else {
                            System.Media.SystemSounds.Beep.Play();
                            KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                            return;
                        }
                    } break;
                }
            }

            if (mBigEndian.Checked) {
                bcBytes8.SetByte(DataBytes[0]);
                bcBytes7.SetByte(DataBytes[1]);
                bcBytes6.SetByte(DataBytes[2]);
                bcBytes5.SetByte(DataBytes[3]);
                bcBytes4.SetByte(DataBytes[4]);
                bcBytes3.SetByte(DataBytes[5]);
                bcBytes2.SetByte(DataBytes[6]);
                bcBytes1.SetByte(DataBytes[7]);
            }
            else {
                bcBytes1.SetByte(DataBytes[0]);
                bcBytes2.SetByte(DataBytes[1]);
                bcBytes3.SetByte(DataBytes[2]);
                bcBytes4.SetByte(DataBytes[3]);
                bcBytes5.SetByte(DataBytes[4]);
                bcBytes6.SetByte(DataBytes[5]);
                bcBytes7.SetByte(DataBytes[6]);
                bcBytes8.SetByte(DataBytes[7]);
            }

            GetValue();
            GetHex();
        }
        private void PerformCalculation() {
            if (CalcAction == CalculatorAction.None) return;

            CalculationBuffer = (byte[])CalculationBytes.Clone();
            switch (DataType) {
                case IntegerType.Byte: {
                    Byte Calc = CalculationBytes[0];
                    Byte Calc2 = DataBytes[0];
                    Byte Result;
                    switch (CalcAction) {
                        case CalculatorAction.Add: {
                            Result = (Byte)(Calc + Calc2);
                        } break;

                        case CalculatorAction.Subtract: {
                            Result = (Byte)(Calc - Calc2);
                        } break;

                        case CalculatorAction.Divide: {
                            Result = (Byte)(Calc / Calc2);
                        } break;

                        case CalculatorAction.Multiply: {
                            Result = (Byte)(Calc * Calc2);
                        } break;

                        case CalculatorAction.Remainder: {
                            Result = (Byte)(Calc % Calc2);
                        } break;

                        case CalculatorAction.Squared: {
                            Result = (Byte)(Calc * Calc);
                        } break;

                        case CalculatorAction.Cubed: {
                            Result = (Byte)(Calc * Calc * Calc);
                        } break;

                        case CalculatorAction.Exponent: {
                            Result = (Byte)Math.Pow(Calc, Calc2);
                        } break;

                        default: return;
                    }
                    KeyDataValue = DataValue = Result.ToString();
                    if (mBigEndian.Checked) {
                        bcBytes8.Byte = Result;
                        bcBytes7.Byte = 0x0;
                        bcBytes6.Byte = 0x0;
                        bcBytes5.Byte = 0x0;
                        bcBytes4.Byte = 0x0;
                        bcBytes3.Byte = 0x0;
                        bcBytes2.Byte = 0x0;
                        bcBytes1.Byte = 0x0;
                    }
                    else {
                        bcBytes1.Byte = Result;
                        bcBytes2.Byte = 0x0;
                        bcBytes3.Byte = 0x0;
                        bcBytes4.Byte = 0x0;
                        bcBytes5.Byte = 0x0;
                        bcBytes6.Byte = 0x0;
                        bcBytes7.Byte = 0x0;
                        bcBytes8.Byte = 0x0;
                    }
                    CalculationBytes = CalculationBuffer;
                } break;

                case IntegerType.SByte: {
                    SByte Calc = unchecked((sbyte)CalculationBytes[0]);
                    SByte Calc2 = unchecked((sbyte)DataBytes[0]);
                    SByte Result;
                    switch (CalcAction) {
                        case CalculatorAction.Add: {
                            Result = (SByte)(Calc + Calc2);
                        } break;

                        case CalculatorAction.Subtract: {
                            Result = (SByte)(Calc - Calc2);
                        } break;

                        case CalculatorAction.Divide: {
                            Result = (SByte)(Calc / Calc2);
                        } break;

                        case CalculatorAction.Multiply: {
                            Result = (SByte)(Calc * Calc2);
                        } break;

                        case CalculatorAction.Remainder: {
                            Result = (SByte)(Calc % Calc2);
                        } break;

                        case CalculatorAction.Squared: {
                            Result = (SByte)(Calc * Calc);
                        } break;

                        case CalculatorAction.Cubed: {
                            Result = (SByte)(Calc * Calc * Calc);
                        } break;

                        case CalculatorAction.Exponent: {
                            Result = (SByte)Math.Pow(Calc, Calc2);
                        } break;

                        default: return;
                    }
                    if (mBigEndian.Checked) {
                        bcBytes8.Byte = (Byte)Result;
                        bcBytes7.Byte = 0x0;
                        bcBytes6.Byte = 0x0;
                        bcBytes5.Byte = 0x0;
                        bcBytes4.Byte = 0x0;
                        bcBytes3.Byte = 0x0;
                        bcBytes2.Byte = 0x0;
                        bcBytes1.Byte = 0x0;
                    }
                    else {
                        bcBytes1.Byte = (Byte)Result;
                        bcBytes2.Byte = 0x0;
                        bcBytes3.Byte = 0x0;
                        bcBytes4.Byte = 0x0;
                        bcBytes5.Byte = 0x0;
                        bcBytes6.Byte = 0x0;
                        bcBytes7.Byte = 0x0;
                        bcBytes8.Byte = 0x0;
                    }
                    CalculationBytes = CalculationBuffer;
                } break;

                case IntegerType.Int16: {
                    Int16 Calc = BitConverter.ToInt16(CalculationBytes, 0);
                    Int16 Calc2 = BitConverter.ToInt16(DataBytes, 0);
                    Int16 Result;
                    switch (CalcAction) {
                        case CalculatorAction.Add: {
                            Result = (Int16)(Calc + Calc2);
                        } break;

                        case CalculatorAction.Subtract: {
                            Result = (Int16)(Calc - Calc2);
                        } break;

                        case CalculatorAction.Divide: {
                            Result = (Int16)(Calc / Calc2);
                        } break;

                        case CalculatorAction.Multiply: {
                            Result = (Int16)(Calc * Calc2);
                        } break;

                        case CalculatorAction.Remainder: {
                            Result = (Int16)(Calc % Calc2);
                        } break;

                        case CalculatorAction.Squared: {
                            Result = (Int16)(Calc * Calc);
                        } break;

                        case CalculatorAction.Cubed: {
                            Result = (Int16)(Calc * Calc * Calc);
                        } break;

                        case CalculatorAction.Exponent: {
                            Result = (Int16)Math.Pow(Calc, Calc2);
                        } break;

                        default: return;
                    }
                    CalculationBytes = BitConverter.GetBytes(Result);
                    if (mBigEndian.Checked) {
                        bcBytes8.Byte = CalculationBytes[0];
                        bcBytes7.Byte = CalculationBytes[1];
                        bcBytes6.Byte = 0x0;
                        bcBytes5.Byte = 0x0;
                        bcBytes4.Byte = 0x0;
                        bcBytes3.Byte = 0x0;
                        bcBytes2.Byte = 0x0;
                        bcBytes1.Byte = 0x0;
                    }
                    else {
                        bcBytes1.Byte = CalculationBytes[0];
                        bcBytes2.Byte = CalculationBytes[1];
                        bcBytes3.Byte = 0x0;
                        bcBytes4.Byte = 0x0;
                        bcBytes5.Byte = 0x0;
                        bcBytes6.Byte = 0x0;
                        bcBytes7.Byte = 0x0;
                        bcBytes8.Byte = 0x0;
                    }
                    CalculationBytes = CalculationBuffer;
                } break;

                case IntegerType.UInt16: {
                    UInt16 Calc = BitConverter.ToUInt16(CalculationBytes, 0);
                    UInt16 Calc2 = BitConverter.ToUInt16(DataBytes, 0);
                    UInt16 Result;
                    switch (CalcAction) {
                        case CalculatorAction.Add: {
                            Result = (UInt16)(Calc + Calc2);
                        } break;

                        case CalculatorAction.Subtract: {
                            Result = (UInt16)(Calc - Calc2);
                        } break;

                        case CalculatorAction.Divide: {
                            Result = (UInt16)(Calc / Calc2);
                        } break;

                        case CalculatorAction.Multiply: {
                            Result = (UInt16)(Calc * Calc2);
                        } break;

                        case CalculatorAction.Remainder: {
                            Result = (UInt16)(Calc % Calc2);
                        } break;

                        case CalculatorAction.Squared: {
                            Result = (UInt16)(Calc * Calc);
                        } break;

                        case CalculatorAction.Cubed: {
                            Result = (UInt16)(Calc * Calc * Calc);
                        } break;

                        case CalculatorAction.Exponent: {
                            Result = (UInt16)Math.Pow(Calc, Calc2);
                        } break;

                        default: return;
                    }
                    KeyDataValue = DataValue = Result.ToString();
                    CalculationBytes = BitConverter.GetBytes(Result);
                    if (mBigEndian.Checked) {
                        bcBytes8.Byte = CalculationBytes[0];
                        bcBytes7.Byte = CalculationBytes[1];
                        bcBytes6.Byte = 0x0;
                        bcBytes5.Byte = 0x0;
                        bcBytes4.Byte = 0x0;
                        bcBytes3.Byte = 0x0;
                        bcBytes2.Byte = 0x0;
                        bcBytes1.Byte = 0x0;
                    }
                    else {
                        bcBytes1.Byte = CalculationBytes[0];
                        bcBytes2.Byte = CalculationBytes[1];
                        bcBytes3.Byte = 0x0;
                        bcBytes4.Byte = 0x0;
                        bcBytes5.Byte = 0x0;
                        bcBytes6.Byte = 0x0;
                        bcBytes7.Byte = 0x0;
                        bcBytes8.Byte = 0x0;
                    }
                    CalculationBytes = CalculationBuffer;
                } break;

                case IntegerType.Int32: {
                    Int32 Calc = BitConverter.ToInt32(CalculationBytes, 0);
                    Int32 Calc2 = BitConverter.ToInt32(DataBytes, 0);
                    Int32 Result;
                    switch (CalcAction) {
                        case CalculatorAction.Add: {
                            Result = (Int32)(Calc + Calc2);
                        } break;

                        case CalculatorAction.Subtract: {
                            Result = (Int32)(Calc - Calc2);
                        } break;

                        case CalculatorAction.Divide: {
                            Result = (Int32)(Calc / Calc2);
                        } break;

                        case CalculatorAction.Multiply: {
                            Result = (Int32)(Calc * Calc2);
                        } break;

                        case CalculatorAction.Remainder: {
                            Result = (Int32)(Calc % Calc2);
                        } break;

                        case CalculatorAction.Squared: {
                            Result = (Int32)(Calc * Calc);
                        } break;

                        case CalculatorAction.Cubed: {
                            Result = (Int32)(Calc * Calc * Calc);
                        } break;

                        case CalculatorAction.Exponent: {
                            Result = (Int32)Math.Pow(Calc, Calc2);
                        } break;

                        default: return;
                    }
                    KeyDataValue = DataValue = Result.ToString();
                    CalculationBytes = BitConverter.GetBytes(Result);
                    if (mBigEndian.Checked) {
                        bcBytes8.Byte = CalculationBytes[0];
                        bcBytes7.Byte = CalculationBytes[1];
                        bcBytes6.Byte = CalculationBytes[2];
                        bcBytes5.Byte = CalculationBytes[3];
                        bcBytes4.Byte = 0x0;
                        bcBytes3.Byte = 0x0;
                        bcBytes2.Byte = 0x0;
                        bcBytes1.Byte = 0x0;
                    }
                    else {
                        bcBytes1.Byte = CalculationBytes[0];
                        bcBytes2.Byte = CalculationBytes[1];
                        bcBytes3.Byte = CalculationBytes[2];
                        bcBytes4.Byte = CalculationBytes[3];
                        bcBytes5.Byte = 0x0;
                        bcBytes6.Byte = 0x0;
                        bcBytes7.Byte = 0x0;
                        bcBytes8.Byte = 0x0;
                    }
                    CalculationBytes = CalculationBuffer;
                } break;

                case IntegerType.UInt32: {
                    UInt32 Calc = BitConverter.ToUInt32(CalculationBytes, 0);
                    UInt32 Calc2 = BitConverter.ToUInt32(DataBytes, 0);
                    UInt32 Result;
                    switch (CalcAction) {
                        case CalculatorAction.Add: {
                            Result = (UInt32)(Calc + Calc2);
                        } break;

                        case CalculatorAction.Subtract: {
                            Result = (UInt32)(Calc - Calc2);
                        } break;

                        case CalculatorAction.Divide: {
                            Result = (UInt32)(Calc / Calc2);
                        } break;

                        case CalculatorAction.Multiply: {
                            Result = (UInt32)(Calc * Calc2);
                        } break;

                        case CalculatorAction.Remainder: {
                            Result = (UInt32)(Calc % Calc2);
                        } break;

                        case CalculatorAction.Squared: {
                            Result = (UInt32)(Calc * Calc);
                        } break;

                        case CalculatorAction.Cubed: {
                            Result = (UInt32)(Calc * Calc * Calc);
                        } break;

                        case CalculatorAction.Exponent: {
                            Result = (UInt32)Math.Pow(Calc, Calc2);
                        } break;

                        default: return;
                    }
                    KeyDataValue = DataValue = Result.ToString();
                    CalculationBytes = BitConverter.GetBytes(Result);
                    if (mBigEndian.Checked) {
                        bcBytes8.Byte = CalculationBytes[0];
                        bcBytes7.Byte = CalculationBytes[1];
                        bcBytes6.Byte = CalculationBytes[2];
                        bcBytes5.Byte = CalculationBytes[3];
                        bcBytes4.Byte = 0x0;
                        bcBytes3.Byte = 0x0;
                        bcBytes2.Byte = 0x0;
                        bcBytes1.Byte = 0x0;
                    }
                    else {
                        bcBytes1.Byte = CalculationBytes[0];
                        bcBytes2.Byte = CalculationBytes[1];
                        bcBytes3.Byte = CalculationBytes[2];
                        bcBytes4.Byte = CalculationBytes[3];
                        bcBytes5.Byte = 0x0;
                        bcBytes6.Byte = 0x0;
                        bcBytes7.Byte = 0x0;
                        bcBytes8.Byte = 0x0;
                    }
                    CalculationBytes = CalculationBuffer;
                } break;

                case IntegerType.Single: {
                    Single Calc = BitConverter.ToSingle(CalculationBytes, 0);
                    Single Calc2 = BitConverter.ToSingle(DataBytes, 0);
                    Single Result;
                    switch (CalcAction) {
                        case CalculatorAction.Add: {
                            Result = (Single)(Calc + Calc2);
                        } break;

                        case CalculatorAction.Subtract: {
                            Result = (Single)(Calc - Calc2);
                        } break;

                        case CalculatorAction.Divide: {
                            Result = (Single)(Calc / Calc2);
                        } break;

                        case CalculatorAction.Multiply: {
                            Result = (Single)(Calc * Calc2);
                        } break;

                        case CalculatorAction.Remainder: {
                            Result = (Single)(Calc % Calc2);
                        } break;

                        case CalculatorAction.Squared: {
                            Result = (Single)(Calc * Calc);
                        } break;

                        case CalculatorAction.Cubed: {
                            Result = (Single)(Calc * Calc * Calc);
                        } break;

                        case CalculatorAction.Exponent: {
                            Result = (Single)Math.Pow(Calc, Calc2);
                        } break;

                        default: return;
                    }
                    KeyDataValue = DataValue = Result.ToString();
                    CalculationBytes = BitConverter.GetBytes(Result);
                    if (mBigEndian.Checked) {
                        bcBytes8.Byte = CalculationBytes[0];
                        bcBytes7.Byte = CalculationBytes[1];
                        bcBytes6.Byte = CalculationBytes[2];
                        bcBytes5.Byte = CalculationBytes[3];
                        bcBytes4.Byte = 0x0;
                        bcBytes3.Byte = 0x0;
                        bcBytes2.Byte = 0x0;
                        bcBytes1.Byte = 0x0;
                    }
                    else {
                        bcBytes1.Byte = CalculationBytes[0];
                        bcBytes2.Byte = CalculationBytes[1];
                        bcBytes3.Byte = CalculationBytes[2];
                        bcBytes4.Byte = CalculationBytes[3];
                        bcBytes5.Byte = 0x0;
                        bcBytes6.Byte = 0x0;
                        bcBytes7.Byte = 0x0;
                        bcBytes8.Byte = 0x0;
                    }
                    CalculationBytes = CalculationBuffer;
                } break;

                case IntegerType.Int64: {
                    Int64 Calc = BitConverter.ToInt64(CalculationBytes, 0);
                    Int64 Calc2 = BitConverter.ToInt64(DataBytes, 0);
                    Int64 Result;
                    switch (CalcAction) {
                        case CalculatorAction.Add: {
                            Result = (Int64)(Calc + Calc2);
                        } break;

                        case CalculatorAction.Subtract: {
                            Result = (Int64)(Calc - Calc2);
                        } break;

                        case CalculatorAction.Divide: {
                            Result = (Int64)(Calc / Calc2);
                        } break;

                        case CalculatorAction.Multiply: {
                            Result = (Int64)(Calc * Calc2);
                        } break;

                        case CalculatorAction.Remainder: {
                            Result = (Int64)(Calc % Calc2);
                        } break;

                        case CalculatorAction.Squared: {
                            Result = (Int64)(Calc * Calc);
                        } break;

                        case CalculatorAction.Cubed: {
                            Result = (Int64)(Calc * Calc * Calc);
                        } break;

                        case CalculatorAction.Exponent: {
                            Result = (Int64)Math.Pow(Calc, Calc2);
                        } break;

                        default: return;
                    }
                    KeyDataValue = DataValue = Result.ToString();
                    CalculationBytes = BitConverter.GetBytes(Result);
                    if (mBigEndian.Checked) {
                        bcBytes8.Byte = CalculationBytes[0];
                        bcBytes7.Byte = CalculationBytes[1];
                        bcBytes6.Byte = CalculationBytes[2];
                        bcBytes5.Byte = CalculationBytes[3];
                        bcBytes4.Byte = CalculationBytes[4];
                        bcBytes3.Byte = CalculationBytes[5];
                        bcBytes2.Byte = CalculationBytes[6];
                        bcBytes1.Byte = CalculationBytes[7];
                    }
                    else {
                        bcBytes1.Byte = CalculationBytes[0];
                        bcBytes2.Byte = CalculationBytes[1];
                        bcBytes3.Byte = CalculationBytes[2];
                        bcBytes4.Byte = CalculationBytes[3];
                        bcBytes5.Byte = CalculationBytes[4];
                        bcBytes6.Byte = CalculationBytes[5];
                        bcBytes7.Byte = CalculationBytes[6];
                        bcBytes8.Byte = CalculationBytes[7];
                    }
                    CalculationBytes = CalculationBuffer;
                } break;

                case IntegerType.UInt64: {
                    UInt64 Calc = BitConverter.ToUInt64(CalculationBytes, 0);
                    UInt64 Calc2 = BitConverter.ToUInt64(DataBytes, 0);
                    UInt64 Result;
                    switch (CalcAction) {
                        case CalculatorAction.Add: {
                            Result = (UInt64)(Calc + Calc2);
                        } break;

                        case CalculatorAction.Subtract: {
                            Result = (UInt64)(Calc - Calc2);
                        } break;

                        case CalculatorAction.Divide: {
                            Result = (UInt64)(Calc / Calc2);
                        } break;

                        case CalculatorAction.Multiply: {
                            Result = (UInt64)(Calc * Calc2);
                        } break;

                        case CalculatorAction.Remainder: {
                            Result = (UInt64)(Calc % Calc2);
                        } break;

                        case CalculatorAction.Squared: {
                            Result = (UInt64)(Calc * Calc);
                        } break;

                        case CalculatorAction.Cubed: {
                            Result = (UInt64)(Calc * Calc * Calc);
                        } break;

                        case CalculatorAction.Exponent: {
                            Result = (UInt64)Math.Pow(Calc, Calc2);
                        } break;

                        default: return;
                    }
                    KeyDataValue = DataValue = Result.ToString();
                    CalculationBytes = BitConverter.GetBytes(Result);
                    if (mBigEndian.Checked) {
                        bcBytes8.Byte = CalculationBytes[0];
                        bcBytes7.Byte = CalculationBytes[1];
                        bcBytes6.Byte = CalculationBytes[2];
                        bcBytes5.Byte = CalculationBytes[3];
                        bcBytes4.Byte = CalculationBytes[4];
                        bcBytes3.Byte = CalculationBytes[5];
                        bcBytes2.Byte = CalculationBytes[6];
                        bcBytes1.Byte = CalculationBytes[7];
                    }
                    else {
                        bcBytes1.Byte = CalculationBytes[0];
                        bcBytes2.Byte = CalculationBytes[1];
                        bcBytes3.Byte = CalculationBytes[2];
                        bcBytes4.Byte = CalculationBytes[3];
                        bcBytes5.Byte = CalculationBytes[4];
                        bcBytes6.Byte = CalculationBytes[5];
                        bcBytes7.Byte = CalculationBytes[6];
                        bcBytes8.Byte = CalculationBytes[7];
                    }
                    CalculationBytes = CalculationBuffer;
                } break;

                case IntegerType.Double: {
                    Double Calc = BitConverter.ToDouble(CalculationBytes, 0);
                    Double Calc2 = BitConverter.ToDouble(DataBytes, 0);
                    Double Result;
                    switch (CalcAction) {
                        case CalculatorAction.Add: {
                            Result = (Double)(Calc + Calc2);
                        } break;

                        case CalculatorAction.Subtract: {
                            Result = (Double)(Calc - Calc2);
                        } break;

                        case CalculatorAction.Divide: {
                            Result = (Double)(Calc / Calc2);
                        } break;

                        case CalculatorAction.Multiply: {
                            Result = (Double)(Calc * Calc2);
                        } break;

                        case CalculatorAction.Remainder: {
                            Result = (Double)(Calc % Calc2);
                        } break;

                        case CalculatorAction.Squared: {
                            Result = (Double)(Calc * Calc);
                        } break;

                        case CalculatorAction.Cubed: {
                            Result = (Double)(Calc * Calc * Calc);
                        } break;

                        case CalculatorAction.Exponent: {
                            Result = Math.Pow(Calc, Calc2);
                        } break;

                        case CalculatorAction.SquareRoot: {
                            Result = Math.Sqrt(Calc2);
                        } break;

                        case CalculatorAction.Sine: {
                            Result = Math.Sin(Calc2);
                        } break;

                        case CalculatorAction.Cosine: {
                            Result = Math.Cos(Calc2);
                        } break;

                        case CalculatorAction.Tangent: {
                            Result = Math.Tan(Calc2);
                        } break;

                        default: return;
                    }
                    KeyDataValue = DataValue = Result.ToString();
                    CalculationBytes = BitConverter.GetBytes(Result);
                    if (mBigEndian.Checked) {
                        bcBytes8.Byte = CalculationBytes[0];
                        bcBytes7.Byte = CalculationBytes[1];
                        bcBytes6.Byte = CalculationBytes[2];
                        bcBytes5.Byte = CalculationBytes[3];
                        bcBytes4.Byte = CalculationBytes[4];
                        bcBytes3.Byte = CalculationBytes[5];
                        bcBytes2.Byte = CalculationBytes[6];
                        bcBytes1.Byte = CalculationBytes[7];
                    }
                    else {
                        bcBytes1.Byte = CalculationBytes[0];
                        bcBytes2.Byte = CalculationBytes[1];
                        bcBytes3.Byte = CalculationBytes[2];
                        bcBytes4.Byte = CalculationBytes[3];
                        bcBytes5.Byte = CalculationBytes[4];
                        bcBytes6.Byte = CalculationBytes[5];
                        bcBytes7.Byte = CalculationBytes[6];
                        bcBytes8.Byte = CalculationBytes[7];
                    }
                    CalculationBytes = CalculationBuffer;
                } break;

                default: return;
            }

            //CalcAction = CalculatorAction.None;
            CalculationBuffer = null;
        }
        private bool GetClipboardData() {
            if (!Clipboard.ContainsText()) return false;
            byte[] buffer;
            string text = Clipboard.GetText();
            switch (DataType) {
                case IntegerType.Byte: {
                    if (Byte.TryParse(text, out Byte val) || Byte.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val)) {
                        buffer = new byte[] { val };
                        if (mBigEndian.Checked) {
                            bcBytes8.Byte = buffer[0];
                        }
                        else {
                            bcBytes1.Byte = buffer[0];
                        }
                        KeyDataValue = val.ToString();
                        return true;
                    }
                    else return false;
                }

                case IntegerType.SByte: {
                    if (SByte.TryParse(text, out SByte val) || SByte.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val)) {
                        buffer = new byte[] { (byte)val };
                        if (mBigEndian.Checked) {
                            bcBytes8.Byte = buffer[0];
                        }
                        else {
                            bcBytes1.Byte = buffer[0];
                        }
                        KeyDataValue = val.ToString();
                        return true;
                    }
                    else return false;
                }

                case IntegerType.Int16: {
                    if (Int16.TryParse(text, out Int16 val) || Int16.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val)) {
                        buffer = BitConverter.GetBytes(val);
                        Array.Resize(ref DataBytes, 8);
                        if (mBigEndian.Checked) {
                            bcBytes8.Byte = buffer[0];
                            bcBytes7.Byte = buffer[1];
                        }
                        else {
                            bcBytes1.Byte = buffer[0];
                            bcBytes2.Byte = buffer[1];
                        }
                        KeyDataValue = val.ToString();
                        return true;
                    }
                    else return false;
                }

                case IntegerType.UInt16: {
                    if (UInt16.TryParse(text, out UInt16 val) || UInt16.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val)) {
                        buffer = BitConverter.GetBytes(val);
                        Array.Resize(ref DataBytes, 8);
                        if (mBigEndian.Checked) {
                            bcBytes8.Byte = buffer[0];
                            bcBytes7.Byte = buffer[1];
                        }
                        else {
                            bcBytes1.Byte = buffer[0];
                            bcBytes2.Byte = buffer[1];
                        }
                        KeyDataValue = val.ToString();
                        return true;
                    }
                    else return false;
                }

                case IntegerType.Int32: {
                    if (Int32.TryParse(text, out Int32 val) || Int32.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val)) {
                        buffer = BitConverter.GetBytes(val);
                        Array.Resize(ref DataBytes, 8);
                        if (mBigEndian.Checked) {
                            bcBytes8.Byte = buffer[0];
                            bcBytes7.Byte = buffer[1];
                            bcBytes6.Byte = buffer[2];
                            bcBytes5.Byte = buffer[3];
                        }
                        else {
                            bcBytes1.Byte = buffer[0];
                            bcBytes2.Byte = buffer[1];
                            bcBytes3.Byte = buffer[2];
                            bcBytes4.Byte = buffer[3];
                        }
                        KeyDataValue = val.ToString();
                        return true;
                    }
                    else return false;
                }

                case IntegerType.UInt32: {
                    if (UInt32.TryParse(text, out UInt32 val) || UInt32.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val)) {
                        buffer = BitConverter.GetBytes(val);
                        if (mBigEndian.Checked) {
                            bcBytes8.Byte = buffer[0];
                            bcBytes7.Byte = buffer[1];
                            bcBytes6.Byte = buffer[2];
                            bcBytes5.Byte = buffer[3];
                        }
                        else {
                            bcBytes1.Byte = buffer[0];
                            bcBytes2.Byte = buffer[1];
                            bcBytes3.Byte = buffer[2];
                            bcBytes4.Byte = buffer[3];
                        }
                        KeyDataValue = val.ToString();
                        return true;
                    }
                    else return false;
                }

                case IntegerType.Single: {
                    if (Single.TryParse(text, out Single val) || Single.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val)) {
                        buffer = BitConverter.GetBytes(val);
                        if (mBigEndian.Checked) {
                            bcBytes8.Byte = buffer[0];
                            bcBytes7.Byte = buffer[1];
                            bcBytes6.Byte = buffer[2];
                            bcBytes5.Byte = buffer[3];
                        }
                        else {
                            bcBytes1.Byte = buffer[0];
                            bcBytes2.Byte = buffer[1];
                            bcBytes3.Byte = buffer[2];
                            bcBytes4.Byte = buffer[3];
                        }
                        KeyDataValue = val.ToString();
                        return true;
                    }
                    else return false;
                }

                case IntegerType.Int64: {
                    if (Int64.TryParse(text, out Int64 val) || Int64.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val)) {
                        buffer = BitConverter.GetBytes(val);
                        if (mBigEndian.Checked) {
                            bcBytes8.Byte = buffer[0];
                            bcBytes7.Byte = buffer[1];
                            bcBytes6.Byte = buffer[2];
                            bcBytes5.Byte = buffer[3];
                            bcBytes4.Byte = buffer[4];
                            bcBytes3.Byte = buffer[5];
                            bcBytes2.Byte = buffer[6];
                            bcBytes1.Byte = buffer[7];
                        }
                        else {
                            bcBytes1.Byte = buffer[0];
                            bcBytes2.Byte = buffer[1];
                            bcBytes3.Byte = buffer[2];
                            bcBytes4.Byte = buffer[3];
                            bcBytes5.Byte = buffer[4];
                            bcBytes6.Byte = buffer[5];
                            bcBytes7.Byte = buffer[6];
                            bcBytes8.Byte = buffer[7];
                        }
                        KeyDataValue = val.ToString();
                        return true;
                    }
                    else return false;
                }

                case IntegerType.UInt64: {
                    if (UInt64.TryParse(text, out UInt64 val) || UInt64.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val)) {
                        buffer = BitConverter.GetBytes(val);
                        if (mBigEndian.Checked) {
                            bcBytes8.Byte = buffer[0];
                            bcBytes7.Byte = buffer[1];
                            bcBytes6.Byte = buffer[2];
                            bcBytes5.Byte = buffer[3];
                            bcBytes4.Byte = buffer[4];
                            bcBytes3.Byte = buffer[5];
                            bcBytes2.Byte = buffer[6];
                            bcBytes1.Byte = buffer[7];
                        }
                        else {
                            bcBytes1.Byte = buffer[0];
                            bcBytes2.Byte = buffer[1];
                            bcBytes3.Byte = buffer[2];
                            bcBytes4.Byte = buffer[3];
                            bcBytes5.Byte = buffer[4];
                            bcBytes6.Byte = buffer[5];
                            bcBytes7.Byte = buffer[6];
                            bcBytes8.Byte = buffer[7];
                        }
                        KeyDataValue = val.ToString();
                        return true;
                    }
                    else return false;
                }

                case IntegerType.Double: {
                    if (Double.TryParse(text, out Double val) || Double.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out val)) {
                        buffer = BitConverter.GetBytes(val);
                        if (mBigEndian.Checked) {
                            bcBytes8.Byte = buffer[0];
                            bcBytes7.Byte = buffer[1];
                            bcBytes6.Byte = buffer[2];
                            bcBytes5.Byte = buffer[3];
                            bcBytes4.Byte = buffer[4];
                            bcBytes3.Byte = buffer[5];
                            bcBytes2.Byte = buffer[6];
                            bcBytes1.Byte = buffer[7];
                        }
                        else {
                            bcBytes1.Byte = buffer[0];
                            bcBytes2.Byte = buffer[1];
                            bcBytes3.Byte = buffer[2];
                            bcBytes4.Byte = buffer[3];
                            bcBytes5.Byte = buffer[4];
                            bcBytes6.Byte = buffer[5];
                            bcBytes7.Byte = buffer[6];
                            bcBytes8.Byte = buffer[7];
                        }
                        KeyDataValue = val.ToString();
                        return true;
                    }
                    else return false;
                }

                default: return false;
            }
        }
        private void ResetInput() {
            DataBytes = new byte[8];
            bcBytes1.Byte = 0x0;
            bcBytes2.Byte = 0x0;
            bcBytes3.Byte = 0x0;
            bcBytes4.Byte = 0x0;
            bcBytes5.Byte = 0x0;
            bcBytes6.Byte = 0x0;
            bcBytes7.Byte = 0x0;
            bcBytes8.Byte = 0x0;
            KeyDataValue = "";
            DataValue = "";
            DataHex = "";
            GetValue();
            GetHex();
            lbUpper.Focus();
        }

        private void mBigEndian_Click(object sender, EventArgs e) {
            mBigEndian.Checked ^= true;
            lbBytesBig1.Visible = mBigEndian.Checked;
            lbBytesBig2.Visible = mBigEndian.Checked;
            lbBytesBig3.Visible = mBigEndian.Checked;
            lbBytesBig4.Visible = mBigEndian.Checked;
            lbBytesBig5.Visible = mBigEndian.Checked;
            lbBytesBig6.Visible = mBigEndian.Checked;
            lbBytesBig7.Visible = mBigEndian.Checked;
            lbBytesBig8.Visible = mBigEndian.Checked;
            lbBytesLittle1.Visible = !mBigEndian.Checked;
            lbBytesLittle2.Visible = !mBigEndian.Checked;
            lbBytesLittle3.Visible = !mBigEndian.Checked;
            lbBytesLittle4.Visible = !mBigEndian.Checked;
            lbBytesLittle5.Visible = !mBigEndian.Checked;
            lbBytesLittle6.Visible = !mBigEndian.Checked;
            lbBytesLittle7.Visible = !mBigEndian.Checked;
            lbBytesLittle8.Visible = !mBigEndian.Checked;
            if (mBigEndian.Checked) {
                bcBytes8.SetByte(DataBytes[0]);
                bcBytes7.SetByte(DataBytes[1]);
                bcBytes6.SetByte(DataBytes[2]);
                bcBytes5.SetByte(DataBytes[3]);
                bcBytes4.SetByte(DataBytes[4]);
                bcBytes3.SetByte(DataBytes[5]);
                bcBytes2.SetByte(DataBytes[6]);
                bcBytes1.SetByte(DataBytes[7]);

                bcBytes8.Enabled = true;
                bcBytes7.Enabled = rbInt16.Checked || rbInt32.Checked || rbSingle.Checked || rbInt64.Checked || rbDouble.Checked;
                bcBytes6.Enabled = rbInt32.Checked || rbSingle.Checked || rbInt64.Checked || rbDouble.Checked;
                bcBytes5.Enabled = rbInt32.Checked || rbSingle.Checked || rbInt64.Checked || rbDouble.Checked;
                bcBytes4.Enabled = rbInt64.Checked || rbDouble.Checked;
                bcBytes3.Enabled = rbInt64.Checked || rbDouble.Checked;
                bcBytes2.Enabled = rbInt64.Checked || rbDouble.Checked;
                bcBytes1.Enabled = rbInt64.Checked || rbDouble.Checked;
            }
            else {
                bcBytes1.SetByte(DataBytes[0]);
                bcBytes2.SetByte(DataBytes[1]);
                bcBytes3.SetByte(DataBytes[2]);
                bcBytes4.SetByte(DataBytes[3]);
                bcBytes5.SetByte(DataBytes[4]);
                bcBytes6.SetByte(DataBytes[5]);
                bcBytes7.SetByte(DataBytes[6]);
                bcBytes8.SetByte(DataBytes[7]);

                bcBytes1.Enabled = true;
                bcBytes2.Enabled = rbInt16.Checked || rbInt32.Checked || rbSingle.Checked || rbInt64.Checked || rbDouble.Checked;
                bcBytes3.Enabled = rbInt32.Checked || rbSingle.Checked || rbInt64.Checked || rbDouble.Checked;
                bcBytes4.Enabled = rbInt32.Checked || rbSingle.Checked || rbInt64.Checked || rbDouble.Checked;
                bcBytes5.Enabled = rbInt64.Checked || rbDouble.Checked;
                bcBytes6.Enabled = rbInt64.Checked || rbDouble.Checked;
                bcBytes7.Enabled = rbInt64.Checked || rbDouble.Checked;
                bcBytes8.Enabled = rbInt64.Checked || rbDouble.Checked;
            }
            bcBytes1.BigEndian = mBigEndian.Checked;
            bcBytes2.BigEndian = mBigEndian.Checked;
            bcBytes3.BigEndian = mBigEndian.Checked;
            bcBytes4.BigEndian = mBigEndian.Checked;
            bcBytes5.BigEndian = mBigEndian.Checked;
            bcBytes6.BigEndian = mBigEndian.Checked;
            bcBytes7.BigEndian = mBigEndian.Checked;
            bcBytes8.BigEndian = mBigEndian.Checked;
            BitSet(null, null);
        }
        private void mTopMost_Click(object sender, EventArgs e) {
            mTopMost.Checked ^= true;
            this.TopMost = mTopMost.Checked;
        }
        private void mThousandths_Click(object sender, EventArgs e) {
            mThousandths.Checked ^= true;
            GetValue();
            GetHex();
        }
        private void mSimpleNames_Click(object sender, EventArgs e) {
            mSimpleNames.Checked ^= true;
            if (mSimpleNames.Checked) {
                rbInt16.Text = "Short";
                rbInt32.Text = "Int";
                rbSingle.Text = "Float";
                rbInt64.Text = "Long";
            }
            else {
                rbInt16.Text = "Int16";
                rbInt32.Text = "Int32";
                rbSingle.Text = "Single";
                rbInt64.Text = "Int64";
            }
        }
        private void mColors_Click(object sender, EventArgs e) {
            using frmChangeColors newColor = new();
            newColor.SetBackgroundColor = pnOutput.BackColor;
            newColor.SetBitBackgroundColor = pnBits.BackColor;
            newColor.SetForeColor = lbUpper.ForeColor;
            newColor.SetFadedForeColor = lbLower.ForeColor;
            if (newColor.ShowDialog() == DialogResult.OK) {
                pnOutput.BackColor = newColor.SetBackgroundColor;
                pnBits.BackColor = newColor.SetBitBackgroundColor;
                lbUpper.ForeColor = lbAction.ForeColor = bcBytes1.ForeColor = bcBytes2.ForeColor = bcBytes3.ForeColor = bcBytes4.ForeColor = bcBytes5.ForeColor = bcBytes6.ForeColor = bcBytes7.ForeColor = bcBytes8.ForeColor = lbBytesBig1.ForeColor = lbBytesBig2.ForeColor = lbBytesBig3.ForeColor = lbBytesBig4.ForeColor = lbBytesBig5.ForeColor = lbBytesBig6.ForeColor = lbBytesBig7.ForeColor = lbBytesBig8.ForeColor = lbBytesLittle1.ForeColor = lbBytesLittle2.ForeColor = lbBytesLittle3.ForeColor = lbBytesLittle4.ForeColor = lbBytesLittle5.ForeColor = lbBytesLittle6.ForeColor = lbBytesLittle7.ForeColor = lbBytesLittle8.ForeColor = newColor.SetForeColor;
                lbLower.ForeColor = newColor.SetFadedForeColor;
            }
        }
        private void mSystemCalculator_Click(object sender, EventArgs e) {
            if (File.Exists("calc.exe")) {
                System.Diagnostics.Process.Start("calc.exe");
            }
            else if (File.Exists("calc1.exe")) {
                System.Diagnostics.Process.Start("calc1.exe");
            }
        }
        private void mAbout_Click(object sender, EventArgs e) {
            using frmAbout about = new();
            about.ShowDialog();
        }

        private void mCopyUpper_Click(object sender, EventArgs e) {
            Clipboard.SetText(lbUpper.Text);
        }
        private void mCopyLower_Click(object sender, EventArgs e) {
            Clipboard.SetText(lbLower.Text);
        }
        private void mPaste_Click(object sender, EventArgs e) {
            if (GetClipboardData()) {
                GetValue();
                GetHex();
            }
        }

        private void rbByte_CheckedChanged(object sender, EventArgs e) {
            if (rbByte.Checked) {
                if (mBigEndian.Checked) {
                    bcBytes8.Enabled = true;
                    bcBytes7.Enabled = bcBytes6.Enabled = bcBytes5.Enabled = bcBytes4.Enabled = bcBytes3.Enabled = bcBytes2.Enabled = bcBytes1.Enabled = false;
                }
                else {
                    bcBytes1.Enabled = true;
                    bcBytes2.Enabled = bcBytes3.Enabled = bcBytes4.Enabled = bcBytes5.Enabled = bcBytes6.Enabled = bcBytes7.Enabled = bcBytes8.Enabled = false;
                }
                chkSigned.Enabled = true;
                btnSine.Enabled = btnCosine.Enabled = btnTangent.Enabled = btnSqRt.Enabled = false;
                btnDecimal.Enabled = false;
                DataType = chkSigned.Checked ? IntegerType.SByte : IntegerType.Byte;
                GetValue();
                GetHex();
            }
            lbUpper.Focus();
        }
        private void rbInt16_CheckedChanged(object sender, EventArgs e) {
            if (rbInt16.Checked) {
                if (mBigEndian.Checked) {
                    bcBytes8.Enabled = bcBytes7.Enabled = true;
                    bcBytes6.Enabled = bcBytes5.Enabled = bcBytes4.Enabled = bcBytes3.Enabled = bcBytes2.Enabled = bcBytes1.Enabled = false;
                }
                else {
                    bcBytes1.Enabled = bcBytes2.Enabled = true;
                    bcBytes3.Enabled = bcBytes4.Enabled = bcBytes5.Enabled = bcBytes6.Enabled = bcBytes7.Enabled = bcBytes8.Enabled = false;
                }
                chkSigned.Enabled = true;
                btnSine.Enabled = btnCosine.Enabled = btnTangent.Enabled = btnSqRt.Enabled = false;
                btnDecimal.Enabled = false;
                DataType = chkSigned.Checked ? IntegerType.Int16 : IntegerType.UInt16;
                GetValue();
                GetHex();
            }
            lbUpper.Focus();
        }
        private void rbInt32_CheckedChanged(object sender, EventArgs e) {
            if (rbInt32.Checked) {
                if (mBigEndian.Checked) {
                    bcBytes8.Enabled = bcBytes7.Enabled = bcBytes6.Enabled = bcBytes5.Enabled = true;
                    bcBytes4.Enabled = bcBytes3.Enabled = bcBytes2.Enabled = bcBytes1.Enabled = false;
                }
                else {
                    bcBytes1.Enabled = bcBytes2.Enabled = bcBytes3.Enabled = bcBytes4.Enabled = true;
                    bcBytes5.Enabled = bcBytes6.Enabled = bcBytes7.Enabled = bcBytes8.Enabled = false;
                }
                chkSigned.Enabled = true;
                btnSine.Enabled = btnCosine.Enabled = btnTangent.Enabled = btnSqRt.Enabled = false;
                btnDecimal.Enabled = false;
                DataType = chkSigned.Checked ? IntegerType.Int32 : IntegerType.UInt32;
                GetValue();
                GetHex();
            }
            lbUpper.Focus();
        }
        private void rbSingle_CheckedChanged(object sender, EventArgs e) {
            if (rbSingle.Checked) {
                if (mBigEndian.Checked) {
                    bcBytes8.Enabled = bcBytes7.Enabled = bcBytes6.Enabled = bcBytes5.Enabled = true;
                    bcBytes4.Enabled = bcBytes3.Enabled = bcBytes2.Enabled = bcBytes1.Enabled = false;
                }
                else {
                    bcBytes1.Enabled = bcBytes2.Enabled = bcBytes3.Enabled = bcBytes4.Enabled = true;
                    bcBytes5.Enabled = bcBytes6.Enabled = bcBytes7.Enabled = bcBytes8.Enabled = false;
                }
                chkSigned.Enabled = false;
                btnSine.Enabled = btnCosine.Enabled = btnTangent.Enabled = btnSqRt.Enabled = false;
                btnDecimal.Enabled = true;
                DataType = IntegerType.Single;
                GetValue();
                GetHex();
            }
            lbUpper.Focus();
        }
        private void rbInt64_CheckedChanged(object sender, EventArgs e) {
            if (rbInt64.Checked) {
                if (mBigEndian.Checked) {
                    bcBytes8.Enabled = bcBytes7.Enabled = bcBytes6.Enabled = bcBytes5.Enabled = bcBytes4.Enabled = bcBytes3.Enabled = bcBytes2.Enabled = bcBytes1.Enabled = true;
                }
                else {
                    bcBytes8.Enabled = bcBytes7.Enabled = bcBytes6.Enabled = bcBytes5.Enabled = bcBytes4.Enabled = bcBytes3.Enabled = bcBytes2.Enabled = bcBytes1.Enabled = true;
                }
                chkSigned.Enabled = true;
                btnSine.Enabled = btnCosine.Enabled = btnTangent.Enabled = btnSqRt.Enabled = false;
                btnDecimal.Enabled = false;
                DataType = chkSigned.Checked ? IntegerType.Int64 : IntegerType.UInt64;
                GetValue();
                GetHex();
            }
            lbUpper.Focus();
        }
        private void rbDouble_CheckedChanged(object sender, EventArgs e) {
            if (rbDouble.Checked) {
                bcBytes8.Enabled = bcBytes7.Enabled = bcBytes6.Enabled = bcBytes5.Enabled = bcBytes4.Enabled = bcBytes3.Enabled = bcBytes2.Enabled = bcBytes1.Enabled = true;
                chkSigned.Enabled = false;
                btnSine.Enabled = btnCosine.Enabled = btnTangent.Enabled = btnSqRt.Enabled = true;
                btnDecimal.Enabled = true;
                DataType = IntegerType.Double;
                GetValue();
                GetHex();
            }
            lbUpper.Focus();
        }
        private void chkSigned_CheckedChanged(object sender, EventArgs e) {
            if (rbByte.Checked || rbInt16.Checked || rbInt32.Checked || rbInt64.Checked) {
                if (rbByte.Checked) {
                    DataType = chkSigned.Checked ? IntegerType.SByte : IntegerType.Byte;
                }
                else if (rbInt16.Checked) {
                    DataType = chkSigned.Checked ? IntegerType.Int16 : IntegerType.UInt16;
                }
                else if (rbInt32.Checked) {
                    DataType = chkSigned.Checked ? IntegerType.Int32 : IntegerType.UInt32;
                }
                else if (rbInt64.Checked) {
                    DataType = chkSigned.Checked ? IntegerType.Int64 : IntegerType.UInt64;
                }
                else {
                    chkSigned.Checked = false;
                    return;
                }
                btnPositive.Enabled = btnNegative.Enabled = chkSigned.Checked;
                GetValue();
            }
            lbUpper.Focus();
        }
        private void chkHex_CheckedChanged(object sender, EventArgs e) {
            if (chkHex.Checked) {
                lbUpper.Text = "0x" + (DataHex.Length > 0 ? DataHex : "0");
                lbLower.Text = DataValue.Length > 0 ? DataValue : "0";
            }
            else {
                lbUpper.Text = DataValue.Length > 0 ? DataValue : "0";
                lbLower.Text = "0x" + (DataHex.Length > 0 ? DataHex : "0");
            }
            btnA.Enabled = btnB.Enabled = btnC.Enabled = btnD.Enabled = btnE.Enabled = btnF.Enabled = chkHex.Checked;
            lbUpper.Focus();
        }

        private void btnBackspace_Click(object sender, EventArgs e) {
            if (KeyDataValue.Length > 0) {
                KeyDataValue = KeyDataValue.Substring(0, KeyDataValue.Length - 1);
                if (KeyDataValue.Length == 0) {
                    KeyDataValue = "0";
                }
                CheckKeyData();
            }
            lbUpper.Focus();
        }
        private void btnClearAll_Click(object sender, EventArgs e) {
            if (CalcAction != CalculatorAction.None) {
                CalcAction = CalculatorAction.None;
                CalculationBytes = new byte[8];
                lbAction.Text = "...";
            }
            ResetInput();
        }
        private void btnClearEntry_Click(object sender, EventArgs e) {
            ResetInput();
        }
        private void btnClearCalculation_Click(object sender, EventArgs e) {
            CalcAction = CalculatorAction.None;
            CalculationBytes = new byte[8];
            lbAction.Text = "...";
            lbUpper.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (CalcAction != CalculatorAction.None) {
                PerformCalculation();
            }
            CalculationBytes = (byte[])DataBytes.Clone();
            CalcAction = CalculatorAction.Add;
            lbAction.Text = "Adding";
            ResetInput();
        }
        private void btnSubtract_Click(object sender, EventArgs e) {
            if (CalcAction != CalculatorAction.None) {
                PerformCalculation();
            }
            CalculationBytes = (byte[])DataBytes.Clone();
            CalcAction = CalculatorAction.Subtract;
            lbAction.Text = "Subtracting";
            ResetInput();
        }
        private void btnDivide_Click(object sender, EventArgs e) {
            if (CalcAction != CalculatorAction.None) {
                PerformCalculation();
            }
            CalculationBytes = (byte[])DataBytes.Clone();
            CalcAction = CalculatorAction.Divide;
            lbAction.Text = "Dividing";
            ResetInput();
        }
        private void btnMulitply_Click(object sender, EventArgs e) {
            if (CalcAction != CalculatorAction.None) {
                PerformCalculation();
            }
            CalculationBytes = (byte[])DataBytes.Clone();
            CalcAction = CalculatorAction.Multiply;
            lbAction.Text = "Multiplying";
            ResetInput();
        }
        private void btnRemainder_Click(object sender, EventArgs e) {
            if (CalcAction != CalculatorAction.None) {
                PerformCalculation();
            }
            CalculationBytes = (byte[])DataBytes.Clone();
            CalcAction = CalculatorAction.Remainder;
            lbAction.Text = "Remainder";
            ResetInput();
        }
        private void btnCalculate_Click(object sender, EventArgs e) {
            if (CalcAction != CalculatorAction.None) {
                PerformCalculation();
                GetValue();
                GetHex();
                //lbAction.Text = "...";
            }
            else {
                System.Media.SystemSounds.Beep.Play();
            }
            lbUpper.Focus();
        }

        private void btnSine_Click(object sender, EventArgs e) {
            if (rbDouble.Checked) {
                if (CalcAction != CalculatorAction.None) {
                    PerformCalculation();
                }
                CalculationBytes = (byte[])DataBytes.Clone();
                CalcAction = CalculatorAction.Sine;
                DataBytes = new byte[8];
                PerformCalculation();
                GetValue();
                GetHex();
            }
            lbUpper.Focus();
        }
        private void btnCosine_Click(object sender, EventArgs e) {
            if (rbDouble.Checked) {
                if (CalcAction != CalculatorAction.None) {
                    PerformCalculation();
                }
                CalculationBytes = (byte[])DataBytes.Clone();
                CalcAction = CalculatorAction.Cosine;
                DataBytes = new byte[8];
                PerformCalculation();
                GetValue();
                GetHex();
            }
            lbUpper.Focus();
        }
        private void btnTangent_Click(object sender, EventArgs e) {
            if (rbDouble.Checked) {
                if (CalcAction != CalculatorAction.None) {
                    PerformCalculation();
                }
                CalculationBytes = (byte[])DataBytes.Clone();
                CalcAction = CalculatorAction.Tangent;
                DataBytes = new byte[8];
                PerformCalculation();
                GetValue();
                GetHex();
            }
            lbUpper.Focus();
        }
        private void btnSqRt_Click(object sender, EventArgs e) {
            if (rbDouble.Checked) {
                if (CalcAction != CalculatorAction.None) {
                    PerformCalculation();
                }
                CalculationBytes = (byte[])DataBytes.Clone();
                CalcAction = CalculatorAction.SquareRoot;
                DataBytes = new byte[8];
                PerformCalculation();
                GetValue();
                GetHex();
            }
            lbUpper.Focus();
        }

        private void btnSquare_Click(object sender, EventArgs e) {
            if (CalcAction != CalculatorAction.None) {
                PerformCalculation();
            }
            CalculationBytes = (byte[])DataBytes.Clone();
            CalcAction = CalculatorAction.Squared;
            DataBytes = new byte[8];
            PerformCalculation();
            GetValue();
            GetHex();
            lbUpper.Focus();
        }
        private void btnCube_Click(object sender, EventArgs e) {
            if (CalcAction != CalculatorAction.None) {
                PerformCalculation();
            }
            CalculationBytes = (byte[])DataBytes.Clone();
            CalcAction = CalculatorAction.Cubed;
            DataBytes = new byte[8];
            PerformCalculation();
            GetValue();
            GetHex();
            lbUpper.Focus();
        }
        private void btnExponent_Click(object sender, EventArgs e) {
            if (CalcAction != CalculatorAction.None) {
                PerformCalculation();
            }
            CalculationBytes = (byte[])DataBytes.Clone();
            CalcAction = CalculatorAction.Exponent;
            lbAction.Text = "Exponent";
            ResetInput();
        }
        private void btnFlipBits_Click(object sender, EventArgs e) {
            bcBytes8.SetByte(bcBytes8.Byte.InvertByte());
            switch (DataType) {
                case IntegerType.Int16 or IntegerType.UInt16: {
                    bcBytes7.SetByte(bcBytes7.Byte.InvertByte());
                } break;

                case IntegerType.Int32 or IntegerType.UInt32 or IntegerType.Single: {
                    bcBytes7.SetByte(bcBytes7.Byte.InvertByte());
                    bcBytes6.SetByte(bcBytes6.Byte.InvertByte());
                    bcBytes5.SetByte(bcBytes5.Byte.InvertByte());
                } break;

                case IntegerType.Int64 or IntegerType.UInt64 or IntegerType.Double: {
                    bcBytes7.SetByte(bcBytes7.Byte.InvertByte());
                    bcBytes6.SetByte(bcBytes6.Byte.InvertByte());
                    bcBytes5.SetByte(bcBytes5.Byte.InvertByte());
                    bcBytes4.SetByte(bcBytes4.Byte.InvertByte());
                    bcBytes3.SetByte(bcBytes3.Byte.InvertByte());
                    bcBytes2.SetByte(bcBytes2.Byte.InvertByte());
                    bcBytes1.SetByte(bcBytes1.Byte.InvertByte());
                } break;
            }
            BitSet(null, null);
            lbUpper.Focus();
        }

        private void btnDecimal_Click(object sender, EventArgs e) {
            if (rbDouble.Checked || rbSingle.Checked) {
                if (!KeyDataValue.Contains(DecimalIdentifier)) {
                    KeyDataValue += DecimalIdentifier;
                }
                else {
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            lbUpper.Focus();
        }
        private void btn0_Click(object sender, EventArgs e) {
            if (KeyDataValue != "0") {
                KeyDataValue += "0";
                CheckKeyData();
            }
            else if (KeyDataValue.Length == 0) {
                KeyDataValue = "0";
                CheckKeyData();
            }
            lbUpper.Focus();
        }
        private void btn1_Click(object sender, EventArgs e) {
            KeyDataValue += "1";
            CheckKeyData();
            lbUpper.Focus();
        }
        private void btn2_Click(object sender, EventArgs e) {
            KeyDataValue += "2";
            CheckKeyData();
            lbUpper.Focus();
        }
        private void btn3_Click(object sender, EventArgs e) {
            KeyDataValue += "3";
            CheckKeyData();
            lbUpper.Focus();
        }
        private void btn4_Click(object sender, EventArgs e) {
            KeyDataValue += "4";
            CheckKeyData();
            lbUpper.Focus();
        }
        private void btn5_Click(object sender, EventArgs e) {
            KeyDataValue += "5";
            CheckKeyData();
            lbUpper.Focus();
        }
        private void btn6_Click(object sender, EventArgs e) {
            KeyDataValue += "6";
            CheckKeyData();
            lbUpper.Focus();
        }
        private void btn7_Click(object sender, EventArgs e) {
            KeyDataValue += "7";
            CheckKeyData();
            lbUpper.Focus();
        }
        private void btn8_Click(object sender, EventArgs e) {
            KeyDataValue += "8";
            CheckKeyData();
            lbUpper.Focus();
        }
        private void btn9_Click(object sender, EventArgs e) {
            KeyDataValue += "9";
            CheckKeyData();
            lbUpper.Focus();
        }
        private void btnA_Click(object sender, EventArgs e) {
            if (chkHex.Checked) {
                KeyDataValue += "A";
                CheckKeyData();
            }
            lbUpper.Focus();
        }
        private void btnB_Click(object sender, EventArgs e) {
            if (chkHex.Checked) {
                KeyDataValue += "B";
                CheckKeyData();
            }
            lbUpper.Focus();
        }
        private void btnC_Click(object sender, EventArgs e) {
            if (chkHex.Checked) {
                KeyDataValue += "C";
                CheckKeyData();
            }
            lbUpper.Focus();
        }
        private void btnD_Click(object sender, EventArgs e) {
            if (chkHex.Checked) {
                KeyDataValue += "D";
                CheckKeyData();
            }
            lbUpper.Focus();
        }
        private void btnE_Click(object sender, EventArgs e) {
            if (chkHex.Checked) {
                KeyDataValue += "E";
                CheckKeyData();
            }
            lbUpper.Focus();
        }
        private void btnF_Click(object sender, EventArgs e) {
            if (chkHex.Checked) {
                KeyDataValue += "F";
                CheckKeyData();
            }
            lbUpper.Focus();
        }

        private void btnPositive_Click(object sender, EventArgs e) {
            if (chkSigned.Checked) {
                if (KeyDataValue.StartsWith("-") && (!KeyDataValue.StartsWith("0") || KeyDataValue != "")) {
                    KeyDataValue = KeyDataValue.Substring(1);
                    CheckKeyData();
                }
            }
            lbUpper.Focus();
        }
        private void btnNegative_Click(object sender, EventArgs e) {
            if (chkSigned.Checked) {
                if (!KeyDataValue.StartsWith("-") && (!KeyDataValue.StartsWith("0") || KeyDataValue != "")) {
                    KeyDataValue = "-" + KeyDataValue;
                    CheckKeyData();
                }
            }
            lbUpper.Focus();
        }

        private void mAppendHexIdentifier_Click(object sender, EventArgs e) {
            mAppendHexIdentifier.Checked ^= true;
            if (chkHex.Checked) {
                if (mAppendHexIdentifier.Checked) {
                    if (!lbUpper.Text.StartsWith("0x")) {
                        lbUpper.Text = "0x" + lbUpper.Text;
                    }
                }
                else {
                    if (lbUpper.Text.StartsWith("0x")) {
                        lbUpper.Text = lbUpper.Text.Substring(2);
                    }
                }
            }
            else {
                if (mAppendHexIdentifier.Checked) {
                    if (!lbLower.Text.StartsWith("0x")) {
                        lbLower.Text = "0x" + lbLower.Text;
                    }
                }
                else {
                    if (lbLower.Text.StartsWith("0x")) {
                        lbLower.Text = lbLower.Text.Substring(2);
                    }
                }
            }
        }

    }
}