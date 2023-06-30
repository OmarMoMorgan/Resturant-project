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
    public partial class statistics : Form
    {
        Controller control;
        public statistics()
        {
            control = new Controller();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager f = new Manager();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text =control.GetTotalSalaries().ToString();
            textBox1.Text = control.GetTotalNumberofEmployees().ToString();
            textBox3.Text = control.GetTotalNumberofBranches().ToString();
            textBox4.Text = control.GetTotalExpenses().ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
