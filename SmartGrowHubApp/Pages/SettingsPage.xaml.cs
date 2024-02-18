using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class SettingsPage : ContentPage
{
    public SettingsPage(SettingsPageModel settingsPageModel)
    {
        InitializeComponent();

        BindingContext = settingsPageModel;
    }
}