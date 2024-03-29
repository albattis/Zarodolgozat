﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoStreet_1._0_ControlStreet
{
    class ControlStreetUser
    {
        private string Name { get; set; }
        private string Employee { get; set; }
        private int Id { get; set; }

        public string Names { get { return Name; }set { Name = value; } }
        public string Employees { get { return Employee; }set { Employee = value; } }
        public int Ids { get { return Id; } set { Id = value; } }

        public ControlStreetUser()
        { }
        
        public ControlStreetUser(string[] users)
        {
            Names = users[0];
            Employees = users[1];
            Ids = int.Parse(users[2]);
            UserWorkDataWrite("Login");
        }
        public void UserWorkDataWrite(string works)
        {
            using (var context = new policeusersEntities())
            {
                pworks work = new pworks
                {
                    Id = context.pworks.Count() + 1,
                    userid = Id,
                    work = works,
                    login_date = DateTime.Now.Date
                };

                pworks n = work;
                context.pworks.Add(n);
                context.SaveChanges();
        }
    }


}
}
