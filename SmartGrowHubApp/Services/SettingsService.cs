using SmartGrowHubApp.Model;
using SmartGrowHubApp.ObservableObjects;

namespace SmartGrowHubApp.Services;

public class SettingsService : ISettingsService
{
    private IList<SettingModel> _settings = [];
    private SettingObservable[] _settingsObservable = [];

    public SettingsService() 
    {
        Load();
    }

    public SettingObservable? GetSetting(SettingType type)
    {
        return _settingsObservable.FirstOrDefault(s => s.Type == type);
    }

    public IEnumerable<SettingObservable> GetSettings()
    {
        return _settingsObservable;
    }

    private ComponentType GetPreviewComponentType(SettingModel setting)
    {
        return ComponentType.Mode;
    }

    private void Load()
    {
        _settings =
        [
            new SettingModel { Type = SettingType.Watering },
            new SettingModel { Type = SettingType.DayLighting },
            new SettingModel { Type = SettingType.UVLighting },
            new SettingModel { Type = SettingType.Heating },
            new SettingModel { Type = SettingType.Cooling },
            new SettingModel { Type = SettingType.AirHumidification }
        ];

        _settings[0]
            .AddComponent(new ComponentModel { Type = ComponentType.Mode, Value = SettingMode.On })
            .AddComponent(new ComponentModel { Type = ComponentType.Power, Value = 50, Unit = "%" });

        _settings[1]
            .AddComponent(new ComponentModel { Type = ComponentType.Mode, Value = SettingMode.Off })
            .AddComponent(new ComponentModel { Type = ComponentType.Power, Value = 43, Unit = "%" });

        _settings[2]
            .AddComponent(new ComponentModel { Type = ComponentType.Mode, Value = SettingMode.On })
            .AddComponent(new ComponentModel { Type = ComponentType.Power, Value = 43, Unit = "%" });

        _settings[3]
            .AddComponent(new ComponentModel { Type = ComponentType.Mode, Value = SettingMode.Auto })
            .AddComponent(new ComponentModel { Type = ComponentType.Power, Value = 43, Unit = "%" });

        _settings[4]
            .AddComponent(new ComponentModel { Type = ComponentType.Mode, Value = SettingMode.Auto })
            .AddComponent(new ComponentModel { Type = ComponentType.Power, Value = 43, Unit = "%" });

        _settings[5]
            .AddComponent(new ComponentModel { Type = ComponentType.Mode, Value = SettingMode.On })
            .AddComponent(new ComponentModel { Type = ComponentType.Power, Value = 43, Unit = "%" });

        _settingsObservable = new SettingObservable[_settings.Count];

        for (var i = 0; i < _settings.Count; i++)
        {
            _settingsObservable[i] = new SettingObservable(_settings[i], GetPreviewComponentType(_settings[i]));
        }
    }
}
