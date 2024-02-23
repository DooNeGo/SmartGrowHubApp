using SmartGrowHubApp.Pages;

namespace SmartGrowHubApp;

public partial class AppShell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(SettingPage), typeof(SettingPage));
    }
}