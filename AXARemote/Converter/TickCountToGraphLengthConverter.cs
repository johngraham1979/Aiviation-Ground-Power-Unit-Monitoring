using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AXARemote.Converter
{
    internal class TickCountToGraphLengthConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2 || values[0] == null || values[1] == null)
                return Binding.DoNothing;

            MessageBox.Show(values[1].GetType().ToString());

            var v = values[1] as ObservableCollection<KeyValuePair<double, double>>;

            var actualWidth = (double) values[0];
            var numPoints = v.Count;

            var width = (actualWidth - 10) / 3 * numPoints;

            return Math.Max(width, actualWidth);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return new[] {Binding.DoNothing, Binding.DoNothing};
        }
    }
}