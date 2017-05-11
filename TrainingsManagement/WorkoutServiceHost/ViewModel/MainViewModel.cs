using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using ServiceProvider;
using Shared;
using System.Collections.ObjectModel;
using System.ServiceModel;
using TrainingsDataRepository;

namespace WorkoutServiceHost.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        private bool isServiceRunning;
        private ObservableCollection<string> logList;
        private DataHandler dh = new DataHandler();

        #region Properties

        public RelayCommand AddBtnClickedCmd { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int Level { get; set; }
        public string Exercises { get; set; }
        

        public bool IsServiceRunning
        {
            get { return isServiceRunning; }
            set { isServiceRunning = value;
                RaisePropertyChanged();
            }
        }
        public ObservableCollection<string> LogList
        {
            get { return logList; }
            set { logList = value; }
        }


        #endregion

        public MainViewModel()
        {
            AddBtnClickedCmd = new RelayCommand(
                () =>
                {
                    //add entries to DB
                    dh.AddWorkout(new Workout()
                    {
                        Description = Description,
                        Duration = Duration,
                        Exercises = Exercises,
                        Intensity = Level
                    });
                });
            if (!IsInDesignMode)
            {
                //Service hosten
                //System.ServiceModel aus App.Config Service
                //Connection Strings aus App.Config Data 
                ServiceHost host = new ServiceHost(typeof(WorkoutService));
                host.Open();
                IsServiceRunning = true;
            }
        }

    }
}