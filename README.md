# OpenUI

**OpenUI** is a lightweight C# library for building modern, interactive graphical user interfaces with simplicity and flexibility.

## Installation

OpenUI is available via `NuGet`. To install the latest version of OpenUI, simply run the following command:

```bat
Install-Package OpenUI
```

Once installed, you can import the library into your C# code to start creating your GUI applications.

📜 Quick Start

Here’s a quick example that demonstrates how to create a window:

```cs
using OpenUI;

public static class Program
{
    public static void Main(string[] args)
    {
        var window = new GameWindow(800, 600, "Simpile Example");
        window.Show();
    }
}
```
