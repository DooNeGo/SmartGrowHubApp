using SmartGrowHubApp.Model;
using System.Globalization;

namespace SmartGrowHubApp.Converters;

public class SelectionToVisibilityConverter : IValueConverter
{
    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(nameof(SelectedItem), typeof(object), typeof(SelectionToVisibilityConverter));

    public object? SelectedItem { get; set; }

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value?.Equals(SelectedItem);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
