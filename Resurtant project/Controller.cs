using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Resurtant_project
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable GetBranchNames()
        {
            String StoredProcedureName = StoredProcedures.getAllBranches;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("@location", location);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public void InsertCInfo(int PNum , string name , string address)
        {
            String StoredProcedureName = StoredProcedures.InsertCoustmerInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PhoneNumber", PNum);
            Parameters.Add("@CName", name);
            Parameters.Add("@CAdd", address);
            dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetMenu(string MName)
        {
            String StoredProcedureName = StoredProcedures.GetMenu;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MenuName", MName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int GetLastOrderID()
        {
            String StoredProcedureName = StoredProcedures.GetLastOrderID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("@MenuName", MName);
            if(dbMan.ExecuteScalar(StoredProcedureName, Parameters) != null)
            {
                try
                {
                    return Int32.Parse(dbMan.ExecuteScalar(StoredProcedureName, Parameters).ToString());
                }catch{
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }


        public void InsertTupleOrderR(int orderii , int pphone , string fname)
        {
            String StoredProcedureName = StoredProcedures.InsertTupleOrderR;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderii", orderii);
            Parameters.Add("@pphone", pphone);
            Parameters.Add("@FoodNAme", fname);
            dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
    }
}
