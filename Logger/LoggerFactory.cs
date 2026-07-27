using NLog;
using NLog.Common;
using NLogLevel = NLog.LogLevel;

namespace TamamoToolkit.Logger
{
    /// <summary>
    /// 日志记录器工厂，此类不能被继承
    /// <para>
    /// 每个同名的 <see cref="ILogger"/> 实例对应独立的 <see cref="LoggerConfig"/>， 因此不同配置的记录器互不影响
    /// </para>
    /// </summary>
    public sealed class LoggerFactory
    {
        private static readonly Lazy<LoggerFactory> lazy = new(() => new LoggerFactory(), true);
        private readonly object locker = new object();

        /// <summary>
        /// 获取 <see cref="LoggerFactory"/> 的唯一实例
        /// </summary>
        public static LoggerFactory Instance => lazy.Value;

        /// <summary>
        /// 未显式指定配置时使用的日志配置
        /// <para>修改此属性只影响之后创建的默认日志记录器</para>
        /// </summary>
        public LoggerConfig DefaultLoggerConfig
        {
            get;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                field = value;
            }
        } = new LoggerConfig();

        private Dictionary<string, ILogger> LoggerDics { get; set; } = [];

        private LoggerFactory()
        {
            LogManager.ThrowExceptions = false;
            InternalLogger.LogLevel = NLogLevel.Off;
            InternalLogger.LogFile = @"C:\temp\nlog-internal.log";
        }

        /// <summary>
        /// 使用默认的日志配置获取日志记录器
        /// </summary>
        /// <param name="loggerName">记录器名称</param>
        /// <returns>日志记录器实例</returns>
        public ILogger GetLogger(string loggerName)
        {
            return GetLogger(loggerName, this.DefaultLoggerConfig);
        }

        /// <summary>
        /// 使用指定的日志配置获取日志记录器
        /// </summary>
        /// <param name="loggerName">记录器名称</param>
        /// <param name="loggerConfig">该记录器使用的日志配置</param>
        /// <returns>日志记录器实例</returns>
        public ILogger GetLogger(string loggerName, LoggerConfig loggerConfig)
        {
            return GetLogger(loggerName, loggerConfig, loggerName => new Logger(loggerName, loggerConfig));
        }

        /// <summary>
        /// 使用指定的日志配置及工厂策略方法获取日志记录器
        /// </summary>
        /// <param name="loggerName">记录器名称</param>
        /// <param name="loggerConfig">该记录器使用的日志配置</param>
        /// <param name="factoryStrategy">创建记录器的工厂策略</param>
        /// <returns>日志记录器实例</returns>
        public ILogger GetLogger(string loggerName, LoggerConfig loggerConfig, Func<string, ILogger> factoryStrategy)
        {
            ValidateLoggerName(loggerName);
            ArgumentNullException.ThrowIfNull(loggerConfig);
            ArgumentNullException.ThrowIfNull(factoryStrategy);
            lock (this.locker)
            {
                if (!this.LoggerDics.TryGetValue(loggerName, out var value))
                {
                    value = factoryStrategy.Invoke(loggerName);
                    value.UpdateConfig(loggerConfig);
                    this.LoggerDics.Add(loggerName, value);
                }
                return value;
            }
        }

        /// <summary>
        /// 更新指定名称的日志记录器的配置
        /// </summary>
        /// <param name="loggerName">记录器名称</param>
        /// <param name="loggerConfig">新的日志配置</param>
        public void UpdateLoggerConfig(string loggerName, LoggerConfig loggerConfig)
        {
            if (this.LoggerDics.TryGetValue(loggerName, out var value))
            {
                value.UpdateConfig(loggerConfig);
            }
        }

        private static void ValidateLoggerName(string loggerName)
        {
            if (string.IsNullOrWhiteSpace(loggerName))
            {
                throw new ArgumentException("日志记录器名称不能为空或空白", nameof(loggerName));
            }
        }
    }
}