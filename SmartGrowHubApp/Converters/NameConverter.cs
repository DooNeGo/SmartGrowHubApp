using System.Globalization;

namespace SmartGrowHubApp.Converters;

public class NameConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        string str = value?.ToString() ?? throw new Exception();
        string upper = str.ToUpper(culture);
        string result = str;
        int shift = 0;

        for (var i = 1; i < str.Length - 1; i++)
        {
            if (str[i] == upper[i] && str[i - 1] != upper[i - 1])
            {
                result = result.Insert(i + shift, " ");
                shift++;
            }
        }

        return result;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        string str = value?.ToString() ?? throw new Exception();
        string result = str;
        int shift = 0;

        for (var i = 1; i < str.Length - 1; i++)
        {
            if (str[i] is ' ')
            {
                result = result.Remove(i - shift);
                shift++;
            }
        }

        return result;
    }
}
