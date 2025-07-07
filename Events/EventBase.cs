using System.Collections.Concurrent;
using TamamoToolkit.Extensions;

namespace TamamoToolkit.Events
{
    /// <summary>
    /// 适用于 <see cref="EventCenter"/> 的事件类型基类
    /// </summary>
    public abstract class EventBase
    {
        /// <summary>
        /// 订阅者列表
        /// </summary>
        protected readonly ConcurrentDictionary<Guid, Subscriber> subscribers = [];

        /// <summary>
        /// 确定是否包含指定的订阅者
        /// </summary>
        /// <param name="subscriber">指定的订阅者</param>
        /// <returns>
        /// 如果包含 <paramref name="subscriber"/>，则返回 <see langword="true"/>，否则返回 <see langword="false"/>
        /// </returns>
        public virtual bool Contains(Subscriber subscriber)
        {
            return this.subscribers.ContainsKey(subscriber.Token);
        }

        /// <summary>
        /// 订阅事件通知
        /// </summary>
        /// <param name="subscriber">指定的订阅者</param>
        /// <returns>如果订阅成功，则返回 <paramref name="subscriber"/>，否则返回 <see langword="null"/></returns>
        public virtual Subscriber? Subscribe(Subscriber subscriber)
        {
            return this.subscribers.TryAdd(subscriber.Token, subscriber) ? subscriber : null;
        }

        /// <summary>
        /// 取消订阅事件通知
        /// </summary>
        /// <param name="subscriber">指定的订阅者</param>
        public virtual void Unsubscribe(Subscriber subscriber)
        {
            _ = this.subscribers.TryRemove(subscriber.Token, out _);
        }

        /// <summary>
        /// 移除所有订阅者
        /// </summary>
        public void UnsubscribeAll()
        {
            this.subscribers.Clear();
        }
    }

    /// <summary>
    /// <see cref="EventBase"/> 类的一个包含事件参数的实现
    /// </summary>
    /// <typeparam name="TEventArgs">事件参数，需要继承自 <see cref="EventArgs"/></typeparam>
    public class EventBase<TEventArgs> : EventBase where TEventArgs : EventArgs
    {
        /// <summary>
        /// 确定发布时是否包含指定的需要执行的动作
        /// </summary>
        /// <param name="action">指定的订阅者</param>
        /// <returns>如果包含 <paramref name="action"/>，则返回 <see langword="true"/>，否则返回 <see langword="false"/></returns>
        public virtual bool Contains(EventHandler<TEventArgs> action)
        {
            return this.subscribers.Any(t => t.Value.Action.Equals(action));
        }

        /// <summary>
        /// 发布事件通知
        /// </summary>
        /// <param name="sender">事件发布者</param>
        /// <param name="e">事件参数</param>
        public virtual void Publish(object? sender, TEventArgs e)
        {
            this.subscribers.Values.ForEach(t =>
            {
                if (t.Action is EventHandler<TEventArgs> action && t.Filter is Predicate<TEventArgs> filter)
                {
                    if (filter.Invoke(e))
                    {
                        action.Invoke(sender, e);
                    }
                }
            });
        }

        /// <summary>
        /// 订阅事件通知
        /// </summary>
        /// <param name="action">事件被发布时执行的动作</param>
        /// <returns>如果订阅成功，则返回订阅者，否则返回 <see langword="null"/></returns>
        public virtual Subscriber? Subscribe(EventHandler<TEventArgs> action)
        {
            return Subscribe(action, filter => true);
        }

        /// <summary>
        /// 订阅事件通知
        /// </summary>
        /// <param name="action">事件被发布时执行的动作</param>
        /// <param name="filter">过滤器，只有当过滤器返回 <see langword="true"/> 时订阅者才会收到通知</param>
        /// <returns>如果订阅成功，则返回订阅者，否则返回 <see langword="null"/></returns>
        public virtual Subscriber? Subscribe(EventHandler<TEventArgs> action, Predicate<TEventArgs> filter)
        {
            return base.Subscribe(new Subscriber(action, filter));
        }

        /// <summary>
        /// 取消订阅事件通知
        /// </summary>
        /// <param name="action">订阅时所注册的事件被发布时执行的动作</param>
        public virtual void Unsubscribe(EventHandler<TEventArgs> action)
        {
            this.subscribers.Values.Where(t => t.Action.Equals(action)).ForEach(Unsubscribe);
        }
    }
}