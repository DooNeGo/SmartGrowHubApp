using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class ControllerPage
{
    private readonly ControllerPageModel _pageModel;

    public ControllerPage(ControllerPageModel pageModel)
    {
        InitializeComponent();

        BindingContext = pageModel;
        _pageModel = pageModel;

        if (DeviceInfo.Current.Platform == DevicePlatform.WinUI)
        {
            SizeChanged += OnSizeChanged;
        }
    }

    private void OnSizeChanged(object? sender, EventArgs e)
    {
        // TODO: Remove the magic number
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