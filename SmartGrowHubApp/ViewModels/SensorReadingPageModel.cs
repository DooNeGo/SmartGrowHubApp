using CommunityToolkit.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using Microcharts;
using SkiaSharp;
using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.ViewModels;

public partial class SensorReadingPageModel : ObservableObject
{
    private readonly ControllerModel _controllerModel;

    [ObservableProperty]
    private ChartEntry[] _entries = [];

    public SensorReadingPageModel(ControllerPageModel controllerPageModel)
    {
        Guard.IsNotNull(controllerPageModel.SelectedItem, nameof(ControllerPageModel.SelectedItem));

        _controllerModel = controllerPageModel.Controller;
        SensorReading = controllerPageModel.SelectedItem;
        Load();
    }

    public SensorReading SensorReading { get; }

    private void Load()
    {
        SKColor color = SKColor.Parse("FFFFFF");

        Entries =
        [
            new ChartEntry(100) { ValueLabel = "100", ValueLabelColor = color, Color = color },
            new ChartEntry(220) { ValueLabel = "220", ValueLabelColor = color, Color = color },
            new ChartEntry(200) { ValueLabel = "200", ValueLabelColor = color, Color = color },
            new ChartEntry(210) { ValueLabel = "210", ValueLabelColor = color, Color = color },
            new ChartEntry(150) { ValueLabel = "150", ValueLabelColor = color, Color = color },
            new ChartEntry(180) { ValueLabel = "180", ValueLabelColor = color, Color = color },
            new ChartEntry(100) { ValueLabel = "100", ValueLabelColor = color, Color = color },
            new ChartEntry(220) { ValueLabel = "220", ValueLabelColor = color, Color = color },
            new ChartEntry(200) { ValueLabel = "200", ValueLabelColor = color, Color = color },
            new ChartEntry(210) { ValueLabel = "210", ValueLabelColor = color, Color = color },
            new ChartEntry(150) { ValueLabel = "150", ValueLabelColor = color, Color = color },
            new ChartEntry(180) { ValueLabel = "180", ValueLabelColor = color, Color = color },
            new ChartEntry(100) { ValueLabel = "100", ValueLabelColor = color, Color = color },
            new ChartEntry(220) { ValueLabel = "220", ValueLabelColor = color, Color = color },
            new ChartEntry(200) { ValueLabel = "200", ValueLabelColor = color, Color = color },
            new ChartEntry(210) { ValueLabel = "210", ValueLabelColor = color, Color = color },
            new ChartEntry(150) { ValueLabel = "150", ValueLabelColor = color, Color = color },
            new ChartEntry(180) { ValueLabel = "180", ValueLabelColor = color, Color = color },
            new ChartEntry(100) { ValueLabel = "100", ValueLabelColor = color, Color = color },
            new ChartEntry(220) { ValueLabel = "220", ValueLabelColor = color, Color = color },
            new ChartEntry(200) { ValueLabel = "200", ValueLabelColor = color, Color = color },
            new ChartEntry(210) { ValueLabel = "210", ValueLabelColor = color, Color = color },
            new ChartEntry(150) { ValueLabel = "150", ValueLabelColor = color, Color = color },
            new ChartEntry(180) { ValueLabel = "180", ValueLabelColor = color, Color = color },
            new ChartEntry(100) { ValueLabel = "100", ValueLabelColor = color, Color = color },
            new ChartEntry(220) { ValueLabel = "220", ValueLabelColor = color, Color = color },
            new ChartEntry(200) { ValueLabel = "200", ValueLabelColor = color, Color = color },
            new ChartEntry(210) { ValueLabel = "210", ValueLabelColor = color, Color = color },
            new ChartEntry(150) { ValueLabel = "150", ValueLabelColor = color, Color = color },
            new ChartEntry(180) { ValueLabel = "180", ValueLabelColor = color, Color = color },
        ];
    }
}
