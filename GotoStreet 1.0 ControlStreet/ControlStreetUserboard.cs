using System;
using System.Windows.Forms;

namespace GotoStreet_1._0_ControlStreet
{
    public partial class ControlStreetUserboard : Form

       
    {
       readonly ControlStreetUser User;
       readonly ControlStreetMessage Mess = new ControlStreetMessage();

       
        private void QueryTrue(string status)
        {
            ControlStreetGridView.Rows.Clear();
            var context = new gotoStreetEntities();
            foreach (var item in context.user)
            {
                if (item.police_id.Equals(User.Ids))
                {
                    var context2 = new gotoStreetEntities();
                    foreach (var item2 in context2.gotoStreet)
                    {
                        if (item.userid.Equals(item2.userid)&&item2.status==status)
                        {
                           
                            ControlStreetGridView.Rows.Add((item.firstname + " " + item.lastname), item2.go_date, item2.cel, item.userid, item2.status);
                        }
                    }
                
                }
            }
            ControlStreetGridView.Show();
        }

        private void QuerySearch(string type,string mode)
        {
            try
            {
                var context = new gotoStreetEntities();
                ControlStreetGridView.Rows.Clear();

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
            QueryTrue("Elfogadva");
        }

        private void Hidden_button_Click(object sender, EventArgs e)
        {
            ControlStreetGridView.Rows.Clear();
        }

        private void ElutasitottKijárásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryTrue("Elutasitva");
        }

        private void IdAlapjánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuerySearch("Id",idsearch_textbox.Text);
        }

        private void DátumAlapjánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuerySearch("Dátum", date_Search_textbox.Text);
        }

        private void KijárásiOkAlapjánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuerySearch("Ok",ok_search_textbox.Text);
        }

        private void RegisztrációToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ControlStreetRegistration cr = new ControlStreetRegistration();
            cr.Show();
        }
    }
}
