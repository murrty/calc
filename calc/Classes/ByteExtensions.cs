
namespace calc {
    internal static class ByteExtensions {

        public static byte SetBitTo1(this byte value, int pos) => value |= (byte)(1 << pos);
        public static byte SetBitTo0(this byte val, int pos) => (byte)(val & ~(1 << pos));
        public static byte FlipBit(this byte val, int pos) => val.GetBit(pos) switch { 0x0 => SetBitTo1(val, pos), _ => SetBitTo0(val, pos) };
        public static byte InvertByte(this byte val) => (byte)~val;
        public static byte GetBit(this byte val, int pos) => (byte)((val >> pos) & 1);
        public static bool IsBitSetTo0(this byte val, int pos) => (val & (1 << pos)) == 0;
        public static bool IsBitSetTo1(this byte val, int pos) => (val & (1 << pos)) == 1;

    }
}
