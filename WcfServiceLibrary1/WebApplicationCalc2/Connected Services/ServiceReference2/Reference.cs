﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationCalc2.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Addition", ReplyAction="http://tempuri.org/IService1/AdditionResponse")]
        int Addition(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Addition", ReplyAction="http://tempuri.org/IService1/AdditionResponse")]
        System.Threading.Tasks.Task<int> AdditionAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Substract", ReplyAction="http://tempuri.org/IService1/SubstractResponse")]
        int Substract(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Substract", ReplyAction="http://tempuri.org/IService1/SubstractResponse")]
        System.Threading.Tasks.Task<int> SubstractAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiplication", ReplyAction="http://tempuri.org/IService1/MultiplicationResponse")]
        int Multiplication(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiplication", ReplyAction="http://tempuri.org/IService1/MultiplicationResponse")]
        System.Threading.Tasks.Task<int> MultiplicationAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Division", ReplyAction="http://tempuri.org/IService1/DivisionResponse")]
        int Division(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Division", ReplyAction="http://tempuri.org/IService1/DivisionResponse")]
        System.Threading.Tasks.Task<int> DivisionAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplicationCalc2.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplicationCalc2.ServiceReference2.IService1>, WebApplicationCalc2.ServiceReference2.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Addition(int a, int b) {
            return base.Channel.Addition(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AdditionAsync(int a, int b) {
            return base.Channel.AdditionAsync(a, b);
        }
        
        public int Substract(int a, int b) {
            return base.Channel.Substract(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SubstractAsync(int a, int b) {
            return base.Channel.SubstractAsync(a, b);
        }
        
        public int Multiplication(int a, int b) {
            return base.Channel.Multiplication(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplicationAsync(int a, int b) {
            return base.Channel.MultiplicationAsync(a, b);
        }
        
        public int Division(int a, int b) {
            return base.Channel.Division(a, b);
        }
        
        public System.Threading.Tasks.Task<int> DivisionAsync(int a, int b) {
            return base.Channel.DivisionAsync(a, b);
        }
    }
}
