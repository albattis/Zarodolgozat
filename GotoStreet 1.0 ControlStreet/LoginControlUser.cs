namespace GotoStreet_1._0_ControlStreet
{
    class LoginControlUser
    {
        private readonly PasswordHash PH = new PasswordHash();
        private readonly ControlStreetMessage Message = new ControlStreetMessage();

        private string Username { get; set; }
        private string Password { get; set; }
        private string Repass;
        private string ShaPass;
        readonly private string[] user = new string[3];
        private bool successfull = false;

        public string Usernames { get { return Username; } set { Username = value; } }
        public string Passwords { get { return Password; } set { Password = value; } }


        public LoginControlUser(string Un, string Pw)
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
                if (int.Parse(Username).Equals(item.Id))
                {
                    Repass = item.password;
                    user[0] = item.name;
                    user[1] = item.employee;
                    user[2] = item.Id.ToString();


                }

            }
            ShaPass = PH.Sha256(Passwords);
            if (ShaPass.Equals(Repass))
            {
                successfull = true;
            }
            else { Message.PasswordError(); }

        }

        public bool Successfully()
        {
            return successfull;
        }

        public string[] ReturnUser()
        {
            return user;
        }



    }
}
