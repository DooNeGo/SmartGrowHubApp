using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class SettingPage : ContentPage
{
    private readonly SettingPageModel _pageModel;

    public SettingPage(SettingPageModel pageModel)
    {
        InitializeComponent();

        _pageModel = pageModel;
        BindingContext = _pageModel;
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var parameter = new ShellNavigationQueryParameters
        {
            { "ModeComponent", _pageModel.ModeComponent! }
        };

        await Shell.Current.GoToAsync($"{nameof(SettingModeSwitchPageModel)}", parameter);
    }
}