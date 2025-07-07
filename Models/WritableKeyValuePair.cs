namespace TamamoToolkit.Models
{
    /// <summary>
    /// 创建 <see cref="WritableKeyValuePair{TKey, TValue}"/> 结构体的实例
    /// </summary>
    public static class WritableKeyValuePair
    {
        /// <summary>
        /// 使用指定的键和值创建 <see cref="WritableKeyValuePair{TKey, TValue}"/> 结构体的新实例
        /// </summary>
        /// <typeparam name="TKey"><see cref="WritableKeyValuePair{TKey, TValue}"/> 中键的类型</typeparam>
        /// <typeparam name="TValue"><see cref="WritableKeyValuePair{TKey, TValue}"/> 中值的类型</typeparam>
        /// <param name="key">类型为 <see langword="TKey"/> 的键</param>
        /// <param name="value">类型为 <see langword="TValue"/> 的值</param>
        /// <returns>用指定的键和值创建的 <see cref="WritableKeyValuePair{TKey, TValue}"/> 结构体新实例</returns>
        public static WritableKeyValuePair<TKey, TValue> Create<TKey, TValue>(TKey key, TValue value) where TKey : notnull
        {
            return new WritableKeyValuePair<TKey, TValue>(key, value);
        }
    }

    /// <summary>
    /// 一个键和值均可修改的键值对
    /// </summary>
    /// <typeparam name="TKey"><see cref="WritableKeyValuePair{TKey, TValue}"/> 中键的类型</typeparam>
    /// <typeparam name="TValue"><see cref="WritableKeyValuePair{TKey, TValue}"/> 中值的类型</typeparam>
    /// <remarks>用指定的键和值初始化 <see cref="WritableKeyValuePair{TKey, TValue}"/> 结构体的新实例</remarks>
    /// <param name="key">类型为 <see langword="TKey"/> 的键</param>
    /// <param name="value">类型为 <see langword="TValue"/> 的值</param>
    public struct WritableKeyValuePair<TKey, TValue>(TKey key, TValue value) where TKey : notnull
    {
        /// <summary>
        /// 类型为 <see langword="TKey"/> 的键
        /// </summary>
        public TKey Key { get; set; } = key;

        /// <summary>
        /// 类型为 <see langword="TValue"/> 的值
        /// </summary>
        public TValue Value { get; set; } = value;

        /// <summary>
        /// 隐式转换为 <see cref="KeyValuePair{TKey, TValue}"/> 类型
        /// </summary>
        /// <param name="writable">转换前的 <see cref="WritableKeyValuePair{TKey, TValue}"/> 结构体实例</param>
        public static implicit operator KeyValuePair<TKey, TValue>(WritableKeyValuePair<TKey, TValue> writable)
        {
            return writable.ToKeyValuePair();
        }

        /// <inheritdoc/>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(this.Key, this.Value);
        }

        /// <summary>
        /// 转换为 <see cref="KeyValuePair{TKey, TValue}"/> 类型
        /// </summary>
        /// <returns>转换后的 <see cref="KeyValuePair{TKey, TValue}"/> 实例</returns>
        public readonly KeyValuePair<TKey, TValue> ToKeyValuePair()
        {
            return KeyValuePair.Create(this.Key, this.Value);
        }

        /// <inheritdoc/>
        public override readonly string ToString()
        {
            return $"[{this.Key},{this.Value}]";
        }
    }
}