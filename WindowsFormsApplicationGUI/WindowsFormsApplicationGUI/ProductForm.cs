using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryFinal.BUI;
using ClassLibraryFinal.DAL;
namespace WindowsFormsApplicationGUI
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit this application?", "Confirmation");
            Application.Exit();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxAuthorID.Clear();textBoxCategoryIdforBook.Clear();textBoxCategoryIdForSoftware.Clear();
            textBoxISBN.Clear();
            textBoxLimitPrice.Clear();
            textBoxPublisherID.Clear();
            textBoxSoftwareId.Clear();
            textBoxSoftwareName.Clear(); 
            textBoxQOH.Clear();
            textBoxTitle.Clear();
            textBoxYearPublished.Clear();
        }
        private void buttonAddBook_Click(object sender, EventArgs e)
        {

            Book book = new Book(); Category cat = new Category(); Publisher pub = new Publisher();
            book.Isbn = Convert.ToInt32(textBoxISBN.Text);
            book.Title = textBoxTitle.Text;
            book.LimitPrice = Convert.ToInt32(textBoxLimitPrice.Text);
            book.QOH = Convert.ToInt32(textBoxQOH.Text);
            book.YearPublished = Convert.ToInt32(textBoxYearPublished.Text);
            cat.CategorieId = Convert.ToInt32(textBoxCategoryIdforBook.Text);
            pub.PublisherId = Convert.ToInt32(textBoxPublisherID.Text);
            if(book.SaveBook(book))
            {
                MessageBox.Show("Book has been saved");
            }
            else { MessageBox.Show("Error!.."); }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Book book = new Book(); 
            int Isbn = Convert.ToInt32(textBoxISBN.Text);
            book = book.SearchBook(Isbn);
            if(book != null)
            {
                textBoxISBN.Text = (book.Isbn).ToString();
                textBoxTitle.Text = book.Title;
                textBoxLimitPrice.Text = book.LimitPrice.ToString();
                textBoxYearPublished.Text = book.YearPublished.ToString();
                textBoxQOH.Text = book.QOH.ToString();
             }
            else
            {
                MessageBox.Show("Book does not exist");
            }
        }

        private void buttonListBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            List<Book> list = book.List(Convert.ToInt32(textBoxAuthorID.Text));
            listViewBook.Items.Clear();
            foreach (Book anbook in list)
            {
                ListViewItem item = new ListViewItem(anbook.Isbn.ToString());
                item.SubItems.Add(anbook.Title);
                item.SubItems.Add(anbook.LimitPrice.ToString());
                item.SubItems.Add(anbook.YearPublished.ToString());
                item.SubItems.Add(anbook.QOH.ToString());
              
                listViewBook.Items.Add(item);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Book book = new Book(); 
            book.Isbn = Convert.ToInt32(textBoxISBN.Text);
            book.Title = textBoxTitle.Text;
            book.LimitPrice = Convert.ToInt32(textBoxLimitPrice.Text);
            book.QOH = Convert.ToInt32(textBoxQOH.Text);
            book.YearPublished = Convert.ToInt32(textBoxYearPublished.Text);
           
            book.delete(book);
            MessageBox.Show("Data Deleted!");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Isbn = Convert.ToInt32(textBoxISBN.Text);
            book.Title = textBoxTitle.Text;
            book.LimitPrice = Convert.ToInt32(textBoxLimitPrice.Text);
            book.QOH = Convert.ToInt32(textBoxQOH.Text);
            book.YearPublished = Convert.ToInt32(textBoxYearPublished.Text);
            book.update(book);
            MessageBox.Show("Book's Data has been updated");
        }
        /**********************************Software******************************************/

        private void buttonAddSoftware_Click(object sender, EventArgs e)
        {
            Software soft = new Software(); Category cat = new Category();
            soft.SoftwareId = Convert.ToInt32(textBoxSoftwareId.Text);
            soft.SoftwareName = textBoxSoftwareName.Text;
            cat.CategorieId = Convert.ToInt32(textBoxCategoryIdForSoftware.Text);
           
            if (soft.addsoftware(soft))
            {
                MessageBox.Show("Software has been saved");
            }
            else { MessageBox.Show("Error in saving the software"); }
        }

        private void buttonSearchSoftware_Click(object sender, EventArgs e)
        {
            Software soft = new Software(); Category cat = new Category();
            int softId = Convert.ToInt32(textBoxSoftwareId.Text);
            soft = soft.searchSoftware(softId);
            if (soft != null)
            {
                textBoxSoftwareName.Text = (soft.SoftwareId).ToString();
                textBoxSoftwareName.Text = soft.SoftwareName;
            }
            else
            {
                MessageBox.Show("Software does not exist");
            }
        }

        private void buttonListSoftware_Click(object sender, EventArgs e)
        {
            Software soft = new Software();
            List<Software> list = soft.listSoftware();
            listViewSoftware.Items.Clear();
            foreach (Software ansoft in list)
            {
                ListViewItem item = new ListViewItem(ansoft.SoftwareId.ToString());
                item.SubItems.Add(ansoft.SoftwareName);
                listViewSoftware.Items.Add(item);
            }
        }

        private void buttonDeleteSoftware_Click(object sender, EventArgs e)
        {
            Software soft = new Software();
            soft.SoftwareId = Convert.ToInt32(textBoxSoftwareId.Text);
            soft.SoftwareName = textBoxSoftwareName.Text;
            soft.DeleteSoftware(soft);
            MessageBox.Show("Software's Data has been Deleted");
        }

        private void buttonUpdateSoftware_Click(object sender, EventArgs e)
        {
            Software soft = new Software();
            soft.SoftwareId = Convert.ToInt32(textBoxSoftwareId.Text);
            soft.SoftwareName = textBoxSoftwareName.Text;
            soft.UpdateSoftware(soft);
            MessageBox.Show("Software's Data has been Updated");
        }

        private void buttonAddAuthBook_Click(object sender, EventArgs e)
        {
            AuthorBook authBook = new AuthorBook();
            authBook.AuthorId = Convert.ToInt32(textBoxAuthorID.Text);
            authBook.Isbn = Convert.ToInt32(textBoxISBN.Text);
            authBook.Date = Convert.ToDateTime(dateTimePicker.Text);
            
            if (authBook.saveauthorbook(authBook))
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("There is Problem in saving!..");
            }
        }
    }
}
