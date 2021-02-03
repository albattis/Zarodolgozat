using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoStreet_1._0
{
    class LoginController
    {
        PasswordHash PH = new PasswordHash();
        GotoStreetError Error = new GotoStreetError();


        private int Ids { get; set; }
        private string Usernames { get; set; }

        private bool Data;
       

        public int Id { get { return Ids; }set { Ids = value; } }

        public string Username { get { return Usernames; } set { Usernames = value; } }


        public bool Login(string id,string password)

        {
            string passwords=null;
            var context = new gotoStreetEntities();
            foreach (var item in context.user)
            {
                if (item.Id.Equals(int.Parse(id)))
                {
                    passwords = item.password;
                }
                

            }
            Data = false;
            string ControlPassword=PH.sha256(password);

            if (ControlPassword.Equals(passwords))
            {
                Data = true;
            }
            else
            {
                Error.PasswordError();
            }

            return Data;
        }

    }
}
