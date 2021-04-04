using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    class GotoStreetRegistation
    {
        private readonly GotoStreetError Error = new GotoStreetError();
        private readonly PasswordHash Ph = new PasswordHash();
        private string password;
        public int ID;
        private readonly TextBox TextBox_firstname;
        private readonly TextBox TextBox_lastname;
        private readonly TextBox TextBox_zip;
        private readonly TextBox TextBox_city;
        private readonly TextBox TextBox_street;
        private readonly TextBox TextBox_place;
        private readonly TextBox TextBox_housenumber;
        private readonly TextBox TextBox_password;
        private readonly TextBox TextBox_repassword;

            
        public GotoStreetRegistation(
            TextBox fn,
            TextBox ln,
            TextBox Zip,
            TextBox City,
            TextBox Street,
            TextBox Place,
            TextBox Housenumber,
            TextBox Password,
            TextBox Repassword)
        {
            
            TextBox_firstname = fn;
            TextBox_lastname = ln;
            TextBox_zip = Zip;
            TextBox_city = City;
            TextBox_street = Street;
            TextBox_place = Place;
            TextBox_housenumber = Housenumber;
            TextBox_password = Password;
            TextBox_repassword = Repassword;

        }

        private bool Controll()
        {
            if (TextBox_firstname.Text != "" || TextBox_lastname.Text != null)
            {
                if (TextBox_zip.Text == "" || TextBox_city.Text == "" ||
                   TextBox_street.Text == "" || TextBox_place.Text == "" ||
                   TextBox_housenumber.Text == "")
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
        }
        public bool Registration()
        {
            if (Controll() && PasswordControll())
            {
                if (Validate_Insert())
                {  Error.Successfull_Registration(); return true; }
                else { return false; }
            }
            else{return false;}

        }
    }
}
