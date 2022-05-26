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
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                PubVariables.SelectedBranchName = dataGridView1.SelectedRows[0].Cells["BranchName"].Value.ToString();
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
