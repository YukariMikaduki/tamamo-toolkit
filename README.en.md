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

## v2.2.0 Update Details

- Added and refactored array extension methods:
    - Optimized performance for the `Clear` and `Fill` methods
    - Added support for the `Func<T>` delegate to the `Fill` method

## [More Changelog](https://github.com/YukariMikaduki/tamamo-toolkit/blob/main/CHANGELOG.en.md)