﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IContract", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/UpdateData", ReplyAction="http://tempuri.org/IContract/UpdateDataResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void UpdateData(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/UpdateData", ReplyAction="http://tempuri.org/IContract/UpdateDataResponse")]
        System.Threading.Tasks.Task UpdateDataAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/UpdateFirstDb", ReplyAction="http://tempuri.org/IContract/UpdateFirstDbResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void UpdateFirstDb(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/UpdateFirstDb", ReplyAction="http://tempuri.org/IContract/UpdateFirstDbResponse")]
        System.Threading.Tasks.Task UpdateFirstDbAsync(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/UpdateSecondDb", ReplyAction="http://tempuri.org/IContract/UpdateSecondDbResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void UpdateSecondDb(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/UpdateSecondDb", ReplyAction="http://tempuri.org/IContract/UpdateSecondDbResponse")]
        System.Threading.Tasks.Task UpdateSecondDbAsync(string str);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContractChannel : Client.ServiceReference.IContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContractClient : System.ServiceModel.ClientBase<Client.ServiceReference.IContract>, Client.ServiceReference.IContract {
        
        public ContractClient() {
        }
        
        public ContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void UpdateData(string name) {
            base.Channel.UpdateData(name);
        }
        
        public System.Threading.Tasks.Task UpdateDataAsync(string name) {
            return base.Channel.UpdateDataAsync(name);
        }
        
        public void UpdateFirstDb(string str) {
            base.Channel.UpdateFirstDb(str);
        }
        
        public System.Threading.Tasks.Task UpdateFirstDbAsync(string str) {
            return base.Channel.UpdateFirstDbAsync(str);
        }
        
        public void UpdateSecondDb(string str) {
            base.Channel.UpdateSecondDb(str);
        }
        
        public System.Threading.Tasks.Task UpdateSecondDbAsync(string str) {
            return base.Channel.UpdateSecondDbAsync(str);
        }
    }
}
