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
        

        public RemoveItemForm()
        {
            InitializeComponent();
            control = new Controller();
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "") { MessageBox.Show("you must choose MenuName and ItemName"); }
            else 
            {
                control.DeleteFoodItemByName(comboBox1.Text, comboBox2.Text);
                MessageBox.Show("item removed from menu"); 
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
