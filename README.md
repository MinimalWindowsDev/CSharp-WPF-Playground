# SimpleWPFApp

A simple C# WPF project demonstrating a basic GUI application with MSBuild integration.

## Project Structure

```
SimpleWPFApp/
│
├── App.xaml
├── App.xaml.cs
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── SimpleWPFApp.csproj
├── build.bat
└── README.md
```

## Current State: Basic WPF GUI Application

The current state of the project is a simple WPF application with a button that updates a label when clicked. You can get to this state by checking out the `v0.2-wpf-gui` tag:

```
git checkout v0.2-wpf-gui
```

## Getting Started

### Prerequisites

- .NET Framework 4.0 or later
- MSBuild (typically included with .NET Framework)
- Git

### Building and Running the Project

1. Clone the repository:
   ```
   git clone https://github.com/MinimalWindowsDev/CSharp-WPF-Playground
   cd SimpleWPFApp
   ```
2. (Optional) Checkout the WPF GUI state:
   ```
   git checkout v0.2-wpf-gui
   ```
3. Run the build script:
   ```
   build.bat
   ```
   This will compile the project and run the application if the build is successful.

## Project Files

- `App.xaml` & `App.xaml.cs`: Define the application entry point
- `MainWindow.xaml` & `MainWindow.xaml.cs`: Define the main window UI and logic
- `SimpleWPFApp.csproj`: MSBuild project file for building the application
- `build.bat`: Batch script to build and run the application

## License

This project is licensed under the WTFPL - see the [LICENSE](https://en.wikipedia.org/wiki/WTFPL) for details.