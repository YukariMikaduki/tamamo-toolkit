using NLog;
using NLog.Common;
using NLog.Config;
using NLog.Targets;
using NLogLevel = NLog.LogLevel;

namespace TamamoToolkit.Logger
{
    /// <summary>
    /// 日志配置
    /// </summary>
    /// <param name="minLevel">最小输出日志等级</param>
    /// <param name="layout">日志布局</param>
    /// <param name="fileName">日志文件名</param>
    /// <param name="archiveFileName">日志存档文件名</param>
    public class LoggerConfig(LogLevel minLevel = LogLevel.Info,
                              string layout = "${longdate} | ${level:uppercase=true:padding=-5} | Thread ${threadid:padding=-3} | ${message}",
                              string fileName = "${baseDir}/Log/${logger}-${shortdate}.log",
                              string archiveFileName = "${baseDir}/Log/archive/${logger}-${shortdate}-{#####}.log")
    {
        /// <summary>
        /// 日志存档文件名
        /// <para>默认为 ${baseDir}/Log/archive/${logger}-${shortdate}-{#####}.log</para>
        /// </summary>
        //// <remarks>参见 <see href="https://nlog-project.org/config/?tab=layout-renderers"/></remarks>
        public string ArchiveFileName { get; } = archiveFileName;

        /// <summary>
        /// 日志文件名
        /// <para>默认为 ${baseDir}/Log/${logger}-${shortdate}.log</para>
        /// </summary>
        //// <remarks>参见 <see href="https://nlog-project.org/config/?tab=layout-renderers"/></remarks>
        public string FileName { get; } = fileName;

        /// <summary>
        /// 日志布局
        /// <para>
        /// 默认为 ${longdate} | ${level:uppercase=true:padding=-5} | Thread ${threadid:padding=-3} |
        /// ${message} ${threadid}${newline}[Message] ${message}${newline}
        /// </para>
        /// </summary>
        /// <remarks>参见 <see href="https://nlog-project.org/config/?tab=layout-renderers"/></remarks>
        public string Layout { get; } = layout;

        /// <summary>
        /// 最小输出日志等级
        /// <para>默认为 <see cref="LogLevel.Info"/></para>
        /// </summary>
        public LogLevel MinLevel { get; } = minLevel;

        internal LoggerConfig() : this(LogLevel.Info)
        {
            UpdateConfig();
        }

        internal void UpdateConfig()
        {
            LogManager.ThrowExceptions = false;
            InternalLogger.LogLevel = NLogLevel.Off;
            InternalLogger.LogFile = @"C:\temp\nlog-internal.log";
            var config = new LoggingConfiguration();
            var logfile = new FileTarget("logfile")
            {
                Layout = this.Layout,
                FileName = this.FileName,
                ArchiveFileName = this.ArchiveFileName,
                ArchiveEvery = FileArchivePeriod.Sunday,
                ArchiveAboveSize = 209715200,
                KeepFileOpen = true,
                OpenFileCacheTimeout = 30,
            };
            config.AddRule(this.MinLevel.ToNLogLevel(), NLogLevel.Fatal, logfile);
            LogManager.Configuration = config;
        }
    }
}