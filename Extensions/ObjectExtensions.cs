namespace TamamoToolkit.Extensions
{
    /// <summary>
    /// <see cref="object"/> 扩展类
    /// </summary>
    public static class ObjectExtensions
    {
        extension(object value)
        {
            /// <summary>
            /// 检查 <paramref name="value"/> 是否为 <typeparamref name="TEnum"/> 中所定义的枚举项
            /// </summary>
            /// <typeparam name="TEnum">枚举类型</typeparam>
            /// <param name="value">要检查的值</param>
            /// <param name="enumValue">
            /// 如果 <paramref name="value"/> 已在 <typeparamref name="TEnum"/> 中定义，则 <paramref
            /// name="enumValue"/> 为转换后的枚举项，否则为 0
            /// </param>
            /// <returns>
            /// 如果 <paramref name="value"/> 已在 <typeparamref name="TEnum"/> 中定义，则返回 <see
            /// langword="true"/>，否则返回 <see langword="false"/>
            /// </returns>
            public bool IsEnumDefined<TEnum>(out TEnum enumValue) where TEnum : struct, Enum
            {
                enumValue = default;
                try
                {
                    if (Enum.IsDefined(typeof(TEnum), value))
                    {
                        enumValue = (TEnum)value;
                        return true;
                    }
                }
                catch
                {
                }
                return false;
            }
        }
    }
}