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

    public partial class BranchesAvailable : Form
    {

        Controller controllerObj;
        //PubVariables pVar;
        public BranchesAvailable()
        {
            InitializeComponent();

            controllerObj = new Controller();

            DataTable dt = controllerObj.GetBranchNames();
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "BranchName";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                PubVariables.SelectedBranchName = comboBox1.SelectedItem.ToString();
                CoustmerInfo C = new CoustmerInfo();
                C.Show();
                this.Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EatingPlaceChoice F = new EatingPlaceChoice();
            F.Show();
            this.Close();
        }
    }
}
