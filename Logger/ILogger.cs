using System.Runtime.CompilerServices;

namespace TamamoToolkit.Logger
{
    /// <summary>
    /// 日志记录器接口
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// 日志配置
        /// </summary>
        LoggerConfig Config { get; }

        /// <summary>
        /// 日志记录器名称
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 记录 Debug 级日志
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Debug(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录 Error 级日志
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Error(string? message, Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录 Error 级日志
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Error(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录 Error 级日志
        /// </summary>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Error(Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录 Fatal 级日志
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Fatal(string? message, Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录 Fatal 级日志
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Fatal(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录 Fatal 级日志
        /// </summary>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Fatal(Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录 Info 级日志
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Info(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录 Trace 级日志
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Trace(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 更新日志配置
        /// </summary>
        /// <param name="newConfig">新的日志配置</param>
        void UpdateConfig(LoggerConfig newConfig);

        /// <summary>
        /// 记录 Warn 级日志
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Warn(string? message, Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录 Warn 级日志
        /// </summary>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Warn(Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录 Warn 级日志
        /// </summary>
        /// <param name="message">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Warn(string? message, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");
    }
}