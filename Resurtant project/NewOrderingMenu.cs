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
        public NewOrderingMenu()
        {
            InitializeComponent();

            controllerObj = new Controller();

            //putting menu items here 
            //for (int i = 0; i < tabControl1.TabCount; i++)
            
            tabControl1.SelectTab(0);
            string NN = tabControl1.SelectedTab.Name;
            DataTable dt = controllerObj.GetMenu(NN);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataGridViewCheckBoxColumn Ccolumn = new DataGridViewCheckBoxColumn();
            Ccolumn.Name = "X";
            Ccolumn.HeaderText = "X";
            Ccolumn.ReadOnly = false;
            dataGridView1.Columns.Add(Ccolumn);

            tabControl1.SelectTab(1);
            NN = tabControl1.SelectedTab.Name;
            dt = controllerObj.GetMenu(NN);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
            //DataGridViewCheckBoxColumn Ccolumn = new DataGridViewCheckBoxColumn();
            //Ccolumn.Name = "X";
            //Ccolumn.HeaderText = "X";
            //Ccolumn.ReadOnly = false;
            dataGridView2.Columns.Add(Ccolumn);

            tabControl1.SelectTab(2);
            NN = tabControl1.SelectedTab.Name;
            dt = controllerObj.GetMenu(NN);
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
            //DataGridViewCheckBoxColumn Ccolumn = new DataGridViewCheckBoxColumn();
            //Ccolumn.Name = "X";
            //Ccolumn.HeaderText = "X";
            //Ccolumn.ReadOnly = false;
            dataGridView3.Columns.Add(Ccolumn);

            tabControl1.SelectTab(3);
            NN = tabControl1.SelectedTab.Name;
            dt = controllerObj.GetMenu(NN);
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();
            //DataGridViewCheckBoxColumn Ccolumn = new DataGridViewCheckBoxColumn();
            //Ccolumn.Name = "X";
            //Ccolumn.HeaderText = "X";
            Ccolumn.ReadOnly = false;
            dataGridView4.Columns.Add(Ccolumn);



            //for(int j = 0; j < dt.Rows.Count; j++)

            //CheckBox Test = new CheckBox();
            //this.tabControl1.SelectedTab.Controls.Add(Test);



        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CoustmerInfo F = new CoustmerInfo();
            F.Show();
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
           // DataTable dd = new DataTable();
            //var checkedRows = from DataGridViewRow r in dataGridView1.Rows
                              //where Convert.ToBoolean(r.Cells[2].Value) == true
                              //select r;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2]))
                {
                    PubVariables.dd.Rows.Add(row);
                }
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2]))
                {
                    PubVariables.dd.Rows.Add(row);
                }
            }

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2]))
                {
                    PubVariables.dd.Rows.Add(row);
                }
            }

            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2]))
                {
                    PubVariables.dd.Rows.Add(row);
                }
            }

            OrderRecipt O = new OrderRecipt();
            O.Show();
            this.Close();
        }
    }
}
