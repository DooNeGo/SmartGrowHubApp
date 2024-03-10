using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.ObservableObjects;
using SmartGrowHubApp.Services;

namespace SmartGrowHubApp.ViewModels.ControllerPageModels;

public partial class SettingsPageModel(ISettingsService settingsService) : ObservableObject
{
    [ObservableProperty]
    private IEnumerable<SettingObservable> _settings = settingsService.GetSettings();

    public SettingObservable? SelectedItem { get; private set; }

    [RelayCommand]
    private void ShowSettingPage(SettingObservable setting)
    {
        SelectedItem = setting;
        Shell.Current.GoToAsync(nameof(SettingPageModel));
    }

    //private void Load()
    //{

    //}
}