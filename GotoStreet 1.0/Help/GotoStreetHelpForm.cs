using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0.Help
{
    public partial class GotoStreetHelpForm : Form
    {

        private readonly GotoStreetError Error = new GotoStreetError();
       private readonly GotoStreetHelp Help = new GotoStreetHelp();


        private void Resetlabel()
        {
            label_screen.Text = "";
            label_tag.Text = "";
            label_screen.Text = "";
        }

        private void ImageLoad(string path)
        {
            try
            {
                FileStream fs = new System.IO.FileStream(path, FileMode.Open, FileAccess.Read);
                GotoStreetPictureBox.Image = Image.FromStream(fs);
                fs.Close();
            }
            catch (FileNotFoundException){Error.FileNootFound(); }
            
        }

        private void HelpScreen(string title, string tag, string screen)
        {
            label_title.Text = title;
            label_tag.Text = tag;
            label_screen.Text = screen;
        }

        public GotoStreetHelpForm()
        {
            InitializeComponent();
            GotoStreetPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            label_title.Text = Help.Login_Help_titles;
            label_screen.Text = "Kérem válasszon a menüpontok közül.";
        }

        private void FelhasználónévToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resetlabel();
            HelpScreen(Help.Login_Help_titles, Help.Login_Help_usernames, Help.Login_help_username_screens);
            ImageLoad(@"Help\img\login_form.png");
        }

        private void JelszóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resetlabel();
            HelpScreen(Help.Login_Help_titles,Help.Login_Help_passwords,Help.Login_Help_password_screens);
            ImageLoad(@"Help\img\login_form.png");
        }

        private void RegisztrációToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Resetlabel();
            HelpScreen(Help.Registration_titles, Help.Registrations, Help.Registration_screens);
            ImageLoad(@"Help\img\registration.png");
        }

        private void KijárásiKérelemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resetlabel();
            HelpScreen(Help.Gotostreettitles,Help.Gotostreets,Help.Gotostreet_screens);
            ImageLoad(@"Help\img\gotostreet.png");
        }
    }
}
