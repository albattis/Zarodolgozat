using GotoStreet_1._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectGotoStreet_user
{
    [TestClass]
    public class Login_Controller_test
    {
        [TestMethod]
        public void LoginController_test()
        {
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

}
