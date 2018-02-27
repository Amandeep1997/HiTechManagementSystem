using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFinal.DAL;
namespace ClassLibraryFinal.BUI
{
    public class AuthorBook
    {
        public int Isbn { get; set; }
        public int AuthorId { get; set; }
        public DateTime Date { get; set; }
        public bool saveauthorbook(AuthorBook authBook)
        {
            return ProductDB.saveauthBook(authBook);
        }
    }
}
