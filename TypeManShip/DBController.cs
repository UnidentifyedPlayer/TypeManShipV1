using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeManShip
{
    class DBController
    {
        DataSet data;

        public DBController()
        {
            data = new DataSet();
        }
        public DBController(DataSet set)
        {
            data = set.Copy();
        }

        public void AddNewUser(string passw)
        {
            data.Tables[0].Rows.Add(new object[] { 0, passw, 0, 0 });
            //DataSet newdata = data.GetChanges();
            //data.Merge(newdata);
            data.AcceptChanges();
            string str = (string)data.Tables[0].Rows[0].ItemArray[1];
        }
    }
}
