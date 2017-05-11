using GalaSoft.MvvmLight;
using Shared;
using System.Collections.ObjectModel;
using System;
using QueryConsumer.SR_ServiceLogic;
using System.Threading.Tasks;

namespace QueryConsumer.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Flight> Flights { get; set; }

        public MainViewModel()
        {
            Flights = new ObservableCollection<Flight>();

           Task.Factory.StartNew(QueryFlights);
            
            
            ////if (!IsInDesignMode)
            ////{
            ////    
            ////}
           
        }      

        private void QueryFlights()
        {
            ServiceLogicClient client = new ServiceLogicClient("http");
            foreach (var item in client.QueryFlights())
            {
                Flights.Add(new Flight()
                {
                    FlightID = item.FlightID,
                    FlightNo = item.FlightNo,
                    StartPoint = item.StartPoint,
                    EndPoint = item.EndPoint,
                    Operator = item.Operator
                });
            }
        }
    }
}