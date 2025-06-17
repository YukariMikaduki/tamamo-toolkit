namespace Chaldea.Components.Extensions
{
    /// <summary>
    /// <see cref="Array"/> 扩展类
    /// </summary>
    public static class ArrayExtensions
    {
        /// <inheritdoc cref="Array.Clear(Array)"/>
        public static void Clear(this Array array)
        {
            Array.Clear(array);
        }

        /// <inheritdoc cref="Array.Clear(Array, int, int)"/>
        public static void Clear(this Array array, int index, int length)
        {
            Array.Clear(array, index, length);
        }

        /// <inheritdoc cref="Array.Fill{T}(T[], T, int, int)"/>
        public static void Fill<T>(this T[] array, T value, int startIndex, int count)
        {
            Array.Fill(array, value, startIndex, count);
        }

        /// <inheritdoc cref="Array.Fill{T}(T[], T)"/>
        public static void Fill<T>(this T[] array, T value)
        {
            Array.Fill(array, value);
        }
    }
}