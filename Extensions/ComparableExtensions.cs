namespace Chaldea.Components.Extensions
{
    /// <summary>
    /// <see cref="IComparable{T}"/> 扩展类
    /// </summary>
    public static class ComparableExtensions
    {
        /// <summary>
        /// 给一个值类型的值 <paramref name="value"/> 设置下限
        /// <para>当 <paramref name="value"/> 小于下限 <paramref name="min"/> 时，会被重新赋值为 <paramref name="min"/>，否则不做改变</para>
        /// </summary>
        /// <typeparam name="T"><paramref name="value"/> 的类型</typeparam>
        /// <param name="value"></param>
        /// <param name="min">下限值</param>
        /// <returns>
        /// 当 <paramref name="value"/> 小于下限 <paramref name="min"/> 时，返回 <paramref name="min"/>，否则返回
        /// <paramref name="value"/>
        /// </returns>
        public static ref T SetLowerLimits<T>(ref this T value, T min) where T : struct, IComparable<T>
        {
            if (value.CompareTo(min) == -1)
            {
                value = min;
            }
            return ref value;
        }

        /// <summary>
        /// 给一个值类型的值 <paramref name="value"/> 同时设置上下限
        /// <para>
        /// 当 <paramref name="value"/> 大于上限 <paramref name="max"/> 时，会被重新赋值为 <paramref name="max"/>；
        /// 当 <paramref name="value"/> 小于下限 <paramref name="min"/> 时，会被重新赋值为 <paramref name="min"/>； 其余情况不做改变
        /// </para>
        /// </summary>
        /// <typeparam name="T"><paramref name="value"/> 的类型</typeparam>
        /// <param name="value"></param>
        /// <param name="max">上限值</param>
        /// <param name="min">下限值</param>
        /// <returns>
        /// 当 <paramref name="value"/> 小于下限 <paramref name="min"/> 时，返回 <paramref name="min"/>； 当
        /// <paramref name="value"/> 大于上限 <paramref name="max"/> 时，返回 <paramref name="max"/>；其余情况返回
        /// <paramref name="value"/>
        /// </returns>
        public static ref T SetUpperAndLowerLimits<T>(ref this T value, T max, T min) where T : struct, IComparable<T>
        {
            return ref value.SetUpperLimits(max).SetLowerLimits(min);
        }

        /// <summary>
        /// 给一个值类型的值 <paramref name="value"/> 设置上限
        /// <para>当 <paramref name="value"/> 大于上限 <paramref name="max"/> 时，会被重新赋值为 <paramref name="max"/>，否则不做改变</para>
        /// </summary>
        /// <typeparam name="T"><paramref name="value"/> 的类型</typeparam>
        /// <param name="value"></param>
        /// <param name="max">上限值</param>
        /// <returns>
        /// 当 <paramref name="value"/> 大于上限 <paramref name="max"/> 时，返回 <paramref name="max"/>，否则返回
        /// <paramref name="value"/>
        /// </returns>
        public static ref T SetUpperLimits<T>(ref this T value, T max) where T : struct, IComparable<T>
        {
            if (value.CompareTo(max) == 1)
            {
                value = max;
            }
            return ref value;
        }
    }
}