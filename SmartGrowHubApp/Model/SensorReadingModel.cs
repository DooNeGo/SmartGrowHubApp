namespace SmartGrowHubApp.Model;

public enum SensorType
{
    Methane,
    Smoke,
    Hydrogen,
    AirTemperature,
    AirPressure,
    AirHumidity,
    PlantHeight,
    SoilAcidity,
    SoilMoisture,
    SoilTemperature,
    Illumination
}

public class SensorReadingModel
{
    public int SensorId { get; set; }

    public SensorType Type { get; set; }

    public double Value { get; set; }

    public string Unit { get; set; } = string.Empty;
}
