using System.Collections.Generic;

namespace HotelReservationManager.Model
{
    public class ReservationBook
    {
        #region Fields

        private readonly List<Reservation> _reservation;

        #endregion Fields

        #region Constructors

        public ReservationBook()
        {
            _reservation = new List<Reservation>();
        }

        #endregion Constructors

        #region Methods

        public void AddReservation(Reservation reservation)
        {
            foreach (var existingReservation in _reservation)
            {
                if (existingReservation.Conflict(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }
            _reservation.Add(reservation);
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservation;
        }

        #endregion Methods
    }
}