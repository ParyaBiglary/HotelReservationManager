using HotelReservationManager.Model;
using HotelReservationManager.Store;

namespace HotelReservationManager
{
    internal static class ActiveDocument
    {
        #region Properties

        public static Hotel Hotel { get; set; }

        public static NavigationStore NavigationStore { get; set; }

        #endregion Properties
    }
}