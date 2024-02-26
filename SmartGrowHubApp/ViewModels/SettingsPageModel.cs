﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.Model;
using System.Collections.ObjectModel;

namespace SmartGrowHubApp.ViewModels;

public partial class SettingsPageModel : ObservableObject
{   
    [ObservableProperty]
    private Setting? _selectedItem;

    [ObservableProperty]
    private ObservableCollection<Setting> _settings = [];

    public SettingsPageModel()
    {
        Load();
    }

    [RelayCommand]
    private void ShowSettingPage(Setting setting)
    {
        SelectedItem = setting;
        Shell.Current.GoToAsync(nameof(SettingPageModel));
    }

    private void Load()
    {
        Settings =
        [
            new() { Type = SettingType.Watering },
            new() { Type = SettingType.DayLighting },
            new() { Type = SettingType.UVLighting },
            new() { Type = SettingType.Heating },
            new() { Type = SettingType.Cooling },
            new() { Type = SettingType.AirHumidification },
            new() { Type = SettingType.PreferAirTemperature },
            new() { Type = SettingType.PreferAirHumidity },
            new() { Type = SettingType.PreferIllumination }
        ];

        SettingMode[] modeValues = Enum.GetValues<SettingMode>();
        int[] powerValues = Enumerable.Range(1, 100).ToArray();
        int[] timeValues = Enumerable.Range(1, 60).ToArray();
        int[] countValues = Enumerable.Range(0, 25).ToArray();
        int[] humidity = Enumerable.Range(0, 101).ToArray();

        //Component[] allComponents =
        //[
        //    new Component { Type = ComponentType.Mode, Value = SettingMode.Auto, AcceptableValues = modeValues },
        //    new Component { Type = ComponentType.Power, Value = 50, Unit = "%", AcceptableValues = powerValues },
        //    new Component { Type = ComponentType.Time, Value = 0, Unit = "min", AcceptableValues = timeValues },
        //    new Component { Type = ComponentType.Count, Value = 1, Unit = "pd", AcceptableValues = countValues },
        //    new Component { Type = ComponentType.Temperature, Value = 27.1, Unit = "C", AcceptableValues = timeValues },
        //    new Component { Type = ComponentType.Humidity, Value = 50, Unit = "%", AcceptableValues = humidity },
        //    new Component { Type = ComponentType.Illumination, Value = 50, Unit = "%", AcceptableValues = humidity }
        //];

        Settings[0]
            .AddComponent(new Component { Type = ComponentType.Mode, Value = SettingMode.On, AcceptableValues = modeValues })
            .AddComponent(new Component { Type = ComponentType.Power, Value = 50, Unit = "%", AcceptableValues = powerValues })
            .AddComponent(new Component { Type = ComponentType.Time, Value = 20, Unit = "min", AcceptableValues = timeValues })
            .AddComponent(new Component { Type = ComponentType.Count, Value = 3, Unit = "pd", AcceptableValues = countValues });

        Settings[1]
            .AddComponent(new Component { Type = ComponentType.Mode, Value = SettingMode.Auto, AcceptableValues = modeValues });

        Settings[2]
            .AddComponent(new Component { Type = ComponentType.Mode, Value = SettingMode.Auto, AcceptableValues = modeValues })
            .AddComponent(new Component { Type = ComponentType.Power, Value = 43, Unit = "%", AcceptableValues = powerValues })
            .AddComponent(new Component { Type = ComponentType.Time, Value = 10, Unit = "min", AcceptableValues = timeValues })
            .AddComponent(new Component { Type = ComponentType.Count, Value = 8, Unit = "pd", AcceptableValues = countValues });

        Settings[3]
            .AddComponent(new Component { Type = ComponentType.Mode, Value = SettingMode.Auto, AcceptableValues = modeValues });
        Settings[4]
            .AddComponent(new Component { Type = ComponentType.Mode, Value = SettingMode.Auto, AcceptableValues = modeValues });
        Settings[5]
            .AddComponent(new Component { Type = ComponentType.Mode, Value = SettingMode.Auto, AcceptableValues = modeValues });

        Settings[6]
            .AddComponent(new Component { Type = ComponentType.Mode, Value = SettingMode.Auto, AcceptableValues = modeValues })
            .AddComponent(new Component { Type = ComponentType.Temperature, Value = 27.1, Unit = "C", AcceptableValues = timeValues });

        Settings[7]
            .AddComponent(new Component { Type = ComponentType.Mode, Value = SettingMode.Auto, AcceptableValues = modeValues })
            .AddComponent(new Component { Type = ComponentType.Humidity, Value = 51, Unit = "%", AcceptableValues = humidity });

        Settings[8]
            .AddComponent(new Component { Type = ComponentType.Mode, Value = SettingMode.Auto, AcceptableValues = modeValues })
            .AddComponent(new Component { Type = ComponentType.Illumination, Value = 30, Unit = "%", AcceptableValues = humidity });
    }
}