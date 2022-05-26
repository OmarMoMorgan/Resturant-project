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
    public partial class branchInfo : Form
    {
        Controller controllerObj;
        public branchInfo()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = controllerObj.ShowInfo();
            dataGridView1.DataSource = dt;

        }
    }
}
