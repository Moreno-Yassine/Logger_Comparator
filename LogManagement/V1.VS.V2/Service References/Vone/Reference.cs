﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace V1.VS.V2.Vone {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Vone.IDetectionClient")]
    public interface IDetectionClient {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetectionClient/IsCustomerAgent", ReplyAction="http://tempuri.org/IDetectionClient/IsCustomerAgentResponse")]
        bool IsCustomerAgent(string civilite, string codepostal, string datenaissance, string nom, string phone, string prenom, string ville, string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDetectionClientChannel : V1.VS.V2.Vone.IDetectionClient, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DetectionClientClient : System.ServiceModel.ClientBase<V1.VS.V2.Vone.IDetectionClient>, V1.VS.V2.Vone.IDetectionClient {
        
        public DetectionClientClient() {
        }
        
        public DetectionClientClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DetectionClientClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DetectionClientClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DetectionClientClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool IsCustomerAgent(string civilite, string codepostal, string datenaissance, string nom, string phone, string prenom, string ville, string email) {
            return base.Channel.IsCustomerAgent(civilite, codepostal, datenaissance, nom, phone, prenom, ville, email);
        }
    }
}
