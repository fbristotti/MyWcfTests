﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.NumberSvc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Complex", Namespace="http://schemas.datacontract.org/2004/07/ServerSvc")]
    [System.SerializableAttribute()]
    public partial class Complex : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ImaginaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RealField;
        
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
        public double Imaginary {
            get {
                return this.ImaginaryField;
            }
            set {
                if ((this.ImaginaryField.Equals(value) != true)) {
                    this.ImaginaryField = value;
                    this.RaisePropertyChanged("Imaginary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Real {
            get {
                return this.RealField;
            }
            set {
                if ((this.RealField.Equals(value) != true)) {
                    this.RealField = value;
                    this.RaisePropertyChanged("Real");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NumberSvc.IComplexNumber")]
    public interface IComplexNumber {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Add", ReplyAction="http://tempuri.org/IComplexNumber/AddResponse")]
        ClientApp.NumberSvc.Complex Add(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Add", ReplyAction="http://tempuri.org/IComplexNumber/AddResponse")]
        System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> AddAsync(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Subtract", ReplyAction="http://tempuri.org/IComplexNumber/SubtractResponse")]
        ClientApp.NumberSvc.Complex Subtract(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Subtract", ReplyAction="http://tempuri.org/IComplexNumber/SubtractResponse")]
        System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> SubtractAsync(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Multiply", ReplyAction="http://tempuri.org/IComplexNumber/MultiplyResponse")]
        ClientApp.NumberSvc.Complex Multiply(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Multiply", ReplyAction="http://tempuri.org/IComplexNumber/MultiplyResponse")]
        System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> MultiplyAsync(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Divide", ReplyAction="http://tempuri.org/IComplexNumber/DivideResponse")]
        ClientApp.NumberSvc.Complex Divide(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Divide", ReplyAction="http://tempuri.org/IComplexNumber/DivideResponse")]
        System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> DivideAsync(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Modulus", ReplyAction="http://tempuri.org/IComplexNumber/ModulusResponse")]
        double Modulus(ClientApp.NumberSvc.Complex x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Modulus", ReplyAction="http://tempuri.org/IComplexNumber/ModulusResponse")]
        System.Threading.Tasks.Task<double> ModulusAsync(ClientApp.NumberSvc.Complex x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Argument", ReplyAction="http://tempuri.org/IComplexNumber/ArgumentResponse")]
        double Argument(ClientApp.NumberSvc.Complex x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Argument", ReplyAction="http://tempuri.org/IComplexNumber/ArgumentResponse")]
        System.Threading.Tasks.Task<double> ArgumentAsync(ClientApp.NumberSvc.Complex x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Conjugate", ReplyAction="http://tempuri.org/IComplexNumber/ConjugateResponse")]
        ClientApp.NumberSvc.Complex Conjugate(ClientApp.NumberSvc.Complex x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Conjugate", ReplyAction="http://tempuri.org/IComplexNumber/ConjugateResponse")]
        System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> ConjugateAsync(ClientApp.NumberSvc.Complex x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Recipocal", ReplyAction="http://tempuri.org/IComplexNumber/RecipocalResponse")]
        ClientApp.NumberSvc.Complex Recipocal(ClientApp.NumberSvc.Complex x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IComplexNumber/Recipocal", ReplyAction="http://tempuri.org/IComplexNumber/RecipocalResponse")]
        System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> RecipocalAsync(ClientApp.NumberSvc.Complex x);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IComplexNumberChannel : ClientApp.NumberSvc.IComplexNumber, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ComplexNumberClient : System.ServiceModel.ClientBase<ClientApp.NumberSvc.IComplexNumber>, ClientApp.NumberSvc.IComplexNumber {
        
        public ComplexNumberClient() {
        }
        
        public ComplexNumberClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ComplexNumberClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ComplexNumberClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ComplexNumberClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientApp.NumberSvc.Complex Add(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y) {
            return base.Channel.Add(x, y);
        }
        
        public System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> AddAsync(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y) {
            return base.Channel.AddAsync(x, y);
        }
        
        public ClientApp.NumberSvc.Complex Subtract(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y) {
            return base.Channel.Subtract(x, y);
        }
        
        public System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> SubtractAsync(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y) {
            return base.Channel.SubtractAsync(x, y);
        }
        
        public ClientApp.NumberSvc.Complex Multiply(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y) {
            return base.Channel.Multiply(x, y);
        }
        
        public System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> MultiplyAsync(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y) {
            return base.Channel.MultiplyAsync(x, y);
        }
        
        public ClientApp.NumberSvc.Complex Divide(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y) {
            return base.Channel.Divide(x, y);
        }
        
        public System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> DivideAsync(ClientApp.NumberSvc.Complex x, ClientApp.NumberSvc.Complex y) {
            return base.Channel.DivideAsync(x, y);
        }
        
        public double Modulus(ClientApp.NumberSvc.Complex x) {
            return base.Channel.Modulus(x);
        }
        
        public System.Threading.Tasks.Task<double> ModulusAsync(ClientApp.NumberSvc.Complex x) {
            return base.Channel.ModulusAsync(x);
        }
        
        public double Argument(ClientApp.NumberSvc.Complex x) {
            return base.Channel.Argument(x);
        }
        
        public System.Threading.Tasks.Task<double> ArgumentAsync(ClientApp.NumberSvc.Complex x) {
            return base.Channel.ArgumentAsync(x);
        }
        
        public ClientApp.NumberSvc.Complex Conjugate(ClientApp.NumberSvc.Complex x) {
            return base.Channel.Conjugate(x);
        }
        
        public System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> ConjugateAsync(ClientApp.NumberSvc.Complex x) {
            return base.Channel.ConjugateAsync(x);
        }
        
        public ClientApp.NumberSvc.Complex Recipocal(ClientApp.NumberSvc.Complex x) {
            return base.Channel.Recipocal(x);
        }
        
        public System.Threading.Tasks.Task<ClientApp.NumberSvc.Complex> RecipocalAsync(ClientApp.NumberSvc.Complex x) {
            return base.Channel.RecipocalAsync(x);
        }
    }
}
