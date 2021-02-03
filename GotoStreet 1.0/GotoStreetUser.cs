using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoStreet_1._0
{
    class GotoStreetUser
    {
        #region fields
        private int Id { get; set; }
        private string Firstname { get; set; }
        private string Lastname { get; set; }
        private int Zip { get; set; }
        private string City { get; set; }
        private string Street { get; set; }
        private string Place { get; set; }
        private string Housenumber { get; set; }
        #endregion

        #region Get; Set;


        public int Ids { get { return Id; } set { Id = value; } }
        public string Firstnames { get { return Firstname; } set { Firstname = value; } }
        public string Lastnames { get { return Lastname; } set { Lastname = value; } }

        public int Zips { get { return Zip; } set { Zip = value; } }
        public string Citys { get { return City; } set { City = value; } }
        public string Streets { get { return Street; } set { Street = value; } }
        public string Places { get { return Place; } set { Place = value; } }
        public string Housenumbers { get { return Housenumber; } set { Housenumber = value; } }

        #endregion

        public GotoStreetUser()
        { 
        
        }
    }
}
