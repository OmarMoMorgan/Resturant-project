using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Runtime.InteropServices;

namespace Resurtant_project
{
    public partial class addBranchForm : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,     // x-coordinate of upper-left corner
        //    int nTopRect,      // y-coordinate of upper-left corner
        //    int nRightRect,    // x-coordinate of lower-right corner
        //    int nBottomRect,   // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        //);

        Controller contrObj;
        public addBranchForm()
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 500, 500));
            InitializeComponent();
            contrObj = new Controller();
        }

        private void addBranchForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //contrObj.addBranch(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            //MessageBox.Show("Done");
            int t = contrObj.addBranch(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            if (t != 0)
            {
                MessageBox.Show("done");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form f = new branchInfo();
            f.Show();
            this.Close();
        }
    }
}
