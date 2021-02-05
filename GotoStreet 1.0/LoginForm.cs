using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    public partial class LoginForm : Form
    {
       readonly LoginController LC = new LoginController();
        private bool Data = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            
            if (Data=LC.Login(Loginname_Textbox.Text,Pasword_Textbox.Text))
            {
                
                UserInterface UI = new UserInterface(int.Parse(Loginname_Textbox.Text));
                UI.Show();
                


            }
        }

        private void Escape_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Registration Reg = new Registration();
                Reg.Show();
        }
    }
}
