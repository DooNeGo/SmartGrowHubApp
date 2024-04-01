using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.ObservableObjects;
using SmartGrowHubApp.Services;

namespace SmartGrowHubApp.ViewModels.ControllerPageModels;

public partial class SettingsPageModel(ISettingsService settingsService) : ObservableObject
{
    [ObservableProperty]
    private IEnumerable<SettingObservable> _settings = settingsService.GetSettings();

    [RelayCommand]
    private async Task ShowSettingPageAsync(SettingObservable setting)
    {
        var parameter = new ShellNavigationQueryParameters
        {
            { "Setting", setting }
        };
        
        await Shell.Current.GoToAsync(nameof(SettingPageModel), parameter);
    }
}