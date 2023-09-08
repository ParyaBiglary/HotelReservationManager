using System;
using System.Windows.Input;

namespace HotelReservationManager.Command
{
    public abstract class CommandBase : ICommand
    {
        #region Events

        public event EventHandler CanExecuteChanged;

        #endregion Events

        #region Methods

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);

        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        #endregion Methods
    }
}