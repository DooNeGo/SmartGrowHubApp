using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.Model;
using SmartGrowHubApp.ObservableObjects;

namespace SmartGrowHubApp.ViewModels.ControllerPageModels;

public partial class SettingModeSwitchPageModel(ComponentObservable modeComponent) : ObservableObject
{
    [ObservableProperty]
    private SettingMode _settingMode = (SettingMode)modeComponent.Value;

    [RelayCommand]
    private void SetSettingMode(object sender)
    {
        if (sender is not BindableObject bindableObject)
        {
            throw new ArgumentException("Wrong bindable object", nameof(sender));
        }

        SettingMode = (SettingMode)bindableObject.BindingContext;
    }
}
