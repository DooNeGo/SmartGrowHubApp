using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class AddControllerPage
{
    public AddControllerPage(AddControllerPageModel addControllerPageModel)
    {
        InitializeComponent();

        BindingContext = addControllerPageModel;
    }
}