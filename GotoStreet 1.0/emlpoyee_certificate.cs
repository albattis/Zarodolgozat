using System;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    public partial class emlpoyee_certificate : Form
    {
        private readonly System.Drawing.Printing.PrintDocument docToPrint;
        public emlpoyee_certificate(Label lab)
        {
            InitializeComponent();
            welcome_label.Text = "Munkáltatói Igazolás";
            employye_label.Text = lab.Text;
            docToPrint = new System.Drawing.Printing.PrintDocument();
            docToPrint.PrintPage += PrintDocument1_PrintPage;

        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_print_Click(object sender, EventArgs e)
        {

            PrintDialog PrintDialog1 = new PrintDialog
            {
                AllowSomePages = true,
                ShowHelp = true,
                Document = docToPrint
            };
            DialogResult result = PrintDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font
        ("Arial", 16, System.Drawing.FontStyle.Regular);

            string print = "Munkáltatoi Igazolás\n " + "\n" + employye_label.Text + "\n" + " \n" + " Nyomtatva a GotoStreet Alkalmazáson keresztül.";
            e.Graphics.DrawString(print, printFont,
                System.Drawing.Brushes.Black, 10, 10);
        }
    }

}
