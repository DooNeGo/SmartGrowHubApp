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
        //Dictionary<string, object> dictionary = new Dictionary<string, object>()
        //{
        //    { "param1",  new SettingModeSwitchPageModel(_pageModel.ModeComponent!) }
        //};

        await Shell.Current.GoToAsync(nameof(SettingModeSwitchPageModel));
    }
}