namespace Chaldea.Components.Extensions
{
    /// <summary>
    /// <see cref="Dictionary{TKey, TValue}"/> 扩展类
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// 将指定的键值对添加到 <see cref="Dictionary{TKey, TValue}"/> 中
        /// </summary>
        /// <typeparam name="TKey"><see cref="Dictionary{TKey, TValue}"/> 中键的类型</typeparam>
        /// <typeparam name="TValue"><see cref="Dictionary{TKey, TValue}"/> 中值的类型</typeparam>
        /// <param name="dic"><see cref="Dictionary{TKey, TValue}"/> 实例</param>
        /// <param name="kv"><see cref="KeyValuePair{TKey, TValue}"/> 结构体实例</param>
        public static void Add<TKey, TValue>(this Dictionary<TKey, TValue> dic, KeyValuePair<TKey, TValue> kv) where TKey : notnull
        {
            dic.Add(kv.Key, kv.Value);
        }

        /// <summary>
        /// 将指定的键和值添加或更新到 <see cref="Dictionary{TKey, TValue}"/> 中
        /// </summary>
        /// <typeparam name="TKey"><see cref="Dictionary{TKey, TValue}"/> 中键的类型</typeparam>
        /// <typeparam name="TValue"><see cref="Dictionary{TKey, TValue}"/> 中值的类型</typeparam>
        /// <param name="dic"><see cref="Dictionary{TKey, TValue}"/> 实例</param>
        /// <param name="key">要添加或更新的类型为 <see langword="TKey"/> 的键</param>
        /// <param name="value">要添加或更新的类型为 <see langword="TValue"/> 的值</param>
        public static void AddOrUpdate<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, TValue value) where TKey : notnull
        {
            if (!dic.TryAdd(key, value))
            {
                dic[key] = value;
            }
        }

        /// <summary>
        /// 将指定的键值对添加或更新到 <see cref="Dictionary{TKey, TValue}"/> 中
        /// </summary>
        /// <typeparam name="TKey"><see cref="Dictionary{TKey, TValue}"/> 中键的类型</typeparam>
        /// <typeparam name="TValue"><see cref="Dictionary{TKey, TValue}"/> 中值的类型</typeparam>
        /// <param name="dic"><see cref="Dictionary{TKey, TValue}"/> 实例</param>
        /// <param name="kv"><see cref="KeyValuePair{TKey, TValue}"/> 结构体实例</param>
        public static void AddOrUpdate<TKey, TValue>(this Dictionary<TKey, TValue> dic, KeyValuePair<TKey, TValue> kv) where TKey : notnull
        {
            if (!dic.TryAdd(kv.Key, kv.Value))
            {
                dic.Add(kv);
            }
        }
    }
}