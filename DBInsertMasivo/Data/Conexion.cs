using DBInsertMasivo.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FastMember;

namespace DBInsertMasivo.Data
{
    public class Conexion
    {
        public bool InsertMasivo(List<cp_proveedor_microempresa> Lista)
        {
            try
            {
                string connectionString = GetConnectionString();
                using (SqlConnection sourceConnection =
                 new SqlConnection(connectionString))
                {
                    using (var bcp = new SqlBulkCopy(connectionString))
                    using (var reader = ObjectReader.Create(Lista, "Ruc", "Nombre"))
                    {
                        bcp.BulkCopyTimeout = 3000;
                        bcp.DestinationTableName = "cp_proveedor_microempresa";
                        bcp.WriteToServer(reader);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public cp_proveedor_microempresa GetInfo(string Ruc)
        {
            try
            {
                cp_proveedor_microempresa info = new cp_proveedor_microempresa();

                string Conexion = GetConnectionString();

                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();

                    string Query = "SELECT Ruc,Nombre FROM cp_proveedor_microempresa WHERE Ruc = '" + Ruc + "'";
                    SqlCommand command = new SqlCommand(Query, connection);
                    var returnValue = command.ExecuteScalar();
                    if (returnValue == null)
                        return null;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        info.Ruc = reader[0].ToString();
                        info.Nombre = reader[1].ToString();
                    }
                    reader.Close();
                }

                return info;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<cp_proveedor_microempresa> GetList()
        {
            try
            {
                List<cp_proveedor_microempresa> Lista = new List<cp_proveedor_microempresa>();

                string Conexion = GetConnectionString();

                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();

                    string Query = "SELECT Ruc,Nombre FROM cp_proveedor_microempresa";
                    SqlCommand command = new SqlCommand(Query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lista.Add(new cp_proveedor_microempresa
                        {
                            Ruc = reader[0].ToString(),
                            Nombre = reader[1].ToString()
                        });                       
                    }
                    reader.Close();
                }

                return Lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static string GetConnectionString()
        {
            /*
            string ip = "fixed.database.windows.net";
            string password = "admin*2016";
            string user = "administrador";
            string InitialCatalog = "AgricolaYTransporte";
            */

            string ip = "192.168.50.8";
            string password = "@dmin*2015.12";
            string user = "sa";
            string InitialCatalog = "DBERP_NAT_PROD";
            
            return "data source=" + ip + ";initial catalog=" + InitialCatalog + ";user id=" + user + ";password=" + password + ";MultipleActiveResultSets=True;";
        }
    }
}
