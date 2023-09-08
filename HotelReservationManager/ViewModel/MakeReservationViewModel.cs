using HotelReservationManager.Command;
using System;
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
            SubmitCommand = new MakeReservationCommand(this);
            CancelCommand = new CancelMakeReservationCommand();
        }

        #endregion Constructors

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
                _endtDate = value;
                OnPropertyChanged(nameof(EndtDate));
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
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
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
                _roomNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
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
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        public ICommand SubmitCommand { get; }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        #endregion Properties

    }
}