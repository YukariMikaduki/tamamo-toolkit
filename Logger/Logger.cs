using NLog;
using System.Runtime.CompilerServices;
using TamamoToolkit.Extensions;

namespace TamamoToolkit.Logger
{
    /// <summary>
    /// <see cref="ILogger"/> 接口的一个实现，可以继承此类以扩展功能
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// <see cref="logger"/> 对应的日志记录器工厂
        /// </summary>
        protected readonly LogFactory logFactory;

        /// <summary>
        /// 使用 NLog 实现的日志记录器
        /// </summary>
        protected readonly NLog.Logger logger;

        /// <inheritdoc/>
        public LoggerConfig Config { get; private set; }

        /// <inheritdoc/>
        public string Name => this.logger.Name;

        /// <summary>
        /// 初始化一个 <see cref="Logger"/> 的新实例
        /// </summary>
        /// <param name="loggerName">日志记录器名称</param>
        /// <param name="config">日志配置</param>
        public Logger(string loggerName, LoggerConfig config)
        {
            this.Config = config;
            this.logFactory = new LogFactory()
            {
                Configuration = config.CreateNLogConfiguration(loggerName),
            };
            this.logger = this.logFactory.GetLogger(loggerName);
        }

        /// <summary>
        /// 记录 Debug 级日志的内部实现
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        protected virtual void InnerDebug(string? message, string filePath, string memberName)
        {
            string className = filePath.Split('\\')[^1];
            this.logger.Debug($"Class: {className} | Method: {memberName} | Message: {(string.IsNullOrWhiteSpace(message) ? "Null" : message)}");
        }

        /// <summary>
        /// 记录 Error 级日志的内部实现
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        protected virtual void InnerError(string? message, Exception? ex, string filePath, string memberName)
        {
            string className = filePath.Split('\\')[^1];
            if (ex is null)
            {
                this.logger.Error($"Class: {className} | Method: {memberName} | Message: {(string.IsNullOrWhiteSpace(message) ? "Null" : message)}");
            }
            else
            {
                this.logger.Error($"Class: {className} | Method: {memberName} | Message: {(string.IsNullOrWhiteSpace(message) ? "Null" : message)} | {ex.JoinWithInner()}");
            }
        }

        /// <summary>
        /// 记录 Fatal 级日志的内部实现
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        protected virtual void InnerFatal(string? message, Exception? ex, string filePath, string memberName)
        {
            string className = filePath.Split('\\')[^1];
            if (ex is null)
            {
                this.logger.Fatal($"Class: {className} | Method: {memberName} | Message: {(string.IsNullOrWhiteSpace(message) ? "Null" : message)}");
            }
            else
            {
                this.logger.Fatal($"Class: {className} | Method: {memberName} | Message: {(string.IsNullOrWhiteSpace(message) ? "Null" : message)} | {ex.JoinWithInner()}");
            }
        }

        /// <summary>
        /// 记录 Info 级日志的内部实现
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        protected virtual void InnerInfo(string? message, string filePath, string memberName)
        {
            string className = filePath.Split('\\')[^1];
            this.logger.Info($"Class: {className} | Method: {memberName} | Message: {(string.IsNullOrWhiteSpace(message) ? "Null" : message)}");
        }

        /// <summary>
        /// 记录 Trace 级日志的内部实现
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        protected virtual void InnerTrace(string? message, string filePath, string memberName)
        {
            string className = filePath.Split('\\')[^1];
            this.logger.Trace($"Class: {className} | Method: {memberName} | Message: {(string.IsNullOrWhiteSpace(message) ? "Null" : message)}");
        }

        /// <summary>
        /// 记录 Warn 级日志的内部实现
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        protected virtual void InnerWarn(string? message, Exception? ex, string filePath, string memberName)
        {
            string className = filePath.Split('\\')[^1];
            if (ex is null)
            {
                this.logger.Warn($"Class: {className} | Method: {memberName} | Message: {(string.IsNullOrWhiteSpace(message) ? "Null" : message)}");
            }
            else
            {
                this.logger.Warn($"Class: {className} | Method: {memberName} | Message: {(string.IsNullOrWhiteSpace(message) ? "Null" : message)} | {ex.JoinWithInner()}");
            }
        }

        #region ILogger接口

        /// <inheritdoc/>
        public void Debug(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerDebug(message, filePath, memberName);
        }

        /// <inheritdoc/>
        public void Error(string? message, Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerError(message, ex, filePath, memberName);
        }

        /// <inheritdoc/>
        public void Error(Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerError("", ex, filePath, memberName);
        }

        /// <inheritdoc/>
        public void Error(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerError(message, null, filePath, memberName);
        }

        /// <inheritdoc/>
        public void Fatal(string? message, Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerFatal(message, ex, filePath, memberName);
        }

        /// <inheritdoc/>
        public void Fatal(Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerFatal("", ex, filePath, memberName);
        }

        /// <inheritdoc/>
        public void Fatal(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerFatal(message, null, filePath, memberName);
        }

        /// <inheritdoc/>
        public void Info(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerInfo(message, filePath, memberName);
        }

        /// <inheritdoc/>
        public void Trace(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerTrace(message, filePath, memberName);
        }

        /// <inheritdoc/>
        public void UpdateConfig(LoggerConfig newConfig)
        {
            this.Config = newConfig;
            this.logFactory.Configuration = newConfig.CreateNLogConfiguration(this.Name);
        }

        /// <inheritdoc/>
        public void Warn(string? message, Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerWarn(message, ex, filePath, memberName);
        }

        /// <inheritdoc/>
        public void Warn(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerWarn(message, null, filePath, memberName);
        }

        /// <inheritdoc/>
        public void Warn(Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "")
        {
            InnerWarn("", ex, filePath, memberName);
        }

        #endregion ILogger接口
    }
}