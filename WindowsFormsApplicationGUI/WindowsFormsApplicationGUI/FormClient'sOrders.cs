using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplicationGUI
{
    public partial class FormClient_sOrders : Form
    {
        HiTechDBEntities dbEntities = new HiTechDBEntities();
        public FormClient_sOrders()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            int search = Convert.ToInt32(comboBoxClientIDName.SelectedValue);
            var list = from orderline in dbEntities.OrderLines
                       join order in dbEntities.Orders on orderline.OrderId equals order.OrderId
                       join book in dbEntities.Books on orderline.Isbn equals book.Isbn
                       where order.ClientId == search
                       select new
                       {
                           order.OrderId,
                           order.OrderDate,
                           order.O_Meth_Pmt,
                           order.ClientId,
                           book.Isbn,
                           book.Title
                       };

            dataGridViewOrderBook.DataSource = list.ToList();
            dbEntities.SaveChanges();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int search = Convert.ToInt32(comboBoxClientIDName.SelectedValue);
            var search_order = (from orderline in dbEntities.OrderLines
                                join order in dbEntities.Orders on orderline.OrderId equals order.OrderId
                                join book in dbEntities.Books on orderline.Isbn equals book.Isbn
                                where order.ClientId == search
                                select new
                                {
                                    order.OrderId,
                                    order.OrderDate,
                                    order.O_Meth_Pmt,
                                    order.ClientId,
                                    book.Isbn,
                                    book.Title
                                }).ToList();
            foreach (var item in search_order)
            {
                textBoxOrderID.Text = item.OrderId.ToString();
                dateTimePickerOrderDate.Text = item.OrderDate.ToString();
                textBoxMethPmt.Text = item.O_Meth_Pmt;
                textBoxIsbn.Text = item.Isbn.ToString();
                textBoxTitle.Text = item.Title.ToString();
                textBoxClientId.Text = item.ClientId.ToString();
            }
            dbEntities.SaveChanges();
        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
            Orders order = new Orders(); Books book = new Books();
            order.OrderId = Convert.ToInt32(textBoxOrderID.Text);
            order.OrderDate = Convert.ToDateTime(dateTimePickerOrderDate.Text);
            order.O_Meth_Pmt = textBoxMethPmt.Text;
            order.ClientId = Convert.ToInt32(textBoxClientId.Text);
            book.Isbn = Convert.ToInt32(textBoxIsbn.Text);
            book.Title = textBoxTitle.Text;
            dbEntities.Orders.Add(order);
            dbEntities.Books.Add(book);
            dbEntities.SaveChanges();
            MessageBox.Show("Client's orders have been saved");
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            Orders searchorder = dbEntities.Orders.Find(comboBoxClientIDName.SelectedValue);
            dbEntities.Orders.Remove(searchorder);
            dbEntities.SaveChanges();
            MessageBox.Show("Order Has been deleted");
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            Orders search = dbEntities.Orders.Find(Convert.ToInt32(comboBoxClientIDName.SelectedValue));
            Orders searchorder = new Orders(); Books searchBook = new Books();
            searchorder.OrderId = Convert.ToInt32(textBoxOrderID.Text);
            searchorder.OrderDate = Convert.ToDateTime(dateTimePickerOrderDate.Text);
            searchorder.O_Meth_Pmt = textBoxMethPmt.Text;
            searchorder.ClientId = Convert.ToInt32(textBoxClientId.Text);
            searchBook.Isbn = Convert.ToInt32(textBoxIsbn.Text);
            searchBook.Title = textBoxTitle.Text;
            dbEntities.SaveChanges();
            MessageBox.Show("Data has been Updated");
        }
        /******************************************Software*******************************************************/
        private void buttonsearchsoftware_Click(object sender, EventArgs e)
        {
            int search = Convert.ToInt32(comboBoxClientID.SelectedValue);
            var search_order = (from orderline in dbEntities.OrderLines
                                join order in dbEntities.Orders on orderline.OrderId equals order.OrderId
                                join software in dbEntities.Softwares on orderline.SoftwareId equals software.SoftwareId
                                where order.ClientId == search
                                select new
                                {
                                    order.OrderId,
                                    order.OrderDate,
                                    order.O_Meth_Pmt,
                                    order.ClientId,
                                    software.SoftwareId,
                                    software.SoftwareName
                                }).ToList();
            foreach (var item in search_order)
            {
                textBoxOrder_Id.Text = item.OrderId.ToString();
                dateTimePickerOrder_Date.Text = item.OrderDate.ToString();
                textBoxMeth_pmt.Text = item.O_Meth_Pmt;
                textBoxSoftwareId.Text = item.SoftwareId.ToString();
                textBoxsoftName.Text = item.SoftwareName.ToString();
                textBoxClient_Id.Text = item.ClientId.ToString();
            }
        }

        private void buttonlistsoftware_Click(object sender, EventArgs e)
        {
            int search = Convert.ToInt32(comboBoxClientID.SelectedValue);
            var list = from orderline in dbEntities.OrderLines
                       join order in dbEntities.Orders on orderline.OrderId equals order.OrderId
                       join software in dbEntities.Softwares on orderline.SoftwareId equals software.SoftwareId
                       where order.ClientId == search
                       select new
                       {
                           order.OrderId,
                           order.OrderDate,
                           order.O_Meth_Pmt,
                           order.ClientId,
                           software.SoftwareId,
                           software.SoftwareName
                       };

            dataGridViewOrderSoftware.DataSource = list.ToList();
            dbEntities.SaveChanges();
        }

        private void buttonaddSoftware_Click(object sender, EventArgs e)
        {
            Orders order = new Orders(); Softwares soft = new Softwares();
            order.OrderId = Convert.ToInt32(textBoxOrder_Id.Text);
            order.OrderDate = Convert.ToDateTime(dateTimePickerOrder_Date.Text);
            order.O_Meth_Pmt = textBoxMeth_pmt.Text;
            order.ClientId = Convert.ToInt32(textBoxClient_Id.Text);
            soft.SoftwareId = Convert.ToInt32(textBoxSoftwareId.Text);
            soft.SoftwareName = textBoxsoftName.Text;
            dbEntities.Orders.Add(order);
            dbEntities.Softwares.Add(soft);
            dbEntities.SaveChanges();
            MessageBox.Show("Client's orders have been saved");
        }

        private void buttonupdatesoftware_Click(object sender, EventArgs e)
        {
            Orders search = dbEntities.Orders.Find(Convert.ToInt32(comboBoxClientID.SelectedValue));
            Orders searchorder = new Orders(); Softwares soft = new Softwares();
            searchorder.OrderId = Convert.ToInt32(textBoxOrder_Id.Text);
            searchorder.OrderDate = Convert.ToDateTime(dateTimePickerOrder_Date.Text);
            searchorder.O_Meth_Pmt = textBoxMeth_pmt.Text;
            searchorder.ClientId = Convert.ToInt32(textBoxClient_Id.Text);
            soft.SoftwareId = Convert.ToInt32(textBoxSoftwareId.Text);
            soft.SoftwareName = textBoxsoftName.Text;
            dbEntities.SaveChanges();
            MessageBox.Show("Data has been Updated");
        }

        private void buttondeleteSoftware_Click(object sender, EventArgs e)
        {
            Orders searchorder = dbEntities.Orders.Find(comboBoxClientID.SelectedValue);
            dbEntities.Orders.Remove(searchorder);
            dbEntities.SaveChanges();
            MessageBox.Show("Order Has been deleted");
        }

        private void FormClient_sOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hiTechDBDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hiTechDBDataSet.Clients);

        }
    }
}
