using CommunityToolkit.Mvvm.ComponentModel;
using SmartGrowHubApp.Model;

namespace SmartGrowHubApp.ObservableObjects;

public class ComponentObservable(ComponentModel component) : ObservableObject
{
    public ComponentType Type => component.Type;

    public object Value
    {
        get => component.Value;
        set
        {
            if (Value.Equals(value))
            {
                return;
            }

            OnPropertyChanging();
            component.Value = value;
            OnPropertyChanged();
        }
    }

    public string Unit
    {
        get => component.Unit;
        set
        {
            if (Unit.Equals(value, StringComparison.Ordinal))
            {
                return;
            }

            OnPropertyChanging();
            component.Unit = value;
            OnPropertyChanged();
        }
    }
}
