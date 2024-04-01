using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class SettingPage
{
    private readonly SettingPageModel _pageModel;

    private bool _tapped;

    public SettingPage(SettingPageModel pageModel)
    {
        InitializeComponent();

        _pageModel = pageModel;
        BindingContext = _pageModel;
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (_tapped)
        {
            return;
        }

        _tapped = true;

        await _pageModel.ShowModeSwitchPageCommand.ExecuteAsync(null);

        _tapped = false;
    }
}