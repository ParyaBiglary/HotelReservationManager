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
        }

        #endregion Constructors

        #region Methods

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

        #endregion Methods
    }
}