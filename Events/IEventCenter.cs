namespace Chaldea.Components.Events
{
    /// <summary>
    /// 事件中心接口
    /// </summary>
    public interface IEventCenter
    {
        /// <summary>
        /// 获取类型为 <see langword="TEvent"/> 的事件实例
        /// </summary>
        /// <typeparam name="TEvent">所需获取事件实例的类型</typeparam>
        /// <returns>类型为 <see langword="TEvent"/> 的事件实例</returns>
        TEvent GetEvent<TEvent>() where TEvent : EventBase, new();
    }
}