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


        public Registration()
        {
            InitializeComponent();
            Button_back.Visible = false;
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {


            GotoStreetRegistation Reg = new GotoStreetRegistation(
                TextBox_firstname,
                TextBox_lastname,
                TextBox_zip,
                TextBox_city,
                TextBox_street,
                TextBox_place,
                TextBox_housenumber,
                TextBox_password,
                TextBox_repassword
                );
            if (Reg.Registration())
            {
                int Id = Reg.ID;
                ListBox_Success.Items.Add("Felhasználónév: " + Id);
                ListBox_Success.Items.Add("Jelszó: " + TextBox_password.Text);
                Button_back.Visible = true;
                Registration_button.Visible = false;
                Escape_button.Visible = false;
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
