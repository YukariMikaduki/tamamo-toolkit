namespace Chaldea.Components.Events
{
    /// <summary>
    /// <see cref="ISubscriber"/> 的一个实现
    /// </summary>
    /// <remarks>初始化一个订阅者信息的新实例</remarks>
    /// <param name="action">事件被发布时执行的动作</param>
    /// <param name="filter">过滤器方法</param>
    public class Subscriber(Delegate action, Delegate filter) : ISubscriber
    {
        /// <inheritdoc/>
        public Delegate Action => action ?? throw new ArgumentNullException(nameof(action));

        /// <inheritdoc/>
        public Delegate Filter => filter ?? throw new ArgumentNullException(nameof(filter));

        /// <inheritdoc/>
        public Guid Token => Guid.NewGuid();

        /// <summary>
        /// 确定两个对象是否不相等
        /// </summary>
        /// <param name="left">对象1</param>
        /// <param name="right">对象2</param>
        /// <returns>如果两个对象不相等，则为 <see langword="true"/>，否则为 <see langword="false"/></returns>
        public static bool operator !=(Subscriber left, Subscriber right)
        {
            return !(left == right);
        }

        /// <summary>
        /// 确定两个对象是否相等
        /// </summary>
        /// <param name="left">对象1</param>
        /// <param name="right">对象2</param>
        /// <returns>如果两个对象相等，则为 <see langword="true"/>，否则为 <see langword="false"/></returns>
        public static bool operator ==(Subscriber left, Subscriber right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj is ISubscriber sub && (ReferenceEquals(this, sub) || Equals(sub));
        }

        /// <inheritdoc/>
        public bool Equals(ISubscriber other)
        {
            return other is not null && this.Token == other.Token;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Token.GetHashCode();
        }
    }
}