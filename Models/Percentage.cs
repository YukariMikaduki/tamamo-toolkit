namespace TamamoToolkit.Models
{
    /// <summary>
    /// 百分数，有效值为 [0,100] 闭区间内的 <see cref="float"/> 值，超出此范围时代表无效
    /// </summary>
    /// <param name="value">百分数的值</param>
    public readonly struct Percentage(float value) : IComparable<Percentage>, IEquatable<Percentage>
    {
        private readonly float value = value < 0 ? float.NegativeInfinity : value > 100 ? float.PositiveInfinity : value;

        /// <summary>
        /// 百分数最大值，即为 100
        /// </summary>
        public static Percentage MaxValue => new Percentage(100f);

        /// <summary>
        /// 百分数最小值，即为 0
        /// </summary>
        public static Percentage MinValue => new Percentage(0f);

        /// <summary>
        /// 百分数负无效值，即小于 0
        /// </summary>
        public static Percentage NegativeNaN => new Percentage(float.NegativeInfinity);

        /// <summary>
        /// 百分数正无效值，即大于 100
        /// </summary>
        public static Percentage PositiveNaN => new Percentage(float.PositiveInfinity);

        /// <summary>
        /// 百分数，有效值为 [0,100] 闭区间内的 <see cref="float"/> 值，超出此范围时代表无效
        /// </summary>
        /// <param name="value">百分数的值</param>
        public Percentage(int value) : this(Convert.ToSingle(value))
        {
        }

        /// <summary>
        /// 百分数，有效值为 [0,100] 闭区间内的 <see cref="float"/> 值，超出此范围时代表无效
        /// </summary>
        /// <param name="value">百分数的值</param>
        public Percentage(double value) : this(Convert.ToSingle(value))
        {
        }

        /// <summary>
        /// 百分数，有效值为 [0,100] 闭区间内的 <see cref="float"/> 值，超出此范围时代表无效
        /// </summary>
        /// <param name="value">百分数的值</param>
        public Percentage(uint value) : this(Convert.ToSingle(value))
        {
        }

        /// <inheritdoc/>
        public int CompareTo(Percentage other)
        {
            return this.value.CompareTo(other.value);
        }

        /// <inheritdoc/>
        public bool Equals(Percentage other)
        {
            return this.value == other.value;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj is Percentage value && Equals(value);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        /// <summary>
        /// 转换为 <see cref="float"/> 值
        /// </summary>
        /// <returns>转换后的 <see cref="float"/> 值</returns>
        public float ToSingle()
        {
            return this.value;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this == NegativeNaN ? "-NaN" : this == PositiveNaN ? "+NaN" : $"{this.value:f2} %";
        }

        #region 强制类型转换

        /// <summary>
        /// 将 <see cref="Percentage"/> 隐式强制类型转换为 <see cref="float"/>
        /// </summary>
        /// <param name="value">待转换的 <see cref="Percentage"/></param>
        public static implicit operator float(Percentage value)
        {
            return value.ToSingle();
        }

        /// <summary>
        /// 将 <see cref="int"/> 隐式强制类型转换为 <see cref="Percentage"/>
        /// </summary>
        /// <param name="value">待转换的 <see cref="int"/></param>
        public static implicit operator Percentage(int value)
        {
            return new Percentage(value);
        }

        /// <summary>
        /// 将 <see cref="uint"/> 隐式强制类型转换为 <see cref="Percentage"/>
        /// </summary>
        /// <param name="value">待转换的 <see cref="uint"/></param>
        public static implicit operator Percentage(uint value)
        {
            return new Percentage(value);
        }

        /// <summary>
        /// 将 <see cref="double"/> 隐式强制类型转换为 <see cref="Percentage"/>
        /// </summary>
        /// <param name="value">待转换的 <see cref="double"/></param>
        public static implicit operator Percentage(double value)
        {
            return new Percentage(value);
        }

        #endregion 强制类型转换

        #region 操作符重载

        /// <summary>
        /// 返回两个 <see cref="Percentage"/> 值的差
        /// </summary>
        /// <param name="left">要计算的第一个值</param>
        /// <param name="right">要计算的第二个值</param>
        /// <returns>两个 <see cref="Percentage"/> 值的差</returns>
        public static Percentage operator -(Percentage left, Percentage right)
        {
            return new Percentage(left.value - right.value);
        }

        /// <summary>
        /// 指示两个指定的 <see cref="Percentage"/> 值是否不相等
        /// </summary>
        /// <param name="left">要比较的第一个值</param>
        /// <param name="right">要比较的第二个值</param>
        /// <returns>
        /// 如果 <paramref name="left"/> 和 <paramref name="right"/> 不相等，则为 <see langword="true"/>，否则为
        /// <see langword="false"/>
        /// </returns>
        public static bool operator !=(Percentage left, Percentage right)
        {
            return !(left == right);
        }

        /// <summary>
        /// 返回两个 <see cref="Percentage"/> 值的积
        /// </summary>
        /// <param name="left">要计算的第一个值</param>
        /// <param name="right">要计算的第二个值</param>
        /// <returns>两个 <see cref="Percentage"/> 值的积</returns>
        public static Percentage operator *(Percentage left, Percentage right)
        {
            return new Percentage(left.value * right.value);
        }

        /// <summary>
        /// 返回两个 <see cref="Percentage"/> 值的商
        /// </summary>
        /// <param name="left">要计算的第一个值</param>
        /// <param name="right">要计算的第二个值</param>
        /// <returns>两个 <see cref="Percentage"/> 值的商</returns>
        public static Percentage operator /(Percentage left, Percentage right)
        {
            return new Percentage(left.value / right.value);
        }

        /// <summary>
        /// 返回两个 <see cref="Percentage"/> 值的和
        /// </summary>
        /// <param name="left">要计算的第一个值</param>
        /// <param name="right">要计算的第二个值</param>
        /// <returns>两个 <see cref="Percentage"/> 值的和</returns>
        public static Percentage operator +(Percentage left, Percentage right)
        {
            return new Percentage(left.value + right.value);
        }

        /// <summary>
        /// 指示指定的 <see cref="Percentage"/> 值是否小于另一个指定的 <see cref="Percentage"/> 值
        /// </summary>
        /// <param name="left">要比较的第一个值</param>
        /// <param name="right">要比较的第二个值</param>
        /// <returns>
        /// 如果 <paramref name="left"/> 小于 <paramref name="right"/>，则为 <see langword="true"/>，否则为
        /// <see langword="false"/>
        /// </returns>
        public static bool operator <(Percentage left, Percentage right)
        {
            return left.CompareTo(right) < 0;
        }

        /// <summary>
        /// 指示指定的 <see cref="Percentage"/> 值是否大于等于另一个指定的 <see cref="Percentage"/> 值
        /// </summary>
        /// <param name="left">要比较的第一个值</param>
        /// <param name="right">要比较的第二个值</param>
        /// <returns>
        /// 如果 <paramref name="left"/> 大于等于 <paramref name="right"/>，则为 <see langword="true"/>，否则为
        /// <see langword="false"/>
        /// </returns>
        public static bool operator <=(Percentage left, Percentage right)
        {
            return left.CompareTo(right) <= 0;
        }

        /// <summary>
        /// 指示两个指定的 <see cref="Percentage"/> 值是否相等
        /// </summary>
        /// <param name="left">要比较的第一个值</param>
        /// <param name="right">要比较的第二个值</param>
        /// <returns>
        /// 如果 <paramref name="left"/> 和 <paramref name="right"/> 相等，则为 <see langword="true"/>，否则为
        /// <see langword="false"/>
        /// </returns>
        public static bool operator ==(Percentage left, Percentage right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// 指示指定的 <see cref="Percentage"/> 值是否大于另一个指定的 <see cref="Percentage"/> 值
        /// </summary>
        /// <param name="left">要比较的第一个值</param>
        /// <param name="right">要比较的第二个值</param>
        /// <returns>
        /// 如果 <paramref name="left"/> 大于 <paramref name="right"/>，则为 <see langword="true"/>，否则为
        /// <see langword="false"/>
        /// </returns>
        public static bool operator >(Percentage left, Percentage right)
        {
            return left.CompareTo(right) > 0;
        }

        /// <summary>
        /// 指示指定的 <see cref="Percentage"/> 值是否大于等于另一个指定的 <see cref="Percentage"/> 值
        /// </summary>
        /// <param name="left">要比较的第一个值</param>
        /// <param name="right">要比较的第二个值</param>
        /// <returns>
        /// 如果 <paramref name="left"/> 大于等于 <paramref name="right"/>，则为 <see langword="true"/>，否则为
        /// <see langword="false"/>
        /// </returns>
        public static bool operator >=(Percentage left, Percentage right)
        {
            return left.CompareTo(right) >= 0;
        }

        #endregion 操作符重载
    }
}