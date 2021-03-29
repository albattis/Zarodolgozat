using System.Windows.Forms;

namespace GotoStreet_1._0_Company
{
    class ErrorMessage
    {
        public void LoginError()
        {
            MessageBox.Show("Rossz felhasználónév vagy jelszó!","Bejelentkezési Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public void SqlError()
        {
            MessageBox.Show("Nem lehet csatlakozni az adatbázishoz", "Elérési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SuccessCertification()
        {
            MessageBox.Show("Sikeres a Kijárási dokumentum elküldése","Kijárási igazolás",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void UnSuccessCertification()
        {
            MessageBox.Show("Sikertelen a Kijárási dokumentum elküldése", "Kijárási igazolás",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public void DeleteCertification()
        {
            MessageBox.Show("Sikeresen törölte a dolgozó kijárási igazolását.", "Törlés megerösités", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
