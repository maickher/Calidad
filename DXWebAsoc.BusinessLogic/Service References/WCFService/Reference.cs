﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DXWebAsoc.BusinessLogic.WCFService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MembershipUser", Namespace="http://schemas.datacontract.org/2004/07/System.Web.Security")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DXWebAsoc.BusinessLogic.WCFService.WCFUsuario))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DXWebAsoc.BusinessLogic.WCFService.WCFUsuario[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(UserState))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Role))]
    public partial class MembershipUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string _CommentField;
        
        private System.DateTime _CreationDateField;
        
        private string _EmailField;
        
        private bool _IsApprovedField;
        
        private bool _IsLockedOutField;
        
        private System.DateTime _LastActivityDateField;
        
        private System.DateTime _LastLockoutDateField;
        
        private System.DateTime _LastLoginDateField;
        
        private System.DateTime _LastPasswordChangedDateField;
        
        private string _PasswordQuestionField;
        
        private string _ProviderNameField;
        
        private object _ProviderUserKeyField;
        
        private string _UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string _Comment {
            get {
                return this._CommentField;
            }
            set {
                if ((object.ReferenceEquals(this._CommentField, value) != true)) {
                    this._CommentField = value;
                    this.RaisePropertyChanged("_Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime _CreationDate {
            get {
                return this._CreationDateField;
            }
            set {
                if ((this._CreationDateField.Equals(value) != true)) {
                    this._CreationDateField = value;
                    this.RaisePropertyChanged("_CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string _Email {
            get {
                return this._EmailField;
            }
            set {
                if ((object.ReferenceEquals(this._EmailField, value) != true)) {
                    this._EmailField = value;
                    this.RaisePropertyChanged("_Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _IsApproved {
            get {
                return this._IsApprovedField;
            }
            set {
                if ((this._IsApprovedField.Equals(value) != true)) {
                    this._IsApprovedField = value;
                    this.RaisePropertyChanged("_IsApproved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _IsLockedOut {
            get {
                return this._IsLockedOutField;
            }
            set {
                if ((this._IsLockedOutField.Equals(value) != true)) {
                    this._IsLockedOutField = value;
                    this.RaisePropertyChanged("_IsLockedOut");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime _LastActivityDate {
            get {
                return this._LastActivityDateField;
            }
            set {
                if ((this._LastActivityDateField.Equals(value) != true)) {
                    this._LastActivityDateField = value;
                    this.RaisePropertyChanged("_LastActivityDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime _LastLockoutDate {
            get {
                return this._LastLockoutDateField;
            }
            set {
                if ((this._LastLockoutDateField.Equals(value) != true)) {
                    this._LastLockoutDateField = value;
                    this.RaisePropertyChanged("_LastLockoutDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime _LastLoginDate {
            get {
                return this._LastLoginDateField;
            }
            set {
                if ((this._LastLoginDateField.Equals(value) != true)) {
                    this._LastLoginDateField = value;
                    this.RaisePropertyChanged("_LastLoginDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime _LastPasswordChangedDate {
            get {
                return this._LastPasswordChangedDateField;
            }
            set {
                if ((this._LastPasswordChangedDateField.Equals(value) != true)) {
                    this._LastPasswordChangedDateField = value;
                    this.RaisePropertyChanged("_LastPasswordChangedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string _PasswordQuestion {
            get {
                return this._PasswordQuestionField;
            }
            set {
                if ((object.ReferenceEquals(this._PasswordQuestionField, value) != true)) {
                    this._PasswordQuestionField = value;
                    this.RaisePropertyChanged("_PasswordQuestion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string _ProviderName {
            get {
                return this._ProviderNameField;
            }
            set {
                if ((object.ReferenceEquals(this._ProviderNameField, value) != true)) {
                    this._ProviderNameField = value;
                    this.RaisePropertyChanged("_ProviderName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public object _ProviderUserKey {
            get {
                return this._ProviderUserKeyField;
            }
            set {
                if ((object.ReferenceEquals(this._ProviderUserKeyField, value) != true)) {
                    this._ProviderUserKeyField = value;
                    this.RaisePropertyChanged("_ProviderUserKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string _UserName {
            get {
                return this._UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this._UserNameField, value) != true)) {
                    this._UserNameField = value;
                    this.RaisePropertyChanged("_UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="WCFUsuario", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Services")]
    [System.SerializableAttribute()]
    public partial class WCFUsuario : DXWebAsoc.BusinessLogic.WCFService.MembershipUser {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContrasenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UserState EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Role RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contrasena {
            get {
                return this.ContrasenaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContrasenaField, value) != true)) {
                    this.ContrasenaField = value;
                    this.RaisePropertyChanged("Contrasena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserState Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Role Role {
            get {
                return this.RoleField;
            }
            set {
                if ((this.RoleField.Equals(value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usuario {
            get {
                return this.UsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioField, value) != true)) {
                    this.UsuarioField = value;
                    this.RaisePropertyChanged("Usuario");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFService.IAsocService")]
    public interface IAsocService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsocService/CreateUser", ReplyAction="http://tempuri.org/IAsocService/CreateUserResponse")]
        void CreateUser(DXWebAsoc.BusinessLogic.WCFService.WCFUsuario user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsocService/CreateUser", ReplyAction="http://tempuri.org/IAsocService/CreateUserResponse")]
        System.Threading.Tasks.Task CreateUserAsync(DXWebAsoc.BusinessLogic.WCFService.WCFUsuario user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsocService/UpdateUser", ReplyAction="http://tempuri.org/IAsocService/UpdateUserResponse")]
        void UpdateUser(DXWebAsoc.BusinessLogic.WCFService.WCFUsuario user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsocService/UpdateUser", ReplyAction="http://tempuri.org/IAsocService/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(DXWebAsoc.BusinessLogic.WCFService.WCFUsuario user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsocService/RedUser", ReplyAction="http://tempuri.org/IAsocService/RedUserResponse")]
        DXWebAsoc.BusinessLogic.WCFService.WCFUsuario RedUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsocService/RedUser", ReplyAction="http://tempuri.org/IAsocService/RedUserResponse")]
        System.Threading.Tasks.Task<DXWebAsoc.BusinessLogic.WCFService.WCFUsuario> RedUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsocService/ReadAllUser", ReplyAction="http://tempuri.org/IAsocService/ReadAllUserResponse")]
        DXWebAsoc.BusinessLogic.WCFService.WCFUsuario[] ReadAllUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsocService/ReadAllUser", ReplyAction="http://tempuri.org/IAsocService/ReadAllUserResponse")]
        System.Threading.Tasks.Task<DXWebAsoc.BusinessLogic.WCFService.WCFUsuario[]> ReadAllUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsocService/DeleteUser", ReplyAction="http://tempuri.org/IAsocService/DeleteUserResponse")]
        void DeleteUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsocService/DeleteUser", ReplyAction="http://tempuri.org/IAsocService/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAsocServiceChannel : DXWebAsoc.BusinessLogic.WCFService.IAsocService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AsocServiceClient : System.ServiceModel.ClientBase<DXWebAsoc.BusinessLogic.WCFService.IAsocService>, DXWebAsoc.BusinessLogic.WCFService.IAsocService {
        
        public AsocServiceClient() {
        }
        
        public AsocServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AsocServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsocServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsocServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateUser(DXWebAsoc.BusinessLogic.WCFService.WCFUsuario user) {
            base.Channel.CreateUser(user);
        }
        
        public System.Threading.Tasks.Task CreateUserAsync(DXWebAsoc.BusinessLogic.WCFService.WCFUsuario user) {
            return base.Channel.CreateUserAsync(user);
        }
        
        public void UpdateUser(DXWebAsoc.BusinessLogic.WCFService.WCFUsuario user) {
            base.Channel.UpdateUser(user);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(DXWebAsoc.BusinessLogic.WCFService.WCFUsuario user) {
            return base.Channel.UpdateUserAsync(user);
        }
        
        public DXWebAsoc.BusinessLogic.WCFService.WCFUsuario RedUser(int id) {
            return base.Channel.RedUser(id);
        }
        
        public System.Threading.Tasks.Task<DXWebAsoc.BusinessLogic.WCFService.WCFUsuario> RedUserAsync(int id) {
            return base.Channel.RedUserAsync(id);
        }
        
        public DXWebAsoc.BusinessLogic.WCFService.WCFUsuario[] ReadAllUser() {
            return base.Channel.ReadAllUser();
        }
        
        public System.Threading.Tasks.Task<DXWebAsoc.BusinessLogic.WCFService.WCFUsuario[]> ReadAllUserAsync() {
            return base.Channel.ReadAllUserAsync();
        }
        
        public void DeleteUser(int id) {
            base.Channel.DeleteUser(id);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(int id) {
            return base.Channel.DeleteUserAsync(id);
        }
    }
}