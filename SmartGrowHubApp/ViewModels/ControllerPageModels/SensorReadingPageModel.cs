using CommunityToolkit.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.ViewModels.ControllerPageModels;

public partial class SensorReadingPageModel : ObservableObject
{
    private readonly ControllerModel _controllerModel;

    public SensorReadingPageModel(ControllerPageModel controllerPageModel)
    {
        Guard.IsNotNull(controllerPageModel.SelectedItem, nameof(ControllerPageModel.SelectedItem));

        _controllerModel = controllerPageModel.Controller;
        SensorReading = controllerPageModel.SelectedItem;
        Load();
    }

    public SensorReadingModel SensorReading { get; }

    private void Load()
    {
        
    }
}
