using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.DAL;

namespace ClassLibraryFinal.BUI
{
   public class Book
    {
        public int Isbn { get; set; }
        public string Title { get; set; }
        public int LimitPrice { get; set; }
        public int YearPublished { get; set; }
        public int QOH { get; set; }

        public bool SaveBook(Book book)
        {
            return ProductDB.saveBook(book);
        }
        public Book SearchBook(int Isbn)
        {
            return ProductDB.SearchBook(Isbn);
        }
        public List<Book> List(int AuthID)
        {
            return ProductDB.listBook(AuthID);
        }
        public void delete(Book book)
        {
            ProductDB.DeleteBook(book);
        }
        public void update(Book book)
        {
            ProductDB.UpdateBook(book);
        }
    }
}
