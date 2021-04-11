using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    class GotoStreetWriteDatabase
    {
        public bool NewGotoStreetWrite(DateTime record_Date,DateTime Go_Date,string where,int id)
        {
            GotoStreetError Error = new GotoStreetError();
            string status="";
            try
            {
                GotoStreet_Controller GSC = new GotoStreet_Controller(id, Go_Date, where);
                
                if (GSC.FullCheck())
                { status = "Elfogadva"; }
                else { status = "Elutasítva"; }
            
                gotoStreet gotoStreet = new gotoStreet
                {
                    userid = id,
                    record_date = record_Date,
                    go_date = Go_Date,
                    cel = where,
                    status = status
                };
                gotoStreet gt = gotoStreet;
                var context = new gotoStreetEntities1();
                context.gotoStreet.Add(gt);
                context.SaveChanges();
                return true;
            }
            catch (SqlException) { return false; }

        }
    }
}
