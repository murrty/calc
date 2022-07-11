namespace murrty.extensions {
    internal static class ByteExtensions {
        /// <summary>
        /// Sets the bit at <paramref name="pos"/> to 1.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="pos"></param>
        /// <returns>A byte value with the modified bit.</returns>
        public static byte SetBitTo1(this byte val, int pos) => val |= (byte)(1 << pos);
        /// <summary>
        /// Sets the bit at <paramref name="pos"/> to 0.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static byte SetBitTo0(this byte val, int pos) => (byte)(val & ~(1 << pos));
        /// <summary>
        /// Flips the bit at <paramref name="pos"/> to either 0 or 1.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static byte FlipBit(this byte val, int pos) => val.IsBitSetTo0(pos) ? SetBitTo1(val, pos) : SetBitTo0(val, pos);
        /// <summary>
        /// Inverts all bits in a byte to their opposite values.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static byte InvertByte(this byte val) => (byte)~val;
        /// <summary>
        /// Gets a bit at <paramref name="pos"/>.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static byte GetBit(this byte val, int pos) => (byte)((val >> pos) & 1);
        /// <summary>
        /// Whether the bit at <paramref name="pos"/> is set to 0.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static bool IsBitSetTo0(this byte val, int pos) => (val & (1 << pos)) == 0;
        /// <summary>
        /// Whether the bit at <paramref name="pos"/> is set to 1.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static bool IsBitSetTo1(this byte val, int pos) => (val & (1 << pos)) == 1;
    }
}