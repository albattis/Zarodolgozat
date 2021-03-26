using System.Security.Cryptography;
using System.Text;

namespace GotoStreet_1._0
{
    class PasswordHash
    {

        public string Sha256(string x)
        {
            string y = "";
           y= XSha256(x);
            return y;
        }

        private string XSha256(string randomString)
        {
            var crypt = new SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

    }
}
