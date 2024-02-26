using CommunityToolkit.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SmartGrowHubApp.Model;
using System.Collections.ObjectModel;

namespace SmartGrowHubApp.ViewModels;

public partial class SettingPageModel : ObservableObject
{
    //private readonly Component[] _allComponents;
    private readonly Setting _setting;

    [ObservableProperty]
    private ObservableCollection<Component> _components;

    public SettingPageModel(SettingsPageModel settingsPageModel)
    {
        Guard.IsNotNull(settingsPageModel.SelectedItem);

        _setting = settingsPageModel.SelectedItem;
        _components = new ObservableCollection<Component>(_setting.Components);

        Components.CollectionChanged += (o, e) =>
        {
            _setting.Components = _components;
        };
    }

    public SettingType SettingType => _setting.Type;

    [RelayCommand]
    private void AddComponent()
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

    [RelayCommand]
    private void DeleteComponent(Component component)
    {
        Components.Remove(component);
    }
}
