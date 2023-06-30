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


            dataGridView1.Columns.Add("Name" , "NAme");
            dataGridView1.Columns.Add("Price", "PRICE");
            dataGridView1.Columns.Add("Qty", "QTY");


            DataTable dt = PubVariables.dd;
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();

            
            //for(int i =0;i<dt.Rows.Count; i++)
            //{
            //    sum += Int32.Parse(dt.Rows[i][0].ToString());
            //}
            
            
            Coustmer_name_label.Text = PubVariables.CurrentCoustmerName;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            DataTable dt = PubVariables.dd;
            int n = controllerObj.GetLastOrderID() + 1;
            controllerObj.InsertCInfo(PubVariables.CurrentCoustmerPhone, PubVariables.CurrentCoustmerName, PubVariables.CurrentCoustmerAdress);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //MessageBox.Show(dataGridView1.Rows[i].Cells[0].Value.ToString());
                controllerObj.InsertTupleOrderR(n, PubVariables.CurrentCoustmerPhone, dataGridView1.Rows[i].Cells[0].Value.ToString() , Int16.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }
            MessageBox.Show("order complete");
            PubVariables.NOM.Close();
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //NewOrderingMenu F = new NewOrderingMenu();
            //F.Show();
            PubVariables.NOM.Show();
            this.Close();
        }

        public void AddGridViewRows(string n , string p , string q)
        {
            // Add rows to grid view.
            dataGridView1.Rows.Add(n,p,q);

            // Refresh the grid
            dataGridView1.Update();
        }

        public void UpdateTotalPrice()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //MessageBox.Show(row.Cells[0].Value.ToString());
                //MessageBox.Show(row.Cells[1].Value.ToString());
                //MessageBox.Show(row.Cells[2].Value.ToString());
                //if (Int32.Parse(row.Cells[0].Value.ToString()) > 0)

                sum += Int32.Parse(row.Cells[1].Value.ToString()) * Int32.Parse(row.Cells[2].Value.ToString());
            }
            PriceLabel.Text = sum.ToString();
        }
    }
}
