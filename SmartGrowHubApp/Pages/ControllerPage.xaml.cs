using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class ControllerPage
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
        gridItemsLayout.Span = (int)(Width / 180);
    }

    private void ButtonView_Tapped(object sender, EventArgs e)
    {
        if (sender is BindableObject item)
        {
            _pageModel.ShowSensorReadingPageCommand.Execute(item.BindingContext);
        }
    }
}