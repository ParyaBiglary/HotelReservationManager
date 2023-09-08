using System;

namespace HotelReservationManager.Model
{
    [Serializable]
    public class ReservationConflictException : Exception
    {

        #region Constructors

        public ReservationConflictException(string message, Reservation existingReservation, Reservation incomingReservation) : base(message)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictException(string message, Exception inner, Reservation existingReservation, Reservation incomingReservation) : base(message, inner)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictException(Reservation existingReservation, Reservation incomingReservation)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        protected ReservationConflictException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        #endregion Constructors

        #region Properties

        public Reservation ExistingReservation { get; set; }
        public Reservation IncomingReservation { get; set; }

        #endregion Properties

    }
}