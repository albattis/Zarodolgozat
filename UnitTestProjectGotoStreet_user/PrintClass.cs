using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace GotoStreet_1._0
{
    class PrintClass
    {
        private PrintDocument docToPrint;
        Label label;
        public void Print(Label labels)
        {
            label = labels;

            docToPrint = new PrintDocument();
            docToPrint.PrintPage += PrintDocument1_PrintPage;

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

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font printFont = new Font
        ("Arial", 16, FontStyle.Regular);

            string print = "Munkáltatoi Igazolás\n " + "\n" + label.Text + "\n" + " \n" + " Nyomtatva a GotoStreet Alkalmazáson keresztül.";
            e.Graphics.DrawString(print, printFont,
                Brushes.Black, 10, 10);
        }
    }
}
