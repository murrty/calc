using System.IO;
using System.Drawing;
using System.Text;

namespace calc {
    internal static class Ini {

        private static string IniPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\murrty\\calc";
        private const string EmptyString = "$[empty]";
        private const string DefaultSection = "calc";

        internal static Point SavedLocation;
        internal static IntegerType SavedIntegerType = IntegerType.Int32;

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

        internal static void Write(string Key, string Value, string Section = null) {
            NativeMethods.WritePrivateProfileString(Section ?? DefaultSection, Key, Value, IniPath);
        }

        internal static void Write(string Key, Point Value, string Section = null) {
            NativeMethods.WritePrivateProfileString(Section ?? DefaultSection, Key, $"{Value.X}, {Value.Y}", IniPath);
        }

    }
}
