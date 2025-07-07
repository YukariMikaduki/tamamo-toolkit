using System.ComponentModel;

namespace TamamoToolkit.Models
{
    /// <summary>
    /// 增强 <see cref="PropertyChangedEventArgs"/> 的功能，添加已更改属性的旧值和新值
    /// </summary>
    /// <param name="propertyName"><inheritdoc/></param>
    public class EnhancePropertyChangedEventArgs(string? propertyName) : PropertyChangedEventArgs(propertyName)
    {
        /// <summary>
        /// 属性更改后的新值
        /// </summary>
        public object? NewValue { get; set; }

        /// <summary>
        /// 属性更改前的旧值
        /// </summary>
        public object? OldValue { get; set; }

        /// <summary>
        /// <inheritdoc cref="EnhancePropertyChangedEventArgs"/>
        /// </summary>
        /// <param name="oldValue">属性更改前的旧值</param>
        /// <param name="newValue">属性更改后的新值</param>
        /// <param name="propertyName"><inheritdoc cref="EnhancePropertyChangedEventArgs(string)"/></param>
        public EnhancePropertyChangedEventArgs(object? oldValue, object? newValue, string? propertyName) : this(propertyName)
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }
    }
}