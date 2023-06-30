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
    public partial class EatingPlaceChoice : Form
    {
        public EatingPlaceChoice()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (OrderDelivery.Checked)
            {
                CoustmerInfo F = new CoustmerInfo();
                F.Show();
                this.Close();
            }else if (BookTable.Checked)
            {
                BranchesAvailable F = new BranchesAvailable();
                F.Show();
                this.Close();
            }
        }

        private void EatingPlaceChoice_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
