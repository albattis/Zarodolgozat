using System;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    public partial class LoginForm : Form
    {
       
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
             LoginController LC = new LoginController();
            if (LC.Login(Loginname_Textbox.Text,Pasword_Textbox.Text))
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
