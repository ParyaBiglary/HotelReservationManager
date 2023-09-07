using HotelReservationManager.Model;
using HotelReservationManager.Store;
using HotelReservationManager.ViewModel;
using System.Windows;

namespace HotelReservationManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Fields

        #endregion Fields

        #region Constructors

        public App()
        {
            ActiveDocument.NavigationStore = new NavigationStore();
        }

        #endregion Constructors

        #region Methods

        protected override void OnStartup(StartupEventArgs e)
        {
            var hotel = new Hotel("Happy Fairytale");
            ActiveDocument.Hotel = hotel;
            ActiveDocument.NavigationStore.CurrentViewModel = new ReservationListingViewModel();

            base.OnStartup(e);
        }

        #endregion Methods
    }
}