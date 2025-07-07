using System.ComponentModel;

namespace TamamoToolkit.Models
{
    /// <summary>
    /// 增强 <see cref="PropertyChangingEventArgs"/> 的功能，添加即将更改的属性的旧值和新值
    /// </summary>
    /// <param name="propertyName"><inheritdoc/></param>
    public class EnhancePropertyChangingEventArgs(string? propertyName) : PropertyChangingEventArgs(propertyName)
    {
        /// <summary>
        /// 即将更改的属性的新值
        /// </summary>
        public object? NewValue { get; set; }

        /// <summary>
        /// 即将更新的属性的旧值
        /// </summary>
        public object? OldValue { get; set; }

        /// <summary>
        /// <inheritdoc cref="EnhancePropertyChangingEventArgs"/>
        /// </summary>
        /// <param name="oldValue">即将更新的属性的旧值</param>
        /// <param name="newValue">即将更改的属性的新值</param>
        /// <param name="propertyName"><inheritdoc cref="EnhancePropertyChangingEventArgs(string)"/></param>
        public EnhancePropertyChangingEventArgs(object? oldValue, object? newValue, string? propertyName) : this(propertyName)
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }
    }
}