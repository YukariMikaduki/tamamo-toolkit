using System.Buffers.Binary;

namespace Chaldea.Components.Extensions
{
    /// <summary>
    /// <see cref="byte"/>[] 数组扩展类
    /// </summary>
    public static class ByteArrayExtensions
    {
        /// <summary>
        /// 将 <see cref="bool"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>长度为 1 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this bool value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 将 <see cref="char"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian">是否需要转换为小端序，默认为 <see langword="true"/></param>
        /// <returns>长度为 2 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this char value, bool isLittleEndian = true)
        {
            return isLittleEndian ? BitConverter.GetBytes(value) : [.. BitConverter.GetBytes(value).AsEnumerable().Reverse()];
        }

        /// <summary>
        /// 将 <see cref="double"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian">是否需要转换为小端序，默认为 <see langword="true"/></param>
        /// <returns>长度为 8 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this double value, bool isLittleEndian = true)
        {
            return isLittleEndian ? BitConverter.GetBytes(value) : [.. BitConverter.GetBytes(value).AsEnumerable().Reverse()];
        }

        /// <summary>
        /// 将 <see cref="Half"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian">是否需要转换为小端序，默认为 <see langword="true"/></param>
        /// <returns>长度为 2 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this Half value, bool isLittleEndian = true)
        {
            return isLittleEndian ? BitConverter.GetBytes(value) : [.. BitConverter.GetBytes(value).AsEnumerable().Reverse()];
        }

        /// <summary>
        /// 将 <see cref="short"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian">是否需要转换为小端序，默认为 <see langword="true"/></param>
        /// <returns>长度为 2 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this short value, bool isLittleEndian = true)
        {
            return isLittleEndian ? BitConverter.GetBytes(value) : [.. BitConverter.GetBytes(value).AsEnumerable().Reverse()];
        }

        /// <summary>
        /// 将 <see cref="int"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian">是否需要转换为小端序，默认为 <see langword="true"/></param>
        /// <returns>长度为 4 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this int value, bool isLittleEndian = true)
        {
            return isLittleEndian ? BitConverter.GetBytes(value) : [.. BitConverter.GetBytes(value).AsEnumerable().Reverse()];
        }

        /// <summary>
        /// 将 <see cref="long"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian">是否需要转换为小端序，默认为 <see langword="true"/></param>
        /// <returns>长度为 8 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this long value, bool isLittleEndian = true)
        {
            return isLittleEndian ? BitConverter.GetBytes(value) : [.. BitConverter.GetBytes(value).AsEnumerable().Reverse()];
        }

        /// <summary>
        /// 将 <see cref="float"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian">是否需要转换为小端序，默认为 <see langword="true"/></param>
        /// <returns>长度为 4 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this float value, bool isLittleEndian = true)
        {
            return isLittleEndian ? BitConverter.GetBytes(value) : [.. BitConverter.GetBytes(value).AsEnumerable().Reverse()];
        }

        /// <summary>
        /// 将 <see cref="ushort"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian">是否需要转换为小端序，默认为 <see langword="true"/></param>
        /// <returns>长度为 2 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this ushort value, bool isLittleEndian = true)
        {
            return isLittleEndian ? BitConverter.GetBytes(value) : [.. BitConverter.GetBytes(value).AsEnumerable().Reverse()];
        }

        /// <summary>
        /// 将 <see cref="uint"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian">是否需要转换为小端序，默认为 <see langword="true"/></param>
        /// <returns>长度为 4 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this uint value, bool isLittleEndian = true)
        {
            return isLittleEndian ? BitConverter.GetBytes(value) : [.. BitConverter.GetBytes(value).AsEnumerable().Reverse()];
        }

        /// <summary>
        /// 将 <see cref="ulong"/> 值转换为对应的 <see cref="byte"/>[] 数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian">是否需要转换为小端序，默认为 <see langword="true"/></param>
        /// <returns>长度为 8 的 <see cref="byte"/>[] 数组</returns>
        public static byte[] GetBytes(this ulong value, bool isLittleEndian = true)
        {
            return isLittleEndian ? BitConverter.GetBytes(value) : [.. BitConverter.GetBytes(value).AsEnumerable().Reverse()];
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每个字节转换为对应的 <see cref="bool"/> 值
        /// <para>若 <see cref="byte"/>[] 数组中的某项非零，则其转换后为 <see langword="true"/>，否则为 <see langword="false"/></para>
        /// </summary>
        /// <param name="value"></param>
        /// <returns>转换后的 <see cref="bool"/>[] 数组</returns>
        public static bool[] ToBoolean(this byte[] value)
        {
            bool[] ret = new bool[value.Length];
            _ = Parallel.For(0, value.Length, i => ret[i] = value[i] != 0);
            return ret;
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每2个字节转换为对应的 <see cref="char"/> 值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian"><see cref="byte"/>[] 数组是否为小端序，默认为 <see langword="true"/></param>
        /// <returns>转换后的 <see cref="char"/>[] 数组</returns>
        /// <exception cref="ArgumentException"><see cref="byte"/>[] 数组长度不为2的倍数</exception>
        public static char[] ToChar(this byte[] value, bool isLittleEndian = true)
        {
            int perLength = 2;
            if (value.Length % perLength != 0)
            {
                throw new ArgumentException($"数组长度必须为{perLength}的倍数", nameof(value));
            }
            char[] ret = new char[value.Length / perLength];
            _ = Parallel.For(0, ret.Length, i =>
            {
                var range = (i * perLength)..((i + 1) * perLength);
                ret[i] = isLittleEndian ? BitConverter.ToChar(value[range], 0) : BitConverter.ToChar([.. value[range].AsEnumerable().Reverse()], 0);
            });
            return ret;
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每8个字节转换为对应的 <see cref="double"/> 值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian"><see cref="byte"/>[] 数组是否为小端序，默认为 <see langword="true"/></param>
        /// <returns>转换后的 <see cref="double"/>[] 数组</returns>
        /// <exception cref="ArgumentException"><see cref="byte"/>[] 数组长度不为8的倍数</exception>
        public static double[] ToDouble(this byte[] value, bool isLittleEndian = true)
        {
            int perLength = 8;
            if (value.Length % perLength != 0)
            {
                throw new ArgumentException($"数组长度必须为{perLength}的倍数", nameof(value));
            }
            double[] ret = new double[value.Length / perLength];
            _ = Parallel.For(0, ret.Length, i =>
            {
                var range = (i * perLength)..((i + 1) * perLength);
                ret[i] = isLittleEndian ? BinaryPrimitives.ReadDoubleLittleEndian(value[range]) : BinaryPrimitives.ReadDoubleBigEndian(value[range]);
            });
            return ret;
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每2个字节转换为对应的 <see cref="Half"/> 值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian"><see cref="byte"/>[] 数组是否为小端序，默认为 <see langword="true"/></param>
        /// <returns>转换后的 <see cref="Half"/>[] 数组</returns>
        /// <exception cref="ArgumentException"><see cref="byte"/>[] 数组长度不为2的倍数</exception>
        public static Half[] ToHalf(this byte[] value, bool isLittleEndian = true)
        {
            int perLength = 2;
            if (value.Length % perLength != 0)
            {
                throw new ArgumentException($"数组长度必须为{perLength}的倍数", nameof(value));
            }
            var ret = new Half[value.Length / perLength];
            _ = Parallel.For(0, ret.Length, i =>
            {
                var range = (i * perLength)..((i + 1) * perLength);
                ret[i] = isLittleEndian ? BinaryPrimitives.ReadHalfLittleEndian(value[range]) : BinaryPrimitives.ReadHalfBigEndian(value[range]);
            });
            return ret;
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每2个字节转换为对应的 <see cref="short"/> 值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian"><see cref="byte"/>[] 数组是否为小端序，默认为 <see langword="true"/></param>
        /// <returns>转换后的 <see cref="short"/>[] 数组</returns>
        /// <exception cref="ArgumentException"><see cref="byte"/>[] 数组长度不为2的倍数</exception>
        public static short[] ToInt16(this byte[] value, bool isLittleEndian = true)
        {
            int perLength = 2;
            if (value.Length % perLength != 0)
            {
                throw new ArgumentException($"数组长度必须为{perLength}的倍数", nameof(value));
            }
            short[] ret = new short[value.Length / perLength];
            _ = Parallel.For(0, ret.Length, i =>
            {
                var range = (i * perLength)..((i + 1) * perLength);
                ret[i] = isLittleEndian ? BinaryPrimitives.ReadInt16LittleEndian(value[range]) : BinaryPrimitives.ReadInt16BigEndian(value[range]);
            });
            return ret;
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每4个字节转换为对应的 <see cref="int"/> 值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian"><see cref="byte"/>[] 数组是否为小端序，默认为 <see langword="true"/></param>
        /// <returns>转换后的 <see cref="int"/>[] 数组</returns>
        /// <exception cref="ArgumentException"><see cref="byte"/>[] 数组长度不为4的倍数</exception>
        public static int[] ToInt32(this byte[] value, bool isLittleEndian = true)
        {
            int perLength = 4;
            if (value.Length % perLength != 0)
            {
                throw new ArgumentException($"数组长度必须为{perLength}的倍数", nameof(value));
            }
            int[] ret = new int[value.Length / perLength];
            _ = Parallel.For(0, ret.Length, i =>
            {
                var range = (i * perLength)..((i + 1) * perLength);
                ret[i] = isLittleEndian ? BinaryPrimitives.ReadInt32LittleEndian(value[range]) : BinaryPrimitives.ReadInt32BigEndian(value[range]);
            });
            return ret;
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每8个字节转换为对应的 <see cref="long"/> 值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian"><see cref="byte"/>[] 数组是否为小端序，默认为 <see langword="true"/></param>
        /// <returns>转换后的 <see cref="long"/>[] 数组</returns>
        /// <exception cref="ArgumentException"><see cref="byte"/>[] 数组长度不为8的倍数</exception>
        public static long[] ToInt64(this byte[] value, bool isLittleEndian = true)
        {
            int perLength = 8;
            if (value.Length % perLength != 0)
            {
                throw new ArgumentException($"数组长度必须为{perLength}的倍数", nameof(value));
            }
            long[] ret = new long[value.Length / perLength];
            _ = Parallel.For(0, ret.Length, i =>
            {
                var range = (i * perLength)..((i + 1) * perLength);
                ret[i] = isLittleEndian ? BinaryPrimitives.ReadInt64LittleEndian(value[range]) : BinaryPrimitives.ReadInt64BigEndian(value[range]);
            });
            return ret;
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每4个字节转换为对应的 <see cref="float"/> 值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian"><see cref="byte"/>[] 数组是否为小端序，默认为 <see langword="true"/></param>
        /// <returns>转换后的 <see cref="float"/>[] 数组</returns>
        /// <exception cref="ArgumentException"><see cref="byte"/>[] 数组长度不为4的倍数</exception>
        public static float[] ToSingle(this byte[] value, bool isLittleEndian = true)
        {
            int perLength = 4;
            if (value.Length % perLength != 0)
            {
                throw new ArgumentException($"数组长度必须为{perLength}的倍数", nameof(value));
            }
            float[] ret = new float[value.Length / perLength];
            _ = Parallel.For(0, ret.Length, i =>
            {
                var range = (i * perLength)..((i + 1) * perLength);
                ret[i] = isLittleEndian ? BinaryPrimitives.ReadSingleLittleEndian(value[range]) : BinaryPrimitives.ReadSingleBigEndian(value[range]);
            });
            return ret;
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每2个字节转换为对应的 <see cref="ushort"/> 值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian"><see cref="byte"/>[] 数组是否为小端序，默认为 <see langword="true"/></param>
        /// <returns>转换后的 <see cref="ushort"/>[] 数组</returns>
        /// <exception cref="ArgumentException"><see cref="byte"/>[] 数组长度不为2的倍数</exception>
        public static ushort[] ToUInt16(this byte[] value, bool isLittleEndian = true)
        {
            int perLength = 2;
            if (value.Length % perLength != 0)
            {
                throw new ArgumentException($"数组长度必须为{perLength}的倍数", nameof(value));
            }
            ushort[] ret = new ushort[value.Length / perLength];
            _ = Parallel.For(0, ret.Length, i =>
            {
                var range = (i * perLength)..((i + 1) * perLength);
                ret[i] = isLittleEndian ? BinaryPrimitives.ReadUInt16LittleEndian(value[range]) : BinaryPrimitives.ReadUInt16BigEndian(value[range]);
            });
            return ret;
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每4个字节转换为对应的 <see cref="uint"/> 值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian"><see cref="byte"/>[] 数组是否为小端序，默认为 <see langword="true"/></param>
        /// <returns>转换后的 <see cref="uint"/>[] 数组</returns>
        /// <exception cref="ArgumentException"><see cref="byte"/>[] 数组长度不为4的倍数</exception>
        public static uint[] ToUInt32(this byte[] value, bool isLittleEndian = true)
        {
            int perLength = 4;
            if (value.Length % perLength != 0)
            {
                throw new ArgumentException($"数组长度必须为{perLength}的倍数", nameof(value));
            }
            uint[] ret = new uint[value.Length / perLength];
            _ = Parallel.For(0, ret.Length, i =>
            {
                var range = (i * perLength)..((i + 1) * perLength);
                ret[i] = isLittleEndian ? BinaryPrimitives.ReadUInt32LittleEndian(value[range]) : BinaryPrimitives.ReadUInt32BigEndian(value[range]);
            });
            return ret;
        }

        /// <summary>
        /// 将 <see cref="byte"/>[] 数组中的每8个字节转换为对应的 <see cref="ulong"/> 值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isLittleEndian"><see cref="byte"/>[] 数组是否为小端序，默认为 <see langword="true"/></param>
        /// <returns>转换后的 <see cref="ulong"/>[] 数组</returns>
        /// <exception cref="ArgumentException"><see cref="byte"/>[] 数组长度不为8的倍数</exception>
        public static ulong[] ToUInt64(this byte[] value, bool isLittleEndian = true)
        {
            int perLength = 8;
            if (value.Length % perLength != 0)
            {
                throw new ArgumentException($"数组长度必须为{perLength}的倍数", nameof(value));
            }
            ulong[] ret = new ulong[value.Length / perLength];
            _ = Parallel.For(0, ret.Length, i =>
            {
                var range = (i * perLength)..((i + 1) * perLength);
                ret[i] = isLittleEndian ? BinaryPrimitives.ReadUInt64LittleEndian(value[range]) : BinaryPrimitives.ReadUInt64BigEndian(value[range]);
            });
            return ret;
        }
    }
}