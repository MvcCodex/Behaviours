using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Samples
{
    class StringToObjectConverter<T>: IValueConverter
    {
        public T EmptyObject { set; get; }
        public T FalseObject { set; get; }

        public T TrueObject { set; get; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value ? this.EmptyObject : this.TrueObject;
        }

        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            return (bool)value ? this.TrueObject : this.FalseObject;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            return ((T)value).Equals(this.TrueObject);
        }
    }
}
