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
}
