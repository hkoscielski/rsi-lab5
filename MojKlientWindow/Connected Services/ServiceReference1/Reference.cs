﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MojKlientWindow.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IRestService1")]
    public interface IRestService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/Create", ReplyAction="http://tempuri.org/IRestService1/CreateResponse")]
        string Create(MojWebSerwis.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/Create", ReplyAction="http://tempuri.org/IRestService1/CreateResponse")]
        System.Threading.Tasks.Task<string> CreateAsync(MojWebSerwis.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/GetAll", ReplyAction="http://tempuri.org/IRestService1/GetAllResponse")]
        MojWebSerwis.Student[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/GetAll", ReplyAction="http://tempuri.org/IRestService1/GetAllResponse")]
        System.Threading.Tasks.Task<MojWebSerwis.Student[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/GetById", ReplyAction="http://tempuri.org/IRestService1/GetByIdResponse")]
        MojWebSerwis.Student GetById(string index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/GetById", ReplyAction="http://tempuri.org/IRestService1/GetByIdResponse")]
        System.Threading.Tasks.Task<MojWebSerwis.Student> GetByIdAsync(string index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/Update", ReplyAction="http://tempuri.org/IRestService1/UpdateResponse")]
        string Update(string index, MojWebSerwis.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/Update", ReplyAction="http://tempuri.org/IRestService1/UpdateResponse")]
        System.Threading.Tasks.Task<string> UpdateAsync(string index, MojWebSerwis.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/Delete", ReplyAction="http://tempuri.org/IRestService1/DeleteResponse")]
        string Delete(string index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/Delete", ReplyAction="http://tempuri.org/IRestService1/DeleteResponse")]
        System.Threading.Tasks.Task<string> DeleteAsync(string index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/CreateJson", ReplyAction="http://tempuri.org/IRestService1/CreateJsonResponse")]
        string CreateJson(MojWebSerwis.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/CreateJson", ReplyAction="http://tempuri.org/IRestService1/CreateJsonResponse")]
        System.Threading.Tasks.Task<string> CreateJsonAsync(MojWebSerwis.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/GetJsonAll", ReplyAction="http://tempuri.org/IRestService1/GetJsonAllResponse")]
        MojWebSerwis.Student[] GetJsonAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/GetJsonAll", ReplyAction="http://tempuri.org/IRestService1/GetJsonAllResponse")]
        System.Threading.Tasks.Task<MojWebSerwis.Student[]> GetJsonAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/GetJsonById", ReplyAction="http://tempuri.org/IRestService1/GetJsonByIdResponse")]
        MojWebSerwis.Student GetJsonById(string index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/GetJsonById", ReplyAction="http://tempuri.org/IRestService1/GetJsonByIdResponse")]
        System.Threading.Tasks.Task<MojWebSerwis.Student> GetJsonByIdAsync(string index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/UpdateJson", ReplyAction="http://tempuri.org/IRestService1/UpdateJsonResponse")]
        string UpdateJson(string index, MojWebSerwis.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/UpdateJson", ReplyAction="http://tempuri.org/IRestService1/UpdateJsonResponse")]
        System.Threading.Tasks.Task<string> UpdateJsonAsync(string index, MojWebSerwis.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/DeleteJson", ReplyAction="http://tempuri.org/IRestService1/DeleteJsonResponse")]
        string DeleteJson(string index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestService1/DeleteJson", ReplyAction="http://tempuri.org/IRestService1/DeleteJsonResponse")]
        System.Threading.Tasks.Task<string> DeleteJsonAsync(string index);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRestService1Channel : MojKlientWindow.ServiceReference1.IRestService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RestService1Client : System.ServiceModel.ClientBase<MojKlientWindow.ServiceReference1.IRestService1>, MojKlientWindow.ServiceReference1.IRestService1 {
        
        public RestService1Client() {
        }
        
        public RestService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RestService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Create(MojWebSerwis.Student student) {
            return base.Channel.Create(student);
        }
        
        public System.Threading.Tasks.Task<string> CreateAsync(MojWebSerwis.Student student) {
            return base.Channel.CreateAsync(student);
        }
        
        public MojWebSerwis.Student[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<MojWebSerwis.Student[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public MojWebSerwis.Student GetById(string index) {
            return base.Channel.GetById(index);
        }
        
        public System.Threading.Tasks.Task<MojWebSerwis.Student> GetByIdAsync(string index) {
            return base.Channel.GetByIdAsync(index);
        }
        
        public string Update(string index, MojWebSerwis.Student student) {
            return base.Channel.Update(index, student);
        }
        
        public System.Threading.Tasks.Task<string> UpdateAsync(string index, MojWebSerwis.Student student) {
            return base.Channel.UpdateAsync(index, student);
        }
        
        public string Delete(string index) {
            return base.Channel.Delete(index);
        }
        
        public System.Threading.Tasks.Task<string> DeleteAsync(string index) {
            return base.Channel.DeleteAsync(index);
        }
        
        public string CreateJson(MojWebSerwis.Student student) {
            return base.Channel.CreateJson(student);
        }
        
        public System.Threading.Tasks.Task<string> CreateJsonAsync(MojWebSerwis.Student student) {
            return base.Channel.CreateJsonAsync(student);
        }
        
        public MojWebSerwis.Student[] GetJsonAll() {
            return base.Channel.GetJsonAll();
        }
        
        public System.Threading.Tasks.Task<MojWebSerwis.Student[]> GetJsonAllAsync() {
            return base.Channel.GetJsonAllAsync();
        }
        
        public MojWebSerwis.Student GetJsonById(string index) {
            return base.Channel.GetJsonById(index);
        }
        
        public System.Threading.Tasks.Task<MojWebSerwis.Student> GetJsonByIdAsync(string index) {
            return base.Channel.GetJsonByIdAsync(index);
        }
        
        public string UpdateJson(string index, MojWebSerwis.Student student) {
            return base.Channel.UpdateJson(index, student);
        }
        
        public System.Threading.Tasks.Task<string> UpdateJsonAsync(string index, MojWebSerwis.Student student) {
            return base.Channel.UpdateJsonAsync(index, student);
        }
        
        public string DeleteJson(string index) {
            return base.Channel.DeleteJson(index);
        }
        
        public System.Threading.Tasks.Task<string> DeleteJsonAsync(string index) {
            return base.Channel.DeleteJsonAsync(index);
        }
    }
}
