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
        private string name;
        private string BossName;
        private int Adoszam;
        public int CompanyId { get { return CompId; }set { CompId = value; } }

        readonly CertificationControl Certification = new CertificationControl();

        private void CompanyData()
        {
            using (var context = new Company_registerEntities1())
            {
                foreach (var item in context.Company)
                    if (item.company_id.Equals(CompId))
                    {
                        name = item.name;
                        BossName = item.Company_manager;
                        Adoszam = item.adoszam;
                    }

            }
        }


        public CompanyBoard(int id)
        {
            InitializeComponent();
            CompId = id;
            CompanyData();
            Company_information.Text = "Cég adatai: Név: " + name + "\n Adószám: " + Adoszam + "\n Cégvezetö neve: " + BossName; ;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try { Certification.CertificationControlId(int.Parse(Id_textbox.Text)); }
            catch (FormatException) { Return_label.ForeColor = System.Drawing.Color.Red;Return_label.Text = "Nem létező ID!"; }
            if (Certification.IdsControl)
            {
                Return_label.ForeColor = System.Drawing.Color.Green; Return_label.Text = "Létező ID!";
                Insert_button.Visible = true;
            }
            else
            {
                Insert_button.Visible = false;
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

        private void Delete_certificate_Click(object sender, EventArgs e)
        {
            if (Certification.Delete_Certification())
            {
                MessageBox.Show("Sikeresen törölte a dolgozó kijárási igazolását.", "Törlés megerösités", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
