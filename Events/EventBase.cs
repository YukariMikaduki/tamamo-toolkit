namespace Chaldea.Components.Events
{
    /// <summary>
    /// 适用于 <see cref="IEventCenter"/> 的事件类型基类
    /// </summary>
    public abstract class EventBase
    {
        /// <summary>
        /// 订阅者列表
        /// </summary>
        protected readonly List<Subscriber> subscribers = [];
    }
}