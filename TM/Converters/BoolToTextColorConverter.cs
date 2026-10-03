using System.Globalization;

namespace TM.Converters
{
    public class BoolToTextColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isCompleted)
                return isCompleted ? Color.FromArgb("#95A5A6") : Color.FromArgb("#2C3E50");

            return Color.FromArgb("#2C3E50");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}