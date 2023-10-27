using CommunityToolkit.Mvvm.Input;
using HotelReservationManager.Model;
using System;
using System.Windows;
using System.Windows.Input;

namespace HotelReservationManager.ViewModel
{
    internal class MakeReservationViewModel : ViewModelBase
    {
        #region Fields

        private DateTime _endtDate = DateTime.Now;
        private int _floorNumber;
        private int _roomNumber;
        private DateTime _startDate = DateTime.Now;
        private string _userName;

        #endregion Fields

        #region Constructors

        public MakeReservationViewModel()
        {
            SubmitCommand = new RelayCommand(ExecuteSubmit,CanExecuteSubmit);
            CancelCommand = new RelayCommand(ExecuteCancel);

            PropertyChanged += _makeReservationViewModel_PropertyChanged;
        }

        #endregion Constructors

        #region Submit Command

        public void ExecuteSubmit()
        {
            Reservation reservation = new Reservation(new RoomID(FloorNumber,RoomNumber),UserName,StartDate,EndtDate);

            try
            {
                ActiveDocument.Hotel.MakeReservation(reservation);
                MessageBox.Show("Your room reserved succesfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                ActiveDocument.NavigationStore.CurrentViewModel = new ReservationListingViewModel();
            }
            catch (ReservationConflictException)
            {
                MessageBox.Show("This Room is already taken, PLease reschedule.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public bool CanExecuteSubmit()
        {
            return !string.IsNullOrEmpty(UserName) && FloorNumber > 0 &&
                RoomNumber > 0 ;
        }

        private void _makeReservationViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals(nameof(UserName))
                || e.PropertyName.Equals(nameof(FloorNumber))
                || e.PropertyName.Equals(nameof(RoomNumber))
                )
            {
                SubmitCommand.NotifyCanExecuteChanged();
            }
        }

        #endregion
        #region Cancel Command
        public  void ExecuteCancel()
        {
            ActiveDocument.NavigationStore.CurrentViewModel = new ReservationListingViewModel();
        }
        #endregion

        #region Properties

        public ICommand CancelCommand { get; }

        public DateTime EndtDate
        {
            get
            {
                return _endtDate;
            }
            set
            {
                SetProperty(ref _endtDate, value);
            }
        }

        public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }
            set
            {
                SetProperty(ref _floorNumber, value);
            }
        }

        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                SetProperty(ref _roomNumber, value);
            }
        }

        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                SetProperty(ref _startDate, value);
            }
        }

        public RelayCommand SubmitCommand { get; }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                SetProperty(ref _userName, value);
            }
        }

        #endregion Properties
    }
}