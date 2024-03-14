using SmartGrowHubApp.Pages.ControllerPages;
using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp;

public partial class AppShell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(SettingModeSwitchPageModel), typeof(SettingModeSwitchPage));
    }
}