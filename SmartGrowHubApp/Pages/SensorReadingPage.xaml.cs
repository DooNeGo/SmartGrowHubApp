using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class SensorReadingPage : ContentPage
{
	public SensorReadingPage(SensorReadingPageModel pageModel)
	{
		InitializeComponent();

		BindingContext = pageModel;
	}
}