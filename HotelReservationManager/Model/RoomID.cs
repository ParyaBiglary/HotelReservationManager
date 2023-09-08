namespace HotelReservationManager.Model
{
    public class RoomID
    {

        #region Constructors

        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        #endregion Constructors

        #region Properties

        public int FloorNumber { get; }
        public int RoomNumber { get; }

        #endregion Properties

        #region Methods

        public override bool Equals(object obj)
        {
            return obj is RoomID roomID && FloorNumber == roomID.FloorNumber && RoomNumber == roomID.RoomNumber;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + FloorNumber.GetHashCode();
                hash = hash * 23 + RoomNumber.GetHashCode();
                return hash;
            }
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }

        #endregion Methods

    }
}