namespace Chaldea.Components.Events
{
    /// <summary>
    /// <see cref="IEventCenter"/> 接口的一个实现，此类不能被继承
    /// </summary>
    public sealed class EventCenter : IEventCenter
    {
        private static readonly Lazy<IEventCenter> lazy = new Lazy<IEventCenter>(() => new EventCenter(), true);
        private readonly Dictionary<Type, object> events = [];

        /// <summary>
        /// 获取 <see cref="IEventCenter"/> 类型单例
        /// </summary>
        public static IEventCenter Instance => lazy.Value;

        private EventCenter()
        {
        }

        /// <inheritdoc/>
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