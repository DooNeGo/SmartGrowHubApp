using System.Globalization;

namespace SmartGrowHubApp.Converters;

public class NameConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var str = value?.ToString();

        if (str is null)
        {
            return null;
        }
        
        string upper  = str.ToUpper(culture);
        string result = str;
        var    shift  = 0;

        for (var i = 1; i < str.Length - 1; i++)
        {
            if (str[i] != upper[i] || str[i - 1] == upper[i - 1])
            {
                continue;
            }

            result = result.Insert(i + shift, " ");
            shift++;
        }

        return result;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var str = value?.ToString();
        
        if (str is null)
        {
            return null;
        }
        
        string result = str;
        var    shift  = 0;

        for (var i = 1; i < str.Length - 1; i++)
        {
            if (str[i] is not ' ')
            {
                continue;
            }

            result = result.Remove(i - shift);
            shift++;
        }

        return result;
    }
}
