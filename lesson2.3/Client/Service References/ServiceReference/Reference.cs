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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IContract")]
    public interface IContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/Method", ReplyAction="http://tempuri.org/IContract/MethodResponse")]
        string Method();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/Method", ReplyAction="http://tempuri.org/IContract/MethodResponse")]
        System.Threading.Tasks.Task<string> MethodAsync();
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
        
        public string Method() {
            return base.Channel.Method();
        }
        
        public System.Threading.Tasks.Task<string> MethodAsync() {
            return base.Channel.MethodAsync();
        }
    }
}
