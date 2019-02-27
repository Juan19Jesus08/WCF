using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioWTF
{
    
    [ServiceContract]
    public interface IService1
    {

        [OperationContract,WebGet(UriTemplate="GetData",ResponseFormat =WebMessageFormat.Json)]
        string GetData();

        [OperationContract,WebGet(UriTemplate="getCliente",ResponseFormat =WebMessageFormat.Json)]
        Cliente getCliente();

        //ahora se realizara un listado de objetos
        [OperationContract,WebGet(UriTemplate = "getClientes", ResponseFormat = WebMessageFormat.Json)]

        IList<Cliente> getClientes();

        [OperationContract, WebGet(UriTemplate = "getClientesSQL", ResponseFormat = WebMessageFormat.Json)]
        IList<Cliente> getClientesSQL();

        [OperationContract, WebGet(UriTemplate = "getClientesSQLByID/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        Cliente getClientesSQLByID(string codigo);

     

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "put", ResponseFormat = WebMessageFormat.Json)]

        int put();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "post", ResponseFormat = WebMessageFormat.Json)]

        int post();

        [OperationContract]
        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Eliminar/{id}")]
        int Eliminar(string id);
        


        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetAllPersons")]
        List<WcfService1.Person> GetAllPersons();



    }

}
