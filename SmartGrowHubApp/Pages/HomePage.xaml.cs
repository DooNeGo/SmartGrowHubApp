using SmartGrowHubApp.ViewModels;
using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages;

public partial class HomePage : ContentPage
{
    public HomePage(HomePageModel homePageModel)
    {
        InitializeComponent();

        BindingContext = homePageModel;
        SizeChanged += OnSizeChanged;
    }

    private void OnSizeChanged(object? sender, EventArgs e)
    {
        gridItemsLayout.Span = (int)(Width / 200);
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count > 0)
        {
            Shell.Current.GoToAsync(nameof(ControllerPageModel));
        }
    }
}