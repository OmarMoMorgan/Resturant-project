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
    public partial class addBranchForm : Form
    {
        Controller contrObj;
        public addBranchForm()
        {
            InitializeComponent();
            contrObj = new Controller();
        }

        private void addBranchForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contrObj.addBranch(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
        }
    }
}
