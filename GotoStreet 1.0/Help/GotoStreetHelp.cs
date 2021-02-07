using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoStreet_1._0.Help
{
    class GotoStreetHelp
    {
        private string Login_Help_title { get; set; }
        private string Login_Help_username { get; set; }
        private string Login_Help_username_screen { get; set; }
        private string Login_Help_password { get; set; }
        private string Login_Help_password_screen { get; set; }
        private string Registration_title { get; set; }
        private string Registration { get; set; }
        private string Registration_screen { get; set; }
        private string Gotostreet_title{ get; set; }
        private string Gotostreet { get; set; }
        private string Gotostreet_screen { get; set; }
        
        public string Login_Help_titles { get { return Login_Help_title; }set { Login_Help_title = value; } }
        public string Login_Help_usernames { get { return Login_Help_username; } set { Login_Help_username = value; } }
        public string Login_Help_passwords { get { return Login_Help_password; } set { Login_Help_password = value; } }
        public string Login_Help_password_screens { get { return Login_Help_password_screen; } set { Login_Help_password_screen = value; } }
        public string Login_help_username_screens { get { return Login_Help_username_screen; }set { Login_Help_username_screen = value; } }
        public string Registration_titles { get { return Registration_title; } set { Registration_title = value; } }
        public string Registrations { get { return Registration; }set { Registration = value; } }
        public string Registration_screens { get {return Registration_screen; }set { Registration_screen = value; } }
        public string Gotostreettitles { get { return Gotostreet_title; }set { Gotostreet_title = value; } }
        public string Gotostreets { get { return Gotostreet; }set { Gotostreet = value; } }
        public string Gotostreet_screens { get { return Gotostreet_screen; } set { Gotostreet_screen = value; } }
        public GotoStreetHelp()
        {
            Login_Help_title = "GotoStreet Help 1.0";
            Login_Help_username = "Bejelentkezés név:";
            Login_Help_username_screen = "Adja meg a Regisztrációnál kapott felhasználónevet.";
            Login_Help_password = "Jelszó";
            Login_Help_password_screen = "Adja meg a Regisztráció során megadott jelszavát";
            Registration_title = "Regisztráció Sugó";
            Registrations="Regisztrációs lépései:";
            Registration_screen = "Töltse ki az adatmezöket értelemszerüen. Az jelszónak minimum 8 karakternek kell lennie.\n Sikeres regisztráció bejelentkezési adatait a jobb oldalon jelzi a program.";
            Gotostreet_title = "Kijáráis kérelem Sugó";
            Gotostreet = "Helyes kitőltés";
            Gotostreet_screen = "Adja meg a napot és az idöpontot. Az idők: Munka,Gyogyszertár Orvos,Bevásárlás lehet.\n Mindig a következö napra lehet kérelmet irni. ";

        }

       



    }
}
