using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class SettingPage : ContentPage
{
    public SettingPage(SettingPageModel pageModel)
    {
        InitializeComponent();

        BindingContext = pageModel;
    }
}