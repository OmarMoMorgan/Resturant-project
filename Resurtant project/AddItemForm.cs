using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Resurtant_project
{
    public partial class AddItemForm : Form
    {
        Controller control;
        public AddItemForm()
        {
            InitializeComponent();
            control = new Controller();
            DataTable dt2 = control.SelectAllMenusNames();
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "MenName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("item added to menu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if ( textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            { MessageBox.Show("enter valid information"); }
            else
            {
                control.InsertFoodItem( float.Parse( textBox2.Text), (textBox3.Text), comboBox1.Text);
                MessageBox.Show("item added to menu");
                this.Hide();
                MenuForm f = new MenuForm();
                f.Show();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
