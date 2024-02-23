using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.Model;
using System.Collections.ObjectModel;

namespace SmartGrowHubApp.ViewModels;

public partial class HomePageModel : ObservableObject
{
    private readonly IPopupService _popupService;

    [ObservableProperty]
    private ObservableCollection<ControllerModel>? _items;

    [ObservableProperty]
    private ControllerModel? _selectedItem;

    [ObservableProperty]
    private ObservableCollection<object> _selectedItems = [];

    public HomePageModel(IPopupService popupService)
    {
        _popupService = popupService;

        Load();

        if (Items is null)
        {
            throw new NullReferenceException(nameof(Items));
        }
    }

    public void ClearSelection()
    {
        SelectedItem = null;
        SelectedItems.Clear();
    }

    [RelayCommand]
    private void ShowAddControllerPopup()
    {
        _popupService.ShowPopupAsync<AddControllerPageModel>();
    }

    private void Load()
    {
        Items =
        [
            new() { Name = "Main", Description = "In livingroom", Status = "Working" },
            new() { Name = "Secondery", Description = "In livingroom", Status = "Working" },
            new() { Name = "Main", Description = "In livingroom", Status = "Working" },
            new() { Name = "Secondery", Description = "In livingroom", Status = "Working" },
            new() { Name = "Main", Description = "In livingroom", Status = "Working" },
            new() { Name = "Secondery", Description = "In livingroom", Status = "Working" },
            new() { Name = "Main", Description = "In livingroom", Status = "Working" },
            new() { Name = "Secondery", Description = "In livingroom", Status = "Working" },
            new() { Name = "Main", Description = "In livingroom", Status = "Working" },
            new() { Name = "Secondery", Description = "In livingroom", Status = "Working" },
        ];
    }
}
