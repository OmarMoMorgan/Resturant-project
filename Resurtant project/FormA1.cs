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
    public partial class FormA1 : Form
    {
        Controller Cnt;
        string supervisorName;
        string branchName;
        public FormA1()
        {
            InitializeComponent();
            Cnt = new Controller();
        }

        public FormA1(string sName)
        {
            InitializeComponent();
            Cnt = new Controller();

            supervisorName = sName;
            //Check which branch does he supervise
            branchName = Cnt.GetSupervisedBranch(supervisorName);
            branchNameLabel.Text = branchName;
            capacityLabel.Text += "  30"; //Default, should be changed with some value from the DB.

        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            historyForm hf = new historyForm();
            hf.Show();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            allEmployeesForm ef = new allEmployeesForm();
            ef.Show();
        }

        private void profitsButton_Click(object sender, EventArgs e)
        {
            profitsForm pf = new profitsForm();
            pf.Show();
        }
    }
}
