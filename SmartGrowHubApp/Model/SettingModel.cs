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
}

public class SettingModel
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SettingType Type { get; init; }

    public IEnumerable<ComponentModel> Components { get; set; } = [];

    public SettingModel AddComponent(ComponentModel component)
    {
        Components = Components.Append(component);

        return this;
    }
}
