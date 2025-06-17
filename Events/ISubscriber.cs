namespace Chaldea.Components.Events
{
    /// <summary>
    /// 订阅者信息接口
    /// </summary>
    public interface ISubscriber
    {
        /// <summary>
        /// 事件被发布时执行的动作
        /// </summary>
        Delegate Action { get; }

        /// <summary>
        /// 过滤器方法
        /// </summary>
        Delegate Filter { get; }

        /// <summary>
        /// 订阅者唯一Token
        /// </summary>
        Guid Token { get; }

        /// <inheritdoc cref="object.Equals(object)"/>
        bool Equals(ISubscriber other);

        /// <inheritdoc cref="object.Equals(object)"/>
        bool Equals(object obj);

        /// <inheritdoc cref="object.GetHashCode"/>
        int GetHashCode();
    }
}