using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using AXARemote.ViewModel;

namespace AXARemote.Control
{
    public sealed class Chart : System.Windows.Controls.DataVisualization.Charting.Chart
    {
        public static readonly DependencyProperty GaugeViewModelCollectionProperty =
            DependencyProperty.Register("GaugeViewModelCollection",
                typeof(ObservableCollection<Tuple<GaugeViewModel, LineSeries>>),
                typeof(Chart), new UIPropertyMetadata(new ObservableCollection<Tuple<GaugeViewModel, LineSeries>>()));

        public static readonly DependencyProperty OriginalWidthProperty =
            DependencyProperty.Register("OriginalWidth", typeof(double),
                typeof(Chart), new UIPropertyMetadata(0.0));

        public static readonly DependencyProperty IsAllPollingProperty =
            DependencyProperty.Register("IsAllPolling", typeof(bool),
                typeof(Chart), new UIPropertyMetadata(false));

        private double OriginalWidth
        {
            get => (double) GetValue(OriginalWidthProperty);
            set => SetValue(OriginalWidthProperty, value);
        }

        private ObservableCollection<Tuple<GaugeViewModel, LineSeries>> GaugeViewModelCollection =>
            (ObservableCollection<Tuple<GaugeViewModel, LineSeries>>) GetValue(GaugeViewModelCollectionProperty);

        public Tuple<GaugeViewModel, LineSeries> AddedGaugeViewModel
        {
            set
            {
                value.Item2.ItemsSource = value.Item1.ChartPoints;
                value.Item1.ChartPoints.CollectionChanged += ChartPoints_CollectionChanged;
                GaugeViewModelCollection.Add(value);
            }
        }

        public bool IsAllPolling
        {
            get { return GaugeViewModelCollection.All(tuple => tuple.Item1.IsRunning); }
            set
            {
                // if all plotting checkboxes are unchecked then check them all and start all plotting.
                var valueToUse =
                    value || GaugeViewModelCollection.Where(tuple => tuple.Item1.Plotting).ToList().Count == 0;

                foreach (var tuple in GaugeViewModelCollection)
                {
                    tuple.Item1.Plotting = valueToUse;
                    if (valueToUse)
                        tuple.Item1.StartCommand.Execute(null);
                    else
                        tuple.Item1.StopCommand.Execute(null);
                }
            }
        }

        private void ChartPoints_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (double.IsNaN(Width))
                OriginalWidth = Width = ActualWidth;

            var maxPointsCount = 0;
            foreach (var tuple in GaugeViewModelCollection)
                maxPointsCount = Math.Max(maxPointsCount, tuple.Item1.ChartPoints.Count);

            if (maxPointsCount < 20 || maxPointsCount % 10 != 0)
                return;

            var newWidth = Width + OriginalWidth / 20;

            if (newWidth > Width)
                Width = newWidth;
        }

        public void ResetGraph()
        {
            foreach (var tuple in GaugeViewModelCollection)
                // clear all data points.
                tuple.Item1.ClearPlotCommand.Execute(null);
        }
    }
}