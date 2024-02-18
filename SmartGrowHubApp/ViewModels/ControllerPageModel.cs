using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.ViewModels;

public class ControllerPageModel
{
    public ControllerPageModel()
    {
        Controller = new ControllerModel() { Id = "esp", Name = "ESP32" };
        Load();
    }

    public IEnumerable<SensorReading> SensorsReading { get; set; }

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
