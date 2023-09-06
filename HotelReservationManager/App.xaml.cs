using HotelReservationManager.Model;
using HotelReservationManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelReservationManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var hotel = new Hotel("Happy Fairytale");
            ActiveDocument.Hotel = hotel;
            base.OnStartup(e);
        }
    }
}
