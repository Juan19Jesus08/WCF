using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace ServicioWTF
{
    public class Dato
    {
        private static string cadena = "Data Source=DESKTOP-RPDFJP3; Initial Catalog=Probar ; integrated security = true;";
        public static IList<Cliente> getClientesSQL()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter("Select * from Cliente", cadena);
            ada.Fill(tabla);
            IList<Cliente> lista = new List<Cliente>();
            for(int i=0; i<tabla.Rows.Count;i++)
            {
                Cliente item = new Cliente()
                {
                    code = tabla.Rows[i]["code"] + "",
                    name = tabla.Rows[i]["name"] + "",
                    lastname = tabla.Rows[i]["lastname"] + ""
                };
                lista.Add(item);
            }
            return lista;
        }

        public static Cliente getClientesByID(string codigo)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter("Select * from Cliente where code="+codigo, cadena);
            ada.Fill(tabla);
            Cliente item = null;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                 item = new Cliente()
                {
                    code = tabla.Rows[i]["code"] + "",
                    name = tabla.Rows[i]["name"] + "",
                    lastname = tabla.Rows[i]["lastname"] + ""
                };
                ;
            }
            return item;
        }

        

       

    }
}