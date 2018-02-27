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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            // Data Validation first
            if (Validator.Validation.ValidEmployeeId(textBoxEmployeeId))
            {
                emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text);
                emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text);
                emp.FirstName = textBoxFirstName.Text;
                emp.LastName = textBoxLastName.Text;
                emp.JobTitle = textBoxJobTitle.Text;
            }
                //Confirmation for the saving record
                if (emp.AddEmployee(emp))
                {
                    MessageBox.Show("Employee Saved..");
                }
           
            }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            int empId = Convert.ToInt32(textBoxEmployeeId.Text);
            emp = emp.SearchRecordByEmpid(empId);

            if (emp != null)
            {
                textBoxEmployeeId.Text = (emp.EmployeeId).ToString();
                textBoxFirstName.Text = emp.FirstName;
                textBoxLastName.Text = emp.LastName;
                textBoxJobTitle.Text = emp.JobTitle;
            }
            else
            {
                MessageBox.Show("Employee not found!");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text);
            emp.FirstName = textBoxFirstName.Text;
            emp.LastName = textBoxLastName.Text;
            emp.JobTitle = textBoxJobTitle.Text;
            emp.UpdateEmployeeById(emp);
            MessageBox.Show("Data Updated!");

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text);
            emp.FirstName = textBoxFirstName.Text;
            emp.LastName = textBoxLastName.Text;
            emp.JobTitle = textBoxJobTitle.Text;
            emp.DeleteEmp(emp);
            MessageBox.Show("Data Deleted!");
        }

        private void buttonListEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            List<Employee> listEmp = emp.ListEmployee();

            listViewEmployee.Items.Clear();

            foreach (Employee anEmp in listEmp)
            {
                ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                item.SubItems.Add(anEmp.FirstName);
                item.SubItems.Add(anEmp.LastName);
                item.SubItems.Add(anEmp.JobTitle);
                listViewEmployee.Items.Add(item);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit this application?", "Confirmation");
            Application.Exit();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hiTechDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hiTechDBDataSet.Employees);

        }
    }
}
