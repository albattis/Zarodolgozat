using System.Windows.Forms;

namespace GotoStreet_1._0_Company
{
    public partial class CompanyLogin : Form
    {
        private CompanyController CC = null;
        private readonly ErrorMessage M = new ErrorMessage();
        public CompanyLogin()
        {
            InitializeComponent();
        }

        private void login_button(object sender, System.EventArgs e)
        {
            string usn = username_textbox.Text;
            string id = password_Textbox.Text;
            CC = new CompanyController(usn, id);
            if (CC.ReturnLogin())
            {
                CompanyBoard B = new CompanyBoard(int.Parse(usn));
                B.Show();

            }
            else { M.LoginError(); }
            username_textbox.Text = "";
            password_Textbox.Text = "";
        }

        private void Escape_button_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
