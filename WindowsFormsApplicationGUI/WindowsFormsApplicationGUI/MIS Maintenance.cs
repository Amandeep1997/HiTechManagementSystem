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
    public partial class MIS_Maintenance : Form
    {
        public MIS_Maintenance()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee frmEmp = new FormEmployee();
            frmEmp.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser frmUser = new FormUser();
            frmUser.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
