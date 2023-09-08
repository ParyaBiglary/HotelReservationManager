using HotelReservationManager.ViewModel;

namespace HotelReservationManager.Command
{
    internal class NavigateCommand : CommandBase
    {

        #region Constructors

        public NavigateCommand()
        {
        }

        #endregion Constructors

        #region Methods

        public override void Execute(object parameter)
        {
            ActiveDocument.NavigationStore.CurrentViewModel = new MakeReservationViewModel();
        }

        #endregion Methods

    }
}