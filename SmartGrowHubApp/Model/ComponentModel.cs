using System.Text.Json.Serialization;

namespace SmartGrowHubApp.Model;

public enum ComponentType
{
    Temperature,
    Power,
    Mode,
    Humidity,
    Illumination,
}

public class ComponentModel
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public required ComponentType Type { get; set; }

    public required object Value { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Unit { get; set; } = string.Empty;
}
