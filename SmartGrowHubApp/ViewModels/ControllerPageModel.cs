using CommunityToolkit.Mvvm.ComponentModel;
using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.ViewModels;

public partial class ControllerPageModel : ObservableObject
{
    [ObservableProperty]
    private IEnumerable<SensorReading> _sensorsReading = [];

    public ControllerPageModel()
    {
        Controller = new ControllerModel() { Id = "esp", Name = "SmartGrowHub" };
        Load();
    }

    public ControllerModel Controller { get; }

    private void Load()
    {
        SensorsReading =
        [
            new SensorReading() { SensorId = 1, Type = SensorType.Methane, Value = 1500, Unit = "ppm"},
            new SensorReading() { SensorId = 1, Type = SensorType.Smoke, Value = 500, Unit = "ppm" },
            new SensorReading() { SensorId = 1, Type = SensorType.Hydrogen, Value = 400, Unit = "ppm" },
            new SensorReading() { SensorId = 2, Type = SensorType.AirTemperature, Value = 25.3, Unit = "C" },
            new SensorReading() { SensorId = 2, Type = SensorType.AirPressure, Value = 101.2, Unit = "kPa" },
        ];
    }
}
