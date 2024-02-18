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
    [JsonInclude]
    [JsonPropertyName("Components")]
    private readonly List<Component> _components = [];

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SettingType Type { get; init; }

    public IEnumerable<Component> Components => _components;

    public Setting AddComponent(Component component)
    {
        _components.Add(component);

        return this;
    }
}
