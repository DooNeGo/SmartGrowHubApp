﻿using System.Text.Json.Serialization;

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

public class Component
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public required ComponentType Type { get; set; }

    public required object Value { get; set; }

    public required object AcceptableValues { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Unit { get; set; }
}
