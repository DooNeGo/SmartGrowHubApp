using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class ControllerPage : ContentPage
{
    private readonly ControllerPageModel _pageModel;

    public ControllerPage(ControllerPageModel pageModel)
    {
        InitializeComponent();

        BindingContext = pageModel;
        _pageModel = pageModel;
    }

    private void OnSizeChanged(object? sender, EventArgs e)
    {
        gridItemsLayout.Span = (int)(Width / 170);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is BindableObject item)
        {
            _pageModel.ShowSensorReadingPageCommand.Execute(item.BindingContext);
        }
    }
}