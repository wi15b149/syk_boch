﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceConsumer.SR_WebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastnameField;
        
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WebServiceConsumer.SR_WebService.SkillSet> SkillsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Lastname {
            get {
                return this.LastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastnameField, value) != true)) {
                    this.LastnameField = value;
                    this.RaisePropertyChanged("Lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public System.Collections.Generic.List<WebServiceConsumer.SR_WebService.SkillSet> Skills {
            get {
                return this.SkillsField;
            }
            set {
                if ((object.ReferenceEquals(this.SkillsField, value) != true)) {
                    this.SkillsField = value;
                    this.RaisePropertyChanged("Skills");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SkillSet", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class SkillSet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private int RankField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Rank {
            get {
                return this.RankField;
            }
            set {
                if ((this.RankField.Equals(value) != true)) {
                    this.RankField = value;
                    this.RaisePropertyChanged("Rank");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_WebService.SimpleWebServiceSoap")]
    public interface SimpleWebServiceSoap {
        
        // CODEGEN: Es wird ein Nachrichtenvertrag generiert, da Elementname lastname aus Namespace http://tempuri.org/ nicht als "nillable" (nullwertfähig) gekennzeichnet ist.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DoWork", ReplyAction="*")]
        WebServiceConsumer.SR_WebService.DoWorkResponse DoWork(WebServiceConsumer.SR_WebService.DoWorkRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DoWork", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceConsumer.SR_WebService.DoWorkResponse> DoWorkAsync(WebServiceConsumer.SR_WebService.DoWorkRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DoWorkRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DoWork", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceConsumer.SR_WebService.DoWorkRequestBody Body;
        
        public DoWorkRequest() {
        }
        
        public DoWorkRequest(WebServiceConsumer.SR_WebService.DoWorkRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DoWorkRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string lastname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string firstname;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int age;
        
        public DoWorkRequestBody() {
        }
        
        public DoWorkRequestBody(string lastname, string firstname, int age) {
            this.lastname = lastname;
            this.firstname = firstname;
            this.age = age;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DoWorkResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DoWorkResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceConsumer.SR_WebService.DoWorkResponseBody Body;
        
        public DoWorkResponse() {
        }
        
        public DoWorkResponse(WebServiceConsumer.SR_WebService.DoWorkResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DoWorkResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceConsumer.SR_WebService.Person DoWorkResult;
        
        public DoWorkResponseBody() {
        }
        
        public DoWorkResponseBody(WebServiceConsumer.SR_WebService.Person DoWorkResult) {
            this.DoWorkResult = DoWorkResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SimpleWebServiceSoapChannel : WebServiceConsumer.SR_WebService.SimpleWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimpleWebServiceSoapClient : System.ServiceModel.ClientBase<WebServiceConsumer.SR_WebService.SimpleWebServiceSoap>, WebServiceConsumer.SR_WebService.SimpleWebServiceSoap {
        
        public SimpleWebServiceSoapClient() {
        }
        
        public SimpleWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimpleWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceConsumer.SR_WebService.DoWorkResponse WebServiceConsumer.SR_WebService.SimpleWebServiceSoap.DoWork(WebServiceConsumer.SR_WebService.DoWorkRequest request) {
            return base.Channel.DoWork(request);
        }
        
        public WebServiceConsumer.SR_WebService.Person DoWork(string lastname, string firstname, int age) {
            WebServiceConsumer.SR_WebService.DoWorkRequest inValue = new WebServiceConsumer.SR_WebService.DoWorkRequest();
            inValue.Body = new WebServiceConsumer.SR_WebService.DoWorkRequestBody();
            inValue.Body.lastname = lastname;
            inValue.Body.firstname = firstname;
            inValue.Body.age = age;
            WebServiceConsumer.SR_WebService.DoWorkResponse retVal = ((WebServiceConsumer.SR_WebService.SimpleWebServiceSoap)(this)).DoWork(inValue);
            return retVal.Body.DoWorkResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceConsumer.SR_WebService.DoWorkResponse> WebServiceConsumer.SR_WebService.SimpleWebServiceSoap.DoWorkAsync(WebServiceConsumer.SR_WebService.DoWorkRequest request) {
            return base.Channel.DoWorkAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceConsumer.SR_WebService.DoWorkResponse> DoWorkAsync(string lastname, string firstname, int age) {
            WebServiceConsumer.SR_WebService.DoWorkRequest inValue = new WebServiceConsumer.SR_WebService.DoWorkRequest();
            inValue.Body = new WebServiceConsumer.SR_WebService.DoWorkRequestBody();
            inValue.Body.lastname = lastname;
            inValue.Body.firstname = firstname;
            inValue.Body.age = age;
            return ((WebServiceConsumer.SR_WebService.SimpleWebServiceSoap)(this)).DoWorkAsync(inValue);
        }
    }
}