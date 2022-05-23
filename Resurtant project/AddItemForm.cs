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

        string MenuName;
        string ItemName;
        int ItemID; 
        float ItemPrice;

        

        public AddItemForm()
        {
            InitializeComponent();
            control = new Controller();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || MenusNamesComboBox.Text == "" )
            { MessageBox.Show("item added to menu"); }
            else
            {
                control.InsertFoodItem(int.Parse(textBox1.Text),textBox3.Text,float.Parse( textBox2.Text), MenusNamesComboBox.Text);
                MessageBox.Show("item added to menu");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f = new MenuForm();
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
