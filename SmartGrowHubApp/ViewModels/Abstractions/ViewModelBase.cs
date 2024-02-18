using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartGrowHubApp.ViewModels.Abstractions;
public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void InvokePropertyChanged([CallerMemberName] string? propertyName = null)
    {
        ArgumentNullException.ThrowIfNull(propertyName, nameof(propertyName));

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}