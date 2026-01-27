# TamamoToolkit

[![Platforms](https://img.shields.io/badge/platform-net6.0_|_net8.0-blue.svg?logo=githubpages)](https://github.com/YukariMikaduki/tamamo-toolkit)
[![NuGet Package](https://img.shields.io/nuget/v/TamamoToolkit.svg?logo=nuget)](https://www.nuget.org/packages/TamamoToolkit)
[![License](https://img.shields.io/github/license/YukariMikaduki/tamamo-toolkit.svg?logo=github)](https://github.com/YukariMikaduki/tamamo-toolkit/blob/main/LICENSE)

- [项目URL](https://github.com/YukariMikaduki/tamamo-toolkit)
- [Nuget包](https://www.nuget.org/packages/TamamoToolkit)

## 自述  

此项目是为了方便日常开发工作而整合的工具集，包括但不限于：
- 简单的事件聚合器
	- `TamamoToolkit.Events` 命名空间
- 各类简化代码的扩展方法和数据模型
	- `TamamoToolkit.Extensions` 命名空间
	- `TamamoToolkit.Models` 命名空间
- [NLog](https://www.nuget.org/packages/NLog) 的包装调用：
	- `TamamoToolkit.Logger` 命名空间	

## v2.2.0 更新内容

- 数组扩展方法新增及重构：
	- 优化了 `Clear` 和 `Fill` 方法的性能表现
	- `Fill` 方法新增对 `Func<T>` 委托的支持

## [更多更新历史](https://github.com/YukariMikaduki/tamamo-toolkit/blob/main/CHANGELOG.md)