using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.BUI;
using System.Data.SqlClient;
namespace ClassLibraryFinal.DAL
{
   public class UserDB
    {
        //Code for User Authentication***************************************
        public static Boolean Authentication(int UserId, string Password)
        {
            // User user = new User();
            string sqlSelect = "Select UserId, Password from Users " +
                               "Where UserId = " + UserId + 
                               "AND Password = '" + Password + "'";
            SqlConnection sqlconn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlSelect, sqlconn);
            SqlDataReader sqlReader = sqlcmd.ExecuteReader();
            if (sqlReader.Read())
            {
                return true;
            }
            return false;
        }
        public static bool AddUser(User user)
        {
            bool success = false;
            try
            {
                string sqlInsert = "Insert into Users " + "Values(@UserId, @Password)";
                
                SqlConnection sqlConn = UtilityDB.ConnectDB();
                
                SqlCommand sqlcmd = new SqlCommand(sqlInsert, sqlConn);
                sqlcmd.Parameters.AddWithValue("@UserId", user.UserId);
                sqlcmd.Parameters.AddWithValue("@Password", user.Password);

                sqlcmd.ExecuteNonQuery();
                sqlConn.Close();
                success = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return success;

        }
        public static User searchUSerRecord(int UserId)
        {
            string sqlSelect = "Select * From Users " + "Where UserId= " + UserId ;
            SqlConnection sqlconn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlSelect, sqlconn);
            SqlDataReader sqlReader = sqlcmd.ExecuteReader();
            User user = new User();
            if (sqlReader.Read())
            {
                user.UserId = Convert.ToInt32(sqlReader["UserId"].ToString());
                user.Password = sqlReader["Password"].ToString();

            }
            else { user = null; }
            sqlconn.Close();
            return user;
        }
        public static List<User> ListUserRecord()
        {
            List<User> listUser = new List<User>();

            string sqlSelect = "Select * From Users ";

            SqlConnection sqlConn = new SqlConnection();
            sqlConn = UtilityDB.ConnectDB();

            SqlCommand sqlcmd = new SqlCommand(sqlSelect, sqlConn);

            SqlDataReader sqlReader = sqlcmd.ExecuteReader();
            while (sqlReader.Read())
            {
                User user = new User();
                user.UserId = Convert.ToInt32(sqlReader["UserId"].ToString());
                user.Password = sqlReader["Password"].ToString();

                listUser.Add(user);
            }
            sqlConn.Close();
            return listUser;

        }
        public static void UpdateUser(User user)
        {
            string sqlUpdate = "Update Users " +
                                "SET Password=@Password WHERE UserId=@UserId";
           
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlUpdate, sqlConn);
            sqlcmd.Parameters.AddWithValue("@UserId", user.UserId);
            sqlcmd.Parameters.AddWithValue("@Password", user.Password);
            sqlcmd.ExecuteNonQuery();

            sqlConn.Close();

        }
        public static void DeleteUser(User user)
        {
            string sqlDelete = "Delete From Users Where UserId=@UserId";
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlDelete, sqlConn);
            sqlcmd.Parameters.AddWithValue("@UserId", user.UserId);
            sqlcmd.Parameters.AddWithValue("@Password", user.Password);
            sqlcmd.ExecuteNonQuery();

            sqlConn.Close();
        }


    }
}
