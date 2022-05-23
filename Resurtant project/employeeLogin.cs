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
    public partial class employeeLogin : Form
    {
        Controller controllerObj;
        public employeeLogin()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r=controllerObj.check_pass(textBox1.Text, textBox2.Text);
            if (r == 1)
            {
                Form f = new Manager();
                f.Show();
            }
            if (r == 2)
            {
                Form f = new FormA1();
                f.Show(); 
            }
        }
    }
}
