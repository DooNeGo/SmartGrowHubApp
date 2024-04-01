using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class SettingsPage
{
    private readonly SettingsPageModel _pageModel;

    private bool tapped;

    public SettingsPage(SettingsPageModel settingsPageModel)
    {
        InitializeComponent();

        BindingContext = settingsPageModel;
        _pageModel = settingsPageModel;
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (tapped)
        {
            return;
        }

        tapped = true;

        if (sender is BindableObject item)
        {
            await _pageModel.ShowSettingPageCommand.ExecuteAsync(item.BindingContext);
        }

        await Task.Delay(500);

        tapped = false;
    }

    private void SettingControl_PointerReleased(object sender, PointerEventArgs e)
    {
        if (sender is BindableObject item)
        {
            _pageModel.ShowSettingPageCommand.Execute(item.BindingContext);
        }
    }

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (sender is BindableObject item)
        {
            _pageModel.ShowSettingPageCommand.Execute(item.BindingContext);
        }
    }
}