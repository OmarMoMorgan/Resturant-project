using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resurtant_project
{
    public partial class CoustmerInfo : Form
    {
        Controller controllerObj;
        public CoustmerInfo()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text != "" && NameTextBox.Text != "" && AddressTextBox.Text != "")
            {
                int pnum = Int32.Parse(PhoneTextBox.Text.ToString());
                string n = NameTextBox.Text.ToString();
                string a = AddressTextBox.Text.ToString();
                PubVariables.CurrentCoustmerPhone = pnum;
                PubVariables.CurrentCoustmerName = n;
                PubVariables.CurrentCoustmerAdress = a;

                //controllerObj.InsertCInfo(pnum , n , a);
                PubVariables.BiggestID = controllerObj.GetLastOrderID();
                NewOrderingMenu F = new NewOrderingMenu();
                F.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("please insert data");
            }
        }

        private void validateText(TextBox tb)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, @"[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tb.Text = tb.Text.Remove(tb.Text.Length - 1);
                tb.Refresh();
                tb.SelectionStart = tb.Text.Length;
                tb.SelectionLength = 0;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            validateText(PhoneTextBox);
        }
    }
}
