using System.Diagnostics;

namespace Chaldea.Components.Extensions
{
    /// <summary>
    /// <see cref="Process"/> 扩展类
    /// </summary>
    public static class ProcessExtensions
    {
        /// <summary>
        /// 尝试获取 <see cref="Process"/> 的主窗体句柄
        /// </summary>
        /// <param name="process">要获取主窗体句柄的进程</param>
        /// <param name="timeout">超时时间，单位：毫秒</param>
        /// <param name="mainwindowHandle">主窗体句柄，若获取失败，则为 <see cref="IntPtr.Zero"/></param>
        /// <returns>获取成功，则返回 <see langword="true"/>，否则返回 <see langword="false"/></returns>
        public static bool TryGetMainwindowHandle(this Process process, int timeout, out nint mainwindowHandle)
        {
            bool ret = false;
            mainwindowHandle = IntPtr.Zero;
            if (process is null)
            {
                return ret;
            }
            if (Task.WaitAny([Task.Run(() =>
            {
                while (true)
                {
                    if (process.MainWindowHandle != IntPtr.Zero)
                    {
                        break;
                    }
                    Thread.Sleep(10);
                }
            })], timeout) != -1)
            {
                ret = true;
                mainwindowHandle = process.MainWindowHandle;
            }
            return ret;
        }
    }
}