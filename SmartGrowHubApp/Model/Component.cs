using System.Text.Json.Serialization;

namespace SmartGrowHubApp.Model;
public enum ComponentType
{
    Time,
    Temperature,
    Power,
    Mode,
    Humidity,
    Illumination,
    Count
}

public struct Component
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public required ComponentType Type { get; set; }

    public required object Value { get; set; }

    [JsonIgnore]
    public required object AcceptableValues { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Unit { get; set; }
}
