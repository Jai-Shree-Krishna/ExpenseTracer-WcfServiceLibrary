﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpenseTracker_WindowsFormsApp.CategoryServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CategoryServiceReference.ICategoryService")]
    public interface ICategoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/AddCategory", ReplyAction="http://tempuri.org/ICategoryService/AddCategoryResponse")]
        bool AddCategory(string category, int UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/AddCategory", ReplyAction="http://tempuri.org/ICategoryService/AddCategoryResponse")]
        System.Threading.Tasks.Task<bool> AddCategoryAsync(string category, int UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetCategories", ReplyAction="http://tempuri.org/ICategoryService/GetCategoriesResponse")]
        System.Data.DataSet GetCategories(int UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetCategories", ReplyAction="http://tempuri.org/ICategoryService/GetCategoriesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetCategoriesAsync(int UserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetAllCategories", ReplyAction="http://tempuri.org/ICategoryService/GetAllCategoriesResponse")]
        System.Data.DataSet GetAllCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetAllCategories", ReplyAction="http://tempuri.org/ICategoryService/GetAllCategoriesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllCategoriesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategoryServiceChannel : ExpenseTracker_WindowsFormsApp.CategoryServiceReference.ICategoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CategoryServiceClient : System.ServiceModel.ClientBase<ExpenseTracker_WindowsFormsApp.CategoryServiceReference.ICategoryService>, ExpenseTracker_WindowsFormsApp.CategoryServiceReference.ICategoryService {
        
        public CategoryServiceClient() {
        }
        
        public CategoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddCategory(string category, int UserId) {
            return base.Channel.AddCategory(category, UserId);
        }
        
        public System.Threading.Tasks.Task<bool> AddCategoryAsync(string category, int UserId) {
            return base.Channel.AddCategoryAsync(category, UserId);
        }
        
        public System.Data.DataSet GetCategories(int UserId) {
            return base.Channel.GetCategories(UserId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetCategoriesAsync(int UserId) {
            return base.Channel.GetCategoriesAsync(UserId);
        }
        
        public System.Data.DataSet GetAllCategories() {
            return base.Channel.GetAllCategories();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllCategoriesAsync() {
            return base.Channel.GetAllCategoriesAsync();
        }
    }
}