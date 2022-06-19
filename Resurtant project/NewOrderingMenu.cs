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
    public partial class NewOrderingMenu : Form
    {
        Controller controllerObj;
        PubVariables p;
        public NewOrderingMenu()
        {
            InitializeComponent();

            controllerObj = new Controller();
            p = new PubVariables();

            //putting menu items here 
            //for (int i = 0; i < tabControl1.TabCount; i++)

            tabControl1.SelectTab(0);
            string NN = tabControl1.SelectedTab.Text;
            //MessageBox.Show(tabControl1.SelectedTab.Text);
            DataTable dt = controllerObj.GetMenu(NN);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataGridViewTextBoxColumn Ccolumn = new DataGridViewTextBoxColumn();
            Ccolumn.Name = "X";
            Ccolumn.HeaderText = "QTY";
            Ccolumn.ReadOnly = false;
            //Ccolumn.TrueValue = 1;
            //Ccolumn.FalseValue = 0;
            dataGridView1.Columns.Add(Ccolumn);
            

            tabControl1.SelectTab(1);
            NN = tabControl1.SelectedTab.Text;
            //MessageBox.Show(NN);
            dt = controllerObj.GetMenu(NN);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
            DataGridViewTextBoxColumn Ccolumn2 = new DataGridViewTextBoxColumn();
            Ccolumn2.Name = "X";
            Ccolumn2.HeaderText = "QTY";
            Ccolumn2.ReadOnly = false;
            dataGridView2.Columns.Add(Ccolumn2);

            tabControl1.SelectTab(2);
            NN = tabControl1.SelectedTab.Text;
            //MessageBox.Show(NN);
            dt = controllerObj.GetMenu(NN);
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
            DataGridViewTextBoxColumn Ccolumn3 = new DataGridViewTextBoxColumn();
            Ccolumn3.Name = "X";
            Ccolumn3.HeaderText = "QTY";
            Ccolumn3.ReadOnly = false;
            dataGridView3.Columns.Add(Ccolumn3);

            tabControl1.SelectTab(3);
            NN = tabControl1.SelectedTab.Text;
            //MessageBox.Show(NN);
            dt = controllerObj.GetMenu(NN);
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();
            DataGridViewTextBoxColumn Ccolumn4 = new DataGridViewTextBoxColumn();
            Ccolumn4.Name = "X";
            Ccolumn4.HeaderText = "QTY";
            Ccolumn4.ReadOnly = false;
            dataGridView4.Columns.Add(Ccolumn4);



            //for(int j = 0; j < dt.Rows.Count; j++)

            //CheckBox Test = new CheckBox();
            //this.tabControl1.SelectedTab.Controls.Add(Test);

            //p.intializeDataTable();
            //PubVariables.intializeDataTable();
            PubVariables.NOM = this;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CoustmerInfo F = new CoustmerInfo();
            F.Show();
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderRecipt O = new OrderRecipt();
            DataTable dd = new DataTable();
            //var checkedRows = from DataGridViewRow r in dataGridView1.Rows where Convert.ToBoolean(r.Cells[2].Value) == true                              select r;

            int noerrorflag = 0;
            int counter = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                //MessageBox.Show(row.Cells[0].Value.ToString());
                if (row.Cells[0].Value != null)
                {
                    //MessageBox.Show(row.Cells[0].Value.ToString());
                    //MessageBox.Show(row.Cells[1].Value.ToString());
                    //MessageBox.Show(row.Cells[2].Value.ToString());
                    if (Int32.Parse(row.Cells[2].Value.ToString()) > 0)
                    {
                        //MessageBox.Show("i got here ");
                        O.AddGridViewRows(row.Cells[1].Value.ToString() , row.Cells[2].Value.ToString() , row.Cells[0].Value.ToString());
                        //PubVariables.dd.Rows.Add(row);
                        //PubVariables.Ordered[counter, 0] = row.Cells[1].Value.ToString();
                        //PubVariables.Ordered[counter, 1] = row.Cells[2].Value.ToString();
                        //PubVariables.Ordered[counter, 2] = row.Cells[0].Value.ToString();
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (Int32.Parse(row.Cells[2].Value.ToString()) > 0)
                    {
                        O.AddGridViewRows(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[0].Value.ToString());
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (Int32.Parse(row.Cells[2].Value.ToString()) > 0)
                    {
                        O.AddGridViewRows(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[0].Value.ToString());
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (Int32.Parse(row.Cells[2].Value.ToString()) > 0)
                    {
                        O.AddGridViewRows(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[0].Value.ToString());
                    }
                }
            }

            O.UpdateTotalPrice();
            O.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


      
    }
}
