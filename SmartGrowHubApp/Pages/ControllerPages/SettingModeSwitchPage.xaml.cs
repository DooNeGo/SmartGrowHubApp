using SmartGrowHubApp.Model;
using SmartGrowHubApp.ViewModels.ControllerPageModels;

namespace SmartGrowHubApp.Pages.ControllerPages;

public partial class SettingModeSwitchPage : ContentPage
{
	private object _previousSelection;

	public SettingModeSwitchPage()
	{
		InitializeComponent();

		//object obj = FindByName(nameof(listView));
		//if (obj is ListView list)
		//{
		//	list.SelectedItem = SettingMode.Auto;
		//}

		BindingContext = this;
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		if (sender is not Element layout)
		{
			throw new ArgumentException("Wrong layout", nameof(sender));
		}

        var checkMark = (Label)layout.FindByName("checkMark");
		checkMark.IsVisible = true;
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		var previousSelection = e.PreviousSelection[0];
		var currentSelection = e.CurrentSelection[0];
    }

    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if (_previousSelection is not null)
		{

		}
    }
}