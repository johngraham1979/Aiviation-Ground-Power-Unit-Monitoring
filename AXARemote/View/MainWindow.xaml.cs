using System.Windows;
using AXARemote.ViewModel;

namespace AXARemote.View
{
    public partial class MainWindow
    {
        private readonly NewPageViewModel _manualCommsViewModel;
        private readonly MultiPhaseViewModel _multiPhaseViewModel;

        public MainWindow()
        {
            InitializeComponent();
            _multiPhaseViewModel = new MultiPhaseViewModel();
            _manualCommsViewModel = new NewPageViewModel();
        }
        private void DataVisualisationView_ButtonClicked(object sender, RoutedEventArgs e)
        {
            DataContext = _multiPhaseViewModel;
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

            DataContext = _manualCommsViewModel;
        }
    }
}