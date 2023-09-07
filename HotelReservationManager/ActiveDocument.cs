using HotelReservationManager.Model;
using HotelReservationManager.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationManager
{
    internal static class ActiveDocument
    {
        public static Hotel Hotel { get; set; }

        public static NavigationStore NavigationStore { get; set; }

    }
}
