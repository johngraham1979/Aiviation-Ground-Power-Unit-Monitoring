using System;
using System.Windows.Input;

namespace AXARemote.Command
{
    public class RelayCommand : ICommand
    {
        private readonly Action _action;
        private readonly Predicate<object> _predicate;

        public RelayCommand(Action action, Predicate<object> predicate)
        {
            _action = action;
            _predicate = predicate;
        }

        public bool CanExecute(object parameter = null)
        {
            return _predicate(parameter);
        }

        public void Execute(object parameter)
        {
            if (_action != null && CanExecute())
                _action();
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        private static void OnCanExecuteChanged(EventArgs e)
        {
            CommandManager.InvalidateRequerySuggested();
        }

        public void RaiseCanExecuteChanged()
        {
            OnCanExecuteChanged(new EventArgs());
        }
    }
}