using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class SettingsPage : ContentPage
{
    public SettingsPage(SettingsPageModel settingsPageModel)
    {
        InitializeComponent();

        BindingContext = settingsPageModel;
    }

    private void ButtonView_Pressed(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(SettingPage));
    }
}