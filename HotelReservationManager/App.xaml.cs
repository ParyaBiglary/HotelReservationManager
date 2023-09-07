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

        private readonly NavigationStore _navigationStore;

        #endregion Fields

        #region Constructors

        public App()
        {
            _navigationStore = new NavigationStore();
        }

        #endregion Constructors

        #region Methods

        protected override void OnStartup(StartupEventArgs e)
        {
            var hotel = new Hotel("Happy Fairytale");
            ActiveDocument.Hotel = hotel;
            _navigationStore.CurrentViewModel = new ReservationListingViewModel(_navigationStore);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        #endregion Methods
    }
}