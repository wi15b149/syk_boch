﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QueryConsumer.SR_ServiceLogic {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_ServiceLogic.IServiceLogic")]
    public interface IServiceLogic {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogic/QueryFlights", ReplyAction="http://tempuri.org/IServiceLogic/QueryFlightsResponse")]
        System.Collections.Generic.List<Shared.Flight> QueryFlights();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogic/QueryFlights", ReplyAction="http://tempuri.org/IServiceLogic/QueryFlightsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Shared.Flight>> QueryFlightsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogic/AddFlight", ReplyAction="http://tempuri.org/IServiceLogic/AddFlightResponse")]
        int AddFlight(string no, string sp, string ep, string op);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogic/AddFlight", ReplyAction="http://tempuri.org/IServiceLogic/AddFlightResponse")]
        System.Threading.Tasks.Task<int> AddFlightAsync(string no, string sp, string ep, string op);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceLogicChannel : QueryConsumer.SR_ServiceLogic.IServiceLogic, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceLogicClient : System.ServiceModel.ClientBase<QueryConsumer.SR_ServiceLogic.IServiceLogic>, QueryConsumer.SR_ServiceLogic.IServiceLogic {
        
        public ServiceLogicClient() {
        }
        
        public ServiceLogicClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceLogicClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLogicClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLogicClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Shared.Flight> QueryFlights() {
            return base.Channel.QueryFlights();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Shared.Flight>> QueryFlightsAsync() {
            return base.Channel.QueryFlightsAsync();
        }
        
        public int AddFlight(string no, string sp, string ep, string op) {
            return base.Channel.AddFlight(no, sp, ep, op);
        }
        
        public System.Threading.Tasks.Task<int> AddFlightAsync(string no, string sp, string ep, string op) {
            return base.Channel.AddFlightAsync(no, sp, ep, op);
        }
    }
}
