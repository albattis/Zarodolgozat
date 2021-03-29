using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GotoStreet_1._0_ControlStreet
{
    public partial class ControlStreetUserboard : Form


    {
        readonly ControlStreetUser User;
        private int Authenticatedid;
        

        private void QuerySearch(string type, string mode)
        {
            ControlStreetMessage Mess = new ControlStreetMessage();
            try
            {
                var context = new gotoStreetEntities();
                switch (type)
                {
                    case ("Id"):
                        foreach (var item in context.gotoStreet)
                        {
                            if (item.userid.Equals(int.Parse(mode)))
                            {
                                ControlStreetGridView.Rows.Add(item.user.firstname + " " + item.user.lastname, item.go_date, item.cel, item.Id, item.status);
                            }
                        }
                        break;

                    case ("Dátum"):
                        foreach (var item in context.gotoStreet)
                        {
                            if (item.go_date.Equals(DateTime.Parse(mode)))
                            {

                                ControlStreetGridView.Rows.Add(item.user.firstname + " " + item.user.lastname, item.go_date, item.cel, item.Id, item.status);
                            }
                        }
                        break;
                    case ("Ok"):
                        foreach (var item in context.gotoStreet)
                        {
                            if (item.cel.Equals(mode))
                            {

                                ControlStreetGridView.Rows.Add(item.user.firstname + " " + item.user.lastname, item.go_date, item.cel, item.Id, item.status);
                            }
                        }
                        break;
                    default:
                        Mess.GoErrors();
                        break;

                }
            }
            catch (FormatException)
            {
                Mess.DataError();
            }
            ControlStreetGridView.Show();
        }

        private void QueryTrue(string status, int id)
        {
            using (var context = new gotoStreetEntities())
            {
                foreach (var item in context.user)
                {
                    if (item.police_id.Equals(id))
                    {
                        var context2 = new gotoStreetEntities();
                        foreach (var item2 in context2.gotoStreet)
                        {
                            if (item.userid.Equals(item2.userid) && item2.status == status)
                            {

                                ControlStreetGridView.Rows.Add((item.firstname + " " + item.lastname), item2.go_date, item2.cel, item.userid, item2.status);
                            }
                        }

                    }
                }
            }
            ControlStreetGridView.Show();
        }

        private void GridClear()
        {
            ControlStreetGridView.Rows.Clear();
        }

        private void QueryAuthenticated()
        {


            var context = new gotoStreetEntities();

            foreach (var item in context.Authenticated_user)
            {
                if (item.status.Equals("no"))
                {
                    foreach (var item2 in context.user)
                    {
                        if (item.userid == item2.userid)
                        {
                            ControlStreetGridView.Rows.Add((item2.firstname + " " + item2.lastname), " ", " ", item2.userid, item.status);
                        }
                    }
                }
            }

            ControlStreetGridView.Show();
        }
        private void Authanticated_Procedure()
        {
            ControlStreetMessage Mess = new ControlStreetMessage();
            using (var context = new gotoStreetEntities())
            {
                try
                {
                    var user = context.Authenticated_user.Where(s => s.userid == Authenticatedid).First();
                    user.status = "ok";
                    context.SaveChanges();
                    textBox_Authenticated_id.Text = "";
                    Authanticated_Data.Text = "Felhasználó Adatok:";
                    Mess.Authenticated_Success();
                    Authenticatedid = 0;
                }
                catch (SqlException) { Mess.InsertError(); }
                catch (InvalidOperationException) { Mess.NotFoundAuthenticate(); }
            }
        
        }
        private void Authenticated_Wait(int id)
        {
            try
            {
                using (var context = new gotoStreetEntities())
                {
                    foreach (var item in context.Authenticated_user)
                    {
                        Authanticated_Data.Text = "Felhasználó adatai: \n\n" +
                            "Anyja neve: " + item.Mother_name + " \n\n" +
                            "Születési Dátum: " + item.Birth_date + "\n\n" +
                            "Okmány Száma: " + item.ICN;
                    }
                }
            }
            catch (SqlException) { Authanticated_Data.Text = "Nincs megjelenithető adat."; }
        }

        public ControlStreetUserboard(string[] users)
        {
            InitializeComponent();
            
            ControlStreetGridView.ColumnCount = 5;
            User = new ControlStreetUser(users);
            Welcome_label.Text = "Üdvözlöm kedves: " + User.Names;
            if (User.Employees.Equals("Boss"))
            {
                regisztrációToolStripMenuItem.Visible = true;
            }
            else
            {
                regisztrációToolStripMenuItem1.Visible = false;
            }
        }

        private void KilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ElfogadottKijárásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridClear();
           QueryTrue("Elfogadva", User.Ids);
            User.UserWorkDataWrite("Okgotostreet");

        }

        private void Hidden_button_Click(object sender, EventArgs e)
        {
            GridClear();
        }

        private void ElutasitottKijárásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridClear();
            QueryTrue("Elutasitva", User.Ids);
            User.UserWorkDataWrite("Nogotostreet");
            
        }
        
        private void IdAlapjánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridClear();
            QuerySearch("Id",idsearch_textbox.Text);
        }

        private void DátumAlapjánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridClear();
            QuerySearch("Dátum", date_Search_textbox.Text);
        }

        private void KijárásiOkAlapjánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridClear();
           QuerySearch("Ok",ok_search_textbox.Text);
        }

        private void RegisztrációToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ControlStreetRegistration cr = new ControlStreetRegistration();
            cr.Show();
        }

        private void HitelesitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridClear();
           QueryAuthenticated();
            
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            ControlStreetMessage Mess = new ControlStreetMessage();
            try
            {
                int data = int.Parse(textBox_Authenticated_id.Text);
                Authenticatedid = data;
                Authenticated_Wait(data);
            }
            catch (FormatException) { Mess.FormatException(); }
        }
        private void Button_Authenticated_Click(object sender, EventArgs e)
        {
            Authanticated_Procedure();
            User.UserWorkDataWrite("Authanticate");
        }
    }
}
