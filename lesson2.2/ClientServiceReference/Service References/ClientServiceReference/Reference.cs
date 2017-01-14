﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientServiceReference.ClientServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientServiceReference.IHello")]
    public interface IHello {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHello/sayHello", ReplyAction="http://tempuri.org/IHello/sayHelloResponse")]
        string sayHello(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHello/sayHello", ReplyAction="http://tempuri.org/IHello/sayHelloResponse")]
        System.Threading.Tasks.Task<string> sayHelloAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloChannel : ClientServiceReference.IHello, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloClient : System.ServiceModel.ClientBase<ClientServiceReference.IHello>, ClientServiceReference.IHello {
        
        public HelloClient() {
        }
        
        public HelloClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string sayHello(string name) {
            return base.Channel.sayHello(name);
        }
        
        public System.Threading.Tasks.Task<string> sayHelloAsync(string name) {
            return base.Channel.sayHelloAsync(name);
        }
    }
}
