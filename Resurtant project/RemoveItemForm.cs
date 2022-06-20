using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Resurtant_project
{
    public partial class RemoveItemForm : Form
    {
        Controller control;
        public RemoveItemForm( )
        {
            InitializeComponent();
            control = new Controller();
            DataTable dt1 = control.SelectAllMenusNames();
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "MenName";

        }

        private void RemoveItemForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f = new MenuForm();
            f.Show();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (comboBox1.Text == "" || comboBox2.Text == "") { MessageBox.Show("you must choose MenuName and ItemName"); }
        //    else
        //    {
        //        control.DeleteFoodItemByName(comboBox1.Text/*, comboBox2.Text*/);
        //        MessageBox.Show("item removed successfully from menu");
        //    }
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = control.GetFoodItemsNames(comboBox1.Text);
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Name";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "") { MessageBox.Show("you must choose MenuName and ItemName"); }
            else
            {
                control.DeleteFoodItemByName(comboBox2.Text/*, comboBox2.Text*/);
                MessageBox.Show("item removed successfully from menu");
                this.Hide();
                MenuForm f = new MenuForm();
                f.Show();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
