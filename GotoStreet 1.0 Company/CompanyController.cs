
namespace GotoStreet_1._0_Company
{
    class CompanyController
    {
        private readonly PasswordHash PS = new PasswordHash();
        private readonly ErrorMessage Message = new ErrorMessage();
        
        private readonly string username;
        private readonly string password;
        private bool success=false;

       public CompanyController(string usn,string psw) 
        {
            this.username = usn;
            this.password = psw;
            Login();
        }

        private void Login()
        {
            try
            {
                using (var context = new Company_registerEntities1())
                {
                    foreach (var item in context.Company)
                    {
                        if (item.company_id.Equals(int.Parse(username)))
                        {
                            string x = PS.Sha256(password);
                            if (x.Equals(item.password))
                            {
                                success = true;
                            }
                        }

                    }
                }
            }
            catch (System.Data.SqlClient.SqlException) { Message.SqlError(); }
            
            }

        public bool ReturnLogin()
        {
            return success;
        }
    }
}
