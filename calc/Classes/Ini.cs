using System.IO;
using System.Drawing;
using System.Globalization;
using System.Text;

namespace calc {
    internal static class Ini {

        private static string IniPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\murrty\\calc";
        private const string EmptyString = "$[empty]";
        private const string DefaultSection = "calc";

        internal static Point SavedLocation = new(-32_000, -32_000);
        internal static IntegerType SavedIntegerType = IntegerType.Int32;

        internal static Color SavedOutputBackgroundColor = Color.FromKnownColor(KnownColor.ControlLight);
        internal static Color SavedBitsBackgroundColor = Color.FromKnownColor(KnownColor.ControlLight);
        internal static Color SavedForeColor = Color.FromKnownColor(KnownColor.ControlText);
        internal static Color SavedFadedForeColor = Color.FromKnownColor(KnownColor.ControlDark);

        internal static bool ColorsMatch(Color c1, Color c2) {
            return c1.A == c2.A && c1.R == c2.R && c1.G == c2.G && c1.B == c2.B;
        }

        internal static void Initialize() {
            if (!File.Exists(IniPath + "\\config.ini")) {
                if (!Directory.Exists(IniPath)) {
                    Directory.CreateDirectory(IniPath);
                }
                File.Create(IniPath + "\\config.ini").Dispose();
            }
            IniPath += "\\config.ini";
        }
        internal static string GetString(string Key, string Section, uint Length = 32_765) {
            Length = Math.Min(Length, 32_765);
            StringBuilder Value = new((int)Length + 2);
            NativeMethods.GetPrivateProfileString(Section ?? DefaultSection, Key, null, Value, Length + 2, IniPath);
            return Value.ToString();
        }
        internal static bool KeyExists(string Key, string Section = null) {
            StringBuilder Value = new(EmptyString.Length + 2);
            NativeMethods.GetPrivateProfileString(Section ?? DefaultSection, Key, EmptyString, Value, (uint)EmptyString.Length + 2, IniPath);
            return Value.ToString() != EmptyString;
        }
        internal static bool ReadBool(string Key, string Section = null) {
            string val = GetString(Key, Section);
            return val.ToLower() switch {
                "true" or "t" or "1" => true,
                _ => false,
            };
        }

        internal static IntegerType ReadIntType(string Key, string Section = null) {
            string val = GetString(Key, Section);
            return val.ToLower() switch {
                "byte" => IntegerType.Byte,
                "sbyte" => IntegerType.SByte,
                "int16" or "short" => IntegerType.Int16,
                "uint16" or "ushort" => IntegerType.UInt16,
                "uint32" or "uint" => IntegerType.UInt32,
                "single" or "float" => IntegerType.Single,
                "int64" or "long" => IntegerType.Int64,
                "uint64" or "ulong" => IntegerType.UInt64,
                "double" => IntegerType.Double,
                _ => IntegerType.Int32
            };
        }
        internal static Point ReadPoint(string Key, string Section = null) {
            string val = GetString(Key, Section);
            Match found = Regex.Match(val, "[0-9]*,([ ]*)?[0-9]*");
            if (found.Success) {
                string[] vals = found.Value.Replace(" ", "").Split(',');
                return new(int.Parse(vals[0]), int.Parse(vals[1]));
            }
            throw new Exception("Wrong value");
        }
        internal static Color ReadColor(string Key, string Section = null) {
            string val = GetString(Key, Section);
            Match found = Regex.Match(val, "([0-9]{1,3},( )?)?[0-9]{1,3},( )?[0-9]{1,3},( )?[0-9]{1,3}");
            if (found.Success) {
                string[] vals = found.Value.Replace(" ", "").Split(',');
                if (vals.Length >= 3) {
                    int[] outi = new int[] {
                        int.Parse(vals[0]),
                        int.Parse(vals[1]),
                        int.Parse(vals[2])
                    };
                    outi[0] = Math.Max(0, Math.Min(255, outi[0]));
                    outi[1] = Math.Max(0, Math.Min(255, outi[1]));
                    outi[2] = Math.Max(0, Math.Min(255, outi[2]));
                    return Color.FromArgb(outi[0], outi[1], outi[2]);
                }
            }
            else {
                found = Regex.Match(val, "(#)?[0-9a-fA-F]{6}");
                if (found.Success && found.Value.Length >= 6) {
                    string[] vals = new string[3];
                    if (found.Value.StartsWith("#")) {
                        vals[0] = $"{found.Value[1]}{found.Value[2]}";
                        vals[1] = $"{found.Value[3]}{found.Value[4]}";
                        vals[2] = $"{found.Value[5]}{found.Value[6]}";
                    }
                    else {
                        vals[0] = $"{found.Value[0]}{found.Value[1]}";
                        vals[1] = $"{found.Value[2]}{found.Value[3]}";
                        vals[2] = $"{found.Value[4]}{found.Value[5]}";
                    }
                    if (vals.Length >= 3) {
                        int[] outi = new int[] {
                            int.Parse(vals[0], NumberStyles.HexNumber),
                            int.Parse(vals[1], NumberStyles.HexNumber),
                            int.Parse(vals[2], NumberStyles.HexNumber)
                        };
                        outi[0] = Math.Max(0, Math.Min(255, outi[0]));
                        outi[1] = Math.Max(0, Math.Min(255, outi[1]));
                        outi[2] = Math.Max(0, Math.Min(255, outi[2]));
                        return Color.FromArgb(outi[0], outi[1], outi[2]);
                    }
                }
            }
            throw new Exception("Wrong value");
        }

        internal static void Write(string Key, string Value, string Section = null) {
            NativeMethods.WritePrivateProfileString(Section ?? DefaultSection, Key, Value, IniPath);
        }
        internal static void Write(string Key, Point Value, string Section = null) {
            NativeMethods.WritePrivateProfileString(Section ?? DefaultSection, Key, $"{Value.X}, {Value.Y}", IniPath);
        }
        internal static void Write(string Key, Color Value, string Section = null) {
            NativeMethods.WritePrivateProfileString(Section ?? DefaultSection, Key, $"{Value.R}, {Value.G}, {Value.B}", IniPath);
        }

    }
}
