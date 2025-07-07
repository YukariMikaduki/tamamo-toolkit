using NLogLevel = NLog.LogLevel;

namespace TamamoToolkit.Logger
{
    internal static class LogLevelExtensions
    {
        public static NLogLevel ToNLogLevel(this LogLevel level)
        {
            return level switch
            {
                LogLevel.Trace => NLogLevel.Trace,
                LogLevel.Debug => NLogLevel.Debug,
                LogLevel.Info => NLogLevel.Info,
                LogLevel.Warn => NLogLevel.Warn,
                LogLevel.Error => NLogLevel.Error,
                LogLevel.Fatal => NLogLevel.Fatal,
                _ => NLogLevel.Off,
            };
        }
    }

    /// <summary>
    /// 日志等级
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Trace级日志
        /// </summary>
        Trace = 0,

        /// <summary>
        /// Debug级日志
        /// </summary>
        Debug = 1,

        /// <summary>
        /// Info级日志
        /// </summary>
        Info = 2,

        /// <summary>
        /// Warn级日志
        /// </summary>
        Warn = 3,

        /// <summary>
        /// Error级日志
        /// </summary>
        Error = 4,

        /// <summary>
        /// Fatal级日志
        /// </summary>
        Fatal = 5,
    }
}