using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class SettingsPage : ContentPage
{
    private readonly SettingsPageModel _pageModel;

    public SettingsPage(SettingsPageModel settingsPageModel)
    {
        InitializeComponent();

        BindingContext = settingsPageModel;
        _pageModel = settingsPageModel;
    }

    private void ButtonView_Pressed(object sender, EventArgs e)
    {
        if (sender is BindableObject item)
        {
            _pageModel.ShowSettingPageCommand.Execute(item.BindingContext);
        }
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is BindableObject item)
        {
            _pageModel.ShowSettingPageCommand.Execute(item.BindingContext);
        }
    }
}