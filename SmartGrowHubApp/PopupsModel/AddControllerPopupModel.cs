using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.ViewModels;

public partial class AddControllerPageModel(HomePageModel homePageModel) : ObservableObject
{
    private readonly HomePageModel _homePageModel = homePageModel;

    [ObservableProperty]
    private string _id = string.Empty;

    [ObservableProperty]
    private string _name = string.Empty;

    [ObservableProperty]
    private string _description = string.Empty;

    [ObservableProperty]
    private string _status = string.Empty;

    [RelayCommand]
    private void AddController(object obj)
    {
        _homePageModel.Items?.Add(new ControllerModel() { Id = Id, Name = Name, Description = Description });
    }

    private bool CanExecuteAddCommand(object obj)
    {
        return !string.IsNullOrWhiteSpace(Id)
            && !string.IsNullOrWhiteSpace(Name);
    }
}