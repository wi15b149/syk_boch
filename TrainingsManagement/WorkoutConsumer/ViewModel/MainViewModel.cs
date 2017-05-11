using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Shared;
using System.Collections.ObjectModel;
using WorkoutConsumer.SR_WorkoutService;

namespace WorkoutConsumer.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        
        private ObservableCollection<Workout> searchResult;
        WorkoutServiceClient client = new WorkoutServiceClient();

        #region Properties
        public RelayCommand SearchBtnClicked { get; set; }
        public string SearchTerm { get; set; }
        public ObservableCollection<Workout> SearchResult
        {
            get { return searchResult; }
            set { searchResult = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        public MainViewModel()
        {           
                SearchBtnClicked = new RelayCommand(() =>
                {
                    SearchResult.Clear();
                    //RaisePropertyChanged() nicht vergessen!
                    SearchResult = new ObservableCollection<Workout>(client.QueryWorkouts(SearchTerm));
                });
        }
    }
}