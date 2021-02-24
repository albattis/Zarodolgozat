using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0_ControlStreet
{
    public partial class LoginControlStreet : Form
    {
        private string[] user = new string[3];  
        public LoginControlStreet()
        {
            InitializeComponent();
        }

        private void Escape_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            LoginControlUser LU = new LoginControlUser(Username_textbox.Text, Password_textbox.Text);
                if(LU.Successfully())
            {
                user = LU.ReturnUser();
                ControlStreetUserboard Usb = new ControlStreetUserboard(user);
                Usb.Show();
            }
        }
    

       
    }
}
