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
        public FormA1()
        {
            InitializeComponent();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            historyForm hf= new historyForm();
            hf.Show();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            allEmployeesForm ef= new allEmployeesForm();
            ef.Show();
        }

        private void profitsButton_Click(object sender, EventArgs e)
        {
            profitsForm pf= new profitsForm();
            pf.Show();
        }
    }
}
