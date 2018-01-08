using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using AXARemote.Command;
using AXARemote.Model;
using AXARemote.Properties;

namespace AXARemote.ViewModel
{
    public class GaugeViewModel : Axa2400, INotifyPropertyChanged
    {
        private IList<KeyValuePair<double, double>> __chartPoints =
            new List<KeyValuePair<double, double>>();

        private ObservableCollection<KeyValuePair<double, double>> _chartPoints =
            new ObservableCollection<KeyValuePair<double, double>>();

        private Tuple<string, Func<int, int, dynamic>> _functionCodeSelection;

        private double _gaugeValue;


        private bool _plotting;

        private double _pollRate;

        private Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>> _powerDictionarySelection;

        private int _registerAddress;

        private double _scalingFactor;

        private double _tick;

        public ObservableCollection<KeyValuePair<double, double>> ChartPoints
        {
            get => _chartPoints;
            set
            {
                if (Equals(value, _chartPoints))
                    return;
                _chartPoints = value;
                OnPropertyChanged(nameof(ChartPoints));
            }
        }

        public double GaugeValue
        {
            get => _gaugeValue;
            set
            {
                _gaugeValue = value;
                Plot();

                OnPropertyChanged(nameof(GaugeValue));
            }
        }

        public Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>> PowerDictionarySelection
        {
            get => _powerDictionarySelection;
            set
            {
                if (Equals(value, _powerDictionarySelection))
                    return;
                _powerDictionarySelection = value;
                FunctionCodeSelection = value.Item4;
                RegisterAddress = value.Item2;
                ScalingFactor = value.Item3;
                OnPropertyChanged(nameof(PowerDictionarySelection));
            }
        }

        public Tuple<string, Func<int, int, dynamic>> FunctionCodeSelection
        {
            get => _functionCodeSelection;
            set
            {
                if (Equals(value, _functionCodeSelection))
                    return;
                _functionCodeSelection = value;
                OnPropertyChanged(nameof(FunctionCodeSelection));
            }
        }

        public int RegisterAddress
        {
            get => _registerAddress;
            set
            {
                if (Equals(value, _registerAddress))
                    return;
                _registerAddress = value;
                OnPropertyChanged(nameof(RegisterAddress));
            }
        }

        public double ScalingFactor
        {
            get => _scalingFactor;
            set
            {
                if (Equals(value, _scalingFactor))
                    return;
                _scalingFactor = value;
                OnPropertyChanged(nameof(ScalingFactor));
            }
        }

        public double PollRate
        {
            get => _pollRate;
            set
            {
                if (Equals(value, _pollRate))
                    return;
                _pollRate = value;
                OnPropertyChanged(nameof(PollRate));
            }
        }

        private double Tick
        {
            get => _tick;
            set
            {
                if (Equals(value, _tick))
                    return;
                _tick = value;
                OnPropertyChanged(nameof(Tick));
            }
        }

        public bool IsRunning => _tokenSource != null && !_tokenSource.IsCancellationRequested;

        public bool Plotting
        {
            get => _plotting;
            set
            {
                if (Equals(value, _plotting))
                    return;
                _plotting = value;
                OnPropertyChanged(nameof(Plotting));
            }
        }

        private void Plot()
        {
            if (!Plotting)
                return;

            __chartPoints.Add(new KeyValuePair<double, double>(Tick, GaugeValue));

            if (Convert.ToInt32(Tick) % 10 == 0)
                Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                {
                    __chartPoints.ToList().ForEach(keyValuePair => ChartPoints.Add(keyValuePair));
                    __chartPoints = new List<KeyValuePair<double, double>>();
                }));
        }

        #region ICommands

        private CancellationTokenSource _tokenSource;
        private Task _taskWithToken;

        public RelayCommand StartCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (FunctionCodeSelection == null)
                    {
                        MessageBox.Show("No function code has been selected.");
                        return;
                    }
                    if (IsRunning)
                    {
                        MessageBox.Show("Polling seems to be already taking place for this meter.");
                        return;
                    }

                    _tokenSource = new CancellationTokenSource();
                    var token = _tokenSource.Token;

                    _taskWithToken = new Task(async() =>
                    {

                        if(!Connected)
                        Connect();
                        Tick = 0;
                        while (IsRunning)
                        {
                            GaugeValue = FunctionCodeSelection?.Item2.Invoke(RegisterAddress, 1)[0] / ScalingFactor;

                            await Task.Delay(1000 / (int) PollRate);

                            Tick += 1 / PollRate;
                        }
                    }, token, TaskCreationOptions.LongRunning);

                    _taskWithToken.Start();
                    OnPropertyChanged(nameof(IsRunning));
                }, o => true);
            }
        }

        public RelayCommand StopCommand
        {
            get
            {
                return new RelayCommand(() =>
                    {
                        _tokenSource?.Cancel();
                        _taskWithToken?.Wait();
                        Disconnect();
                        _tokenSource = null;
                        OnPropertyChanged(nameof(IsRunning));
                    }
                    , o => true);
            }
        }

        public RelayCommand ClearPlotCommand
        {
            get
            {
                return new RelayCommand(() => { ChartPoints.Clear(); }
                    , o => true);
            }
        }

        #endregion

        #region PropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}