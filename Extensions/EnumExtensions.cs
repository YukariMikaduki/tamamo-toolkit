using System.ComponentModel;
using System.Reflection;

namespace TamamoToolkit.Extensions
{
    /// <summary>
    /// <see cref="Enum"/> 扩展类
    /// </summary>
    public static class EnumExtensions
    {
        extension(Enum en)
        {
            /// <summary>
            /// 获取标注了 <see cref="DescriptionAttribute"/> 特性的枚举值的描述字符串
            /// </summary>
            /// <returns>描述字符串，若未标注 <see cref="DescriptionAttribute"/> 特性或特性字符串为空则返回枚举值字符串本身</returns>
            public string ToDescription()
            {
                string ret = en.ToString();
                var obj = en.GetType().GetField(ret)?.GetCustomAttribute<DescriptionAttribute>();
                if (obj is not null && !string.IsNullOrEmpty(obj.Description))
                {
                    ret = obj.Description;
                }
                return ret;
            }
        }
    }
}