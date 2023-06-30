using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Resurtant_project
{
    public partial class EditItemForm : Form
    {
        Controller control;
        public EditItemForm()
        {
            InitializeComponent();
            control = new Controller();
            DataTable dt1 = control.SelectAllMenusNames();
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "MenName";
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
        //    { MessageBox.Show("enter full data"); }
        //    else
        //    {
        //        control.EditFoodItemByName(comboBox1.Text, comboBox2.Text, textBox1.Text, float.Parse(textBox3.Text));
        //        MessageBox.Show("item edited");
        //    }
        //}

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = control.GetFoodItemsNames(textBox1.Text);
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "choose Food ITem Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            { MessageBox.Show("enter full data"); }
            else
            {
                control.EditFoodItemByName( comboBox2.Text, textBox1.Text, float.Parse(textBox3.Text));
                MessageBox.Show("item edited");
                this.Hide();
                MenuForm f = new MenuForm();
                f.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = control.GetFoodItemsNames(comboBox1.Text);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Name";
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
