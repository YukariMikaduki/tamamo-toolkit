namespace TamamoToolkit.Models
{
    /// <summary>
    /// <see cref="IDeepCopy{T}"/> 接口的一个抽象实现
    /// </summary>
    /// <typeparam name="T"><inheritdoc cref="IDeepCopy{T}"/></typeparam>
    public abstract class DeepCopyBase<T> : DeepCopyBase, IDeepCopy<T> where T : new()
    {
        /// <inheritdoc/>
        public override object Clone()
        {
            var ret = new T();
            DeepCopyTo(ret);
            return ret;
        }

        /// <inheritdoc/>
        public abstract void DeepCopyTo(T target);

        /// <inheritdoc/>
        public override void DeepCopyTo(object target)
        {
            if (target is T t)
            {
                DeepCopyTo(t);
            }
        }
    }

    /// <summary>
    /// <see cref="IDeepCopy"/> 接口的一个抽象实现
    /// </summary>
    public abstract class DeepCopyBase : IDeepCopy
    {
        /// <inheritdoc/>
        public abstract object Clone();

        /// <inheritdoc/>
        public abstract void DeepCopyTo(object target);
    }
}