using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0_ControlStreet
{
    class ControlStreetMessage
    {

        public void Authenticated_Success()
        {
            MessageBox.Show("Sikeres felhasználó hitelesités", "Hitelesités", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void InserSuccess(int id)
        {
            string text = "Felhasználónév: " + id+" Jelszó: A Választott jelszó.";
            MessageBox.Show(text, "Bejelentkezési adatok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UsernameError()
        {
            MessageBox.Show("Hibás felhasználónevet adott meg","Bejelentkezési hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public void PasswordError()
        {
            MessageBox.Show("Hibás jelszavat adott meg", "Bejelentkezési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void GoErrors()
        {
            MessageBox.Show("Nem jó feltételt adott meg.", "Szürési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void InsertError()
        {
            MessageBox.Show("Nem sikerült az új felhasználó rögzitése.", "Regisztrációs Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void InsertSuccessfull()
        {
            MessageBox.Show("Sikeres regisztráció", "Regisztráció", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void DataError()
        {
            MessageBox.Show("Nem adott meg elegendö adatot.", "Adathiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void FormatException()
        {
            MessageBox.Show("Nem megfelelő Id-t adott meg", "Konvertálási Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        internal void NotFoundAuthenticate()
        {
            MessageBox.Show("Nincs Hitelesitendö felhasználó", "Keresés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
