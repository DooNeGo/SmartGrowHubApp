using System.Text.Json.Serialization;

namespace SmartGrowHubApp.Model;

public enum SettingMode
{
    Off,
    On,
    Auto
}

public enum SettingType
{
    Watering,
    DayLighting,
    UVLighting,
    Heating,
    Cooling,
    AirHumidification,
    PreferAirTemperature,
    PreferAirHumidity,
    PreferIllumination
}

public class Setting
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SettingType Type { get; init; }

    public IEnumerable<Component> Components { get; set; } = [];

    public Setting AddComponent(Component component)
    {
        Components = Components.Append(component);

        return this;
    }
}
