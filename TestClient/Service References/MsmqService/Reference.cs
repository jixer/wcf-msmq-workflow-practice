﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chris.Blog.MsmqWorkflow.Test.MsmqService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StartProcessRequest", Namespace="http://schemas.datacontract.org/2004/07/Chris.Blog.MsmqWorkflow.Contract")]
    [System.SerializableAttribute()]
    public partial class StartProcessRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageText {
            get {
                return this.MessageTextField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageTextField, value) != true)) {
                    this.MessageTextField = value;
                    this.RaisePropertyChanged("MessageText");
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
    [System.ServiceModel.ServiceContractAttribute(Name="Chris.Blog.MsmqWorkflow.Contract.IMsmqService", ConfigurationName="MsmqService.ChrisBlogMsmqWorkflowContractIMsmqService")]
    public interface ChrisBlogMsmqWorkflowContractIMsmqService {
        
        // CODEGEN: Generating message contract since the operation StartProcess is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/Chris.Blog.MsmqWorkflow.Contract.IMsmqService/StartProcess")]
        void StartProcess(Chris.Blog.MsmqWorkflow.Test.MsmqService.StartProcess request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StartProcess {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.datacontract.org/2004/07/Chris.Blog.MsmqWorkflow.Contract", Order=0)]
        public Chris.Blog.MsmqWorkflow.Test.MsmqService.StartProcessRequest StartProcessRequest;
        
        public StartProcess() {
        }
        
        public StartProcess(Chris.Blog.MsmqWorkflow.Test.MsmqService.StartProcessRequest StartProcessRequest) {
            this.StartProcessRequest = StartProcessRequest;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ChrisBlogMsmqWorkflowContractIMsmqServiceChannel : Chris.Blog.MsmqWorkflow.Test.MsmqService.ChrisBlogMsmqWorkflowContractIMsmqService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChrisBlogMsmqWorkflowContractIMsmqServiceClient : System.ServiceModel.ClientBase<Chris.Blog.MsmqWorkflow.Test.MsmqService.ChrisBlogMsmqWorkflowContractIMsmqService>, Chris.Blog.MsmqWorkflow.Test.MsmqService.ChrisBlogMsmqWorkflowContractIMsmqService {
        
        public ChrisBlogMsmqWorkflowContractIMsmqServiceClient() {
        }
        
        public ChrisBlogMsmqWorkflowContractIMsmqServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChrisBlogMsmqWorkflowContractIMsmqServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChrisBlogMsmqWorkflowContractIMsmqServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChrisBlogMsmqWorkflowContractIMsmqServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void Chris.Blog.MsmqWorkflow.Test.MsmqService.ChrisBlogMsmqWorkflowContractIMsmqService.StartProcess(Chris.Blog.MsmqWorkflow.Test.MsmqService.StartProcess request) {
            base.Channel.StartProcess(request);
        }
        
        public void StartProcess(Chris.Blog.MsmqWorkflow.Test.MsmqService.StartProcessRequest StartProcessRequest) {
            Chris.Blog.MsmqWorkflow.Test.MsmqService.StartProcess inValue = new Chris.Blog.MsmqWorkflow.Test.MsmqService.StartProcess();
            inValue.StartProcessRequest = StartProcessRequest;
            ((Chris.Blog.MsmqWorkflow.Test.MsmqService.ChrisBlogMsmqWorkflowContractIMsmqService)(this)).StartProcess(inValue);
        }
    }
}
