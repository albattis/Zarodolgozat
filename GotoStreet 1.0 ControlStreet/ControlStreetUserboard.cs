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
    public partial class ControlStreetUserboard : Form
    {
        private void QueryTrue(int id)
        {
            var context = new gotoStreetEntities();
            foreach (var item in context.gotoStreet)
            {
                if (item.user.police_id.Equals(id))
                { }
            }
        }


        public ControlStreetUserboard(string[] users)
        {
            InitializeComponent();
            ControlStreetUser User = new ControlStreetUser(users);
            Welcome_label.Text = "Üdvözlöm kedves: " + User.Names;
            if (User.Employees.Equals("Boss"))
            {
                munkavállalókToolStripMenuItem.Visible = true;
            }
            else 
            {
                munkavállalókToolStripMenuItem.Visible = false;
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void elfogadottKijárásokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
