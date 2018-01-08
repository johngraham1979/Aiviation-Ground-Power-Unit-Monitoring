using System.Windows;
using System.Windows.Media;

namespace AXARemote.Control
{
    public sealed class LineSeries : System.Windows.Controls.DataVisualization.Charting.LineSeries
    {
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(SolidColorBrush),
                typeof(LineSeries), new UIPropertyMetadata(new SolidColorBrush(Colors.Black)));

        public SolidColorBrush Color
        {
            get => (SolidColorBrush) GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }
    }
}