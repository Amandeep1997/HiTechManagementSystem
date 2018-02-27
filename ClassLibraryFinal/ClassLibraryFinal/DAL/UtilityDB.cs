using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.BUI;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassLibraryFinal.DAL
{
   public class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["HiTechConnectionString"].ToString();
            sqlconn.Open();
            return sqlconn;
        }
    }
}
