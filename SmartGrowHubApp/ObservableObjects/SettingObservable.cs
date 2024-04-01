using CommunityToolkit.Mvvm.ComponentModel;
using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.ObservableObjects;

public class SettingObservable : ObservableObject
{
    private object? _previewValue;

    private readonly SettingModel         _settingModel;
    private readonly ComponentObservable? _previewComponent;

    public SettingObservable(SettingModel setting, ComponentType? previewComponentType)
    {
        _settingModel = setting;

        List<ComponentModel> componentsList = _settingModel.Components.ToList();
        var components = new ComponentObservable[componentsList.Count];

        for (var i = 0; i < componentsList.Count; i++)
        {
            components[i] = new ComponentObservable(componentsList[i]);
        }

        Components = components;

        if (previewComponentType is null)
        {
            return;
        }

        _previewComponent = Components.First(c => c.Type == previewComponentType);
        PreviewValue      = _previewComponent.Value;
        
        _previewComponent.PropertyChanged += (_, args) =>
        {
            if (args.PropertyName is not nameof(_previewComponent.Value))
            {
                return;
            }

            PreviewValue = _previewComponent.Value;
        };
    }

    public object? PreviewValue
    {
        get => _previewValue;

        private set
        {
            if (Equals(value, _previewValue))
            {
                return;
            }
            
            OnPropertyChanging();
            _previewValue = value;
            OnPropertyChanged();
        }
    }

    public SettingType Type => _settingModel.Type;

    public IEnumerable<ComponentObservable> Components { get; }
}