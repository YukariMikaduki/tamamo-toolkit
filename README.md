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

## v2.4.0 更新内容

- 重构 `TamamoToolkit.Logger` 日志模块：
	- `LoggerFactory` 调整为线程安全单例，通过 `LoggerFactory.Instance` 获取唯一实例
	- 每个 `Logger` 使用独立的 NLog `LogFactory` 与 `LoggerConfig`，不再修改全局 NLog 配置，多个记录器的配置互不影响
	- 新增 `ILogger.Name`、`ILogger.Config` 和 `ILogger.UpdateConfig`，支持运行时更新指定日志记录器的配置
	- 新增 `LoggerFactory.UpdateLoggerConfig`，可按记录器名称动态更新其日志配置
	- 保留同名日志记录器的实例缓存，并补充参数校验与线程同步
- [NLog](https://www.nuget.org/packages/NLog) 包的依赖升级为6.1.4版本

## [更多更新历史](https://github.com/YukariMikaduki/tamamo-toolkit/blob/main/CHANGELOG.md)