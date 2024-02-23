namespace SmartGrowHubApp.Services;

public enum MessagePurpose
{
    GetData
}

public class QueryMessage
{
    public IEnumerable<byte> Message { get; }
}
