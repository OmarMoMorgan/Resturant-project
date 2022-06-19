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
    public partial class removeBranchForm : Form
    {
        Controller controllerObj;
        public removeBranchForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r=controllerObj.removeForm(int.Parse(textBox1.Text));
            if (r!=0)
            {
                MessageBox.Show("done");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form f = new branchInfo();f.Show();
        }
    }
}
