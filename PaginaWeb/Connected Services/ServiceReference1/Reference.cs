//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/ServicioWTF")]
    public partial class Cliente : object
    {
        
        private string codeField;
        
        private string lastnameField;
        
        private string nameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastname
        {
            get
            {
                return this.lastnameField;
            }
            set
            {
                this.lastnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    public partial class Person : object
    {
        
        private int AgeField;
        
        private int IdField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age
        {
            get
            {
                return this.AgeField;
            }
            set
            {
                this.AgeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCliente", ReplyAction="http://tempuri.org/IService1/getClienteResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Cliente> getClienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getClientes", ReplyAction="http://tempuri.org/IService1/getClientesResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Cliente[]> getClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getClientesSQL", ReplyAction="http://tempuri.org/IService1/getClientesSQLResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Cliente[]> getClientesSQLAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getClientesSQLByID", ReplyAction="http://tempuri.org/IService1/getClientesSQLByIDResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Cliente> getClientesSQLByIDAsync(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/put", ReplyAction="http://tempuri.org/IService1/putResponse")]
        System.Threading.Tasks.Task<int> putAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/post", ReplyAction="http://tempuri.org/IService1/postResponse")]
        System.Threading.Tasks.Task<int> postAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Eliminar", ReplyAction="http://tempuri.org/IService1/EliminarResponse")]
        System.Threading.Tasks.Task<int> EliminarAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPersons", ReplyAction="http://tempuri.org/IService1/GetAllPersonsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Person[]> GetAllPersonsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
    {
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync()
        {
            return base.Channel.GetDataAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Cliente> getClienteAsync()
        {
            return base.Channel.getClienteAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Cliente[]> getClientesAsync()
        {
            return base.Channel.getClientesAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Cliente[]> getClientesSQLAsync()
        {
            return base.Channel.getClientesSQLAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Cliente> getClientesSQLByIDAsync(string codigo)
        {
            return base.Channel.getClientesSQLByIDAsync(codigo);
        }
        
        public System.Threading.Tasks.Task<int> putAsync()
        {
            return base.Channel.putAsync();
        }
        
        public System.Threading.Tasks.Task<int> postAsync()
        {
            return base.Channel.postAsync();
        }
        
        public System.Threading.Tasks.Task<int> EliminarAsync(string id)
        {
            return base.Channel.EliminarAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Person[]> GetAllPersonsAsync()
        {
            return base.Channel.GetAllPersonsAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
