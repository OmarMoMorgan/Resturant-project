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
        string name;
        Controller controllerObj;
        public employeeLogin()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            int r=controllerObj.check_pass(textBox1.Text, textBox2.Text);
            /*MessageBox.Show(r.ToString());*/
            if (r == 1)
            {
                Form f = new Manager();
                f.Show();
                this.Close();
            }
            if (r == 2)
            {
                Form f = new FormA1(name);
                f.Show();
                 this.Close();
            }
            else if(r == 0)
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            this.Close();
        }
    }
}
