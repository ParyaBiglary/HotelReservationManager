using HotelReservationManager.ViewModel;
using System;

namespace HotelReservationManager.Store
{
    public class NavigationStore
    {

        #region Fields

        private ViewModelBase _currentViewModel;

        private MakeReservationViewModel _makeReservationViewModel;
        private ReservationListingViewModel _reservationListingViewModel;

        #endregion Fields

        #region Events

        public event EventHandler<ViewModelBase> CurrentViewModelChanged;

        #endregion Events

        #region Properties

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;

                if (value is ReservationListingViewModel reservationListingViewModel)
                {
                    _reservationListingViewModel = reservationListingViewModel;
                }
                else if (value is MakeReservationViewModel makeReservationViewModel)
                {
                    _makeReservationViewModel = makeReservationViewModel;
                }

                CurrentViewModelChanged?.Invoke(this, _currentViewModel);
            }
        }

        internal MakeReservationViewModel MakeReservationViewModel
        {
            get
            {
                return _makeReservationViewModel;
            }
        }

        internal ReservationListingViewModel ReservationListingViewModel
        {
            get
            {
                return _reservationListingViewModel;
            }
        }

        #endregion Properties
    }
}