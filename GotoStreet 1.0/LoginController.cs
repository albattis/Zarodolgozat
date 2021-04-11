using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GotoStreet_1._0
{
    public class LoginController
    {
       readonly PasswordHash PH = new PasswordHash();
       readonly GotoStreetError Error = new GotoStreetError();


        private int Ids { get; set; }
        private string Usernames { get; set; }

        private bool Data = false;
       

        public int Id { get { return Ids; }set { Ids = value; } }

        public string Username { get { return Usernames; } set { Usernames = value; } }


        public bool Login(string id, string password)

        {
            string passwords = null;
            using (var context = new gotoStreetEntities1())
            {
                Data = false;
                try
                {
                    foreach (var item in context.user)
                    {
                        if (item.userid.Equals(int.Parse(id)))
                        {
                            passwords = item.password;
                            string ControlPassword = PH.Sha256(password);

                            if (ControlPassword.Equals(passwords))
                            {
                                Data = true;
                            }
                            else
                            {
                                Error.PasswordError();
                            }
                        }
                    }
                    if (!Data)
                    {
                        Error.LoginnameError();
                    }
            
                    
                }
                catch (FormatException) { Error.FormatException();  }
                catch (EntityException) { Error.EntityException();  }
            }
            return Data;
        }

    }
}
