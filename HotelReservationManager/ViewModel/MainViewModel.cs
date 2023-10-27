namespace HotelReservationManager.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        #region Fields

        private ViewModelBase _currentViewModel;

        #endregion Fields

        #region Constructors

        public MainViewModel()
        {
            _currentViewModel = ActiveDocument.NavigationStore.CurrentViewModel;

            ActiveDocument.NavigationStore.CurrentViewModelChanged += NavigationStore_CurrentViewModelChanged;
        }

        #endregion Constructors

        #region Properties

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                SetProperty(ref _currentViewModel, value);
            }
        }

        #endregion Properties

        #region Methods

        private void NavigationStore_CurrentViewModelChanged(object sender, ViewModelBase e)
        {
            CurrentViewModel = e;
        }

        #endregion Methods
    }
}