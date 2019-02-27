using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1;

namespace ServicioWTF
{
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDb();
        }
        SqlConnection conn;
        SqlCommand comm;
        SqlConnectionStringBuilder connStringBuilder;
        void ConnectToDb()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "DESKTOP-RPDFJP3";
            connStringBuilder.InitialCatalog = "Probar";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }

        public string GetData()
        {
            string cadena = "Mi primer Metodo WTF WCF";
            return cadena;
        }

        public Cliente getCliente()
        {
            return new Cliente()
            {
                code = "001",
                name = "juan jesus",
                lastname = "padron diaz"
            };
        }

        public IList<Cliente> getClientes()
        {
            IList<Cliente> lista = new List<Cliente>();
            for (int i = 0; i <= 100; i++)
            {
                lista.Add(new Cliente() { code = "00" + i, name = "Numero del cliente es " + i, lastname = "Mi apellido es " + i });

            }
            return lista;
        }

        public IList<Cliente> getClientesSQL()
        {
            return Dato.getClientesSQL();
        }

        public Cliente getClientesSQLByID(string codigo)
        {
            return Dato.getClientesByID(codigo);
        }
     

        public int put()
        {
            return 123;
        }

        public int post()
        {
            return 456;
        }

        //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetAllPersons")]
        public List<Person> GetAllPersons()
        {
            List<Person> list = new List<Person>();
            try
            {
                comm.CommandText = "Select * from Person";
                comm.CommandType = CommandType.Text;
                conn.Open();

                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Person person = new Person()
                    {
                        Id = Convert.ToInt32(reader[0]),
                        Name = reader[1].ToString(),
                        Age = Convert.ToInt32(reader[2])
                    };
                    list.Add(person);
                }
                return list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

       
        public int Eliminar(string id)
        {
            try
            {
                comm.CommandText = "delete person where Id=@Id";
                comm.Parameters.AddWithValue("Id", id);
                comm.CommandType = CommandType.Text;
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
 }
