using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    interface IGotoStreetErrors
    {
        void LoginnameError();
        void PasswordError();
    }

   class GotoStreetError : IGotoStreetErrors
    {

        public void LoginnameError()
        {
            MessageBox.Show("Hibás Felhasználónevet adott meg.","Bejelentkezési Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void PasswordError()
        {
            MessageBox.Show("Hibás Jelszót adott meg.", "Bejelentkezési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DateError()
        {
            MessageBox.Show("Nem megfelelö dátumot adott meg.", "Beviteli Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void FileNootFound()
        {
            MessageBox.Show("Nem sikerült a képet megjelenteni.", "Beolvasási kisérlet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void GotoStreetErrors()
        {
            MessageBox.Show("Nem lehet a megadott napra kijárást rögziteni.", "Rögzitési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void TryingError() {
            MessageBox.Show("Nem megfelelö indokot választott,vagy elirási hiba lépett fel", "Kijárási cél Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void PasswordContainsError()
        {
            MessageBox.Show("Nem egyezik a két jelszó.", "Jelszó Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void PasswordLenghtError()
        {
            MessageBox.Show("Nem elég hosszó a jelszó.", "Jelszó Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Registration_nameError()
        {
            MessageBox.Show("Nem töltötte ki a név mezö(ket).", "Regisztráció Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Registration_cityError()
        {
            MessageBox.Show("Nem töltött ki minden mezöt a lakcimre vonatkozóan.", "Regisztráció Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void Registration_formatError()
        {
            MessageBox.Show("Nem megfelelöen töltötte ki a mezőket.", "Regisztráció Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        internal void Registration_Error()
        {
            MessageBox.Show("Hiba lépet fel az adatmetés közben.", "Regisztráció Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        internal void Successfull_Registration()
        {
            MessageBox.Show("Sikeres Regisztráció.", "Regisztráció", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Sucessfull_go()
        {
            MessageBox.Show("Sikeres Kijárási kérelem.", "Kijárás", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
