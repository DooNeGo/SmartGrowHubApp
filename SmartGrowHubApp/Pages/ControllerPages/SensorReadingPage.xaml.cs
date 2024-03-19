using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class SensorReadingPage
{
    public SensorReadingPage(SensorReadingPageModel pageModel)
    {
        InitializeComponent();

        BindingContext = pageModel;
    }
}