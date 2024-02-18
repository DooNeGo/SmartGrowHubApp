using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class ControllerPage
{
    public ControllerPage(ControllerPageModel pageModel)
    {
        InitializeComponent();

        BindingContext = pageModel;
    }

    private void OnSizeChanged(object? sender, EventArgs e)
    {
        gridItemsLayout.Span = (int)(Width / 200);
    }
}