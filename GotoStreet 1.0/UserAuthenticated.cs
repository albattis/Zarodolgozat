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
    public partial class UserAuthenticated : Form
    {
        private int id;
        public UserAuthenticated(int ids)
        {
            InitializeComponent();
            id = ids;
        }

        private void Authenticate_button_Click(object sender, EventArgs e)
        {
            string mn="";
            DateTime bd=DateTime.Parse("1000.01.01");
            string icn="";

            GotoStreetError Error = new GotoStreetError();
            bool siker = false;
            try
            {
                 mn = textBox_mthn.Text;
                 bd = DateTime.Parse(textBox_bd.Text);
                 icn = textBox_icn.Text;
                siker = true;
            }
            catch (FormatException) { siker = false;Error.DataError(); }
            
            if (siker) {
                AuthenticatedNow Now = new AuthenticatedNow(id,mn,bd,icn);
                Error.Authenticated_Success();
            }
        }
    }
}
