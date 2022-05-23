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
            empName = nameTextBox.Text;
            empJob= jobComboBox.Text;
            empJoiningDate = joiningDateTextBox.Text;
            empSalary= int.Parse(salaryTextBox.Text);
            empId = 1;
            Cnt.InsertEmployee(empName, empJob, empJoiningDate, empSalary, empId);

            
            
        }

        private void jobComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
