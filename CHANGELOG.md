## v2.4.0 更新内容

- 重构 `TamamoToolkit.Logger` 日志模块：
	- `LoggerFactory` 调整为线程安全单例，通过 `LoggerFactory.Instance` 获取唯一实例
	- 每个 `Logger` 使用独立的 NLog `LogFactory` 与 `LoggerConfig`，不再修改全局 NLog 配置，多个记录器的配置互不影响
	- 新增 `ILogger.Name`、`ILogger.Config` 和 `ILogger.UpdateConfig`，支持运行时更新指定日志记录器的配置
	- 新增 `LoggerFactory.UpdateLoggerConfig`，可按记录器名称动态更新其日志配置
	- 保留同名日志记录器的实例缓存，并补充参数校验与线程同步
- [NLog](https://www.nuget.org/packages/NLog) 包的依赖升级为6.1.4版本

## v2.3.0 更新内容

- IEnumerable扩展方法新增：
	- 对每个元素执行异步等待操作
- 部分注释错别字修改

## v2.2.0 更新内容

- 数组扩展方法新增及重构：
	- 优化了 `Clear` 和 `Fill` 方法的性能表现
	- `Fill` 方法新增对 `Func<T>` 委托的支持

## v2.1.0 更新内容

- [NLog](https://www.nuget.org/packages/NLog) 包的依赖升级为6.0.5版本
- 修改了日志输出的 Exception 字符串拼接布局

## v2.0.1 更新内容

- 项目正式更名为 **TamamoToolkit**，所有命名空间均已调整
	- Chaldea.Components -> TamamoToolkit
	- Chaldea.Components.Events -> TamamoToolkit.Events
	- Chaldea.Components.Extensions -> TamamoToolkit.Extensions
	- Chaldea.Components.Models -> TamamoToolkit.Models
	- Chaldea.Components.Logger -> TamamoToolkit.Logger

## v2.0.0 更新内容

- 将依赖于 Windows 环境的内容拆分到 [Chaldea.Components.Windows](https://www.nuget.org/packages/Chaldea.Components.Windows)，包括 `Chaldea.Components.DllImport` 命名空间和 `Chaldea.Components.Utils` 命名空间的所有类及方法

## v1.9.5 更新内容

- 修改了事件聚合器的运作模式，现在更简洁稳定了

## v1.9.4 更新内容

- 添加了新的扩展方法：
	- 检查对象是否在某个枚举中已定义，并返回相应的枚举值

## v1.9.3.2 更新内容

- 一些自述文件及项目程序集描述的修改，以更好地符合Nuget包管理标准

## v1.9.3.1 更新内容

- 添加了英文自述文件

## v1.9.3 更新内容

- 重写了自述文件
- NLog包的依赖升级为5.5.0版本
- 日志模块增加了配置控制
- 修改了日志输出的字符串布局
- 新增了支持可空模式
- 添加新的数据模型：
	- 百分数

## v1.9.2 及更早的更新内容

- 参见源代码提交历史
