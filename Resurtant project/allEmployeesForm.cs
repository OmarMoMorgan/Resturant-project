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
    public partial class allEmployeesForm : Form
    {
        Controller Cnt;
        public allEmployeesForm()
        {
            InitializeComponent();
            Cnt= new Controller();
            dataGridView1.DataSource = Cnt.GetAllEmployees(); 
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            addEmplyeeForm af = new addEmplyeeForm();
            af.Show();
        }
    }
}
