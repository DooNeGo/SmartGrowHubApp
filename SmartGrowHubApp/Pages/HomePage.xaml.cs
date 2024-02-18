using Mopups.Interfaces;
using SmartGrowHubApp.ViewModels;

namespace SmartGrowHubApp.Pages;

public partial class HomePage : ContentPage
{
    private readonly IPopupNavigation _popupNavigation;
    private readonly IServiceProvider _services;

    public HomePage(HomePageModel homePageModel, IPopupNavigation popupNavigation, IServiceProvider services)
    {
        InitializeComponent();

        BindingContext = homePageModel;
        SizeChanged += OnSizeChanged;
        _popupNavigation = popupNavigation;
        _services = services;

        homePageModel.SelectionChanged += collectionView.UpdateSelectedItems;
    }

    private void OnSizeChanged(object? sender, EventArgs e)
    {
        gridItemsLayout.Span = (int)(Width / 200);
    }

    private void Button_Released(object sender, EventArgs e)
    {
        _popupNavigation.PushAsync(_services.GetRequiredService<AddControllerPage>());
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count > 0)
        {
            Shell.Current.GoToAsync(nameof(ControllerPage));
            collectionView.SelectedItem = null;
            collectionView.SelectedItems.Clear();
        }
    }
}