using System.Globalization;

namespace TM.Converters
{
    public class BoolToIconConverter : IValueConverter
    {
        public object? Convert(
            object? value,
            Type targetType,
            object? parameter,
            CultureInfo culture)
        {
            if (value is bool isCompleted)
                return isCompleted ? "↶" : "✓";

            return "✓";
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