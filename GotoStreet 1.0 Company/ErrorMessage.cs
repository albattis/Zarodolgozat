using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoStreet_1._0_Company
{
    class ErrorMessage
    {
        public void LoginError()
        {
            MessageBox.Show("Rossz felhasználónév vagy jelszó!","Bejelentkezési Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
