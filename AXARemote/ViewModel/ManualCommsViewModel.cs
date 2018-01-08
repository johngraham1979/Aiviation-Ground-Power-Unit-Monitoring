namespace AXARemote.ViewModel
{
    public class ManualCommsViewModel : GaugeViewModel
    {
        private double _barGraphScale = 20;

        public double BarGraphScale
        {
            get => _barGraphScale;
            set
            {
                if (Equals(_barGraphScale, value))
                    return;
                _barGraphScale = value;
                OnPropertyChanged(nameof(BarGraphScale));
            }
        }
    }
}