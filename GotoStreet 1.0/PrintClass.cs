using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    class PrintClass
    {
        private System.Drawing.Printing.PrintDocument docToPrint;
        Label label;
        public void Print(Label labels)
        {

            label = labels;

            docToPrint = new System.Drawing.Printing.PrintDocument();
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

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font printFont = new System.Drawing.Font
        ("Arial", 16, System.Drawing.FontStyle.Regular);

            string print = "Munkáltatoi Igazolás\n " + "\n" + label.Text + "\n" + " \n" + " Nyomtatva a GotoStreet Alkalmazáson keresztül.";
            e.Graphics.DrawString(print, printFont,
                System.Drawing.Brushes.Black, 10, 10);
        }
    }
}
