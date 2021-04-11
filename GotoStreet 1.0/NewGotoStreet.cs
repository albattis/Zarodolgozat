using System;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    public partial class NewGotoStreet : Form
    {
       
        private readonly int id;

        public NewGotoStreet(string fn, string ln, int ids)
        {
            InitializeComponent();

            Firstname_label_write.Text = fn;
            Lastname_label_write.Text = ln;
            Go_Label_date.Text = DateTime.Now.ToString();
            id = ids;

        }

        private void Button_write_Click(object sender, EventArgs e)
        {
            GotoStreetError Error = new GotoStreetError();
            DateTime record_date = DateTime.Parse("2000.01.01");
            DateTime go_Date= DateTime.Parse("2000.01.01"); 
            string where="";
            try
            {
                record_date = DateTime.Parse(Go_Label_date.Text);
                go_Date = DateTime.Parse(TextBox_Date.Text);
                where = TextBox_where.Text;
            }
            catch(FormatException)
            {
                Error.FormatException();
            }


           GotoStreetWriteDatabase GSDW = new GotoStreetWriteDatabase();
           
           
            if (GSDW.NewGotoStreetWrite(record_date, go_Date, where, id))
            { Error.Sucessfull_go(); }
        }
        private void Escape_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
