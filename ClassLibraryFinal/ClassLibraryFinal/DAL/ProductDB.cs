using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.BUI;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ClassLibraryFinal.DAL
{
   public class ProductDB
    {
        /*********************************************Book**********************************************************/
        public static bool saveBook(Book book)
        {
            Category cat = new Category(); Publisher pub = new Publisher();
            bool success = false;
            try
            {
                string sqlInsert = "Insert INTO Books (Isbn, Title, LimitPrice, YearPublished, QOH, CategorieId, PublisherId) " +
                                   "SELECT @Isbn, @Title, @LimitPrice, @YearPublished, @QOH, c.CategorieId, p.PublisherId FROM Categories c, Publishers p, Books " +
                                   "WHERE Books.CategorieId = c.CategorieId AND Books.PublisherId = p.PublisherId";
                         
               // MessageBox.Show(sqlInsert);//Test
                SqlConnection sqlconn = UtilityDB.ConnectDB();
                SqlCommand sqlcmd = new SqlCommand(sqlInsert, sqlconn);
                sqlcmd.Parameters.AddWithValue("@Isbn", book.Isbn);
                sqlcmd.Parameters.AddWithValue("@Title", book.Title);
                sqlcmd.Parameters.AddWithValue("@LimitPrice", book.LimitPrice);
                sqlcmd.Parameters.AddWithValue("@YearPublished", book.YearPublished);
                sqlcmd.Parameters.AddWithValue("@QOH", book.QOH);
                sqlcmd.Parameters.AddWithValue("@CategorieId", cat.CategorieId);
                sqlcmd.Parameters.AddWithValue("@PublisherId", pub.PublisherId);
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
                success = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return success;  
        }
        public static Book SearchBook(int Isbn)
        {
            Book book = new Book();
            string sqlSelect = "Select * From Books " + "Where Isbn= " + Isbn;
            SqlConnection sqlconn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlSelect, sqlconn);
            SqlDataReader sqlReader = sqlcmd.ExecuteReader();
            if(sqlReader.Read())
            {
                book.Isbn = Convert.ToInt32(sqlReader["Isbn"].ToString());
                book.Title = sqlReader["Title"].ToString();
                book.LimitPrice = Convert.ToInt32(sqlReader["LimitPrice"].ToString());
                book.YearPublished = Convert.ToInt32(sqlReader["YearPublished"].ToString());
                book.QOH = Convert.ToInt32(sqlReader["QOH"].ToString());
                
            }
            return book;
        }

        public static List<Book> listBook(int AuthorId)
        {
            List<Book> list = new List<Book>();
            string sqlSelect = "Select ab.Isbn, Title, LimitPrice, YearPublished, QOH From AuthorBook ab, Authors a, Books b "+
                               "Where ab.AuthorId= a.AuthorId "+
                               "AND ab.Isbn = b.Isbn "+
                               "AND a.AuthorId = " + AuthorId;
            SqlConnection sqlConn = new SqlConnection();
            sqlConn = UtilityDB.ConnectDB(); 
            SqlCommand sqlcmd = new SqlCommand(sqlSelect, sqlConn);
            SqlDataReader sqlReader = sqlcmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Book book = new Book(); 
                book.Isbn = Convert.ToInt32(sqlReader["Isbn"].ToString());
                book.Title = sqlReader["Title"].ToString();
                book.LimitPrice = Convert.ToInt32(sqlReader["LimitPrice"].ToString());
                book.YearPublished = Convert.ToInt32(sqlReader["YearPublished"].ToString());
                book.QOH = Convert.ToInt32(sqlReader["QOH"].ToString());
              
                list.Add(book);
            }
            sqlConn.Close();
            return list;
        }
        public static void DeleteBook(Book book)
        {
            string sqlDelete = "Delete From Books Where Isbn=@Isbn";
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlDelete, sqlConn);
            sqlcmd.Parameters.AddWithValue("@Isbn", book.Isbn);
            sqlcmd.Parameters.AddWithValue("@Title", book.Title);
            sqlcmd.Parameters.AddWithValue("@LimitPrice", book.LimitPrice);
            sqlcmd.Parameters.AddWithValue("@YearPublished", book.YearPublished);
            sqlcmd.Parameters.AddWithValue("@QOH", book.QOH);
           
            sqlcmd.ExecuteNonQuery();

            sqlConn.Close();
        }
        public static void UpdateBook(Book book)
        {
            string sqlUpdate = "Update Books " +
                                "SET Title=@Title, LimitPrice=@LimitPrice, YearPublished=@YearPublished, QOH=@QOH Where Isbn=@Isbn ";
            MessageBox.Show(sqlUpdate);
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlUpdate, sqlConn);
            sqlcmd.Parameters.AddWithValue("@Isbn", book.Isbn);
            sqlcmd.Parameters.AddWithValue("@Title", book.Title);
            sqlcmd.Parameters.AddWithValue("@LimitPrice", book.LimitPrice);
            sqlcmd.Parameters.AddWithValue("@YearPublished", book.YearPublished);
            sqlcmd.Parameters.AddWithValue("@QOH", book.QOH);
           
            sqlcmd.ExecuteNonQuery();

            sqlConn.Close();
        }
        /*******************************************AuthorBook************************************************/
        /**********************************Add Data into AuthorBooks******************************************/
        public static bool saveauthBook(AuthorBook AuthBook)
        {
            bool success = false;
            try
            {
                string sqlInsert = "Insert INTO AuthorBook " + "Values(@AuthorId, @Isbn, @Date)";
                SqlConnection sqlconn = UtilityDB.ConnectDB();
                SqlCommand sqlCmd = new SqlCommand(sqlInsert, sqlconn);

                sqlCmd.Parameters.AddWithValue("@AuthorId", AuthBook.AuthorId);
                sqlCmd.Parameters.AddWithValue("@Isbn", AuthBook.Isbn);
                sqlCmd.Parameters.AddWithValue("@Date", AuthBook.Date);
                sqlCmd.ExecuteReader();
                sqlconn.Close();
                success = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return success;
        }

        /*********************************************Software************************************************/
        public static bool saveSoftware(Software software)
        {
            Category cat = new Category(); 
            bool success = false;
            try
            {
                string sqlInsert = "Insert INTO Softwares (SoftwareId, SoftwareName, CategorieId) " +
                                   "SELECT @SoftwareId, @SoftwareName, c.CategorieId FROM Categories c, Softwares " +
                                   "WHERE Softwares.CategorieId = c.CategorieId ";

                // MessageBox.Show(sqlInsert);//Test
                SqlConnection sqlconn = UtilityDB.ConnectDB();
                SqlCommand sqlcmd = new SqlCommand(sqlInsert, sqlconn);
                sqlcmd.Parameters.AddWithValue("@SoftwareId", software.SoftwareId);
                sqlcmd.Parameters.AddWithValue("@SoftwareName", software.SoftwareName);
                sqlcmd.Parameters.AddWithValue("@CategorieId", cat.CategorieId);
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
                success = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return success;
        }
        public static Software Searchsoftware(int softwareID)
        {
            Software soft = new Software();
            string sqlSelect = "Select * From Softwares " + "Where SoftwareId= " + softwareID;
            SqlConnection sqlconn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlSelect, sqlconn);
            SqlDataReader sqlReader = sqlcmd.ExecuteReader();
            if (sqlReader.Read())
            {
                soft.SoftwareId= Convert.ToInt32(sqlReader["SoftwareId"].ToString());
                soft.SoftwareName = sqlReader["SoftwareName"].ToString();
              
            }
            return soft;
        }
        public static List<Software> listsoftware()
        {
            List<Software> list = new List<Software>();
            string sqlSelect = "Select SoftwareId, SoftwareName From Softwares";
            SqlConnection sqlConn = new SqlConnection();
            sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlSelect, sqlConn);
            SqlDataReader sqlReader = sqlcmd.ExecuteReader();
            while (sqlReader.Read())
            {
                Software soft = new Software();
                soft.SoftwareId = Convert.ToInt32(sqlReader["SoftwareId"].ToString());
                soft.SoftwareName = sqlReader["SoftwareName"].ToString();
                list.Add(soft);
            }
            sqlConn.Close();
            return list;
        }
        public static void DeleteSoftware(Software software)
        {
            string sqlDelete = "Delete From Softwares WHERE SoftwareId=@SoftwareId";
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlDelete, sqlConn);
            sqlcmd.Parameters.AddWithValue("@SoftwareId", software.SoftwareId);
            sqlcmd.Parameters.AddWithValue("@SoftwareName", software.SoftwareName);
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
        public static void UpdateSoftware(Software soft)
        {
            string sqlUpdate = "Update Softwares " +
                                "SET SoftwareName=@SoftwareName Where SoftwareId=@SoftwareId";
            MessageBox.Show(sqlUpdate);
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlcmd = new SqlCommand(sqlUpdate, sqlConn);
            sqlcmd.Parameters.AddWithValue("@SoftwareId", soft.SoftwareId);
            sqlcmd.Parameters.AddWithValue("@SoftwareName", soft.SoftwareName);

            sqlcmd.ExecuteNonQuery();

            sqlConn.Close();
        }
    }
}
