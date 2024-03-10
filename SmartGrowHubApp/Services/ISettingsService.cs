using SmartGrowHubApp.Model;
using SmartGrowHubApp.ObservableObjects;

namespace SmartGrowHubApp.Services;

public interface ISettingsService
{
    public SettingObservable? GetSetting(SettingType type);

    public IEnumerable<SettingObservable> GetSettings();
}
