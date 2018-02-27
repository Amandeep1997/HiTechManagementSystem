using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace WindowsFormsApplicationGUI.Validator
{
    public static class Validation
    {

        public static bool ValidUserID(TextBox textBox, int size = 4)
        {
            if (!(Regex.IsMatch(textBox.Text, @"^\d{" + size + "}$")))
            {
                MessageBox.Show(textBox + " UserID or Password is wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        
        /*************************Data Validation for Employee***************************/
        public static bool ValidEmployeeId(TextBox textBox, int size = 4)
        {
            if (!(Regex.IsMatch(textBox.Text, @"^\d{" + size + "}$")))
            {
                MessageBox.Show(textBox + " EmployeeID cannot be longer than 4-digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public static bool ValidEmployeeFirstName(TextBox textbox, string size = "")
        {
            for (int j = 0; j < size.Length; j++)
            {
                if (!Char.IsLetter(size, j) && (!char.IsWhiteSpace(size, j)))
                {
                    return false;
                    MessageBox.Show(textbox + "Invalid FirstName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return true;
        }
    }
}