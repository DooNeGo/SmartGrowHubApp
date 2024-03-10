using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class SensorReadingPage : ContentPage
{
    public SensorReadingPage(SensorReadingPageModel pageModel)
    {
        InitializeComponent();

        BindingContext = pageModel;
    }
}