using DataLayer;
using LayerService;
using MQCommunication;
using Shared;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayerLogic
{
    public class PersonHandler
    {
        IPersonQueryable repositoryA = new Repo("A");
        IPersonQueryable repositoryB = new Repo("B");

        public PersonHandler()
        {
            Task.Factory.StartNew(StartMqReading);

            repositoryA.AddPerson(new Person("Michael Boch1", Guid.NewGuid(), 1, 666, true));
            repositoryA.AddPerson(new Person("Michael Boch2", Guid.NewGuid(), 1, 777, false));
            repositoryA.AddPerson(new Person("Michael Boch3", Guid.NewGuid(), 0, 888, true));

            repositoryB.AddPerson(new Person("Michael Boch6", Guid.NewGuid(), 1, 111, true));
            repositoryB.AddPerson(new Person("Michael Boch7", Guid.NewGuid(), 0, 222, false));
            repositoryB.AddPerson(new Person("Michael Boch8", Guid.NewGuid(), 1, 333, true));
        }

        private void StartMqReading()
        {
            //Instance of our MQ
            MqHandler<Person> mq = new MqHandler<Person>(@".\private$\SycoMq");
            while (true)
            {
                //Write to our DB
                repositoryA.AddPerson(mq.Receive());
            }
        }

        private void StartServices()
        {
            //start VS as admin!
            ServiceHost host = new ServiceHost(typeof(PersonProvider));
            PersonProvider.InitService(MessageReceived);
            //host.SetEndpointAddress(new ServiceEndpoint(new ContractDescription("http")), "/http");
            host.Open();
        }

        private void MessageReceived(Person p)
        {
            repositoryA.AddPerson(p);
        }
    }
}
