using SmartGrowHubApp.Model;
using SmartGrowHubApp.ViewModels.Abstractions;

namespace SmartGrowHubApp.ViewModels;

public class AddControllerPageModel : ViewModelBase
{
    private readonly HomePageModel _homePageModel;

    private string _id = string.Empty;
    private string _name = string.Empty;
    private string _description = string.Empty;
    private string _status = string.Empty;

    public AddControllerPageModel(HomePageModel homePageModel)
    {
        _homePageModel = homePageModel;
        AddCommand = new Command(ExecuteAddCommand, CanExecuteAddCommand);
    }

    public Command AddCommand { get; private set; }

    public string Id
    {
        get => _id;
        set
        {
            _id = value;
            InvokePropertyChanged();
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            InvokePropertyChanged();
        }
    }

    public string Description
    {
        get => _description;
        set
        {
            _description = value;
            InvokePropertyChanged();
        }
    }

    public string Status
    {
        get => _status;
        set
        {
            _status = value;
            InvokePropertyChanged();
        }
    }

    private void ExecuteAddCommand(object obj)
    {
        _homePageModel.Items?.Add(new ControllerModel() { Id = _id, Name = _name, Description = _description });
    }

    private bool CanExecuteAddCommand(object obj)
    {
        return !string.IsNullOrWhiteSpace(Id)
            && !string.IsNullOrWhiteSpace(Name);
    }
}