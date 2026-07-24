<div align="center">

[![Superfighters Deluxe Logo](https://raw.githubusercontent.com/MythoFame/.github/refs/heads/master/assets/SFD_titleLoop.gif)](https://store.steampowered.com/app/855860)

# Superfighters Deluxe Templates

.NET templates for Superfighters Deluxe development

[![GitHub License](https://img.shields.io/github/license/dsafxP/SFD.Templates)](LICENSE)

</div>

## 🚀 Installation

Install the templates on your machine:

```sh
dotnet new install SFDScript
```

To uninstall them later:

```sh
dotnet new uninstall SFDScript
```

## 🌱 Templates

### SFDScript

This template creates a project for developing Superfighters Deluxe Extension Scripts. It provides an environment that closely matches the in-game script editor while allowing you to build a deployable `*.txt` script from the command line. It includes the tools from [SFD.ScriptTools](https://github.com/dsafxP/SFD.ScriptTools) required to do this.

Because `SFD.GameScriptInterface.dll` is proprietary, it cannot be included with the template.

Instead, use the copy from your Superfighters Deluxe installation by running:

```sh
dotnet fsi tools/SFD.ScriptTools.LibrarySetup.fsx
```

This script creates a symbolic link to the DLL and automatically adds it to `.gitignore` to prevent it from being committed accidentally.

To generate the final `*.txt` script, run:

```sh
dotnet build -t:GenerateScript
```

The generated script is written to the project's default output directory.
