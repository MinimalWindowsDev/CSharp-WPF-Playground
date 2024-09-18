# CSharp-WPF-Playground

A simple C# WPF project demonstrating console, build automation, and MVVM patterns.

## Project Structure

1. Console Application: "Hello World" C# console app
2. Build Automation: Command-line compilation and cmd batch script
3. VS Code Integration: Workspace setup, debugging, and build tasks (coming soon)
4. WPF GUI: Simple MVVM implementation (coming soon)

## Current State: Hello World Console App

The current state of the project is a simple "Hello World" console application with a build script. You can get to this state by checking out the `v0.1-hello-world` tag:

```
git checkout v0.1-hello-world
```

### Project Structure at v0.1-hello-world

```
.gitignore
build/ (created by build script)
build.bat
Program.cs
README.md
```

## Getting Started

### Prerequisites

- .NET Framework (for csc.exe)
- Git

### Building the Project

1. Clone the repository:
   ```
   git clone https://github.com/MinimalWindowsDev/CSharp-WPF-Playground
   cd CSharp-WPF-Playground
   ```
2. (Optional) Checkout the Hello World state:
   ```
   git checkout v0.1-hello-world
   ```
3. Run the build script:
   ```
   build.bat
   ```
4. Run the compiled program:
   ```
   build\HelloWorld.exe
   ```

## Upcoming Features

- VS Code Integration: Workspace setup, debugging, and build tasks
- WPF GUI: Simple MVVM implementation

## License

This project is licensed under the WTFPL - see the [LICENSE](https://en.wikipedia.org/wiki/WTFPL) for details.