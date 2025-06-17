namespace Chaldea.Components.Events
{
    /// <summary>
    /// <see cref="EventBase"/> 类的一个包含事件参数的实现
    /// </summary>
    /// <typeparam name="TEventArgs">事件参数，需要继承自 <see cref="EventArgs"/></typeparam>
    public class CanPubSubEvent<TEventArgs> : EventBase where TEventArgs : EventArgs
    {
        /// <summary>
        /// 发布事件通知
        /// </summary>
        /// <param name="sender">事件发布者</param>
        /// <param name="e">事件参数</param>
        public virtual void Publish(object sender, TEventArgs e)
        {
            this.subscribers.ForEach(t =>
            {
                if (t.Action is EventHandler<TEventArgs> action && t.Filter is Predicate<TEventArgs> filter)
                {
                    if (filter.Invoke(e))
                    {
                        action?.Invoke(sender, e);
                    }
                }
            });
        }

        /// <summary>
        /// 订阅事件通知
        /// </summary>
        /// <param name="action">事件被发布时执行的动作</param>
        /// <returns>订阅者信息</returns>
        public virtual Subscriber Subscribe(EventHandler<TEventArgs> action)
        {
            return Subscribe(action, args => true);
        }

        /// <summary>
        /// 订阅事件通知
        /// </summary>
        /// <param name="action">事件被发布时执行的动作</param>
        /// <param name="filter">过滤器，只有当过滤器返回 <see langword="true"/> 时订阅者才会收到通知</param>
        /// <returns>订阅者信息</returns>
        public virtual Subscriber Subscribe(EventHandler<TEventArgs> action, Predicate<TEventArgs> filter)
        {
            var sub = new Subscriber(action, filter);
            lock (this.subscribers)
            {
                this.subscribers.Add(sub);
            }
            return sub;
        }

        /// <summary>
        /// 取消订阅事件通知
        /// </summary>
        /// <param name="action">订阅时所注册的事件被发布时执行的动作</param>
        public virtual void Unsubscribe(EventHandler<TEventArgs> action)
        {
            lock (this.subscribers)
            {
                _ = this.subscribers.RemoveAll(t => t.Action.Equals(action));
            }
        }

        /// <summary>
        /// 取消订阅事件通知
        /// </summary>
        /// <param name="subscriber">订阅时所返回的订阅者信息</param>
        public virtual void Unsubscribe(Subscriber subscriber)
        {
            var sub = this.subscribers.FirstOrDefault(t => t.Token == subscriber.Token);
            if (sub is not null)
            {
                lock (this.subscribers)
                {
                    _ = this.subscribers.Remove(sub);
                }
            }
        }
    }
}