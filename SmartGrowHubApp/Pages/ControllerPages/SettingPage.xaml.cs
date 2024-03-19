using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class SettingPage
{
    private readonly SettingPageModel _pageModel;

    public SettingPage(SettingPageModel pageModel)
    {
        InitializeComponent();

        _pageModel = pageModel;
        BindingContext = _pageModel;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        _pageModel.ShowModeSwitchPageCommand.Execute(null);
    }
}