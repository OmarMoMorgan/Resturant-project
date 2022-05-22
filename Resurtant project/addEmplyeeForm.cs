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
        public addEmplyeeForm()
        {
            InitializeComponent();
        }

        string empName;
        string empJob;
        string empJoiningDate;
        int empSalary;
        int empId;

        private void addButton_Click(object sender, EventArgs e)
        {
            empName = nameTextBox.Text;
            empJob= jobComboBox.Text;
            empJoiningDate = joiningDateTextBox.Text;
            empSalary= int.Parse(salaryTextBox.Text);
            IDTextBox.Text = empId.ToString();
            
            
        }
    }
}
