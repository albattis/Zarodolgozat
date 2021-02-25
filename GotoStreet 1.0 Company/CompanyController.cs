using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoStreet_1._0_Company
{
    class CompanyController
    {
        private readonly PasswordHash PS = new PasswordHash();
        
        private string username;
        private string password;
        private bool success=false;

       public CompanyController(string usn,string psw) 
        {
            this.username = usn;
            this.password = psw;
            Login();
        }

        private void Login()
        {
            var context = new Company_registerEntities1();
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

        public bool ReturnLogin()
        {
            return success;
        }
    }
}
