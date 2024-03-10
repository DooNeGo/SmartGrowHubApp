using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.Repository;

public interface ISensorsReadingRepository
{
    public IEnumerable<SensorReadingModel> GetSensorsReading(ControllerModel controller);
}
