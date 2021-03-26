using System;
using System.Windows.Forms;
using GotoStreet_1._0.Help;

namespace GotoStreet_1._0
{
    public partial class UserInterface : Form
    {

        readonly GotoStreetUser LogUser = new GotoStreetUser();

        private readonly int id;




        public UserInterface(int ids)
        {
            InitializeComponent();
            id = ids;
            UserSettings();
            Welcomae_Label.Text = "Üdvözöllek Kedves " + LogUser.Firstnames + " " + LogUser.Lastnames;
            Date_Label.Text = "Bejelentkezés ideje:  " + DateTime.Now.ToString();
            userdatas.Visible = false;
            usedata_button.Visible = false;
            var context = new gotoStreetEntities1();
            bool cheked = true;
            foreach (var item in context.Authenticated_user)
            {
                if (id.Equals(item.userid) && cheked)
                {
                    Authenticated_label.Text = "Hitelesitett Felhasználó";
                    felhasználóiRegisztrációToolStripMenuItem.Visible = false;
                    cheked = false;

                }
                
            }

        }

        private Label Emlpoyee_certificate_setting()
        {
            Label label = new Label();
            var context = new Company_registerEntities();
            foreach (var item in context.Emlpoye_Certificate)
            {
                if (id.Equals(item.userid))
                {
                    var context3 = new Company_registerEntities();
                    foreach (var item2 in context3.Company)
                    {
                        if (item.Companyid.Equals(item2.company_id))
                        {
                            var context2 = new gotoStreetEntities1();
                            foreach (var item3 in context2.Authenticated_user)
                                if (id.Equals(item3.userid))
                                {
                                    label.Text = "Alulirott "
                                          + item2.Company_manager + " mint a(z) "
                                          + item2.name + " ügyvezetője Kijelentem,hogy: \n\n"
                                          + "Név: " + LogUser.Firstnames + " " + LogUser.Lastnames + " nevü \n"
                                          + "Születési idő: " + item3.Birth_date + "\n"
                                          + "Anyja neve: " + item3.Mother_name + "\n"
                                          + "Lakcim: " + LogUser.Zips + " " + LogUser.Citys + " " + LogUser.Streets + " " + LogUser.Places + " " + LogUser.Housenumbers +
                                           "\n\nNevü munkavállaló, Otthonát elhagyhatja munkavégzés céljából.\n\n" + DateTime.Now + " \n\n" + item2.Company_manager + "\n Ügyvezetö\n" + item2.name;
                                }
                        }

                    }
                }

            }
            return label;
        }
        private void UserSettings()
        {
            var context = new gotoStreetEntities1();
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

            var context = new gotoStreetEntities1();
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
            GotoStreet_View("elutasítva");
        }

        private void ÚjKijárásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGotoStreet Ngs = new NewGotoStreet(LogUser.Firstnames, LogUser.Lastnames, id);
            Ngs.Show();
        }

        private void FelhasználóiKézikönyvToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GotoStreetHelpForm Help = new GotoStreetHelpForm();
            Help.Show();
        }

        private void FelhasználóiAdataimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userdatas.Text = "Felhasználó név: " + LogUser.Firstnames + " " + LogUser.Lastnames + "\n" +
                "Lakcím: " + LogUser.Zips + " " + LogUser.Citys + " " + LogUser.Streets + " " + LogUser.Places + " " + LogUser.Housenumbers;
            usedata_button.Visible = true;
            userdatas.Visible = true;
        }

        private void Usedata_button_Click(object sender, EventArgs e)
        {
            userdatas.Visible = false;
            usedata_button.Hide();
        }

        private void MunkáltatóiIgazolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emlpoyee_certificate ec = new emlpoyee_certificate(Emlpoyee_certificate_setting());
            ec.Show();
        }

        private void FelhasználóiRegisztrációToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAuthenticated Au = new UserAuthenticated(id);
            Au.Show();
        }
    }
}
