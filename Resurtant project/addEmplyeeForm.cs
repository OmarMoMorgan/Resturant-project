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
    public partial class addEmplyeeForm : Form
    {
        Controller Cnt;
        string empName;
        string empJob;
        string empJoiningDate;
        int empSalary;
        int empId;

        public addEmplyeeForm()
        {
            InitializeComponent();
            Cnt = new Controller();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int x;
            bool salarysIsNum= int.TryParse(salaryTextBox.Text, out x);
            if (!salarysIsNum) MessageBox.Show("Salary must be a number.");
            else
            {
                empName = nameTextBox.Text;
                empJob = jobComboBox.Text;
                empJoiningDate = joiningDateTextBox.Text;
                empSalary = int.Parse(salaryTextBox.Text);
                empId = 2;
                int check= Cnt.InsertEmployee(empName, empJob, empJoiningDate, empSalary, empId);
                if (check == 0) MessageBox.Show("Insertion Failed!");
                else MessageBox.Show("Inserted Successfuly.");


            }



        }
    }
}
