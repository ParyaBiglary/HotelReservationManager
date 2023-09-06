using System.Collections.Generic;

namespace HotelReservationManager.Model
{
    public class Hotel
    {
        #region Fields

        private readonly ReservationBook _reservationBook;

        #endregion Fields

        #region Constructors

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        #endregion Constructors

        #region Properties

        public string Name { get; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Get the reservations for a user
        /// </summary>
        /// <param name="username">
        /// The username of the user.
        /// </param>
        /// <returns>
        /// The reservations for the user.
        /// </returns>
        public IEnumerable<Reservation> GetAllReservations(string username)
        {
            return _reservationBook.GetAllReservations();
        }

        /// <summary>
        /// Make a reservation.
        /// </summary>
        /// <param name="reservation">
        /// The incoming reservation
        /// </param>
        /// <exception cref="ReservationConflictException">
        /// </exception>
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }

        #endregion Methods
    }
}