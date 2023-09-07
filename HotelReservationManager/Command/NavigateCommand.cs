using HotelReservationManager.Model;
using HotelReservationManager.Store;
using HotelReservationManager.ViewModel;

namespace HotelReservationManager.Command
{
    internal class NavigateCommand : CommandBase
    {
        #region Fields

        private readonly NavigationStore _navigationStore;

        #endregion Fields

        #region Constructors

        public NavigateCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        #endregion Constructors

        #region Methods

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new MakeReservationViewModel();
        }

        #endregion Methods
    }
}