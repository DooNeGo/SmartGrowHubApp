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

        ReadOnlySpan<char> strSpan = str.AsSpan();
        Span<char> result = stackalloc char[strSpan.Length * 2];
        var counter = 0;

        for (var i = 1; i < strSpan.Length - 1; i++)
        {
            if (char.IsUpper(strSpan[i])
             && char.IsLower(strSpan[i + 1]))
            {
                result[i + counter++] = ' ';
            }

            result[i + counter] = strSpan[i];
        }

        result[0] = strSpan[0];
        result[strSpan.Length + counter++] = strSpan[^1];

        return result[..(strSpan.Length + counter)].ToString();
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
