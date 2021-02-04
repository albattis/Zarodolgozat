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

        public void GotoStreetErrors()
        {
            MessageBox.Show("Nem lehet a megadott napra kijárást rögziteni.", "Rögzitési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void TryingError() {
            MessageBox.Show("Nem megfelelö indokot választott,vagy elirási hiba lépett fel", "Kijárási cél Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
