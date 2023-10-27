using CommunityToolkit.Mvvm.Input;
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

        public ReservationListingViewModel()
        {
            var reservations = ActiveDocument.Hotel.GetAllReservations();

            _reservations = new ObservableCollection<ReservationViewModel>();

            foreach (var reservation in reservations)
            {
                var reservationVM = new ReservationViewModel(reservation);

                _reservations.Add(reservationVM);
            }

            MakeReservationCommand = new RelayCommand(ExecuteMRC);
        }


        #endregion Constructors
        public  void ExecuteMRC()
        {
            ActiveDocument.NavigationStore.CurrentViewModel = new MakeReservationViewModel();
        }

        #region Properties

        public ICommand MakeReservationCommand { get; }
        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        #endregion Properties

    }
}