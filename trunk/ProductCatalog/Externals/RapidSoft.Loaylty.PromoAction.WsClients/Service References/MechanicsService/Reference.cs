﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultBase", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.OutputR" +
        "esults")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.FactorsResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.GenerateResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.CalculateResult))]
    public partial class ResultBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ResultCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResultDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
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
        public int ResultCode {
            get {
                return this.ResultCodeField;
            }
            set {
                if ((this.ResultCodeField.Equals(value) != true)) {
                    this.ResultCodeField = value;
                    this.RaisePropertyChanged("ResultCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResultDescription {
            get {
                return this.ResultDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultDescriptionField, value) != true)) {
                    this.ResultDescriptionField = value;
                    this.RaisePropertyChanged("ResultDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FactorsResult", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.OutputR" +
        "esults")]
    [System.SerializableAttribute()]
    public partial class FactorsResult : RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.ResultBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AdditionFactorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BaseAdditionFactorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BaseMultiplicationFactorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsBaseAppliedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsNotBaseAppliedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MultiplicationFactorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] TraceMessagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal AdditionFactor {
            get {
                return this.AdditionFactorField;
            }
            set {
                if ((this.AdditionFactorField.Equals(value) != true)) {
                    this.AdditionFactorField = value;
                    this.RaisePropertyChanged("AdditionFactor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal BaseAdditionFactor {
            get {
                return this.BaseAdditionFactorField;
            }
            set {
                if ((this.BaseAdditionFactorField.Equals(value) != true)) {
                    this.BaseAdditionFactorField = value;
                    this.RaisePropertyChanged("BaseAdditionFactor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal BaseMultiplicationFactor {
            get {
                return this.BaseMultiplicationFactorField;
            }
            set {
                if ((this.BaseMultiplicationFactorField.Equals(value) != true)) {
                    this.BaseMultiplicationFactorField = value;
                    this.RaisePropertyChanged("BaseMultiplicationFactor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsBaseApplied {
            get {
                return this.IsBaseAppliedField;
            }
            set {
                if ((this.IsBaseAppliedField.Equals(value) != true)) {
                    this.IsBaseAppliedField = value;
                    this.RaisePropertyChanged("IsBaseApplied");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsNotBaseApplied {
            get {
                return this.IsNotBaseAppliedField;
            }
            set {
                if ((this.IsNotBaseAppliedField.Equals(value) != true)) {
                    this.IsNotBaseAppliedField = value;
                    this.RaisePropertyChanged("IsNotBaseApplied");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MultiplicationFactor {
            get {
                return this.MultiplicationFactorField;
            }
            set {
                if ((this.MultiplicationFactorField.Equals(value) != true)) {
                    this.MultiplicationFactorField = value;
                    this.RaisePropertyChanged("MultiplicationFactor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] TraceMessages {
            get {
                return this.TraceMessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.TraceMessagesField, value) != true)) {
                    this.TraceMessagesField = value;
                    this.RaisePropertyChanged("TraceMessages");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenerateResult", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.OutputR" +
        "esults")]
    [System.SerializableAttribute()]
    public partial class GenerateResult : RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.ResultBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ActionSqlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BaseSqlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.RuleApplyStatuses RuleApplyStatusField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ActionSql {
            get {
                return this.ActionSqlField;
            }
            set {
                if ((object.ReferenceEquals(this.ActionSqlField, value) != true)) {
                    this.ActionSqlField = value;
                    this.RaisePropertyChanged("ActionSql");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BaseSql {
            get {
                return this.BaseSqlField;
            }
            set {
                if ((object.ReferenceEquals(this.BaseSqlField, value) != true)) {
                    this.BaseSqlField = value;
                    this.RaisePropertyChanged("BaseSql");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.RuleApplyStatuses RuleApplyStatus {
            get {
                return this.RuleApplyStatusField;
            }
            set {
                if ((this.RuleApplyStatusField.Equals(value) != true)) {
                    this.RuleApplyStatusField = value;
                    this.RaisePropertyChanged("RuleApplyStatus");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CalculateResult", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.OutputR" +
        "esults")]
    [System.SerializableAttribute()]
    public partial class CalculateResult : RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.ResultBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BaseResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PromoResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.RuleApplyStatuses RuleApplyStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] TraceMessagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal BaseResult {
            get {
                return this.BaseResultField;
            }
            set {
                if ((this.BaseResultField.Equals(value) != true)) {
                    this.BaseResultField = value;
                    this.RaisePropertyChanged("BaseResult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PromoResult {
            get {
                return this.PromoResultField;
            }
            set {
                if ((this.PromoResultField.Equals(value) != true)) {
                    this.PromoResultField = value;
                    this.RaisePropertyChanged("PromoResult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.RuleApplyStatuses RuleApplyStatus {
            get {
                return this.RuleApplyStatusField;
            }
            set {
                if ((this.RuleApplyStatusField.Equals(value) != true)) {
                    this.RuleApplyStatusField = value;
                    this.RaisePropertyChanged("RuleApplyStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] TraceMessages {
            get {
                return this.TraceMessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.TraceMessagesField, value) != true)) {
                    this.TraceMessagesField = value;
                    this.RaisePropertyChanged("TraceMessages");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RuleApplyStatuses", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.OutputR" +
        "esults")]
    public enum RuleApplyStatuses : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BaseOnlyRulesExecuted = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RulesExecuted = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RulesNotExecuted = 0,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenerateSqlParameters", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.InputPa" +
        "rameters")]
    [System.SerializableAttribute()]
    public partial class GenerateSqlParameters : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> AliasesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> ContextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InitialNumberAliasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RuleDomainNameField;
        
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
        public System.Collections.Generic.Dictionary<string, string> Aliases {
            get {
                return this.AliasesField;
            }
            set {
                if ((object.ReferenceEquals(this.AliasesField, value) != true)) {
                    this.AliasesField = value;
                    this.RaisePropertyChanged("Aliases");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> Context {
            get {
                return this.ContextField;
            }
            set {
                if ((object.ReferenceEquals(this.ContextField, value) != true)) {
                    this.ContextField = value;
                    this.RaisePropertyChanged("Context");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InitialNumberAlias {
            get {
                return this.InitialNumberAliasField;
            }
            set {
                if ((object.ReferenceEquals(this.InitialNumberAliasField, value) != true)) {
                    this.InitialNumberAliasField = value;
                    this.RaisePropertyChanged("InitialNumberAlias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RuleDomainName {
            get {
                return this.RuleDomainNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RuleDomainNameField, value) != true)) {
                    this.RuleDomainNameField = value;
                    this.RaisePropertyChanged("RuleDomainName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MechanicsService.IMechanicsService")]
    public interface IMechanicsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupportService/Echo", ReplyAction="http://tempuri.org/ISupportService/EchoResponse")]
        string Echo(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupportService/Echo", ReplyAction="http://tempuri.org/ISupportService/EchoResponse")]
        System.Threading.Tasks.Task<string> EchoAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMechanicsService/CalculateSingleValue", ReplyAction="http://tempuri.org/IMechanicsService/CalculateSingleValueResponse")]
        RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.CalculateResult CalculateSingleValue(string ruleDomainName, decimal initialNumber, System.Collections.Generic.Dictionary<string, string> context);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMechanicsService/CalculateSingleValue", ReplyAction="http://tempuri.org/IMechanicsService/CalculateSingleValueResponse")]
        System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.CalculateResult> CalculateSingleValueAsync(string ruleDomainName, decimal initialNumber, System.Collections.Generic.Dictionary<string, string> context);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMechanicsService/CalculateFactors", ReplyAction="http://tempuri.org/IMechanicsService/CalculateFactorsResponse")]
        RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.FactorsResult CalculateFactors(string ruleDomainName, System.Collections.Generic.Dictionary<string, string> context);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMechanicsService/CalculateFactors", ReplyAction="http://tempuri.org/IMechanicsService/CalculateFactorsResponse")]
        System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.FactorsResult> CalculateFactorsAsync(string ruleDomainName, System.Collections.Generic.Dictionary<string, string> context);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMechanicsService/GenerateSql", ReplyAction="http://tempuri.org/IMechanicsService/GenerateSqlResponse")]
        RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.GenerateResult GenerateSql(RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.GenerateSqlParameters parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMechanicsService/GenerateSql", ReplyAction="http://tempuri.org/IMechanicsService/GenerateSqlResponse")]
        System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.GenerateResult> GenerateSqlAsync(RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.GenerateSqlParameters parameters);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMechanicsServiceChannel : RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.IMechanicsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MechanicsServiceClient : System.ServiceModel.ClientBase<RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.IMechanicsService>, RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.IMechanicsService {
        
        public MechanicsServiceClient() {
        }
        
        public MechanicsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MechanicsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MechanicsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MechanicsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Echo(string message) {
            return base.Channel.Echo(message);
        }
        
        public System.Threading.Tasks.Task<string> EchoAsync(string message) {
            return base.Channel.EchoAsync(message);
        }
        
        public RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.CalculateResult CalculateSingleValue(string ruleDomainName, decimal initialNumber, System.Collections.Generic.Dictionary<string, string> context) {
            return base.Channel.CalculateSingleValue(ruleDomainName, initialNumber, context);
        }
        
        public System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.CalculateResult> CalculateSingleValueAsync(string ruleDomainName, decimal initialNumber, System.Collections.Generic.Dictionary<string, string> context) {
            return base.Channel.CalculateSingleValueAsync(ruleDomainName, initialNumber, context);
        }
        
        public RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.FactorsResult CalculateFactors(string ruleDomainName, System.Collections.Generic.Dictionary<string, string> context) {
            return base.Channel.CalculateFactors(ruleDomainName, context);
        }
        
        public System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.FactorsResult> CalculateFactorsAsync(string ruleDomainName, System.Collections.Generic.Dictionary<string, string> context) {
            return base.Channel.CalculateFactorsAsync(ruleDomainName, context);
        }
        
        public RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.GenerateResult GenerateSql(RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.GenerateSqlParameters parameters) {
            return base.Channel.GenerateSql(parameters);
        }
        
        public System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.GenerateResult> GenerateSqlAsync(RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.GenerateSqlParameters parameters) {
            return base.Channel.GenerateSqlAsync(parameters);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MechanicsService.IServiceInfo")]
    public interface IServiceInfo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceInfo/Ping", ReplyAction="http://tempuri.org/IServiceInfo/PingResponse")]
        void Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceInfo/Ping", ReplyAction="http://tempuri.org/IServiceInfo/PingResponse")]
        System.Threading.Tasks.Task PingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceInfo/GetServiceVersion", ReplyAction="http://tempuri.org/IServiceInfo/GetServiceVersionResponse")]
        System.Version GetServiceVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceInfo/GetServiceVersion", ReplyAction="http://tempuri.org/IServiceInfo/GetServiceVersionResponse")]
        System.Threading.Tasks.Task<System.Version> GetServiceVersionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceInfoChannel : RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.IServiceInfo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceInfoClient : System.ServiceModel.ClientBase<RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.IServiceInfo>, RapidSoft.Loaylty.PromoAction.WsClients.MechanicsService.IServiceInfo {
        
        public ServiceInfoClient() {
        }
        
        public ServiceInfoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceInfoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceInfoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceInfoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Ping() {
            base.Channel.Ping();
        }
        
        public System.Threading.Tasks.Task PingAsync() {
            return base.Channel.PingAsync();
        }
        
        public System.Version GetServiceVersion() {
            return base.Channel.GetServiceVersion();
        }
        
        public System.Threading.Tasks.Task<System.Version> GetServiceVersionAsync() {
            return base.Channel.GetServiceVersionAsync();
        }
    }
}
