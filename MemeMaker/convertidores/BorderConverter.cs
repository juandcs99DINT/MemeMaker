using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace MemeMaker
{
    public class BorderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool bordeChecked = (bool)value;
            Border borde;
            if (bordeChecked)
            {
                borde = new Border
                {
                    BorderBrush = Brushes.Black
                    // border thickness
                };
            }
            else
            {
               borde = null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
