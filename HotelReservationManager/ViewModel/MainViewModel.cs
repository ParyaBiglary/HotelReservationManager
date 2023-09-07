using HotelReservationManager.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationManager.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
        }

        public ViewModelBase CurrentViewModel => ActiveDocument.NavigationStore.CurrentViewModel;
    }
}
