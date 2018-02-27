using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.BUI;
using System.Data.SqlClient;
namespace ClassLibraryFinal.DAL
{
   public class EmployeeDB
    {
        public static bool SaveEmployee(Employee emp)
        {
            bool success = false;
            try
            {

                string sqlInsert = "Insert into Employees " + "Values(@EmployeeId, @FirstName, @LastName, @JobTitle)";
                SqlConnection sqlConn = UtilityDB.ConnectDB();
                SqlCommand sqlcmd = new SqlCommand(sqlInsert, sqlConn);
                sqlcmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                sqlcmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                sqlcmd.Parameters.AddWithValue("@LastName", emp.LastName);
                sqlcmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
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
        public static Employee searchRecord(int empId)
        {
            string sqlSelect = "Select * From Employees " + "Where EmployeeId= " + empId;
            SqlConnection sqlconn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlSelect, sqlconn);
            SqlDataReader sqlReader = sqlcmd.ExecuteReader();
            Employee emp = new Employee();
            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"].ToString());
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();

            }
            else { emp = null; }
            sqlconn.Close();
            return emp;
        }
        public static void UpdateEmployee(Employee emp)
        {
            string sqlUpdate = "Update Employees " +
                                "SET FirstName=@FirstName, LastName=@LastName, JobTitle=@JobTitle Where EmployeeId=@EmployeeId ";
            // connect the database
            SqlConnection sqlConn = UtilityDB.ConnectDB();//to connect to the database
            //Customize the sqlCommand object
            SqlCommand sqlcmd = new SqlCommand(sqlUpdate, sqlConn);
            sqlcmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            sqlcmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            sqlcmd.Parameters.AddWithValue("@LastName", emp.LastName);
            sqlcmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            sqlcmd.ExecuteNonQuery();

            sqlConn.Close();

        }
        public static void DeleteEmployee(Employee emp)
        {
            string sqlDelete = "Delete From Employees Where EmployeeId=@EmployeeId";
            SqlConnection sqlConn = UtilityDB.ConnectDB();//to connect to the database
            //Customize the sqlCommand object
            SqlCommand sqlcmd = new SqlCommand(sqlDelete, sqlConn);
            sqlcmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            sqlcmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            sqlcmd.Parameters.AddWithValue("@LastName", emp.LastName);
            sqlcmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            sqlcmd.ExecuteNonQuery();

            sqlConn.Close();
        }

        public static List<Employee> ListRecords()
        {
            List<Employee> listEmp = new List<Employee>();

            string sqlSelect = "Select * From Employees "; 
            SqlConnection sqlConn = new SqlConnection();
            sqlConn = UtilityDB.ConnectDB(); 

            SqlCommand sqlcmd = new SqlCommand(sqlSelect, sqlConn);

            SqlDataReader sqlReader = sqlcmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                listEmp.Add(emp);
            }
            sqlConn.Close();
            return listEmp;

        }







    }
}
