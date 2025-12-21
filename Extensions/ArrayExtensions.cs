namespace TamamoToolkit.Extensions
{
    /// <summary>
    /// <see cref="Array"/> 扩展类
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// 清除数组的内容，将数组中的所有元素设置为每个元素类型的默认值
        /// </summary>
        /// <typeparam name="T">数组元素的类型</typeparam>
        /// <param name="array">需要清除其元素的数组</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> 为 <see langword="null"/> 时拋出的异常
        /// </exception>
        public static void Clear<T>(this T?[] array)
        {
            ArgumentNullException.ThrowIfNull(array);
            _ = Parallel.For(0, array.Length, i => array[i] = default);
        }

        /// <summary>
        /// 清除数组指定范围的内容，将数组中的指定范围的元素设置为每个元素类型的默认值
        /// </summary>
        /// <typeparam name="T">数组元素的类型</typeparam>
        /// <param name="array">需要清除其元素的数组</param>
        /// <param name="startIndex">起始索引（含）</param>
        /// <param name="count">要清除的元素数</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> 为 <see langword="null"/> 时拋出的异常
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="startIndex"/> 小于 0，或 <paramref name="count"/> 小于 0，或 <paramref
        /// name="startIndex"/> 与 <paramref name="count"/> 之和大于 <paramref name="array"/> 长度时拋出的异常
        /// </exception>
        public static void Clear<T>(this T?[] array, int startIndex, int count)
        {
            ArgumentNullException.ThrowIfNull(array);
#if NET6_0
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }
#elif NET8_0_OR_GREATER
            ArgumentOutOfRangeException.ThrowIfNegative(startIndex);
            ArgumentOutOfRangeException.ThrowIfNegative(count);
#endif
            if (startIndex + count > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }
            _ = Parallel.For(startIndex, startIndex + count, i => array[i] = default);
        }

        /// <summary>
        /// 填充数组的指定范围，将数组中的指定范围的元素设置为 <paramref name="value"/>
        /// <para>注意： <paramref name="value"/> 为引用类型时，填充后的数组元素将指向同一个引用</para>
        /// </summary>
        /// <typeparam name="T">数组元素的类型</typeparam>
        /// <param name="array">需要填充的数组</param>
        /// <param name="value">待填充的新值</param>
        /// <param name="startIndex">起始索引（含）</param>
        /// <param name="count">要填充的元素数</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> 为 <see langword="null"/> 时拋出的异常
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="startIndex"/> 小于 0，或 <paramref name="count"/> 小于 0，或 <paramref
        /// name="startIndex"/> 与 <paramref name="count"/> 之和大于 <paramref name="array"/> 长度时拋出的异常
        /// </exception>
        public static void Fill<T>(this T[] array, T value, int startIndex, int count)
        {
            ArgumentNullException.ThrowIfNull(array);
#if NET6_0
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }
#elif NET8_0_OR_GREATER
            ArgumentOutOfRangeException.ThrowIfNegative(startIndex);
            ArgumentOutOfRangeException.ThrowIfNegative(count);
#endif
            if (startIndex + count > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }
            _ = Parallel.For(startIndex, startIndex + count, i => array[i] = value);
        }

        /// <summary>
        /// 填充数组，将数组中的所有元素设置为 <paramref name="value"/>
        /// <para>注意： <paramref name="value"/> 为引用类型时，填充后的数组元素将指向同一个引用</para>
        /// </summary>
        /// <typeparam name="T">数组元素的类型</typeparam>
        /// <param name="array">需要填充的数组</param>
        /// <param name="value">待填充的新值</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> 为 <see langword="null"/> 时拋出的异常
        /// </exception>
        public static void Fill<T>(this T[] array, T value)
        {
            ArgumentNullException.ThrowIfNull(array);
            _ = Parallel.For(0, array.Length, i => array[i] = value);
        }

        /// <summary>
        /// 填充数组的指定范围，将数组中的指定范围的元素设置为 <paramref name="filler"/> 返回的值
        /// </summary>
        /// <typeparam name="T">数组元素的类型</typeparam>
        /// <param name="array">需要填充的数组</param>
        /// <param name="filler">返回新值的方法</param>
        /// <param name="startIndex">起始索引（含）</param>
        /// <param name="count">要填充的元素数</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> 为 <see langword="null"/>，或 <paramref name="filler"/> 为 <see
        /// langword="null"/> 时拋出的异常
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="startIndex"/> 小于 0，或 <paramref name="count"/> 小于 0，或 <paramref
        /// name="startIndex"/> 与 <paramref name="count"/> 之和大于 <paramref name="array"/> 长度时拋出的异常
        /// </exception>
        public static void Fill<T>(this T[] array, Func<T> filler, int startIndex, int count)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentNullException.ThrowIfNull(filler);
#if NET6_0
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }
#elif NET8_0_OR_GREATER
            ArgumentOutOfRangeException.ThrowIfNegative(startIndex);
            ArgumentOutOfRangeException.ThrowIfNegative(count);
#endif
            if (startIndex + count > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }
            _ = Parallel.For(startIndex, startIndex + count, i => array[i] = filler.Invoke());
        }

        /// <summary>
        /// 填充数组，将数组中的所有元素设置为 <paramref name="filler"/> 返回的值
        /// </summary>
        /// <typeparam name="T">数组元素的类型</typeparam>
        /// <param name="array">需要填充的数组</param>
        /// <param name="filler">返回新值的方法</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> 为 <see langword="null"/>，或 <paramref name="filler"/> 为 <see
        /// langword="null"/> 时拋出的异常
        /// </exception>
        public static void Fill<T>(this T[] array, Func<T> filler)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentNullException.ThrowIfNull(filler);
            _ = Parallel.For(0, array.Length, i => array[i] = filler.Invoke());
        }
    }
}