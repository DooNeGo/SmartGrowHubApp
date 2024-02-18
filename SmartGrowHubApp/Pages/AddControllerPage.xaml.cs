using Mopups.Interfaces;
using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class AddControllerPage
{
    private readonly IPopupNavigation _popupNavigation;

    public AddControllerPage(AddControllerPageModel addControllerPageModel, IPopupNavigation popupNavigation)
    {
        InitializeComponent();

        BindingContext = addControllerPageModel;
        _popupNavigation = popupNavigation;
    }

    private void ButtonView_Pressed(object sender, EventArgs e)
    {
        _popupNavigation.PopAsync();
    }
}