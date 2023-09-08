using HotelReservationManager.Model;
using System;

namespace HotelReservationManager.ViewModel
{
    internal class ReservationViewModel : ViewModelBase
    {
        #region Fields

        private readonly Reservation _reservation;

        #endregion Fields

        #region Constructors

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }

        #endregion Constructors

        #region Properties

        public DateTime EndDate => _reservation.EndDate;
        public string RoomID => _reservation.RoomID?.ToString();
        public DateTime StartDate => _reservation.StartDate;
        public string Username => _reservation.Username;

        #endregion Properties
    }
}