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
            string mn =textBox_mthn.Text;
            DateTime bd = DateTime.Parse("1000.01.01");
            string icn =textBox_icn.Text;
            AuthenticatedNow Now = new AuthenticatedNow(id,mn,bd,icn);
        }
    }
}
