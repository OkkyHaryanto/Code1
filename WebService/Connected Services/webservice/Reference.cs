﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService.webservice {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="webservice.IFirstcode")]
    public interface IFirstcode {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstcode/Message", ReplyAction="http://tempuri.org/IFirstcode/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstcode/Message", ReplyAction="http://tempuri.org/IFirstcode/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFirstcodeChannel : WebService.webservice.IFirstcode, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FirstcodeClient : System.ServiceModel.ClientBase<WebService.webservice.IFirstcode>, WebService.webservice.IFirstcode {
        
        public FirstcodeClient() {
        }
        
        public FirstcodeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FirstcodeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FirstcodeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FirstcodeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
    }
}
