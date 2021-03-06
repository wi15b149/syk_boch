﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgentComServices.SR_AgentAdapter {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_AgentAdapter.IMessageTransmissionService")]
    public interface IMessageTransmissionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageTransmissionService/TransmitMessage", ReplyAction="http://tempuri.org/IMessageTransmissionService/TransmitMessageResponse")]
        bool TransmitMessage(Shared.CoreMessage message);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMessageTransmissionService/TransmitMessage", ReplyAction="http://tempuri.org/IMessageTransmissionService/TransmitMessageResponse")]
        System.IAsyncResult BeginTransmitMessage(Shared.CoreMessage message, System.AsyncCallback callback, object asyncState);
        
        bool EndTransmitMessage(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageTransmissionServiceChannel : AgentComServices.SR_AgentAdapter.IMessageTransmissionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransmitMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public TransmitMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MessageTransmissionServiceClient : System.ServiceModel.ClientBase<AgentComServices.SR_AgentAdapter.IMessageTransmissionService>, AgentComServices.SR_AgentAdapter.IMessageTransmissionService {
        
        private BeginOperationDelegate onBeginTransmitMessageDelegate;
        
        private EndOperationDelegate onEndTransmitMessageDelegate;
        
        private System.Threading.SendOrPostCallback onTransmitMessageCompletedDelegate;
        
        public MessageTransmissionServiceClient() {
        }
        
        public MessageTransmissionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MessageTransmissionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MessageTransmissionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MessageTransmissionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<TransmitMessageCompletedEventArgs> TransmitMessageCompleted;
        
        public bool TransmitMessage(Shared.CoreMessage message) {
            return base.Channel.TransmitMessage(message);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginTransmitMessage(Shared.CoreMessage message, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginTransmitMessage(message, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool EndTransmitMessage(System.IAsyncResult result) {
            return base.Channel.EndTransmitMessage(result);
        }
        
        private System.IAsyncResult OnBeginTransmitMessage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Shared.CoreMessage message = ((Shared.CoreMessage)(inValues[0]));
            return this.BeginTransmitMessage(message, callback, asyncState);
        }
        
        private object[] OnEndTransmitMessage(System.IAsyncResult result) {
            bool retVal = this.EndTransmitMessage(result);
            return new object[] {
                    retVal};
        }
        
        private void OnTransmitMessageCompleted(object state) {
            if ((this.TransmitMessageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.TransmitMessageCompleted(this, new TransmitMessageCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void TransmitMessageAsync(Shared.CoreMessage message) {
            this.TransmitMessageAsync(message, null);
        }
        
        public void TransmitMessageAsync(Shared.CoreMessage message, object userState) {
            if ((this.onBeginTransmitMessageDelegate == null)) {
                this.onBeginTransmitMessageDelegate = new BeginOperationDelegate(this.OnBeginTransmitMessage);
            }
            if ((this.onEndTransmitMessageDelegate == null)) {
                this.onEndTransmitMessageDelegate = new EndOperationDelegate(this.OnEndTransmitMessage);
            }
            if ((this.onTransmitMessageCompletedDelegate == null)) {
                this.onTransmitMessageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTransmitMessageCompleted);
            }
            base.InvokeAsync(this.onBeginTransmitMessageDelegate, new object[] {
                        message}, this.onEndTransmitMessageDelegate, this.onTransmitMessageCompletedDelegate, userState);
        }
    }
}
