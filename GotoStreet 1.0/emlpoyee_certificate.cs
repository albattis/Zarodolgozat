using System;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    public partial class emlpoyee_certificate : Form
    {
        
        public emlpoyee_certificate(Label lab)
        {
            InitializeComponent();
            welcome_label.Text = "Munkáltatói Igazolás";
            employye_label.Text = lab.Text;
           

        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_print_Click(object sender, EventArgs e)
        {
            PrintClass Print = new PrintClass();
            Print.Print(employye_label);
        }

        
    }

}
