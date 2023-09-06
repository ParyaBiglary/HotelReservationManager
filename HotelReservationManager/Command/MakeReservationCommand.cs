using HotelReservationManager.Model;
using HotelReservationManager.ViewModel;
using System.Windows;

namespace HotelReservationManager.Command
{
    internal class MakeReservationCommand : CommandBase
    {

        #region Fields

        private readonly MakeReservationViewModel _makeReservationViewModel;

        #endregion Fields

        #region Constructors

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _makeReservationViewModel.PropertyChanged += _makeReservationViewModel_PropertyChanged;
        }

        #endregion Constructors

        #region Methods

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.UserName) && _makeReservationViewModel.FloorNumber > 0 &&
                _makeReservationViewModel.RoomNumber > 0 &&
                base.CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            Reservation reservation = new Reservation(new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber), _makeReservationViewModel.UserName, _makeReservationViewModel.StartDate, _makeReservationViewModel.EndtDate);

            try
            {
                ActiveDocument.Hotel.MakeReservation(reservation);
                MessageBox.Show("Your Room reserved SUCCESSFULLY", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ReservationConflictException)
            {
                MessageBox.Show("This Room is already taken,SORRY!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void _makeReservationViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals(nameof(MakeReservationViewModel.UserName))
                || e.PropertyName.Equals(nameof(MakeReservationViewModel.FloorNumber))
                || e.PropertyName.Equals(nameof(MakeReservationViewModel.RoomNumber))
                )
            {
                OnCanExecuteChanged();
            }
        }

        #endregion Methods
    }
}