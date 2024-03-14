using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class SettingsPage : ContentPage
{
    private readonly SettingsPageModel _pageModel;

    public SettingsPage(SettingsPageModel settingsPageModel)
    {
        InitializeComponent();

        BindingContext = settingsPageModel;
        _pageModel = settingsPageModel;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is BindableObject item)
        {
            _pageModel.ShowSettingPageCommand.Execute(item.BindingContext);
        }
    }
}