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