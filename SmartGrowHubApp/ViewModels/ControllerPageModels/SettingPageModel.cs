using CommunityToolkit.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using SmartGrowHubApp.Model;
using SmartGrowHubApp.ObservableObjects;

namespace SmartGrowHubApp.ViewModels.ControllerPageModels;

public partial class SettingPageModel : ObservableObject
{
    public static readonly SettingMode[] ModeValues = Enum.GetValues<SettingMode>();

    private readonly SettingObservable _setting;

    [ObservableProperty]
    private ComponentObservable? _modeComponent;

    [ObservableProperty]
    private ComponentObservable? _powerComponent;

    [ObservableProperty]
    private IEnumerable<ComponentObservable> _components;

    [ObservableProperty]
    private bool _isSettingOn;

    [ObservableProperty]
    private bool _isAutoOn;

    public SettingPageModel(SettingsPageModel settingsPageModel)
    {
        Guard.IsNotNull(settingsPageModel.SelectedItem);

        _setting = settingsPageModel.SelectedItem;
        _modeComponent = _setting.Components.FirstOrDefault(c => c.Type is ComponentType.Mode);
        _powerComponent = _setting.Components.FirstOrDefault(c => c.Type is ComponentType.Power);
        _components = _setting.Components;

        Guard.IsNotNull(_modeComponent);

        _modeComponent.PropertyChanged += (_, _) =>
        {
            _setting.PreviewValue = _modeComponent.Value;
            IsSettingOn = _modeComponent.Value is SettingMode.On;
            IsAutoOn = _modeComponent.Value is SettingMode.Auto;
        };
    }

    public SettingType SettingType => _setting.Type;
}
