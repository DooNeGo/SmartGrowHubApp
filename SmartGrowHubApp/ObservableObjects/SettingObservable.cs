using CommunityToolkit.Mvvm.ComponentModel;
using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.ObservableObjects;

public partial class SettingObservable : ObservableObject
{
    [ObservableProperty]
    private object? _previewValue;

    private readonly SettingModel _settingModel;

    public SettingObservable(SettingModel setting)
    {
        _settingModel = setting;

        var components = new ComponentObservable[_settingModel.Components.Count()];
        int counter = 0;

        foreach (ComponentModel componentModel in _settingModel.Components)
        {
            components[counter++] = new ComponentObservable(componentModel);
        }

        Components = components;
    }

    public SettingType Type => _settingModel.Type;

    public IEnumerable<ComponentObservable> Components { get; }
}
