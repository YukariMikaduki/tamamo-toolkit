namespace TamamoToolkit.Extensions
{
    /// <summary>
    /// <see cref="Exception"/> 扩展类
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <param name="ex"><see cref="Exception"/> 实例</param
        extension(Exception? ex)
        {
            /// <summary>
            /// 将 <see cref="Exception"/> 拼接成可显示的字符串
            /// <para>
            /// 包含 <see cref="Exception.Message"/>、 <see cref="Exception.GetBaseException()"/> 的
            /// <see cref="Exception.Message"/> 和 <see cref="Exception.StackTrace"/>
            /// </para>
            /// </summary>
            /// <returns>拼接后的字符串</returns>
            public string JoinWithInner()
            {
                if (ex is null)
                {
                    return "Null";
                }
                else
                {
                    var baseEx = ex.GetBaseException();
                    return $"BaseMessage: {(string.IsNullOrWhiteSpace(baseEx.Message) ? "Null" : baseEx.Message)} | StackTrace: {Environment.NewLine}{(string.IsNullOrWhiteSpace(baseEx.StackTrace) ? "Null" : baseEx.StackTrace)}";
                }
            }
        }
    }
}