using System;
using System.Collections.Generic;
using System.Linq;

namespace GotoStreet_1._0
{
    class AuthenticatedNow
    {



        public AuthenticatedNow(int id, string mn, DateTime bd, string icn)
        {
           
            Authenticate(id, mn, bd, icn); 
        }

        


        private void Authenticate(int id,string mn, DateTime bd, string icn)
        {
            GotoStreetError Error = new GotoStreetError();
            Authenticated_user users = new Authenticated_user
            {
                userid = id,
                Mother_name = mn,
                ICN = icn,
                Birth_date = bd,
                status="no"
            };
            Authenticated_user u = users;
            try
            {
                using (var context = new gotoStreetEntities1())
                {
                    context.Authenticated_user.Add(u);
                    context.SaveChanges();
                }

            }
            catch (System.Data.SqlClient.SqlException) { Error.Registration_Error(); }
        
        }
    }
}
