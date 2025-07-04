# Chaldea.Componets

[![Platforms](https://img.shields.io/badge/platform-net6.0_|_net8.0-blue.svg?logo=githubpages)](https://github.com/YukariMikaduki/Chaldea.Components)
[![NuGet Package](https://img.shields.io/nuget/v/Chaldea.Components.svg?logo=nuget)](https://www.nuget.org/packages/Chaldea.Components)
[![License](https://img.shields.io/github/license/YukariMikaduki/Chaldea.Components.svg?logo=github)](https://github.com/YukariMikaduki/Chaldea.Components/blob/main/LICENSE)

- [项目URL](https://github.com/YukariMikaduki/Chaldea.Components)
- [Nuget包](https://www.nuget.org/packages/Chaldea.Components)

## 自述  

此模块是为了方便日常开发工作而整合的工具集，包括但不限于：
- 简单的事件聚合器
	- `Chaldea.Components.Events` 命名空间
- 各类简化代码的扩展方法和数据模型
	- `Chaldea.Components.Extensions` 命名空间
	- `Chaldea.Components.Models` 命名空间
- [NLog](https://www.nuget.org/packages/NLog) 的包装调用：
	- `Chaldea.Components.Logger` 命名空间	

## v2.0.0 更新内容

- 将依赖于 Windows 环境的内容拆分到 [Chaldea.Components.Windows](https://www.nuget.org/packages/Chaldea.Components.Windows)，包括 `Chaldea.Components.DllImport` 命名空间和 `Chaldea.Components.Utils` 命名空间的所有类及方法
- [更新历史](https://github.com/YukariMikaduki/Chaldea.Components/blob/main/CHANGELOG.md)