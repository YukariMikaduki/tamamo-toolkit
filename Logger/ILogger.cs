using System.Runtime.CompilerServices;

namespace TamamoToolkit.Logger
{
    /// <summary>
    /// 日志记录器接口
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// 记录Debug级日志
        /// </summary>
        /// <param name="msg">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Debug(string? msg, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Error级日志
        /// </summary>
        /// <param name="msg">日志显示的信息</param>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Error(string? msg, Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Error级日志
        /// </summary>
        /// <param name="msg">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Error(string? msg, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Error级日志
        /// </summary>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Error(Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Fatal级日志
        /// </summary>
        /// <param name="msg">日志显示的信息</param>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Fatal(string? msg, Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Fatal级日志
        /// </summary>
        /// <param name="msg">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Fatal(string? msg, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Fatal级日志
        /// </summary>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Fatal(Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Info级日志
        /// </summary>
        /// <param name="msg">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Info(string? msg, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Trace级日志
        /// </summary>
        /// <param name="msg">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Trace(string? msg, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Warn级日志
        /// </summary>
        /// <param name="msg">日志显示的信息</param>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Warn(string? msg, Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Warn级日志
        /// </summary>
        /// <param name="ex">错误实例</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Warn(Exception? ex, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");

        /// <summary>
        /// 记录Warn级日志
        /// </summary>
        /// <param name="msg">日志显示的信息</param>
        /// <param name="filePath">调用成员路径</param>
        /// <param name="memberName">调用成员名</param>
        void Warn(string? msg, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "");
    }
}