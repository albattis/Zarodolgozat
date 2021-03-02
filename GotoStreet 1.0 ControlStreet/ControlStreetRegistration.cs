using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0_ControlStreet
{
    public partial class ControlStreetRegistration : Form
    {
        private bool data = false;
        private readonly ControlStreetMessage Mess = new ControlStreetMessage();

        public ControlStreetRegistration()
        {
            InitializeComponent();
        }

        private void Insert()
        {
           // try
           // {
                if (!data)
                {
                    var context = new policeusersEntities();
                    int id = context.puser.Count() + 1;

                    PasswordHash PH = new PasswordHash();
                    string pass = PH.Sha256(password_textbox.Text);

                puser user = new puser
                {

                    Id = id,
                        name = name_textbox.Text.ToString(),
                        password = pass,
                        employee = employee_textbox.Text.ToString(),
                        officeid = int.Parse(policeid_textbox.Text)

                    };

                    puser u = user;
                    context.puser.Add(u);
                    context.SaveChanges();
                    data = true;
                }
                if (data)
                { Mess.InsertSuccessfull(); }
                else { Mess.InsertError(); }

            //}
            //catch (DbEntityValidationException ) { Mess.InsertError(); }
            }
        private void Exit_button(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Registration_button(object sender, EventArgs e)
        {
            Insert();
        }
    }
}
