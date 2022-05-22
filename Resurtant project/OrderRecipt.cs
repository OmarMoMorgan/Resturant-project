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
    public partial class OrderRecipt : Form
    {
        Controller controllerObj;
        public OrderRecipt()
        {
            InitializeComponent();
            controllerObj = new Controller();
            label5.Text = (controllerObj.GetLastOrderID() + 1).ToString();
            Coustmer_name_label.Text = PubVariables.CurrentCoustmerName;


            DataTable dt = PubVariables.dd;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            int sum = 0;
            for(int i =0;i<dt.Rows.Count; i++)
            {
                sum += Int32.Parse(dt.Rows[i][1].ToString());
            }
            PriceLabel.Text = sum.ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            DataTable dt = PubVariables.dd;
            int n = controllerObj.GetLastOrderID() + 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                controllerObj.InsertTupleOrderR(n, Int32.Parse(PubVariables.CurrentCoustmerPhone), dt.Rows[i][0].ToString());
            }
            MessageBox.Show("order complete");
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            NewOrderingMenu F = new NewOrderingMenu();
            F.Show();
            this.Close();
        }
    }
}
