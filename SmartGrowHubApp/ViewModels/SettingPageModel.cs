using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.Model;
using System.Collections.ObjectModel;

namespace SmartGrowHubApp.ViewModels;

public partial class SettingPageModel : ObservableObject
{
    private readonly Component[] _allComponents;
    private readonly Setting _setting;

    [ObservableProperty]
    private ObservableCollection<Component> _components;

    public SettingPageModel(Setting setting, Component[] allComponents)
    {
        _setting = setting;
        _allComponents = allComponents;
        _components = new ObservableCollection<Component>(_setting.Components);
    }

    public SettingType SettingType => _setting.Type;

    [RelayCommand]
    private void AddComponent(object obj)
    {
        //IEnumerable<ComponentType>? types = await _dialogService.DisplayCheckBoxPromptAsync("Select components to add", _allComponents.Select(f => f.Type));

        //if (types is null || !types.Any())
        //{
        //    return;
        //}

        //foreach (ComponentType type in types)
        //{
        //    Setting.AddComponent(_allComponents.FirstOrDefault(f => f.Type == type));
        //    InvokePropertyChanged(nameof(Setting));
        //}
    }
}
