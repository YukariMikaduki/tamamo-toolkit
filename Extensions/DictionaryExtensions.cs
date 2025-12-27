namespace TamamoToolkit.Extensions
{
    /// <summary>
    /// <see cref="Dictionary{TKey, TValue}"/> 扩展类
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <typeparam name="TKey"><see cref="Dictionary{TKey, TValue}"/> 中键的类型</typeparam>
        /// <typeparam name="TValue"><see cref="Dictionary{TKey, TValue}"/> 中值的类型</typeparam>
        extension<TKey, TValue>(Dictionary<TKey, TValue> dic) where TKey : notnull
        {
            /// <summary>
            /// 将指定的键值对添加到 <see cref="Dictionary{TKey, TValue}"/> 中
            /// </summary>
            /// <param name="kv"><see cref="KeyValuePair{TKey, TValue}"/> 结构体实例</param>
            public void Add(KeyValuePair<TKey, TValue> kv)
            {
                dic.Add(kv.Key, kv.Value);
            }

            /// <summary>
            /// 将指定的键和值添加或更新到 <see cref="Dictionary{TKey, TValue}"/> 中
            /// </summary>
            /// <param name="key">要添加或更新的类型为 <see langword="TKey"/> 的键</param>
            /// <param name="value">要添加或更新的类型为 <see langword="TValue"/> 的值</param>
            public void AddOrUpdate(TKey key, TValue value)
            {
                if (!dic.TryAdd(key, value))
                {
                    dic[key] = value;
                }
            }

            /// <summary>
            /// 将指定的键值对添加或更新到 <see cref="Dictionary{TKey, TValue}"/> 中
            /// </summary>
            /// <param name="kv"><see cref="KeyValuePair{TKey, TValue}"/> 结构体实例</param>
            public void AddOrUpdate(KeyValuePair<TKey, TValue> kv)
            {
                if (!dic.TryAdd(kv.Key, kv.Value))
                {
                    dic.Add(kv);
                }
            }
        }
    }
}