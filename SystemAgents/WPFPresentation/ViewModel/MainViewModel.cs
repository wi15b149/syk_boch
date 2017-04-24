using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System;
using Shared.Delegates;
using CoreLogic;
using Shared;
using System.ComponentModel;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Data;
using System.Windows.Input;

namespace WPFPresentation.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        

        #region Properties

        private string searchText;
        public ObservableCollection<CoreMessage> Messages { get; set; }
        public ObservableCollection<AgentsVm> Agents { get; set; }


        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        public MainViewModel()
        {
            Agents = new ObservableCollection<AgentsVm>();
            //Agents.Add(new AgentsVm("1", "1", "1"));
            Messages = new ObservableCollection<CoreMessage>();


            //TODO: LH wieder hinzufügen, Rechts filtern, Links alle

            LogicHandler lh; //  = new LogicHandler(new MessageInformer(NewMessageReceived));


            //Agents.Add(new CoreMessage("abc", "666", "abc","nachricht"));

            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                lh =  new LogicHandler(new MessageInformer(NewMessageReceived));
            }
        }

        private void NewMessageReceived(CoreMessage message)
        {
            bool addAgent = true;

            foreach (var item in Messages)
            {
                if (item.Source.Equals(message.Source))
                {
                    addAgent = false;
                }
            }
            App.Current.Dispatcher.Invoke(() => {
                Agents.Add(new AgentsVm(message.Source, "666", message.Date.ToShortTimeString()));
            });
                if (addAgent)
            {
                App.Current.Dispatcher.Invoke(() => {
                    Messages.Add(message);                   

                });
            }
           
        }
    }

}
