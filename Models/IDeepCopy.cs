namespace TamamoToolkit.Models
{
    /// <summary>
    /// 可以深复制的方法接口，泛型版本
    /// </summary>
    /// <typeparam name="T">数据类型，必须具有默认无参构造函数</typeparam>
    public interface IDeepCopy<T> : IDeepCopy where T : new()
    {
        /// <summary>
        /// 深复制到目标
        /// </summary>
        /// <param name="target">目标实例</param>
        void DeepCopyTo(T target);
    }

    /// <summary>
    /// 可以深复制的方法接口
    /// </summary>
    public interface IDeepCopy : ICloneable
    {
        /// <summary>
        /// 深复制到目标
        /// </summary>
        /// <param name="target">目标实例</param>
        void DeepCopyTo(object target);
    }
}