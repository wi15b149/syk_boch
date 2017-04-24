using GalaSoft.MvvmLight;

namespace WPFPresentation.ViewModel
{
    public class AgentsVm : ViewModelBase
    {
        private string name;
        private string host;
        private string time;

        public AgentsVm(string name, string host, string time)
        {
            Name = name;
            Host = host;
            Time = time;
        }


        #region Properties
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        public string Host
        {
            get { return host; }
            set
            {
                host = value;
                RaisePropertyChanged();
            }
        }

        public string Time
        {
            get { return time; }
            set
            {
                time = value;
                RaisePropertyChanged();
            }
        }

        #endregion
    }
}