﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kitchen_Side.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoGood", Namespace="http://schemas.datacontract.org/2004/07/DataLayer.DtoLayer")]
    [System.SerializableAttribute()]
    public partial class DtoGood : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Category_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public int Category_Id {
            get {
                return this.Category_IdField;
            }
            set {
                if ((this.Category_IdField.Equals(value) != true)) {
                    this.Category_IdField = value;
                    this.RaisePropertyChanged("Category_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoUser", Namespace="http://schemas.datacontract.org/2004/07/DataLayer.DtoLayer")]
    [System.SerializableAttribute()]
    public partial class DtoUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Role_IdField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Role_Id {
            get {
                return this.Role_IdField;
            }
            set {
                if ((this.Role_IdField.Equals(value) != true)) {
                    this.Role_IdField = value;
                    this.RaisePropertyChanged("Role_Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceUser", Namespace="http://schemas.datacontract.org/2004/07/Service")]
    [System.SerializableAttribute()]
    public partial class ServiceUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HostNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string HostName {
            get {
                return this.HostNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HostNameField, value) != true)) {
                    this.HostNameField = value;
                    this.RaisePropertyChanged("HostName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IpAddress {
            get {
                return this.IpAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.IpAddressField, value) != true)) {
                    this.IpAddressField = value;
                    this.RaisePropertyChanged("IpAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceMessage", Namespace="http://schemas.datacontract.org/2004/07/Service")]
    [System.SerializableAttribute()]
    public partial class ServiceMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Kitchen_Side.ServiceReference1.DtoGood MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Kitchen_Side.ServiceReference1.ServiceUser UserField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Kitchen_Side.ServiceReference1.DtoGood Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Kitchen_Side.ServiceReference1.ServiceUser User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IContract", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/TestConnection", ReplyAction="http://tempuri.org/IContract/TestConnectionResponse")]
        bool TestConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/TestConnection", ReplyAction="http://tempuri.org/IContract/TestConnectionResponse")]
        System.Threading.Tasks.Task<bool> TestConnectionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetGoods", ReplyAction="http://tempuri.org/IContract/GetGoodsResponse")]
        Kitchen_Side.ServiceReference1.DtoGood[] GetGoods();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetGoods", ReplyAction="http://tempuri.org/IContract/GetGoodsResponse")]
        System.Threading.Tasks.Task<Kitchen_Side.ServiceReference1.DtoGood[]> GetGoodsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetUsers", ReplyAction="http://tempuri.org/IContract/GetUsersResponse")]
        Kitchen_Side.ServiceReference1.DtoUser[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetUsers", ReplyAction="http://tempuri.org/IContract/GetUsersResponse")]
        System.Threading.Tasks.Task<Kitchen_Side.ServiceReference1.DtoUser[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/SendOrder", ReplyAction="http://tempuri.org/IContract/SendOrderResponse")]
        void SendOrder(Kitchen_Side.ServiceReference1.DtoGood[] list, Kitchen_Side.ServiceReference1.DtoUser user, int terminalNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/SendOrder", ReplyAction="http://tempuri.org/IContract/SendOrderResponse")]
        System.Threading.Tasks.Task SendOrderAsync(Kitchen_Side.ServiceReference1.DtoGood[] list, Kitchen_Side.ServiceReference1.DtoUser user, int terminalNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/ClientConnect", ReplyAction="http://tempuri.org/IContract/ClientConnectResponse")]
        Kitchen_Side.ServiceReference1.ServiceUser ClientConnect(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/ClientConnect", ReplyAction="http://tempuri.org/IContract/ClientConnectResponse")]
        System.Threading.Tasks.Task<Kitchen_Side.ServiceReference1.ServiceUser> ClientConnectAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetNewMessages", ReplyAction="http://tempuri.org/IContract/GetNewMessagesResponse")]
        Kitchen_Side.ServiceReference1.ServiceMessage[] GetNewMessages(Kitchen_Side.ServiceReference1.ServiceUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetNewMessages", ReplyAction="http://tempuri.org/IContract/GetNewMessagesResponse")]
        System.Threading.Tasks.Task<Kitchen_Side.ServiceReference1.ServiceMessage[]> GetNewMessagesAsync(Kitchen_Side.ServiceReference1.ServiceUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/SendNewMessage", ReplyAction="http://tempuri.org/IContract/SendNewMessageResponse")]
        void SendNewMessage(Kitchen_Side.ServiceReference1.ServiceMessage newMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/SendNewMessage", ReplyAction="http://tempuri.org/IContract/SendNewMessageResponse")]
        System.Threading.Tasks.Task SendNewMessageAsync(Kitchen_Side.ServiceReference1.ServiceMessage newMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/RemoveUser", ReplyAction="http://tempuri.org/IContract/RemoveUserResponse")]
        void RemoveUser(Kitchen_Side.ServiceReference1.ServiceUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/RemoveUser", ReplyAction="http://tempuri.org/IContract/RemoveUserResponse")]
        System.Threading.Tasks.Task RemoveUserAsync(Kitchen_Side.ServiceReference1.ServiceUser user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContractChannel : Kitchen_Side.ServiceReference1.IContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContractClient : System.ServiceModel.ClientBase<Kitchen_Side.ServiceReference1.IContract>, Kitchen_Side.ServiceReference1.IContract {
        
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
        
        public bool TestConnection() {
            return base.Channel.TestConnection();
        }
        
        public System.Threading.Tasks.Task<bool> TestConnectionAsync() {
            return base.Channel.TestConnectionAsync();
        }
        
        public Kitchen_Side.ServiceReference1.DtoGood[] GetGoods() {
            return base.Channel.GetGoods();
        }
        
        public System.Threading.Tasks.Task<Kitchen_Side.ServiceReference1.DtoGood[]> GetGoodsAsync() {
            return base.Channel.GetGoodsAsync();
        }
        
        public Kitchen_Side.ServiceReference1.DtoUser[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<Kitchen_Side.ServiceReference1.DtoUser[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public void SendOrder(Kitchen_Side.ServiceReference1.DtoGood[] list, Kitchen_Side.ServiceReference1.DtoUser user, int terminalNum) {
            base.Channel.SendOrder(list, user, terminalNum);
        }
        
        public System.Threading.Tasks.Task SendOrderAsync(Kitchen_Side.ServiceReference1.DtoGood[] list, Kitchen_Side.ServiceReference1.DtoUser user, int terminalNum) {
            return base.Channel.SendOrderAsync(list, user, terminalNum);
        }
        
        public Kitchen_Side.ServiceReference1.ServiceUser ClientConnect(string userName) {
            return base.Channel.ClientConnect(userName);
        }
        
        public System.Threading.Tasks.Task<Kitchen_Side.ServiceReference1.ServiceUser> ClientConnectAsync(string userName) {
            return base.Channel.ClientConnectAsync(userName);
        }
        
        public Kitchen_Side.ServiceReference1.ServiceMessage[] GetNewMessages(Kitchen_Side.ServiceReference1.ServiceUser user) {
            return base.Channel.GetNewMessages(user);
        }
        
        public System.Threading.Tasks.Task<Kitchen_Side.ServiceReference1.ServiceMessage[]> GetNewMessagesAsync(Kitchen_Side.ServiceReference1.ServiceUser user) {
            return base.Channel.GetNewMessagesAsync(user);
        }
        
        public void SendNewMessage(Kitchen_Side.ServiceReference1.ServiceMessage newMessage) {
            base.Channel.SendNewMessage(newMessage);
        }
        
        public System.Threading.Tasks.Task SendNewMessageAsync(Kitchen_Side.ServiceReference1.ServiceMessage newMessage) {
            return base.Channel.SendNewMessageAsync(newMessage);
        }
        
        public void RemoveUser(Kitchen_Side.ServiceReference1.ServiceUser user) {
            base.Channel.RemoveUser(user);
        }
        
        public System.Threading.Tasks.Task RemoveUserAsync(Kitchen_Side.ServiceReference1.ServiceUser user) {
            return base.Channel.RemoveUserAsync(user);
        }
    }
}
