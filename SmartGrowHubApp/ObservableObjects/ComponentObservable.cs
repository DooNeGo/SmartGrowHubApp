using CommunityToolkit.Mvvm.ComponentModel;
using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.ObservableObjects;

public partial class ComponentObservable(ComponentModel component) : ObservableObject
{
    public ComponentType Type => component.Type;

    public object Value
    {
        get => component.Value;
        set
        {
            OnPropertyChanging(nameof(Value));
            component.Value = value;
            OnPropertyChanged(nameof(Value));
        }
    }

    public string? Unit
    {
        get => component.Unit;
        set
        {
            OnPropertyChanging(nameof(Unit));
            component.Unit = value;
            OnPropertyChanged(nameof(Unit));
        }
    }
}
