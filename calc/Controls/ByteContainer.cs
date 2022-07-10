using System.Drawing;
using System.Windows.Forms;

namespace calc {

    internal sealed class ByteContainer : Panel {

        private bool _bigEndian = true;
        private bool _enabled = true;
        private byte _byte = 0x0;

        /// <summary>
        /// The byte-order of the container.
        /// </summary>
        public bool BigEndian {
            get => _bigEndian;
            set {
                if (_bigEndian != value) {
                    _bigEndian = value;
                    if (value) {
                        Byte0.Text = _byte.GetBit(7).ToString();
                        Byte1.Text = _byte.GetBit(6).ToString();
                        Byte2.Text = _byte.GetBit(5).ToString();
                        Byte3.Text = _byte.GetBit(4).ToString();
                        Byte4.Text = _byte.GetBit(3).ToString();
                        Byte5.Text = _byte.GetBit(2).ToString();
                        Byte6.Text = _byte.GetBit(1).ToString();
                        Byte7.Text = _byte.GetBit(0).ToString();
                    }
                    else {
                        Byte0.Text = _byte.GetBit(0).ToString();
                        Byte1.Text = _byte.GetBit(1).ToString();
                        Byte2.Text = _byte.GetBit(2).ToString();
                        Byte3.Text = _byte.GetBit(3).ToString();
                        Byte4.Text = _byte.GetBit(4).ToString();
                        Byte5.Text = _byte.GetBit(5).ToString();
                        Byte6.Text = _byte.GetBit(6).ToString();
                        Byte7.Text = _byte.GetBit(7).ToString();
                    }
                }
            }
        }

        [System.ComponentModel.DefaultValue(true)]
        public new bool Enabled {
            get => _enabled;
            set {
                _enabled = value;
                //Byte0.ForeColor = value ? Color.FromKnownColor(KnownColor.ControlText) : Color.FromKnownColor(KnownColor.ControlDarkDark);
                //Byte1.ForeColor = value ? Color.FromKnownColor(KnownColor.ControlText) : Color.FromKnownColor(KnownColor.ControlDarkDark);
                //Byte2.ForeColor = value ? Color.FromKnownColor(KnownColor.ControlText) : Color.FromKnownColor(KnownColor.ControlDarkDark);
                //Byte3.ForeColor = value ? Color.FromKnownColor(KnownColor.ControlText) : Color.FromKnownColor(KnownColor.ControlDarkDark);
                //Byte4.ForeColor = value ? Color.FromKnownColor(KnownColor.ControlText) : Color.FromKnownColor(KnownColor.ControlDarkDark);
                //Byte5.ForeColor = value ? Color.FromKnownColor(KnownColor.ControlText) : Color.FromKnownColor(KnownColor.ControlDarkDark);
                //Byte6.ForeColor = value ? Color.FromKnownColor(KnownColor.ControlText) : Color.FromKnownColor(KnownColor.ControlDarkDark);
                //Byte7.ForeColor = value ? Color.FromKnownColor(KnownColor.ControlText) : Color.FromKnownColor(KnownColor.ControlDarkDark);
                Byte0.Enabled = value;
                Byte1.Enabled = value;
                Byte2.Enabled = value;
                Byte3.Enabled = value;
                Byte4.Enabled = value;
                Byte5.Enabled = value;
                Byte6.Enabled = value;
                Byte7.Enabled = value;
            }
        }

        public new Font Font {
            get => base.Font;
            set {
                base.Font = value;
                Byte0.Font = value;
                Byte1.Font = value;
                Byte2.Font = value;
                Byte3.Font = value;

                Byte4.Font = value;
                Byte5.Font = value;
                Byte6.Font = value;
                Byte7.Font = value;

                ResizeControl();
            }
        }

        public new Color ForeColor {
            get => base.ForeColor;
            set {
                base.ForeColor = value;
                Byte0.ForeColor = value;
                Byte1.ForeColor = value;
                Byte2.ForeColor = value;
                Byte3.ForeColor = value;
                Byte4.ForeColor = value;
                Byte5.ForeColor = value;
                Byte6.ForeColor = value;
                Byte7.ForeColor = value;
            }
        }

        public byte Byte {
            get => _byte;
            set {
                _byte = value;
                if (_bigEndian) {
                    Byte0.Text = _byte.GetBit(7).ToString();
                    Byte1.Text = _byte.GetBit(6).ToString();
                    Byte2.Text = _byte.GetBit(5).ToString();
                    Byte3.Text = _byte.GetBit(4).ToString();
                    Byte4.Text = _byte.GetBit(3).ToString();
                    Byte5.Text = _byte.GetBit(2).ToString();
                    Byte6.Text = _byte.GetBit(1).ToString();
                    Byte7.Text = _byte.GetBit(0).ToString();
                }
                else {
                    Byte0.Text = _byte.GetBit(0).ToString();
                    Byte1.Text = _byte.GetBit(1).ToString();
                    Byte2.Text = _byte.GetBit(2).ToString();
                    Byte3.Text = _byte.GetBit(3).ToString();
                    Byte4.Text = _byte.GetBit(4).ToString();
                    Byte5.Text = _byte.GetBit(5).ToString();
                    Byte6.Text = _byte.GetBit(6).ToString();
                    Byte7.Text = _byte.GetBit(7).ToString();
                }
                BitChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public string ByteString => Byte.ToString("X2");

        public event EventHandler<EventArgs> BitChanged;

        private readonly HandLabel Byte0 = new() { Text = "0", BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false, Cursor = Cursors.Hand };
        private readonly HandLabel Byte1 = new() { Text = "0", BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false, Cursor = Cursors.Hand };
        private readonly HandLabel Byte2 = new() { Text = "0", BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false, Cursor = Cursors.Hand };
        private readonly HandLabel Byte3 = new() { Text = "0", BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false, Cursor = Cursors.Hand };

        private readonly HandLabel Byte4 = new() { Text = "0", BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false, Cursor = Cursors.Hand };
        private readonly HandLabel Byte5 = new() { Text = "0", BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false, Cursor = Cursors.Hand };
        private readonly HandLabel Byte6 = new() { Text = "0", BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false, Cursor = Cursors.Hand };
        private readonly HandLabel Byte7 = new() { Text = "0", BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter, AutoSize = false, Cursor = Cursors.Hand };

        public ByteContainer() {
            Controls.Add(Byte0);
            Byte0.MouseDown += (s, e) => {
                if (_bigEndian) {
                    _byte = _byte.FlipBit(7);
                    Byte0.Text = _byte.GetBit(7).ToString();
                }
                else {
                    _byte = _byte.FlipBit(0);
                    Byte0.Text = _byte.GetBit(0).ToString();
                }
                BitChanged?.Invoke(this, EventArgs.Empty);
            };
            Controls.Add(Byte1);
            Byte1.MouseDown += (s, e) => {
                if (_bigEndian) {
                    _byte = _byte.FlipBit(6);
                    Byte1.Text = _byte.GetBit(6).ToString();
                }
                else {
                    _byte = _byte.FlipBit(1);
                    Byte1.Text = _byte.GetBit(1).ToString();
                }
                BitChanged?.Invoke(this, EventArgs.Empty);
            };
            Controls.Add(Byte2);
            Byte2.MouseDown += (s, e) => {
                if (_bigEndian) {
                    _byte = _byte.FlipBit(5);
                    Byte2.Text = _byte.GetBit(5).ToString();
                }
                else {
                    _byte = _byte.FlipBit(2);
                    Byte2.Text = _byte.GetBit(2).ToString();
                }
                BitChanged?.Invoke(this, EventArgs.Empty);
            };
            Controls.Add(Byte3);
            Byte3.MouseDown += (s, e) => {
                if (_bigEndian) {
                    _byte = _byte.FlipBit(4);
                    Byte3.Text = _byte.GetBit(4).ToString();
                }
                else {
                    _byte = _byte.FlipBit(3);
                    Byte3.Text = _byte.GetBit(3).ToString();
                }
                BitChanged?.Invoke(this, EventArgs.Empty);
            };

            Controls.Add(Byte4);
            Byte4.MouseDown += (s, e) => {
                if (_bigEndian) {
                    _byte = _byte.FlipBit(3);
                    Byte4.Text = _byte.GetBit(3).ToString();
                }
                else {
                    _byte = _byte.FlipBit(4);
                    Byte4.Text = _byte.GetBit(4).ToString();
                }
                BitChanged?.Invoke(this, EventArgs.Empty);
            };
            Controls.Add(Byte5);
            Byte5.MouseDown += (s, e) => {
                if (_bigEndian) {
                    _byte = _byte.FlipBit(2);
                    Byte5.Text = _byte.GetBit(2).ToString();
                }
                else {
                    _byte = _byte.FlipBit(5);
                    Byte5.Text = _byte.GetBit(5).ToString();
                }
                BitChanged?.Invoke(this, EventArgs.Empty);
            };
            Controls.Add(Byte6);
            Byte6.MouseDown += (s, e) => {
                if (_bigEndian) {
                    _byte = _byte.FlipBit(1);
                    Byte6.Text = _byte.GetBit(1).ToString();
                }
                else {
                    _byte = _byte.FlipBit(6);
                    Byte6.Text = _byte.GetBit(6).ToString();
                }
                BitChanged?.Invoke(this, EventArgs.Empty);
            };
            Controls.Add(Byte7);
            Byte7.MouseDown += (s, e) => {
                if (_bigEndian) {
                    _byte = _byte.FlipBit(0);
                    Byte7.Text = _byte.GetBit(0).ToString();
                }
                else {
                    _byte = _byte.FlipBit(7);
                    Byte7.Text = _byte.GetBit(7).ToString();
                }
                BitChanged?.Invoke(this, EventArgs.Empty);
            };
            this.Font = new("Consolas", 12);
            ResizeControl();
        }

        private void ResizeControl() {
            Size fontSize = TextRenderer.MeasureText("0", this.Font);
            this.Size = new(
                //(fontSize.Width * 8) + 8,
                ((fontSize.Width - 8) * 8) + 14,
                fontSize.Height + 8
            );

            Byte0.Size = new(fontSize.Width - 8, fontSize.Height);
            Byte1.Size = new(fontSize.Width - 8, fontSize.Height);
            Byte2.Size = new(fontSize.Width - 8, fontSize.Height);
            Byte3.Size = new(fontSize.Width - 8, fontSize.Height);
            Byte4.Size = new(fontSize.Width - 8, fontSize.Height);
            Byte5.Size = new(fontSize.Width - 8, fontSize.Height);
            Byte6.Size = new(fontSize.Width - 8, fontSize.Height);
            Byte7.Size = new(fontSize.Width - 8, fontSize.Height);

            Byte0.Location = new(
                4,
                4
            );
            Byte1.Location = new(
                Byte0.Location.X + Byte0.Size.Width,
                4
            );
            Byte2.Location = new(
                Byte1.Location.X + Byte1.Size.Width,
                4
            );
            Byte3.Location = new(
                Byte2.Location.X + Byte2.Size.Width,
                4
            );

            Byte4.Location = new(
                Byte3.Location.X + Byte3.Size.Width + 6,
                4
            );
            Byte5.Location = new(
                Byte4.Location.X + Byte4.Size.Width,
                4
            );
            Byte6.Location = new(
                Byte5.Location.X + Byte5.Size.Width,
                4
            );
            Byte7.Location = new(
                Byte6.Location.X + Byte6.Size.Width,
                4
            );
        }

    }

    internal sealed class ControlCursors {
        private const int IDC_HAND = 32_649;
        internal const int WM_SETCURSOR = 0x0020;
        internal static readonly IntPtr SystemHand = NativeMethods.LoadCursor(IntPtr.Zero, (IntPtr)IDC_HAND);
    }

    internal sealed class HandLabel : Label {
        [System.Diagnostics.DebuggerStepThrough]
        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case ControlCursors.WM_SETCURSOR: {
                    if (Cursor == Cursors.Hand) {
                        NativeMethods.SetCursor(ControlCursors.SystemHand);
                        m.Result = IntPtr.Zero;
                        return;
                    }
                    else {
                        base.WndProc(ref m);
                    }
                } break;

                default: {
                    base.WndProc(ref m);
                } break;
            }
        }
    }

}
