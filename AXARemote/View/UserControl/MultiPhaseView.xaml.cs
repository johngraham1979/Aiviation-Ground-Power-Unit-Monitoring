using System;
using System.Windows;
using System.Windows.Media;
using AXARemote.Control;
using AXARemote.ViewModel;

namespace AXARemote.View.UserControl
{
    public partial class MultiPhaseView
    {
        public MultiPhaseView()
        {
            InitializeComponent();
        }

        private void SynchronizeGraphing_OnClick(object sender, RoutedEventArgs e)
        {
            ChartView.Chart.ResetGraph();
            ChartView.Chart.IsAllPolling = !ChartView.Chart.IsAllPolling;
        }

        private void ClearGraph_OnClick(object sender, RoutedEventArgs e)
        {
            ChartView.Chart.ResetGraph();
        }

        private void MultiPhaseView_OnLoaded(object sender, RoutedEventArgs e)
        {
            ChartView.LineSeries0.Color = new SolidColorBrush(Colors.DarkBlue);
            ChartView.LineSeries1.Color = new SolidColorBrush(Colors.DarkGreen);
            ChartView.LineSeries2.Color = new SolidColorBrush(Colors.DarkGoldenrod);

            ChartView.Chart.AddedGaugeViewModel =
                new Tuple<GaugeViewModel, LineSeries>(GaugeView0.DataContext as GaugeViewModel, ChartView.LineSeries0);
            ChartView.Chart.AddedGaugeViewModel =
                new Tuple<GaugeViewModel, LineSeries>(GaugeView1.DataContext as GaugeViewModel, ChartView.LineSeries1);
            ChartView.Chart.AddedGaugeViewModel =
                new Tuple<GaugeViewModel, LineSeries>(GaugeView2.DataContext as GaugeViewModel, ChartView.LineSeries2);
        }
    }
}