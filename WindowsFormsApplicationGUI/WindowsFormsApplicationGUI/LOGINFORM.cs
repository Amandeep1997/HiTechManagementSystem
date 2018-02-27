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
using WindowsFormsApplicationGUI.Validator;
namespace WindowsFormsApplicationGUI
{
    public partial class LOGINFORM : Form
    {
        public LOGINFORM()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Validator.Validation.ValidUserID(textBoxUserId))
            {
                User user = new User();
                int UserId = Convert.ToInt32(textBoxUserId.Text);
                string Password = textBoxPassword.Text;

                if (UserId == 1111 )
                {
                    MIS_Maintenance formMaintenance = new MIS_Maintenance();
                    formMaintenance.Show();
                    this.Hide();

                }
                else if (UserId == 2222 )
                {
                    FormClients formClient = new FormClients();
                    formClient.Show();
                    this.Hide();
                }
                else if (UserId == 3333 )
                {
                    ProductForm formProduct = new ProductForm();
                    formProduct.Show();
                    this.Hide();
                }
                else if (UserId == 4444 )
                {
                    FormClient_sOrders formorders = new FormClient_sOrders();
                    formorders.Show();
                    this.Hide();
                }
                else if (UserId == 5555 )
                {
                    FormClient_sOrders formorders = new FormClient_sOrders();
                    formorders.Show();
                    this.Hide();
                }
            }
          
        }

       
    }
}
