﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppCollectorAgent.SR_RunningAppsQueryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_RunningAppsQueryService.RunningAppsQueryServiceSoap")]
    public interface RunningAppsQueryServiceSoap {
        
        // CODEGEN: Es wird ein Nachrichtenvertrag generiert, da Elementname QueryAppsResult aus Namespace http://tempuri.org/ nicht als "nillable" (nullwertfähig) gekennzeichnet ist.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryApps", ReplyAction="*")]
        AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsResponse QueryApps(AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryApps", ReplyAction="*")]
        System.Threading.Tasks.Task<AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsResponse> QueryAppsAsync(AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryAppsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryApps", Namespace="http://tempuri.org/", Order=0)]
        public AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequestBody Body;
        
        public QueryAppsRequest() {
        }
        
        public QueryAppsRequest(AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class QueryAppsRequestBody {
        
        public QueryAppsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QueryAppsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QueryAppsResponse", Namespace="http://tempuri.org/", Order=0)]
        public AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsResponseBody Body;
        
        public QueryAppsResponse() {
        }
        
        public QueryAppsResponse(AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QueryAppsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AppCollectorAgent.SR_RunningAppsQueryService.ArrayOfString QueryAppsResult;
        
        public QueryAppsResponseBody() {
        }
        
        public QueryAppsResponseBody(AppCollectorAgent.SR_RunningAppsQueryService.ArrayOfString QueryAppsResult) {
            this.QueryAppsResult = QueryAppsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RunningAppsQueryServiceSoapChannel : AppCollectorAgent.SR_RunningAppsQueryService.RunningAppsQueryServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RunningAppsQueryServiceSoapClient : System.ServiceModel.ClientBase<AppCollectorAgent.SR_RunningAppsQueryService.RunningAppsQueryServiceSoap>, AppCollectorAgent.SR_RunningAppsQueryService.RunningAppsQueryServiceSoap {
        
        public RunningAppsQueryServiceSoapClient() {
        }
        
        public RunningAppsQueryServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RunningAppsQueryServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RunningAppsQueryServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RunningAppsQueryServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsResponse AppCollectorAgent.SR_RunningAppsQueryService.RunningAppsQueryServiceSoap.QueryApps(AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequest request) {
            return base.Channel.QueryApps(request);
        }
        
        public AppCollectorAgent.SR_RunningAppsQueryService.ArrayOfString QueryApps() {
            AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequest inValue = new AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequest();
            inValue.Body = new AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequestBody();
            AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsResponse retVal = ((AppCollectorAgent.SR_RunningAppsQueryService.RunningAppsQueryServiceSoap)(this)).QueryApps(inValue);
            return retVal.Body.QueryAppsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsResponse> AppCollectorAgent.SR_RunningAppsQueryService.RunningAppsQueryServiceSoap.QueryAppsAsync(AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequest request) {
            return base.Channel.QueryAppsAsync(request);
        }
        
        public System.Threading.Tasks.Task<AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsResponse> QueryAppsAsync() {
            AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequest inValue = new AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequest();
            inValue.Body = new AppCollectorAgent.SR_RunningAppsQueryService.QueryAppsRequestBody();
            return ((AppCollectorAgent.SR_RunningAppsQueryService.RunningAppsQueryServiceSoap)(this)).QueryAppsAsync(inValue);
        }
    }
}
