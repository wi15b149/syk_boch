using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using QueryConsumer.SR_ServiceLogic;

namespace NewFlightsWpf.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private string newFlightNo;
        private string newStartPoint;
        private string newEndPoint;
        private string newOperator;  

        public RelayCommand Save2DbCmd { get; set; }

        #region Properties
        public string NewStartpoint
        {
            get { return newStartPoint; }
            set
            {
                newStartPoint = value;
                RaisePropertyChanged();
            }

        }
        public string NewEndpoint
        {
            get { return newEndPoint; }
            set
            {
                newEndPoint = value;
                RaisePropertyChanged();
            }

        }
        public string NewOperator
        {
            get { return newOperator; }
            set
            {
                newOperator = value;
                RaisePropertyChanged();
            }

        }
        public string NewFlightNo
        {
            get { return newFlightNo; }
            set { newFlightNo = value; }
        }

        #endregion


        public MainViewModel()
        {
            Save2DbCmd = new RelayCommand(Save2DbCmdClicked);
            ////if (!IsInDesignMode)
            ////{
            ////    
            ////}
        }

        private void Save2DbCmdClicked()
        {
            ServiceLogicClient client = new ServiceLogicClient("tcp");
            client.AddFlight(NewFlightNo, NewStartpoint, newEndPoint, NewOperator);
         }
    }
}