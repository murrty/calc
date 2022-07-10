namespace calc {
    internal static class IntegralConversions {

        internal const string ThousandthsInt = "#,##0";
        internal const string ThousandthsSingle = "#,##0.#########";
        internal const string ThousandthsDouble = "#,##0.###################";

        /// <summary>
        /// Gets the bytes of an object in an 8-byte array, and sets them in <paramref name="array"/>.
        /// </summary>
        /// <param name="data">The integral data to get the byte from.</param>
        /// <param name="array">Reference array</param>
        /// <exception cref="ArgumentException"></exception>
        public static void GetBytes(object data, ref byte[] array) {
            if (array == null) {
                array = new byte[8];
            }
            else {
                if (array.Length < 8) {
                    Array.Resize(ref array, 8);
                }
            }
            switch (data) {
                case Byte val: {
                    array[0] = val;
                } break;

                case SByte val: {
                    array[0] = (byte)val;
                } break;

                case Int16 val: {
                    array[0] = (byte)(val >> 0);
                    array[1] = (byte)(val >> 8);
                } break;

                case UInt16 val: {
                    array[0] = (byte)(val >> 0);
                    array[1] = (byte)(val >> 8);
                } break;

                case Int32 val: {
                    array[0] = (byte)(val >> 0);
                    array[1] = (byte)(val >> 8);
                    array[2] = (byte)(val >> 16);
                    array[3] = (byte)(val >> 24);
                } break;

                case UInt32 val: {
                    array[0] = (byte)(val >> 0);
                    array[1] = (byte)(val >> 8);
                    array[2] = (byte)(val >> 16);
                    array[3] = (byte)(val >> 24);
                } break;

                case Single val: {
                    array = BitConverter.GetBytes(val);
                    Array.Resize(ref array, 8);
                } break;

                case Int64 val: {
                    array[0] = (byte)(val >> 0);
                    array[1] = (byte)(val >> 8);
                    array[2] = (byte)(val >> 16);
                    array[3] = (byte)(val >> 24);
                    array[4] = (byte)(val >> 32);
                    array[5] = (byte)(val >> 40);
                    array[6] = (byte)(val >> 48);
                    array[7] = (byte)(val >> 56);
                } break;

                case UInt64 val: {
                    array[0] = (byte)(val >> 0);
                    array[1] = (byte)(val >> 8);
                    array[2] = (byte)(val >> 16);
                    array[3] = (byte)(val >> 24);
                    array[4] = (byte)(val >> 32);
                    array[5] = (byte)(val >> 40);
                    array[6] = (byte)(val >> 48);
                    array[7] = (byte)(val >> 56);
                } break;

                case Double val: {
                    array = BitConverter.GetBytes(val);
                } break;

                default: {
                    throw new ArgumentException(nameof(data));
                }
            }
        }

        /// <summary>
        /// Gets values from input bytes.
        /// </summary>
        /// <param name="data">byte array of the data to get the value of.</param>
        /// <param name="type">the integer type to convert the bytes into.</param>
        /// <returns>an object that can be cast into a specific integral type.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static object GetValue(byte[] data, IntegerType type) {
            return type switch {
                _ when data is null => throw new ArgumentNullException(nameof(data)),
                _ when data.Length == 0 => throw new ArgumentNullException(nameof(data)),

                IntegerType.Byte => data[0],
                IntegerType.SByte => unchecked((sbyte)data[0]),

                IntegerType.Int16 when data.Length < 2 => throw new ArgumentException(nameof(data)),
                IntegerType.Int16 => BitConverter.ToInt16(data, 0),

                IntegerType.UInt16 when data.Length < 2 => throw new ArgumentException(nameof(data)),
                IntegerType.UInt16 => BitConverter.ToUInt16(data, 0),

                IntegerType.Int32 when data.Length < 4 => throw new ArgumentException(nameof(data)),
                IntegerType.Int32 => BitConverter.ToInt32(data, 0),

                IntegerType.UInt32 when data.Length < 4 => throw new ArgumentException(nameof(data)),
                IntegerType.UInt32 => BitConverter.ToUInt32(data, 0),

                IntegerType.Single when data.Length < 4 => throw new ArgumentException(nameof(data)),
                IntegerType.Single => BitConverter.ToSingle(data, 0),

                IntegerType.Int64 when data.Length < 8 => throw new ArgumentException(nameof(data)),
                IntegerType.Int64 => BitConverter.ToInt64(data, 0),

                IntegerType.UInt64 when data.Length < 8 => throw new ArgumentException(nameof(data)),
                IntegerType.UInt64 => BitConverter.ToUInt64(data, 0),

                IntegerType.Double when data.Length < 8 => throw new ArgumentException(nameof(data)),
                IntegerType.Double => BitConverter.ToDouble(data, 0),

                _ => throw new ArgumentException(nameof(type))
            };
        }

        public static string GetString(object data, bool ThousandsthSeparator) {
            return data switch {
                Byte val => val.ToString(),
                SByte val => val.ToString(),
                Int16 val => val.ToString(ThousandsthSeparator ? ThousandthsInt : ""),
                UInt16 val => val.ToString(ThousandsthSeparator ? ThousandthsInt : ""),
                Int32 val => val.ToString(ThousandsthSeparator ? ThousandthsInt : ""),
                UInt32 val => val.ToString(ThousandsthSeparator ? ThousandthsInt : ""),
                Single val => val.ToString(ThousandsthSeparator ? ThousandthsSingle : ""),
                Int64 val => val.ToString(ThousandsthSeparator ? ThousandthsInt : ""),
                UInt64 val => val.ToString(ThousandsthSeparator ? ThousandthsInt : ""),
                Double val => val.ToString(ThousandsthSeparator ? ThousandthsDouble : ""),
                _ => throw new ArgumentException(nameof(data)),
            };
        }

        /// <summary>
        /// Gets a formatted string for a specified integral value.
        /// </summary>
        /// <param name="data">The numbered data to format.</param>
        /// <param name="formatting">The formatting string.</param>
        /// <returns>A formatted string representing the input data.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetString(object data, string formatting = null) {
            return data switch {
                Byte val => val.ToString(formatting ?? ""),
                SByte val => val.ToString(formatting ?? ""),
                Int16 val => val.ToString(formatting ?? ThousandthsInt),
                UInt16 val => val.ToString(formatting ?? ThousandthsInt),
                Int32 val => val.ToString(formatting ?? ThousandthsInt),
                UInt32 val => val.ToString(formatting ?? ThousandthsInt),
                Single val => val.ToString(formatting ?? ThousandthsSingle),
                Int64 val => val.ToString(formatting ?? ThousandthsInt),
                UInt64 val => val.ToString(formatting ?? ThousandthsInt),
                Double val => val.ToString(formatting ?? ThousandthsDouble),
                _ => throw new ArgumentException(nameof(data)),
            };
        }

        public static string ByteToHex(byte value) {
            return value.ToString("X2");
        }

        public static byte GetByte(string data, bool BigEndian) {
            if (data.Length != 8) {
                throw new ArgumentException(nameof(data));
            }
            byte[] bytes = new byte[8];
            byte newByte = 0x0;

            if (BigEndian) {
                bytes[0] = data[7] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[1] = data[6] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[2] = data[5] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[3] = data[4] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[4] = data[3] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[5] = data[2] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[6] = data[1] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[7] = data[0] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
            }
            else {
                bytes[0] = data[0] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[1] = data[1] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[2] = data[2] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[3] = data[3] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[4] = data[4] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[5] = data[5] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[6] = data[6] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
                bytes[7] = data[7] switch {
                    '0' => 0x0,
                    '1' => 0x1,
                    _ => throw new ArgumentException(nameof(data)),
                };
            }

            newByte = (byte)(newByte & ~(1 << 0) | (bytes[0] << 0));
            newByte = (byte)(newByte & ~(1 << 1) | (bytes[1] << 1));
            newByte = (byte)(newByte & ~(1 << 2) | (bytes[2] << 2));
            newByte = (byte)(newByte & ~(1 << 3) | (bytes[3] << 3));
            newByte = (byte)(newByte & ~(1 << 4) | (bytes[4] << 4));
            newByte = (byte)(newByte & ~(1 << 5) | (bytes[5] << 5));
            newByte = (byte)(newByte & ~(1 << 6) | (bytes[6] << 6));
            newByte = (byte)(newByte & ~(1 << 7) | (bytes[7] << 7));

            return newByte;
        }

    }
}
