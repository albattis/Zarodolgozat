﻿using System;
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
        public bool NewGotoStreetWrite(Label Go_Label_date,TextBox TextBox_Date,TextBox TextBox_where,int id)
        {
            GotoStreetError Error = new GotoStreetError();
            string status="";
            try
            {
                GotoStreet_Controller GSC = new GotoStreet_Controller(id, DateTime.Parse(TextBox_Date.Text), TextBox_where.Text);
                
                if (GSC.FullCheck())
                { status = "Elfogadva"; }
                else { status = "Elutasítva"; }
            }
            catch (FormatException) { Error.DateError(); }
            
            try
            {
                gotoStreet gotoStreet = new gotoStreet
                {
                    userid = id,
                    record_date = DateTime.Parse(Go_Label_date.Text),
                    go_date = DateTime.Parse(TextBox_Date.Text),
                    cel = TextBox_where.Text.Trim(),
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
