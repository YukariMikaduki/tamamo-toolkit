namespace Chaldea.Components.Logger
{
    /// <summary>
    /// 日志记录器工厂
    /// </summary>
    public class LoggerFactory
    {
        /// <summary>
        /// 日志配置，修改之后会自动更新配置
        /// </summary>
        public static LoggerConfig LoggerConfig
        {
            get;
            set
            {
                field = value;
                field.UpdateConfig();
            }
        } = new LoggerConfig();

        /// <summary>
        /// 日志记录器字典
        /// <para><see langword="Key"/> 为日志记录器名称</para>
        /// <para><see langword="Value"/> 为该名称对应的 <see cref="ILogger"/> 实例</para>
        /// </summary>
        protected static Dictionary<string, ILogger> LoggerDics { get; set; } = [];

        /// <summary>
        /// 使用默认工厂策略方法获取日志记录器
        /// <para>默认策略为 <see cref="Logger(string)"/></para>
        /// </summary>
        /// <param name="loggerName">记录器名称，同一名称对应相同的记录器</param>
        /// <returns>日志记录器实例</returns>
        public static ILogger GetLogger(string loggerName)
        {
            return GetLogger(loggerName, (loggerName) => new Logger(loggerName));
        }

        /// <summary>
        /// 指定工厂策略方法并获取日志记录器
        /// </summary>
        /// <param name="loggerName">记录器名称，同一名称对应相同的记录器</param>
        /// <param name="factoryStrategy">
        /// 工厂策略方法，输入为日志记录器名称，返回值为一个对应该名称的新的 <see cref="ILogger"/> 实例
        /// </param>
        /// <returns>日志记录器实例</returns>
        public static ILogger GetLogger(string loggerName, Func<string, ILogger> factoryStrategy)
        {
            if (!LoggerDics.TryGetValue(loggerName, out var value))
            {
                value = factoryStrategy.Invoke(loggerName);
                LoggerDics.Add(loggerName, value);
            }
            return value;
        }
    }
}