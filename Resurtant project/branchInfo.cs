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
    public partial class branchInfo : Form
    {
        Controller controllerObj;
        public branchInfo()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.ShowInfo();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = controllerObj.ShowInfo();
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new addBranchForm();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new removeBranchForm();
            f.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form f = new Manager();f.Show();
        }
    }
}
