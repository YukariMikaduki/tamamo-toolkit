namespace Chaldea.Components.Extensions
{
    /// <summary>
    /// <see cref="IEnumerable{T}"/> 扩展类
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// 对 <see cref="IEnumerable{T}"/> 中的每个元素执行操作
        /// </summary>
        /// <typeparam name="T"><see cref="IEnumerable{T}"/> 中的数据类型</typeparam>
        /// <param name="obj"><see cref="IEnumerable{T}"/> 的实例</param>
        /// <param name="action">所需执行的操作</param>
        /// <param name="runAsParallel">是否需要并行执行，默认值为 <see langword="false"/></param>
        public static void ForEach<T>(this IEnumerable<T> obj, Action<T> action, bool runAsParallel = false)
        {
            if (runAsParallel)
            {
                _ = Parallel.ForEach(obj, action);
            }
            else
            {
                foreach (var item in obj)
                {
                    action.Invoke(item);
                }
            }
        }

        /// <summary>
        /// 检查 <see cref="IEnumerable{T}"/> 是否为 <see langword="null"/> 或不含有任何元素
        /// </summary>
        /// <typeparam name="T"><see cref="IEnumerable{T}"/> 中的数据类型</typeparam>
        /// <param name="obj"><see cref="IEnumerable{T}"/> 的实例</param>
        /// <returns>
        /// 若 <see cref="IEnumerable{T}"/> 为 <see langword="null"/> 或不含有任何元素，则返回 <see
        /// langword="true"/>，否则返回 <see langword="false"/>
        /// </returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T>? obj)
        {
            return obj is null || !obj.Any();
        }
    }
}