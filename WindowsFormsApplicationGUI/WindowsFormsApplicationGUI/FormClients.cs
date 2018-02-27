using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data;
using ClassLibraryFinal.DAL;
using ClassLibraryFinal.BUI;

namespace WindowsFormsApplicationGUI
{
    public partial class FormClients : Form
    {
        private DataSet dsHiTech = new DataSet("DBHiTech");
        private DataTable dtClients = new DataTable("Clients");
        private SqlDataAdapter sqlDa = new SqlDataAdapter();
        private SqlCommandBuilder sqlCmdClient;
        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you really want to quit this application", "Qusetion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.Exit();
        }
        public FormClients()
        {
            InitializeComponent();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            dsHiTech.Tables.Add(dtClients);
            dsHiTech = UtilityDBDisconnected.GetDataSetClients(dsHiTech, dtClients);
            dataGridViewClient.DataSource = dsHiTech;
            dataGridViewClient.DataMember = "Clients";
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            dsHiTech = UtilityDBDisconnected.GetDataSetClients(dsHiTech, dtClients);
            dataGridViewClient.DataSource = dsHiTech;
            dataGridViewClient.DataMember = "Clients";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Client aClient  = new Client();
        //    aClient.ClientID = Convert.ToInt32(textBoxClientId.Text);
            aClient.ClientName = textBoxClientName.Text;
            aClient.Street = textBoxStreet.Text;
            aClient.City = textBoxCity.Text;
            aClient.PostalCode = textBoxPostalCode.Text;
            aClient.PhoneNumber = textBoxPhoneNumber.Text;
            aClient.FaxNumber = textBoxFaxNumber.Text;
            aClient.CreditLimit = Convert.ToInt32(textBoxCreditLimit.Text);
          
            dtClients.Rows.Add(null, aClient.ClientName, aClient.Street, aClient.City, aClient.PostalCode,
                               aClient.PhoneNumber,aClient.FaxNumber, aClient.CreditLimit);
            foreach (DataRow dr in dtClients.Rows)
            {
                MessageBox.Show(dr.RowState.ToString());
            }
          }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchClientId = Convert.ToInt32(textBoxClientId.Text);
            DataRow dr = dtClients.Rows.Find(searchClientId);
            if (dr !=null)
            {
                textBoxClientName.Text = dr["ClientName"].ToString();
                textBoxStreet.Text = dr["Street"].ToString();
                textBoxCity.Text = dr["City"].ToString();
                textBoxPostalCode.Text = dr["PostalCode"].ToString();
                textBoxPhoneNumber.Text = dr["PhoneNumber"].ToString();
                textBoxFaxNumber.Text = dr["FaxNumber"].ToString();
                textBoxCreditLimit.Text = dr["CreditLimit"].ToString();
               
            }
            else { MessageBox.Show("Client does not exist", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error); }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int searchClientId = Convert.ToInt32(textBoxClientId.Text);
            DataRow dr = dtClients.Rows.Find(searchClientId);
            if (dr != null)
            {
                dr["ClientName"] = textBoxClientName.Text;
                dr["Street"] = textBoxStreet.Text;
                dr["City"] = textBoxCity.Text ;
                dr["PostalCode"] = textBoxPostalCode.Text ;
                dr["PhoneNumber"] = textBoxPhoneNumber.Text ;
                dr["FaxNumber"] = textBoxFaxNumber.Text ;
                dr["CreditLimit"] = textBoxCreditLimit.Text ;
                MessageBox.Show("Client's Data has been Updated");

            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int searchClientId = Convert.ToInt32(textBoxClientId.Text);
            DataRow dr = dtClients.Rows.Find(searchClientId);
            if (dr != null)
            {
                dr.Delete();
            }
            MessageBox.Show("Client's Data has been deleted", "Confimation", MessageBoxButtons.OK);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxClientId.Clear();
            textBoxClientName.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxPostalCode.Clear();
            textBoxPhoneNumber.Clear();
            textBoxFaxNumber.Clear();
            textBoxCreditLimit.Clear();
            textBoxClientId.Focus();
        }

        private void buttonupdatedatabase_Click(object sender, EventArgs e)
        {
            if (dsHiTech.HasChanges())
            {
                sqlDa = UtilityDBDisconnected.GetDataAdapterClients();
                sqlCmdClient = new SqlCommandBuilder(sqlDa);
                sqlDa.Update(dsHiTech.Tables["Clients"]);
                MessageBox.Show("Database has been updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
