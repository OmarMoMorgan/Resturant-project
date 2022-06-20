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
    public partial class DeleteMenu : Form
    {
        Controller control;
        public DeleteMenu()
        {
            InitializeComponent();
            control = new Controller();
            DataTable dt = control.SelectAllMenusNames();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "MenName";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control.DeleteMenu(comboBox1.Text);
            MessageBox.Show("menu deleted");
        }
    }
}
