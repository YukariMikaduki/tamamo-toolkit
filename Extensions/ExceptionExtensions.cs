namespace TamamoToolkit.Extensions
{
    /// <summary>
    /// <see cref="Exception"/> 扩展类
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        /// 将 <see cref="Exception"/> 拼接成可显示的字符串
        /// <para>
        /// 包含 <see cref="Exception.Message"/>、 <see cref="Exception.StackTrace"/> 和 <see cref="Exception.InnerException"/>
        /// </para>
        /// </summary>
        /// <param name="ex"><see cref="Exception"/> 实例</param>
        /// <returns>拼接后的字符串</returns>
        public static string JoinWithInner(this Exception? ex)
        {
            return ex is null
                ? "Null"
                : $"Exception: {(string.IsNullOrWhiteSpace(ex.Message) ? "Null" : ex.Message)} | StackTrace: {(string.IsNullOrWhiteSpace(ex.StackTrace) ? "Null" : ex.Message)} | InnerException: < {ex.InnerException.JoinWithInner()} >";
        }
    }
}