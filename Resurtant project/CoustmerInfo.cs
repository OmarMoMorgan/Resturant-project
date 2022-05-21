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
            BranchesAvailable F = new BranchesAvailable();
            F.Show();
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int pnum = Int32.Parse(PhoneTextBox.Text.ToString());
            string n = NameTextBox.Text.ToString();
            string a = AddressTextBox.Text.ToString();
            controllerObj.InsertCInfo(pnum , n , a);
            PubVariables.BiggestID = controllerObj.GetLastOrderID();
            NewOrderingMenu F = new NewOrderingMenu();
            F.Show();
            this.Close();
        }
    }
}
