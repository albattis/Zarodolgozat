using System;
using GotoStreet_1._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectGotoStreet_user
{
    [TestClass]
    public class Login_Controller_test
    {
        [TestMethod]
        public void LoginController_test()
        {//LoginController osztály nem tartalmaz több metodust.
            LoginController Lg = new LoginController();
            Assert.AreEqual(false, Lg.Login("1", "1"));
            Assert.AreEqual(true, Lg.Login("1", "asdfghjk"));
            Assert.AreEqual(false, Lg.Login("", ""));
        }
    }

    [TestClass]
    public class PaswordHash_test
    {
        [TestMethod]
        public void SHA256_test()//Ez az egy fügvény volr a PasswordHash osztályban.
        {
            PasswordHash Ph = new PasswordHash();
            Assert.AreEqual("265fda17a34611b1533d8a281ff680dc5791b0ce0a11c25b35e11c8e75685509", Ph.Sha256("'"));

        }
    }

    [TestClass]
    public class GotoStreet_Controller_test
    {
        
        [TestMethod]
        public void GotoStreet_Controller_testmethod()
        {
            GotoStreet_Controller Comt = new GotoStreet_Controller(1,DateTime.Parse("2021.12.01"),"Munka");
            Assert.AreEqual(true, Comt.FullCheck());
           
            Comt = new GotoStreet_Controller(1, DateTime.Parse("2021.12.01"), "asd");
            Assert.AreEqual(false,Comt.FullCheck());

            
        }
    }

    [TestClass]

    public class AuthenticatedNow_Test
    {
        [TestMethod]
        public void AutheticatedNowTest()
        {
          /* int id;
            string mn;
            string date;
            string icn;
            AuthenticatedNow authenticatedNow;

            //Egy meglévö ügyfél beirása a hitelesitési táblába
            id = 3;
            mn = "Minta Minta";
            date = "1999.12.31";
            icn = "ABCDEF12";
            Assert.AreEqual(expected:true, authenticatedNow = new AuthenticatedNow(id, mn, DateTime.Parse(date), icn)); ;
        */
        }


    }

}
