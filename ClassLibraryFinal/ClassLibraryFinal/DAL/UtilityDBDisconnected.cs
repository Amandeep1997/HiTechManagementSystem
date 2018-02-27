using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ClassLibraryFinal.DAL
{
   public static class UtilityDBDisconnected
    {
        private static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HiTechConnectionString"].ConnectionString;
            return connectionString;
        }
      
        //Code for Clients****************************************************************************************************
        private static SqlDataAdapter sqlDaClient = new SqlDataAdapter();
        private static SqlCommandBuilder sqlCmdBuilder;

        public static string tableNameClients = "Clients";
        private static string sqlClient = "SELECT * FROM Clients";
        public static SqlDataAdapter GetDataAdapterClients()
        {
           
            sqlDaClient = new SqlDataAdapter(sqlClient, GetConnectionString());
            sqlCmdBuilder = new SqlCommandBuilder(sqlDaClient);

            return sqlDaClient;
        }
        public static DataSet GetDataSetClients(DataSet ds, DataTable dt)
        {
           
            sqlDaClient = GetDataAdapterClients();
            sqlDaClient.FillSchema(ds, SchemaType.Source, tableNameClients);
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ClientID"] };
            sqlDaClient.Fill(ds, tableNameClients);
            return ds;
        }

    }
}
