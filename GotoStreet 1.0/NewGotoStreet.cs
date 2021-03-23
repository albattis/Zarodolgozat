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
           GotoStreetWriteDatabase GSDW = new GotoStreetWriteDatabase();
           GotoStreetError Error = new GotoStreetError();

            if (GSDW.NewGotoStreetWrite(Go_Label_date, TextBox_Date, TextBox_where, id))
            { Error.Sucessfull_go(); }
        }
        private void Escape_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
