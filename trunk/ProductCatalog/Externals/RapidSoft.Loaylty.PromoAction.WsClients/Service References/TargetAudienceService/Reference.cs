﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultBase", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.OutputR" +
        "esults")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientAudienceResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.GetTargetAudiencesResult))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.GetClientTargetAudiencesResult))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AssignClientAudienceResult", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.OutputR" +
        "esults")]
    [System.SerializableAttribute()]
    public partial class AssignClientAudienceResult : RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ResultBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ClientTargetAudienceRelationResult[] ClientTargetAudienceRelationsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ClientTargetAudienceRelationResult[] ClientTargetAudienceRelations {
            get {
                return this.ClientTargetAudienceRelationsField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientTargetAudienceRelationsField, value) != true)) {
                    this.ClientTargetAudienceRelationsField = value;
                    this.RaisePropertyChanged("ClientTargetAudienceRelations");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTargetAudiencesResult", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.OutputR" +
        "esults")]
    [System.SerializableAttribute()]
    public partial class GetTargetAudiencesResult : RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ResultBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.TargetAudience[] TargetAudiencesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.TargetAudience[] TargetAudiences {
            get {
                return this.TargetAudiencesField;
            }
            set {
                if ((object.ReferenceEquals(this.TargetAudiencesField, value) != true)) {
                    this.TargetAudiencesField = value;
                    this.RaisePropertyChanged("TargetAudiences");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetClientTargetAudiencesResult", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.OutputR" +
        "esults")]
    [System.SerializableAttribute()]
    public partial class GetClientTargetAudiencesResult : RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ResultBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.TargetAudience[] ClientTargetAudiencesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.TargetAudience[] ClientTargetAudiences {
            get {
                return this.ClientTargetAudiencesField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientTargetAudiencesField, value) != true)) {
                    this.ClientTargetAudiencesField = value;
                    this.RaisePropertyChanged("ClientTargetAudiences");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TargetAudience", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.DTO")]
    [System.SerializableAttribute()]
    public partial class TargetAudience : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSegmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSegment {
            get {
                return this.IsSegmentField;
            }
            set {
                if ((this.IsSegmentField.Equals(value) != true)) {
                    this.IsSegmentField = value;
                    this.RaisePropertyChanged("IsSegment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientTargetAudienceRelationResult", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.InputPa" +
        "rameters")]
    [System.SerializableAttribute()]
    public partial class ClientTargetAudienceRelationResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AssignResultCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PromoActionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResultDescriptionField;
        
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
        public int AssignResultCode {
            get {
                return this.AssignResultCodeField;
            }
            set {
                if ((this.AssignResultCodeField.Equals(value) != true)) {
                    this.AssignResultCodeField = value;
                    this.RaisePropertyChanged("AssignResultCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientId {
            get {
                return this.ClientIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientIdField, value) != true)) {
                    this.ClientIdField = value;
                    this.RaisePropertyChanged("ClientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PromoActionId {
            get {
                return this.PromoActionIdField;
            }
            set {
                if ((object.ReferenceEquals(this.PromoActionIdField, value) != true)) {
                    this.PromoActionIdField = value;
                    this.RaisePropertyChanged("PromoActionId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AssignClientTargetAudienceParameters", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.InputPa" +
        "rameters")]
    [System.SerializableAttribute()]
    public partial class AssignClientTargetAudienceParameters : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ClientTargetAudienceRelation[] ClientAudienceRelationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
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
        public RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ClientTargetAudienceRelation[] ClientAudienceRelations {
            get {
                return this.ClientAudienceRelationsField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientAudienceRelationsField, value) != true)) {
                    this.ClientAudienceRelationsField = value;
                    this.RaisePropertyChanged("ClientAudienceRelations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientTargetAudienceRelation", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.InputPa" +
        "rameters")]
    [System.SerializableAttribute()]
    public partial class ClientTargetAudienceRelation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PromoActionIdField;
        
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
        public string ClientId {
            get {
                return this.ClientIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientIdField, value) != true)) {
                    this.ClientIdField = value;
                    this.RaisePropertyChanged("ClientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PromoActionId {
            get {
                return this.PromoActionIdField;
            }
            set {
                if ((object.ReferenceEquals(this.PromoActionIdField, value) != true)) {
                    this.PromoActionIdField = value;
                    this.RaisePropertyChanged("PromoActionId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AssignClientSegmentParameters", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.InputPa" +
        "rameters")]
    [System.SerializableAttribute()]
    public partial class AssignClientSegmentParameters : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.Segment[] SegmentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
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
        public RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.Segment[] Segments {
            get {
                return this.SegmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.SegmentsField, value) != true)) {
                    this.SegmentsField = value;
                    this.RaisePropertyChanged("Segments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Segment", Namespace="http://schemas.datacontract.org/2004/07/RapidSoft.Loaylty.PromoAction.Api.DTO")]
    [System.SerializableAttribute()]
    public partial class Segment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ClientIdsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
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
        public string[] ClientIds {
            get {
                return this.ClientIdsField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientIdsField, value) != true)) {
                    this.ClientIdsField = value;
                    this.RaisePropertyChanged("ClientIds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TargetAudienceService.ITargetAudienceService")]
    public interface ITargetAudienceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupportService/Echo", ReplyAction="http://tempuri.org/ISupportService/EchoResponse")]
        string Echo(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupportService/Echo", ReplyAction="http://tempuri.org/ISupportService/EchoResponse")]
        System.Threading.Tasks.Task<string> EchoAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITargetAudienceService/GetClientTargetAudiences", ReplyAction="http://tempuri.org/ITargetAudienceService/GetClientTargetAudiencesResponse")]
        RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.GetClientTargetAudiencesResult GetClientTargetAudiences(string clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITargetAudienceService/GetClientTargetAudiences", ReplyAction="http://tempuri.org/ITargetAudienceService/GetClientTargetAudiencesResponse")]
        System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.GetClientTargetAudiencesResult> GetClientTargetAudiencesAsync(string clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITargetAudienceService/AssignClientTargetAudience", ReplyAction="http://tempuri.org/ITargetAudienceService/AssignClientTargetAudienceResponse")]
        RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientAudienceResult AssignClientTargetAudience(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientTargetAudienceParameters parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITargetAudienceService/AssignClientTargetAudience", ReplyAction="http://tempuri.org/ITargetAudienceService/AssignClientTargetAudienceResponse")]
        System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientAudienceResult> AssignClientTargetAudienceAsync(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientTargetAudienceParameters parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITargetAudienceService/AssignClientSegment", ReplyAction="http://tempuri.org/ITargetAudienceService/AssignClientSegmentResponse")]
        RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ResultBase AssignClientSegment(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientSegmentParameters parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITargetAudienceService/AssignClientSegment", ReplyAction="http://tempuri.org/ITargetAudienceService/AssignClientSegmentResponse")]
        System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ResultBase> AssignClientSegmentAsync(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientSegmentParameters parameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITargetAudienceService/GetTargetAudiences", ReplyAction="http://tempuri.org/ITargetAudienceService/GetTargetAudiencesResponse")]
        RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.GetTargetAudiencesResult GetTargetAudiences(System.Nullable<bool> isSegment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITargetAudienceService/GetTargetAudiences", ReplyAction="http://tempuri.org/ITargetAudienceService/GetTargetAudiencesResponse")]
        System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.GetTargetAudiencesResult> GetTargetAudiencesAsync(System.Nullable<bool> isSegment);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITargetAudienceServiceChannel : RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ITargetAudienceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TargetAudienceServiceClient : System.ServiceModel.ClientBase<RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ITargetAudienceService>, RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ITargetAudienceService {
        
        public TargetAudienceServiceClient() {
        }
        
        public TargetAudienceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TargetAudienceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TargetAudienceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TargetAudienceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Echo(string message) {
            return base.Channel.Echo(message);
        }
        
        public System.Threading.Tasks.Task<string> EchoAsync(string message) {
            return base.Channel.EchoAsync(message);
        }
        
        public RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.GetClientTargetAudiencesResult GetClientTargetAudiences(string clientId) {
            return base.Channel.GetClientTargetAudiences(clientId);
        }
        
        public System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.GetClientTargetAudiencesResult> GetClientTargetAudiencesAsync(string clientId) {
            return base.Channel.GetClientTargetAudiencesAsync(clientId);
        }
        
        public RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientAudienceResult AssignClientTargetAudience(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientTargetAudienceParameters parameters) {
            return base.Channel.AssignClientTargetAudience(parameters);
        }
        
        public System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientAudienceResult> AssignClientTargetAudienceAsync(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientTargetAudienceParameters parameters) {
            return base.Channel.AssignClientTargetAudienceAsync(parameters);
        }
        
        public RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ResultBase AssignClientSegment(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientSegmentParameters parameters) {
            return base.Channel.AssignClientSegment(parameters);
        }
        
        public System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.ResultBase> AssignClientSegmentAsync(RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.AssignClientSegmentParameters parameters) {
            return base.Channel.AssignClientSegmentAsync(parameters);
        }
        
        public RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.GetTargetAudiencesResult GetTargetAudiences(System.Nullable<bool> isSegment) {
            return base.Channel.GetTargetAudiences(isSegment);
        }
        
        public System.Threading.Tasks.Task<RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.GetTargetAudiencesResult> GetTargetAudiencesAsync(System.Nullable<bool> isSegment) {
            return base.Channel.GetTargetAudiencesAsync(isSegment);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TargetAudienceService.IServiceInfo")]
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
    public interface IServiceInfoChannel : RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.IServiceInfo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceInfoClient : System.ServiceModel.ClientBase<RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.IServiceInfo>, RapidSoft.Loaylty.PromoAction.WsClients.TargetAudienceService.IServiceInfo {
        
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
