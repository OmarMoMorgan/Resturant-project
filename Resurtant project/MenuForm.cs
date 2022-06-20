using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Resurtant_project
{
    public partial class MenuForm : Form
    {
        Controller control;
        public MenuForm()
        {
            InitializeComponent();
            control = new Controller();
            DataTable dt = control.SelectAllMenusNames();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "MenName";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddItemForm f = new AddItemForm();
            f.Show();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    RemoveItemForm f = new RemoveItemForm();
        //    f.Show();
        //}

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditItemForm f = new EditItemForm();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager f = new Manager();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = control.GetMenu(comboBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddItemForm f = new AddItemForm();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RemoveItemForm f = new RemoveItemForm();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EditItemForm f = new EditItemForm();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Manager f = new Manager();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new AddMenu();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new DeleteMenu();
            f.Show();
        }
    }
}
