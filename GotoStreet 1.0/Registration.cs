using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    public partial class Registration : Form
    {

       private readonly GotoStreetError Error = new GotoStreetError();
       private readonly PasswordHash Ph = new PasswordHash();

        private string password;
        private int ID;

        private bool Controll()
        {
            if (TextBox_firstname.Text != "" || TextBox_lastname.Text != null)
            {
                if (TextBox_zip.Text.Equals(null) || TextBox_city.Text.Equals(null) ||
                    TextBox_street.Text.Equals(null) || TextBox_place.Text.Equals(null) ||
                    TextBox_housenumber.Text.Equals(null))
                { Error.Registration_cityError(); return false; }
                else { return true; }
            }
            else { Error.Registration_nameError(); return false; }

            
           
        }

        private bool PasswordControll()
        {

            if (TextBox_password.Text.Equals(TextBox_repassword.Text))
            {
                if (TextBox_password.Text.Length > 7)
                {
                    password = Ph.Sha256(TextBox_password.Text);
                    return true;
                }
                else 
                {
                    Error.PasswordLenghtError();
                    return false;
                }

            }
            else { Error.PasswordContainsError(); return false; }
        }

        private bool Validate_Insert()
        { 
            try
            {
                var context = new gotoStreetEntities1();
                ID = context.user.Count() + 1;
                user user = new user
                {
                    firstname = TextBox_firstname.Text.ToString(),
                    lastname = TextBox_lastname.Text.ToString(),
                    password = password,
                    userid = ID
                };

                city newcity = new city
                {
                    zip = int.Parse(TextBox_zip.Text),
                    city1 = TextBox_city.Text.ToString(),
                    street = TextBox_street.Text.ToString(),
                    place = TextBox_place.Text.ToString(),
                    housenumber = TextBox_housenumber.Text.ToString(),
                    userid = ID


                };
                    user u = user;
                    context.user.Add(u);
                    context.SaveChanges();
                    
                    city c = newcity;
                    context.city.Add(c);
                    context.SaveChanges();

                return true;
            }
            catch (FormatException) { Error.Registration_formatError(); return false; }
            catch (DivideByZeroException e)
            { Console.WriteLine( e.Message);  Error.Registration_Error(); return false; }


            
        }


        public Registration()
        {
            InitializeComponent();
            Button_back.Visible = false;
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            if (Controll()&&PasswordControll())
            {
                if (Validate_Insert())
                {
                    Error.Successfull_Registration();
                    ListBox_Success.Items.Add("Felhasználónév: " + ID);
                    ListBox_Success.Items.Add("Jelszó: " + TextBox_password.Text);
                    Button_back.Visible = true;
                    Registration_button.Visible = false;
                    Escape_button.Visible = false;
                }
            }

        }

        private void Escape_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
