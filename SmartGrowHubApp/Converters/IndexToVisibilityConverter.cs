using System.Collections;
using System.Globalization;
using CommunityToolkit.Diagnostics;

namespace SmartGrowHubApp.Converters;

public class IndexToVisibilityConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        Guard.IsNotNull(value);

        var itemsCount = (int)value;
        var itemIndex = ((IList)parameter).IndexOf(value);

        return itemIndex < itemsCount - 1;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
