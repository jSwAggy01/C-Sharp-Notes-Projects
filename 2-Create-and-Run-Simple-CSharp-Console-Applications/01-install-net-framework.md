# Install and Configure Visual Studio Code

Some optimizations for the VSCode IDE.

## Installing Visual Studio Code

If you need help installing VSCode, there are plenty of resources online that optimize it for your specific programming language. I've had it installed since university so I'm going to gloss over this portion.

## Installing the .NET SDK

One of the major differneces in what separates C# from C++ is the fact that C# code must be compiled to an intermediate language (IL) code. And so, in order to do this it must utilize the compilers of the .NET SDK (software development kit) framework. Whereas C++ gets directly compiled to machine code, relative to the target platform (Windows, macOS, Linux, etc).

To check if you already have it installed, run: `dotnet --version`.

To install the latest version, go to https://dotnet.microsoft.com/download.

## Extensions for C#

Install the following:
- **C# Dev Kit** - Official C# extension from Microsoft.
    - **C#** - Base language support for C#.
    - **IntelliCode for C#** - AI-assisted development for C# Dev Kit.
    - **.NET Install Tool for Extension Authors**.

**Note**: `C# Dev Kit` usually installs the other three automatically. I however, had to manually install the `.NET Install Tool for Extension Authors`.

## Building and Running

In C++, we compile source files to generate executables and then run them directly without any intermediate translation. In C# however, the source files get compiled to IL code, which must then be translated to machine code by the .NET Framework during runtime, which can then be executed by a target platform that supports .NET.

Here's a recap:

- **C++**:
    - **Compilation**: source code -> machine code (platform-specific)
    - **Runtime**: Operating system
    - **Execution**: Machine code
        - Runs on the CPU, managed by the OS

- **C#**:
    - **Compilation**: Source code -> IL code (platform-independent)
    - **Runtime**: .NET runtime
    - **Execution**: IL code -> machine code via JIT compiler
        - Runs on the CPU, managed by the .NET runtime

And so, we start by creating a console application in a specified folder.
```cs
dotnet new console -o ./CsharpProjects/TestProject
```

Then, we compile it.
```cs
dotnet build
```

Finally, we run our application.
```cs
dotnet run
```

**Note**: The `.NET SDK` is the tool that enables .NET command line interface commands.