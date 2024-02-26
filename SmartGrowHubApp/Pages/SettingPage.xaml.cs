using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class SettingPage : ContentPage
{
    private readonly SettingPageModel _pageModel;

    public SettingPage(SettingPageModel pageModel)
    {
        InitializeComponent();

        BindingContext = pageModel;
        _pageModel = pageModel;
    }

    private void SwipeItem_Clicked(object sender, EventArgs e)
    {
        if (sender is BindableObject item)
        {
            _pageModel.DeleteComponentCommand.Execute(item.BindingContext);
        }
    }
}