﻿using HotelReservationManager.Command;
using HotelReservationManager.Store;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HotelReservationManager.ViewModel
{
    internal class ReservationListingViewModel : ViewModelBase
    {

        #region Fields

        private readonly ObservableCollection<ReservationViewModel> _reservations;

        #endregion Fields

        #region Constructors

        public ReservationListingViewModel(NavigationStore navigationStore)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            MakeReservationCommand = new NavigateCommand(navigationStore);
        }

        #endregion Constructors

        #region Properties

        public ICommand MakeReservationCommand { get; }
        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        #endregion Properties

    }
}