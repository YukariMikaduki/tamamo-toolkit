namespace TamamoToolkit.Events
{
    /// <summary>
    /// 订阅者
    /// </summary>
    /// <param name="action">事件被发布时执行的动作</param>
    /// <param name="filter">过滤器方法</param>
    public class Subscriber(Delegate action, Delegate filter) : IEquatable<Subscriber>
    {
        /// <summary>
        /// 事件被发布时执行的动作
        /// </summary>
        public Delegate Action => action ?? throw new ArgumentNullException(nameof(action));

        /// <summary>
        /// 过滤器方法
        /// </summary>
        public Delegate Filter => filter ?? throw new ArgumentNullException(nameof(filter));

        /// <summary>
        /// 订阅者唯一Token
        /// </summary>
        public Guid Token { get; } = Guid.NewGuid();

        /// <summary>
        /// 确定两个 <see cref="Subscriber"/> 对象是否不相等
        /// </summary>
        /// <param name="left">要比较的第一个对象</param>
        /// <param name="right">要比较的第二个对象</param>
        /// <returns>
        /// 如果 <paramref name="left"/> 和 <paramref name="right"/> 不相等，则为 <see langword="true"/>，否则为
        /// <see langword="false"/>
        /// </returns>
        public static bool operator !=(Subscriber? left, Subscriber? right)
        {
            return !(left == right);
        }

        /// <summary>
        /// 确定两个 <see cref="Subscriber"/> 对象是否相等
        /// </summary>
        /// <param name="left">要比较的第一个对象</param>
        /// <param name="right">要比较的第二个对象</param>
        /// <returns>
        /// 如果 <paramref name="left"/> 和 <paramref name="right"/> 相等，则为 <see langword="true"/>，否则为
        /// <see langword="false"/>
        /// </returns>
        public static bool operator ==(Subscriber? left, Subscriber? right)
        {
            return left is not null && left.Equals(right);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj is Subscriber sub && (ReferenceEquals(this, sub) || Equals(sub));
        }

        /// <inheritdoc/>
        public bool Equals(Subscriber? other)
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