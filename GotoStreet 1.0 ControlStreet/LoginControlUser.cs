using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoStreet_1._0_ControlStreet
{
    class LoginControlUser
    {
        private readonly PasswordHash PH = new PasswordHash();

        private string Username { get; set; }
        private string Password { get; set; }
        private string Repass;
        private string ShaPass;
        private string[] user = new string[3];
        public string Usernames { get { return Username; }set { Username = value; } }
        public string Passwords { get { return Password; }set { Password = value; } }


        public LoginControlUser(string Un,string Pw)
        {
            Passwords = Pw;
            Usernames = Un;
            Login();
        }

        private void Login()
        {
            var context = new policeusersEntities();
            foreach (var item in context.puser)
            {
                if (Username.Equals(item.Id))
                {
                    Repass = item.password;
                    ShaPass = PH.Sha256(Passwords);
                    if (ShaPass.Equals(Repass))
                    {
                        user[0] = item.name;
                        user[1] = item.employee;
                        user[2] = item.Id.ToString();
                    }

                }
            }

        }

        public string[] ReturnUser()
        {
            return user;
        }

    }
}
