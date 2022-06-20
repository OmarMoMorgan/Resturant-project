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
    public partial class AddMenu : Form
    {
        Controller control;
        public AddMenu()
        {
            InitializeComponent();
            control = new Controller();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control.AddMenu(textBox1.Text);
            MessageBox.Show("menu added");
        }
    }
}
