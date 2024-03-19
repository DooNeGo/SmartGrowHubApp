using CommunityToolkit.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.Model;
using SmartGrowHubApp.ObservableObjects;

namespace SmartGrowHubApp.ViewModels.ControllerPageModels;

public partial class SettingModeSwitchPageModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    private ComponentObservable? _modeComponent;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        ModeComponent = (ComponentObservable)query[nameof(ModeComponent)];
    }

    [RelayCommand]
    private void SetSettingMode(SettingMode settingMode)
    {
        Guard.IsNotNull(ModeComponent);
        ModeComponent.Value = settingMode;
    }
}
