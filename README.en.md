# Chaldea.Components

[![Platforms](https://img.shields.io/badge/platform-net6.0_|_net8.0-blue.svg?logo=githubpages)](https://github.com/YukariMikaduki/Chaldea.Components)
[![NuGet Package](https://img.shields.io/nuget/v/Chaldea.Components.svg?logo=nuget)](https://www.nuget.org/packages/Chaldea.Components)
[![License](https://img.shields.io/github/license/YukariMikaduki/Chaldea.Components.svg?logo=github)](https://github.com/YukariMikaduki/Chaldea.Components/blob/main/LICENSE)

- [Project URL](https://github.com/YukariMikaduki/Chaldea.Components)
- [NuGet Package](https://www.nuget.org/packages/Chaldea.Components)

## README  

This module is a collection of utilities integrated to facilitate daily development work, including but not limited to:
- Simple event aggregator
	- `Chaldea.Components.Events` namespace
- Various extension methods and data models for code simplification
	- `Chaldea.Components.Extensions` namespace
	- `Chaldea.Components.Models` namespace
- Wrapper calls for [NLog](https://www.nuget.org/packages/NLog):
	- `Chaldea.Components.Logger` namespace

## v2.0.0 Update Details

- Migrated Windows-specific features to separate package [Chaldea.Components.Windows](https://www.nuget.org/packages/Chaldea.Components.Windows), encompassing entire `Chaldea.Components.DllImport` and `Chaldea.Components.Utils` namespaces.
- [Changelog](https://github.com/YukariMikaduki/Chaldea.Components/blob/main/CHANGELOG.en.md)