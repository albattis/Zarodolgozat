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
    }
}
