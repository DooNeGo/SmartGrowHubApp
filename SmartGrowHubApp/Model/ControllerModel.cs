namespace SmartGrowHubApp.Model;

public class ControllerModel
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public IEnumerable<Setting> Settings { get; set; } = [];
}