using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class SettingsPage
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

    private void SettingControl_PointerReleased(object sender, PointerEventArgs e)
    {
        if (sender is BindableObject item)
        {
            _pageModel.ShowSettingPageCommand.Execute(item.BindingContext);
        }
    }
}