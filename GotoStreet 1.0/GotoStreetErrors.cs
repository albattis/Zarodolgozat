using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0
{
    interface GotoStreetErrors
    {
        void LoginnameError();
        void PasswordError();
    }

   class GotoStreetError : GotoStreetErrors
    {

        public void LoginnameError()
        {
            MessageBox.Show("Hibás Felhasználónevet adott meg.","Bejelentkezési Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void PasswordError()
        {
            MessageBox.Show("Hibás Jelszót adott meg.", "Bejelentkezési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
