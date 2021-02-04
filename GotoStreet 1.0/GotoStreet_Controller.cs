
using System;

namespace GotoStreet_1._0
{
    class GotoStreet_Controller
    {
        private string[] Ok = { "Munka", "Bevásárlás", "Orvos", "Gyógyszertár" };
        private readonly GotoStreetError error = new GotoStreetError();
        private readonly DateTime Date;
        private readonly string trying;
        
        private readonly int id;



        private bool CheckTry()
        {
            bool data = false;
            for (int i = 0; i < Ok.Length; i++)
            {
                if (trying == Ok[i])
                { data = true; }
            }

            if (!data)
            { error.TryingError(); }
            return data;

        }
        public GotoStreet_Controller(int ids,DateTime dateTime,string trys)
        {
            trying = trys;
            id = ids;
            Date = dateTime;

        }

        private bool CheckDate()
        {
            if (Date > DateTime.Now.Date)
            {
                return true;
            }
            else { error.DateError(); return false;  }
        }

        private bool CheckGo()
        {
            int Count = 0;
            var context = new gotoStreetEntities();
            foreach (var item in context.gotoStreet)
            {
                if (item.userid.Equals(id) && item.go_date.Equals(Date))
                { Count++; }
            }
            if (Count > 0)
            { error.GotoStreetErrors(); return false;  }
            else { return true; }
        }

        public bool FullCheck()
        {
            if (CheckDate() && CheckGo()&&CheckTry())
            { return true; }
            else { return false; }
        }

    }
}
