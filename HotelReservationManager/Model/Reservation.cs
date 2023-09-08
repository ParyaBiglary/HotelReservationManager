using System;

namespace HotelReservationManager.Model
{
    public class Reservation
    {

        #region Constructors

        public Reservation(RoomID roomID, string username, DateTime startDate, DateTime endDate)
        {
            RoomID = roomID;
            Username = username;
            StartDate = startDate;
            EndDate = endDate;
        }

        #endregion Constructors

        #region Properties

        public DateTime EndDate { get; }

        public TimeSpan Length
        {
            get
            {
                return EndDate.Subtract(StartDate);
            }
        }

        public RoomID RoomID { get; }
        public DateTime StartDate { get; }
        public string Username { get; }

        #endregion Properties

        #region Methods

        public bool Conflict(Reservation reservation)
        {
            if (!reservation.RoomID.Equals(RoomID))
            {
                return false;
            }

            return (reservation.StartDate < EndDate) && (reservation.EndDate > StartDate);
        }

        #endregion Methods

    }
}