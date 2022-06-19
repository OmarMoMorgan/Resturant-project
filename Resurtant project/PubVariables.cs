using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Resurtant_project
{
    class PubVariables
    {
        public static string SelectedBranchName;
        public static string CurrentCoustmerName;
        public static int CurrentCoustmerPhone;
        public static string CurrentCoustmerAdress;
        public static int BiggestID;
        public static DataTable dd = new DataTable();
        private static int flag = 0;
        public static string[,] Ordered = new string[100, 3];

        public static NewOrderingMenu NOM;

        public static void intializeDataTable()
        {
            if (flag == 0)
            {
                dd.Columns.Add("Name");
                dd.Columns.Add("price");
                dd.Columns.Add("QRY");
                flag = 1;
            }

        }

        //PubVariables.dd.
    }
}
