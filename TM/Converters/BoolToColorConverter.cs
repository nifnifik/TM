using System.Globalization;

namespace TM.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        public object? Convert(
            object? value,
            Type targetType,
            object? parameter,
            CultureInfo culture)
        {
            if (value is bool isCompleted)
                return isCompleted
                    ? Colors.Orange
                    : Color.FromArgb("#4CAF50");

            return Color.FromArgb("#4CAF50");
        }

        public object? ConvertBack(
            object? value,
            Type targetType,
            object? parameter,
            CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}