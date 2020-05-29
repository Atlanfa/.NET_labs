﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_GUI.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Insert_Book", ReplyAction="http://tempuri.org/IService/Insert_BookResponse")]
        string Insert_Book(_Library_GUI_.ServiceReference1.BookService book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Insert_Book", ReplyAction="http://tempuri.org/IService/Insert_BookResponse")]
        System.Threading.Tasks.Task<string> Insert_BookAsync(_Library_GUI_.ServiceReference1.BookService book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Insert_Author", ReplyAction="http://tempuri.org/IService/Insert_AuthorResponse")]
        string Insert_Author(_Library_GUI_.ServiceReference1.AuthorService author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Insert_Author", ReplyAction="http://tempuri.org/IService/Insert_AuthorResponse")]
        System.Threading.Tasks.Task<string> Insert_AuthorAsync(_Library_GUI_.ServiceReference1.AuthorService author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Insert_Genre", ReplyAction="http://tempuri.org/IService/Insert_GenreResponse")]
        string Insert_Genre(_Library_GUI_.ServiceReference1.GenreService genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Insert_Genre", ReplyAction="http://tempuri.org/IService/Insert_GenreResponse")]
        System.Threading.Tasks.Task<string> Insert_GenreAsync(_Library_GUI_.ServiceReference1.GenreService genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update_Book", ReplyAction="http://tempuri.org/IService/Update_BookResponse")]
        string Update_Book(_Library_GUI_.ServiceReference1.BookService book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update_Book", ReplyAction="http://tempuri.org/IService/Update_BookResponse")]
        System.Threading.Tasks.Task<string> Update_BookAsync(_Library_GUI_.ServiceReference1.BookService book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update_Author", ReplyAction="http://tempuri.org/IService/Update_AuthorResponse")]
        string Update_Author(_Library_GUI_.ServiceReference1.AuthorService author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update_Author", ReplyAction="http://tempuri.org/IService/Update_AuthorResponse")]
        System.Threading.Tasks.Task<string> Update_AuthorAsync(_Library_GUI_.ServiceReference1.AuthorService author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update_Genre", ReplyAction="http://tempuri.org/IService/Update_GenreResponse")]
        string Update_Genre(_Library_GUI_.ServiceReference1.GenreService genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update_Genre", ReplyAction="http://tempuri.org/IService/Update_GenreResponse")]
        System.Threading.Tasks.Task<string> Update_GenreAsync(_Library_GUI_.ServiceReference1.GenreService genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Read_Book", ReplyAction="http://tempuri.org/IService/Read_BookResponse")]
        System.Data.DataSet Read_Book();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Read_Book", ReplyAction="http://tempuri.org/IService/Read_BookResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> Read_BookAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Read_Author", ReplyAction="http://tempuri.org/IService/Read_AuthorResponse")]
        System.Data.DataSet Read_Author();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Read_Author", ReplyAction="http://tempuri.org/IService/Read_AuthorResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> Read_AuthorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Read_Genre", ReplyAction="http://tempuri.org/IService/Read_GenreResponse")]
        System.Data.DataSet Read_Genre();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Read_Genre", ReplyAction="http://tempuri.org/IService/Read_GenreResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> Read_GenreAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Library_GUI.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Library_GUI.ServiceReference1.IService>, Library_GUI.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Insert_Book(_Library_GUI_.ServiceReference1.BookService book) {
            return base.Channel.Insert_Book(book);
        }
        
        public System.Threading.Tasks.Task<string> Insert_BookAsync(_Library_GUI_.ServiceReference1.BookService book) {
            return base.Channel.Insert_BookAsync(book);
        }
        
        public string Insert_Author(_Library_GUI_.ServiceReference1.AuthorService author) {
            return base.Channel.Insert_Author(author);
        }
        
        public System.Threading.Tasks.Task<string> Insert_AuthorAsync(_Library_GUI_.ServiceReference1.AuthorService author) {
            return base.Channel.Insert_AuthorAsync(author);
        }
        
        public string Insert_Genre(_Library_GUI_.ServiceReference1.GenreService genre) {
            return base.Channel.Insert_Genre(genre);
        }
        
        public System.Threading.Tasks.Task<string> Insert_GenreAsync(_Library_GUI_.ServiceReference1.GenreService genre) {
            return base.Channel.Insert_GenreAsync(genre);
        }
        
        public string Update_Book(_Library_GUI_.ServiceReference1.BookService book) {
            return base.Channel.Update_Book(book);
        }
        
        public System.Threading.Tasks.Task<string> Update_BookAsync(_Library_GUI_.ServiceReference1.BookService book) {
            return base.Channel.Update_BookAsync(book);
        }
        
        public string Update_Author(_Library_GUI_.ServiceReference1.AuthorService author) {
            return base.Channel.Update_Author(author);
        }
        
        public System.Threading.Tasks.Task<string> Update_AuthorAsync(_Library_GUI_.ServiceReference1.AuthorService author) {
            return base.Channel.Update_AuthorAsync(author);
        }
        
        public string Update_Genre(_Library_GUI_.ServiceReference1.GenreService genre) {
            return base.Channel.Update_Genre(genre);
        }
        
        public System.Threading.Tasks.Task<string> Update_GenreAsync(_Library_GUI_.ServiceReference1.GenreService genre) {
            return base.Channel.Update_GenreAsync(genre);
        }
        
        public System.Data.DataSet Read_Book() {
            return base.Channel.Read_Book();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Read_BookAsync() {
            return base.Channel.Read_BookAsync();
        }
        
        public System.Data.DataSet Read_Author() {
            return base.Channel.Read_Author();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Read_AuthorAsync() {
            return base.Channel.Read_AuthorAsync();
        }
        
        public System.Data.DataSet Read_Genre() {
            return base.Channel.Read_Genre();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Read_GenreAsync() {
            return base.Channel.Read_GenreAsync();
        }
    }
}
