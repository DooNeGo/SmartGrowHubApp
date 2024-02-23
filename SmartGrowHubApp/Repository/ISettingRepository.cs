using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.Repository;

public interface ISettingRepository
{
    public IEnumerable<Setting> GetSettings(ControllerModel controller);

    public void SetSettings(ControllerModel controller, IEnumerable<Setting> settings);
}
