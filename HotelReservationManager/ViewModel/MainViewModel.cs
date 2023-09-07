﻿using HotelReservationManager.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationManager.ViewModel
{
    internal class MainViewModel:ViewModelBase
    {
        private readonly NavigationStore _navigationStore;

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
    }
}
