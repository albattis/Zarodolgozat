using System;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    public partial class UserInterface : Form
    {

      readonly  GotoStreetUser LogUser = new GotoStreetUser();

        private readonly int id;

        public UserInterface(int ids)
        {
            InitializeComponent();
            id = ids;
            UserSettings();
            Welcomae_Label.Text = "Üdvözöllek Kedves "+LogUser.Firstnames+" "+LogUser.Lastnames;
            Date_Label.Text = "Bejelentkezés ideje:"+ DateTime.Now.ToString();
        
        }

        private void UserSettings()
        {
            var context = new gotoStreetEntities();
            foreach (var item in context.user)
            {
                if (id.Equals(item.userid))
                {
                    LogUser.Firstnames = item.firstname;
                    LogUser.Lastnames = item.lastname;
                    LogUser.Zips = item.city.zip;
                    LogUser.Citys = item.city.city1;
                    LogUser.Streets = item.city.street;
                    LogUser.Places = item.city.place;
                    LogUser.Housenumbers = item.city.housenumber;
                }
            }
        }

        private void GotoStreet_View(string v)
        {

            var context = new gotoStreetEntities();
            GotoStreet_Views.ColumnCount = 4;
            foreach (var go in context.gotoStreet)
            {
                if (id.Equals(go.userid) && go.status.ToLower() == v)
                {
                    GotoStreet_Views.Rows.Add((LogUser.Firstnames + " " + LogUser.Lastnames), go.go_date, go.cel, go.status);
                }


            }
            GotoStreet_Views.Show();
        }


        private void KilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EngedélyezettKijárásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GotoStreet_Views.Rows.Clear();
            GotoStreet_View("elfogadva");
        }

        private void ElutasitottKijárásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GotoStreet_Views.Rows.Clear();
            GotoStreet_View("elutasitva");
        }

        private void ÚjKijárásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGotoStreet Ngs = new NewGotoStreet(LogUser.Firstnames,LogUser.Lastnames,id);
            Ngs.Show();
        }

        private void MunkáltatóiIgazolásToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
