using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System;
using MQCommunication;
using Shared;

namespace AddDataApplication.ViewModel
{

    public class MainViewModel : ViewModelBase
    {

        public ObservableCollection<string> Targets { get; set; }
        public ObservableCollection<int> Types { get; set; }
        private string newName;

        private decimal newSalary;

        private bool newOwnskey;

        private string selectedTarget;

        private int selectedType;

        public RelayCommand SaveBtnCmd { get; set; }

        private MqHandler<Person> mq = new MqHandler<Person>(@".\private$\CD5");

        #region Properties
        public string SelectedTarget
        {
            get { return selectedTarget; }
            set
            {
                selectedTarget = value;
                RaisePropertyChanged();
            }
        }

        public int SelectedType
        {
            get { return selectedType; }
            set
            {
                selectedType = value;
                RaisePropertyChanged();
            }
        }

        public string NewName
        {
            get { return newName; }
            set
            {
                newName = value;
                RaisePropertyChanged();
            }
        }

        public bool NewOwnskey
        {
            get { return newOwnskey; }
            set
            {
                newOwnskey = value;
                RaisePropertyChanged();
            }
        }

        public decimal NewSalary
        {
            get { return newSalary; }
            set
            {
                newSalary = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        public MainViewModel()
        {
            FillTargets();
            FillTypes();           
            
            SaveBtnCmd = new RelayCommand(MqSend);

            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        private void FillTypes()
        {
            Types = new ObservableCollection<int>();
            Types.Add(0);
            Types.Add(1);
        }

        private void FillTargets()
        {
           Targets = new ObservableCollection<string>();
            Targets.Add("RepoA");
            Targets.Add("RepoB");
        }

        private void MqSend()
        {            
            mq.Send(new Person(NewName, Guid.NewGuid(), SelectedType, NewSalary, NewOwnskey));
        }

    }
}