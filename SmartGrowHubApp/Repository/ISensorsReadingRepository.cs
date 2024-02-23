using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.Repository;

public interface ISensorsReadingRepository
{
    public IEnumerable<SensorReading> GetSensorsReading(ControllerModel controller);
}
