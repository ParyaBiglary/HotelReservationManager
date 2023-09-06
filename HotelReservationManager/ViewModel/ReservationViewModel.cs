using HotelReservationManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationManager.ViewModel
{
    internal class ReservationViewModel: ViewModelBase
    {
        private readonly Reservation _reservation;

        public string Username => _reservation.Username;
        public string RoomID=> _reservation.RoomID?.ToString();
        public DateTime StartDate=> _reservation.StartDate;
        public DateTime EndDate => _reservation.EndDate;
        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }

    }
}
