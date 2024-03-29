﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.ViewModels.ControllerPageModels;

public partial class ControllerPageModel : ObservableObject
{
    [ObservableProperty]
    private IEnumerable<SensorReadingModel> _sensorsReading = [];

    [ObservableProperty]
    private SensorReadingModel? _selectedItem;

    public ControllerPageModel()
    {
        Controller = new ControllerModel() { Id = "esp", Name = "Smart Grow Hub" };
        Load();
    }

    public ControllerModel Controller { get; }

    private void Load()
    {
        SensorsReading =
        [
            new SensorReadingModel() { SensorId = 1, Type = SensorType.Methane, Value = 1500, Unit = "ppm"},
            new SensorReadingModel() { SensorId = 1, Type = SensorType.Smoke, Value = 500, Unit = "ppm" },
            new SensorReadingModel() { SensorId = 1, Type = SensorType.Hydrogen, Value = 400, Unit = "ppm" },
            new SensorReadingModel() { SensorId = 2, Type = SensorType.AirTemperature, Value = 25.3, Unit = "C" },
            new SensorReadingModel() { SensorId = 2, Type = SensorType.AirPressure, Value = 101.2, Unit = "kPa" },
        ];
    }

    [RelayCommand]
    private void ShowSensorReadingPage(SensorReadingModel sensorReading)
    {
        SelectedItem = sensorReading;
        Shell.Current.GoToAsync(nameof(SensorReadingPageModel));
    }
}
