using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Data;

namespace MissingPets
{
    public class EnumToBooleanConverter : IValueConverter
    {
        /// <summary>
        /// Compares the bound value with an enum param. Returns true when they match.
        /// </summary>
        public object Convert(object value, Type targetType, object param, System.Globalization.CultureInfo culture)
        {
            return value.Equals(param);
        }

        /// <summary>
        /// Updates the bound value if it's different from the parameter.
        /// </summary>
        public object ConvertBack(object value, Type targetType, object param, System.Globalization.CultureInfo culture)
        {
            return (bool)value ? param : Binding.DoNothing;
        }
    }
}
