# TamamoToolkit

[![Platforms](https://img.shields.io/badge/platform-net6.0_|_net8.0-blue.svg?logo=githubpages)](https://github.com/YukariMikaduki/tamamo-toolkit)
[![NuGet Package](https://img.shields.io/nuget/v/TamamoToolkit.svg?logo=nuget)](https://www.nuget.org/packages/TamamoToolkit)
[![License](https://img.shields.io/github/license/YukariMikaduki/tamamo-toolkit.svg?logo=github)](https://github.com/YukariMikaduki/tamamo-toolkit/blob/main/LICENSE)

- [Project URL](https://github.com/YukariMikaduki/tamamo-toolkit)
- [NuGet Package](https://www.nuget.org/packages/TamamoToolkit)

## README  

This project is a collection of utilities integrated to facilitate daily development work, including but not limited to:
- Simple event aggregator
	- `TamamoToolkit.Events` namespace
- Various extension methods and data models for code simplification
	- `TamamoToolkit.Extensions` namespace
	- `TamamoToolkit.Models` namespace
- Wrapper calls for [NLog](https://www.nuget.org/packages/NLog):
	- `TamamoToolkit.Logger` namespace

## v2.4.0 Update Details

- Refactored the `TamamoToolkit.Logger` logging module:
	- Converted `LoggerFactory` into a thread-safe singleton, accessed through `LoggerFactory.Instance`
	- Each `Logger` now uses its own NLog `LogFactory` and `LoggerConfig`, avoiding global NLog configuration changes and configuration interference between loggers
	- Added `ILogger.Name`, `ILogger.Config`, and `ILogger.UpdateConfig` to support runtime configuration updates for a specific logger
	- Added `LoggerFactory.UpdateLoggerConfig` to update a logger's configuration by name
	- Retained same-name logger caching and added argument validation and synchronization
- Upgraded the dependency of the [NLog](https://www.nuget.org/packages/NLog) package to version 6.1.4

## [More Changelog](https://github.com/YukariMikaduki/tamamo-toolkit/blob/main/CHANGELOG.en.md)