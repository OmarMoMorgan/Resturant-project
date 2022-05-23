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
    public partial class historyForm : Form
    {
        public historyForm()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            //Fill with data between the two dates...
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
