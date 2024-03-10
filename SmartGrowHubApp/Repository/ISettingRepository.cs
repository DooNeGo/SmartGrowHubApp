using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.Repository;

public interface ISettingRepository
{
    public IEnumerable<SettingModel> GetSettings(ControllerModel controller);

    public void SetSettings(ControllerModel controller, IEnumerable<SettingModel> settings);
}
