﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetVelo.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Feature", Namespace="http://schemas.datacontract.org/2004/07/ProjetVelo")]
    [System.SerializableAttribute()]
    public partial class Feature : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float[] bboxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProjetVelo.ServiceReference1.Geometry geometryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProjetVelo.ServiceReference1.Properties propertiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeField;
        
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
        public float[] bbox {
            get {
                return this.bboxField;
            }
            set {
                if ((object.ReferenceEquals(this.bboxField, value) != true)) {
                    this.bboxField = value;
                    this.RaisePropertyChanged("bbox");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProjetVelo.ServiceReference1.Geometry geometry {
            get {
                return this.geometryField;
            }
            set {
                if ((object.ReferenceEquals(this.geometryField, value) != true)) {
                    this.geometryField = value;
                    this.RaisePropertyChanged("geometry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProjetVelo.ServiceReference1.Properties properties {
            get {
                return this.propertiesField;
            }
            set {
                if ((object.ReferenceEquals(this.propertiesField, value) != true)) {
                    this.propertiesField = value;
                    this.RaisePropertyChanged("properties");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                if ((object.ReferenceEquals(this.typeField, value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Geometry", Namespace="http://schemas.datacontract.org/2004/07/ProjetVelo")]
    [System.SerializableAttribute()]
    public partial class Geometry : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float[][] coordinatesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeField;
        
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
        public float[][] coordinates {
            get {
                return this.coordinatesField;
            }
            set {
                if ((object.ReferenceEquals(this.coordinatesField, value) != true)) {
                    this.coordinatesField = value;
                    this.RaisePropertyChanged("coordinates");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                if ((object.ReferenceEquals(this.typeField, value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Properties", Namespace="http://schemas.datacontract.org/2004/07/ProjetVelo")]
    [System.SerializableAttribute()]
    public partial class Properties : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int fareField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProjetVelo.ServiceReference1.Segment[] segmentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProjetVelo.ServiceReference1.Summary summaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int transfersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] way_pointsField;
        
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
        public int fare {
            get {
                return this.fareField;
            }
            set {
                if ((this.fareField.Equals(value) != true)) {
                    this.fareField = value;
                    this.RaisePropertyChanged("fare");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProjetVelo.ServiceReference1.Segment[] segments {
            get {
                return this.segmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.segmentsField, value) != true)) {
                    this.segmentsField = value;
                    this.RaisePropertyChanged("segments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProjetVelo.ServiceReference1.Summary summary {
            get {
                return this.summaryField;
            }
            set {
                if ((object.ReferenceEquals(this.summaryField, value) != true)) {
                    this.summaryField = value;
                    this.RaisePropertyChanged("summary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int transfers {
            get {
                return this.transfersField;
            }
            set {
                if ((this.transfersField.Equals(value) != true)) {
                    this.transfersField = value;
                    this.RaisePropertyChanged("transfers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] way_points {
            get {
                return this.way_pointsField;
            }
            set {
                if ((object.ReferenceEquals(this.way_pointsField, value) != true)) {
                    this.way_pointsField = value;
                    this.RaisePropertyChanged("way_points");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Summary", Namespace="http://schemas.datacontract.org/2004/07/ProjetVelo")]
    [System.SerializableAttribute()]
    public partial class Summary : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float distanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float durationField;
        
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
        public float distance {
            get {
                return this.distanceField;
            }
            set {
                if ((this.distanceField.Equals(value) != true)) {
                    this.distanceField = value;
                    this.RaisePropertyChanged("distance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float duration {
            get {
                return this.durationField;
            }
            set {
                if ((this.durationField.Equals(value) != true)) {
                    this.durationField = value;
                    this.RaisePropertyChanged("duration");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Segment", Namespace="http://schemas.datacontract.org/2004/07/ProjetVelo")]
    [System.SerializableAttribute()]
    public partial class Segment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float distanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float durationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProjetVelo.ServiceReference1.Step[] stepsField;
        
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
        public float distance {
            get {
                return this.distanceField;
            }
            set {
                if ((this.distanceField.Equals(value) != true)) {
                    this.distanceField = value;
                    this.RaisePropertyChanged("distance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float duration {
            get {
                return this.durationField;
            }
            set {
                if ((this.durationField.Equals(value) != true)) {
                    this.durationField = value;
                    this.RaisePropertyChanged("duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProjetVelo.ServiceReference1.Step[] steps {
            get {
                return this.stepsField;
            }
            set {
                if ((object.ReferenceEquals(this.stepsField, value) != true)) {
                    this.stepsField = value;
                    this.RaisePropertyChanged("steps");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Step", Namespace="http://schemas.datacontract.org/2004/07/ProjetVelo")]
    [System.SerializableAttribute()]
    public partial class Step : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float distanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float durationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string instructionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] way_pointsField;
        
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
        public float distance {
            get {
                return this.distanceField;
            }
            set {
                if ((this.distanceField.Equals(value) != true)) {
                    this.distanceField = value;
                    this.RaisePropertyChanged("distance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float duration {
            get {
                return this.durationField;
            }
            set {
                if ((this.durationField.Equals(value) != true)) {
                    this.durationField = value;
                    this.RaisePropertyChanged("duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string instruction {
            get {
                return this.instructionField;
            }
            set {
                if ((object.ReferenceEquals(this.instructionField, value) != true)) {
                    this.instructionField = value;
                    this.RaisePropertyChanged("instruction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int type {
            get {
                return this.typeField;
            }
            set {
                if ((this.typeField.Equals(value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] way_points {
            get {
                return this.way_pointsField;
            }
            set {
                if ((object.ReferenceEquals(this.way_pointsField, value) != true)) {
                    this.way_pointsField = value;
                    this.RaisePropertyChanged("way_points");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ProjetVelo")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        ProjetVelo.ServiceReference1.Feature GetData(string depart, string arrivee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<ProjetVelo.ServiceReference1.Feature> GetDataAsync(string depart, string arrivee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ProjetVelo.ServiceReference1.CompositeType GetDataUsingDataContract(ProjetVelo.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ProjetVelo.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ProjetVelo.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ProjetVelo.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ProjetVelo.ServiceReference1.IService1>, ProjetVelo.ServiceReference1.IService1 {
        
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
        
        public ProjetVelo.ServiceReference1.Feature GetData(string depart, string arrivee) {
            return base.Channel.GetData(depart, arrivee);
        }
        
        public System.Threading.Tasks.Task<ProjetVelo.ServiceReference1.Feature> GetDataAsync(string depart, string arrivee) {
            return base.Channel.GetDataAsync(depart, arrivee);
        }
        
        public ProjetVelo.ServiceReference1.CompositeType GetDataUsingDataContract(ProjetVelo.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ProjetVelo.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ProjetVelo.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}