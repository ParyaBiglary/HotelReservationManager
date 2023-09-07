using HotelReservationManager.ViewModel;

namespace HotelReservationManager.Store
{
    public class NavigationStore
    {
        #region Fields

        private ViewModelBase _currentViewModel;

        #endregion Fields

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
            }
        }

        #endregion Properties
    }
}