using CommunityToolkit.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.Model;
using SmartGrowHubApp.ObservableObjects;

namespace SmartGrowHubApp.ViewModels.ControllerPageModels;

public partial class SettingPageModel : ObservableObject, IQueryAttributable
{
    public static readonly SettingMode[] ModeValues = Enum.GetValues<SettingMode>();

    [ObservableProperty]
    private SettingObservable? _setting;

    [ObservableProperty]
    private ComponentObservable? _modeComponent;

    [ObservableProperty]
    private ComponentObservable? _powerComponent;

    [ObservableProperty]
    private IEnumerable<ComponentObservable>? _components;

    [ObservableProperty]
    private bool _isSettingOn;

    [ObservableProperty]
    private bool _isAutoOn;
    
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (!query.Any())
        {
            return;
        }

        Setting = (SettingObservable)query["Setting"];
        
        ModeComponent  = Setting.Components.First(c => c.Type is ComponentType.Mode);
        PowerComponent = Setting.Components.First(c => c.Type is ComponentType.Power);
        Components     = Setting.Components;

        ModeComponent.PropertyChanged += (_, _) =>
        {
            IsSettingOn = ModeComponent.Value is SettingMode.On;
            IsAutoOn    = ModeComponent.Value is SettingMode.Auto;
        };
    }

    [RelayCommand]
    private async Task ShowModeSwitchPage()
    {
        Guard.IsNotNull(ModeComponent);
        
        var parameter = new ShellNavigationQueryParameters
        {
            { SettingModeSwitchPageModel.ModeComponentName, ModeComponent }
        };

        await Shell.Current.GoToAsync(nameof(SettingModeSwitchPageModel), parameter);
    }
}
