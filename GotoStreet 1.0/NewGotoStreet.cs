using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    public partial class NewGotoStreet : Form
    {
       private readonly GotoStreetError Error = new GotoStreetError();
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
            GotoStreet_Controller GSC = new GotoStreet_Controller(id,DateTime.Parse(TextBox_Date.Text),TextBox_where.Text);
            string status;
            if (GSC.FullCheck())
            { status = "Elfogadva"; }
            else { status = "Elutasitva"; }
                try
                {
                    gotoStreet gotoStreet = new gotoStreet
                    {
                        userid = id,
                        record_date = DateTime.Parse(Go_Label_date.Text),
                        go_date = DateTime.Parse(TextBox_Date.Text),
                        cel = TextBox_where.Text.Trim(),
                        status = status
                    };
                    gotoStreet gt = gotoStreet;
                    var context = new gotoStreetEntities1();
                    context.gotoStreet.Add(gt);
                    context.SaveChanges();
                Error.Sucessfull_go();   
                }
                catch (SqlException) { }
            
        }
        private void Escape_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
