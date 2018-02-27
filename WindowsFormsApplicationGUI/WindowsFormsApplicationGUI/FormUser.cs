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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        { 
            
            User user = new User();
            user.UserId = Convert.ToInt32(comboBoxUserID.SelectedValue);
            user.Password = textBoxPassword.Text;
            //Confirmation for the saving record
            if (user.AddUser(user))
            {
                MessageBox.Show("User is Saved..","Saved");
            }
            else { MessageBox.Show("Error! Check Your Information", "Error"); }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            User user = new User();
            int UserId = Convert.ToInt32(comboBoxUserID.SelectedValue);
            user = user.SearchUser(UserId);

            if (user != null)
            {
                comboBoxUserID.SelectedValue = user.UserId.ToString();
                textBoxPassword.Text = user.Password;
                
            }
            else
            {
                MessageBox.Show("User not found!","Question");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = Convert.ToInt32(comboBoxUserID.SelectedValue);
            user.Password = textBoxPassword.Text;
          
            user.UpdateUser(user);
            MessageBox.Show("Data Updated For User!", "Done");

        }
               
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = Convert.ToInt32(comboBoxUserID.SelectedValue);
            user.Password = textBoxPassword.Text;
            user.DeleteUser(user);
            MessageBox.Show("Data Deleted From User!","Deleted");
        }

        private void buttonListUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            List<User> listuser = user.ListUser();
            listViewuser.Items.Clear();

            foreach (User anuser in listuser)
            {
                ListViewItem item = new ListViewItem(anuser.UserId.ToString());
                item.SubItems.Add(anuser.Password);
                listViewuser.Items.Add(item);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to quit this application?", "UserConfirmation", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hiTechDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hiTechDBDataSet.Users);

        }
    }
}
