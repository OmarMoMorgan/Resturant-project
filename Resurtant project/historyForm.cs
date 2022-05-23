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

        Controller Cnt;
        string fromDate;
        string toDate;
        public historyForm()
        {
            InitializeComponent();
            dataGridView1.Hide();
            Cnt= new Controller();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            //Fill with data between the two dates...
            fromDate = fromDatePicker.Text;
            toDate = toDatePicker.Text;

            dataGridView1.DataSource = Cnt.GetProfits(fromDate, toDate);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
