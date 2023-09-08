using HotelReservationManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HotelReservationManager.Command
{
    internal class CancelMakeReservationCommand : CommandBase
    {
        #region Methods

        public override void Execute(object parameter)
        {
            ActiveDocument.NavigationStore.CurrentViewModel = new ReservationListingViewModel();
        }

        #endregion Methods
    }
}
