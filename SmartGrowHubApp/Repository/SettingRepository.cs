using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.Repository;

public class SettingRepository : ISettingRepository
{
    public IEnumerable<SettingModel> GetSettings(ControllerModel controller)
    {
        throw new NotImplementedException();
    }

    public void SetSettings(ControllerModel controller, IEnumerable<SettingModel> settings)
    {
        throw new NotImplementedException();
    }
}