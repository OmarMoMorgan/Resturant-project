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
    public partial class profitsForm : Form
    {
        Controller Cnt;

        DateTime fromDate;
        DateTime toDate;

        public profitsForm()
        {
            InitializeComponent();
            Cnt= new Controller();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void profitsForm_Load(object sender, EventArgs e)
        {

        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            //expensesLabel.Text += 10;
            //salariesLabel.Text += 100;
            //materialsLabel.Text += 1000;
            //incomeLabel.Text += 10000;
            //itemsLabel.Text += 100000;
            //delieveryLabel.Text += 1000000;

            fromDate = fromDatePicker.Value;
            toDate = toDatePicker.Value;

            dataGridView2.DataSource= Cnt.GetProfits(/*fromDate, toDate*/);
            totalLabel.Text = (Cnt.GetTotalProfits()).ToString();
        }
    }
}
