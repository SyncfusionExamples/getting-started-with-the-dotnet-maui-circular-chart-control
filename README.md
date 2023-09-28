# Getting Started with the .NET MAUI Circular Chart Control
Syncfusion .NET MAUI Charts (SfCircularChart) is used to create the chart with beautiful and enhanced UI visualization of data that are used in high-quality .NET MAUI applications.
* **Chart types** - Supports two types of series such as pie and doughnut. Each series presents data in a unique way and it is designed to be more user-friendly.

* **User interaction** - The circular chart selection, tooltips, and explode user interaction features significantly improves the end-user experience.

* **Legends** - Display additional information about the data points of chart series.

* **Dynamic update** - Updates the chart dynamically or lazily with live data that changes over seconds or minutes.
  
A quick start .NET MAUI project that shows how to create and configure the Syncfusion MAUI Circular Chart. This project also includes a code snippet to bind data objects to it, explode each segment, customize selection behavior, render doughnut chart type, and enable a few of its interactive features like data labels, legends, and tooltips.

Documentation: https://help.syncfusion.com/maui/circular-charts/getting-started 

## Project pre-requisites

Make sure that you have the compatible versions of Visual Studio with .NET MAUI workloads and .NET SDK version in your machine before starting to work on this project.

## How to run this application?

To run this application, you need to first clone the getting-started-with-the-dotnet-maui-circular-chart-control repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## Creating an application using the .NET MAUI chart
* Create a new .NET MAUI application in Visual Studio.
* Syncfusion .NET MAUI components are available in nuget.org. To add SfCircularChart to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Charts and then install it.
* To initialize the control, import the Chart namespace.
* Initialize SfCircularChart.

```XAML
<ContentPage   
    . . .
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <chart:SfCircularChart/>
</ContentPage>
```

## Register the handler
Syncfusion.Maui.Core nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

```XAML
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace ChartGettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}
```

![image](https://github.com/SuryaKaran2143/getting-started-with-the-dotnet-maui-circular-chart-control/assets/113962276/81f55193-5ab7-4f28-a64a-4f67c87f4544)
