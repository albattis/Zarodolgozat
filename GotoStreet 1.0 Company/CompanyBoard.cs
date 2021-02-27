using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0_Company
{
    public partial class CompanyBoard : Form
    {

        private int CompId { get; set; }
        public int CompanyId { get { return CompId; }set { CompId = value; } }
        CertificationControl Certification = new CertificationControl();

        public CompanyBoard(int id)
        {
            InitializeComponent();
            CompId = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { Certification.CertificationControlId(int.Parse(Id_textbox.Text)); }
            catch (FormatException) { Return_label.ForeColor = System.Drawing.Color.Red;Return_label.Text = "Nem létező ID!"; }
            if (Certification.IdsControl)
            {
                Return_label.ForeColor = System.Drawing.Color.Green; Return_label.Text = "Létező ID!";
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Certification.IdsControl = false;
            Id_textbox.Text = "";
            Return_label.Text = "Adatok törölve.";
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            Certification.InsertControl(CompanyId);
            if (Certification.InsContr)
            {
                MessageBox.Show("Sikeres a Kijárási dokumentum elküldése");
            }
            else {
                MessageBox.Show("Sikertelen a Kijárási dokumentum elküldése");
            }
        }

        private void delete_certificate_Click(object sender, EventArgs e)
        {
            if (Certification.Delete_Certification())
            {
                MessageBox.Show("Sikeresen törölte a dolgozó kijárási igazolását.", "Törlés megerösités", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
