namespace TamamoToolkit.Events
{
    /// <summary>
    /// 事件中心，此类不能被继承
    /// </summary>
    public sealed class EventCenter
    {
        private static readonly Lazy<EventCenter> lazy = new Lazy<EventCenter>(() => new EventCenter(), true);
        private readonly Dictionary<Type, EventBase> events = [];

        /// <summary>
        /// 获取 <see cref="EventCenter"/> 类型实例
        /// </summary>
        public static EventCenter Instance => lazy.Value;

        private EventCenter()
        {
        }

        /// <summary>
        /// 获取类型为 <typeparamref name="TEvent"/> 的事件实例
        /// </summary>
        /// <typeparam name="TEvent">所需获取事件实例的类型</typeparam>
        /// <returns>类型为 <typeparamref name="TEvent"/> 的事件实例</returns>
        public TEvent GetEvent<TEvent>() where TEvent : EventBase, new()
        {
            if (!this.events.ContainsKey(typeof(TEvent)))
            {
                this.events.Add(typeof(TEvent), new TEvent());
            }
            return this.events[typeof(TEvent)] is TEvent ret ? ret : throw new NotImplementedException();
        }
    }
}