using System;
using Windows.UI.Xaml.Data;

namespace XAMLPatterns.ImplicitDataTemplates.WinRT.ValueConverters
{
    public class DateFormatValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return string.Format("{0:M}", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
