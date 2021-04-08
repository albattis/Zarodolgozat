using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GotoStreet_1._0_ControlStreet;
using System.Windows.Forms;

namespace UnitTestProjectGotoStreet_user
{
    /// <summary>
    /// Summary description for UnitTestGotoStreetPolice
    /// </summary>
    [TestClass]
    public class UnitTestGotoStreetPolice
    {
        public UnitTestGotoStreetPolice()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private readonly TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


    }

    [TestClass]

    public class ControlStreetUser_Test
    { 
    
        [TestMethod]

        public void ControlStreetUser_Const_Test()
        {

            
            String[] feltetel = new string[3];
            feltetel[0] = "Teszt László";
            feltetel[1] = "Teszt";
            feltetel[2] = "2";
            ControlStreetUser user;
            bool result;
            try { user = new ControlStreetUser(feltetel); result = true; }
            catch(Exception e) {
                MessageBox.Show(e.Message, "");
                result = false; }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UseWorkDataWrite_Test()
        {
            String[] feltetel = new string[3];
            feltetel[0] = "Teszt László";
            feltetel[1] = "Teszt";
            feltetel[2] = "2";
            ControlStreetUser user;
            bool result;
            try { user = new ControlStreetUser(feltetel);
                user.UserWorkDataWrite("Test");
                result = true; }
            catch (Exception) { result = false; }
            Assert.IsTrue(result);
            try
            {
                user = new ControlStreetUser(feltetel);
                user.UserWorkDataWrite("");
                result = true;
            }
            catch (Exception) { result = false; }
            Assert.IsTrue(result);
        }
    }

    [TestClass]

    public class LoginControlUser_Test
    {

        [TestMethod]
        public void Login_Test()
        {
            
            LoginControlUser test = new LoginControlUser("1","asdfghjk");
            LoginControlUser test2 = new LoginControlUser("1", "ewd");
            LoginControlUser test3 = new LoginControlUser("", "");
            LoginControlUser test4 = new LoginControlUser("", "asdfghjk");

            Assert.AreEqual(true, test.Successfully());
            Assert.AreEqual(false, test2.Successfully());
            Assert.AreEqual(false, test3.Successfully());
            Assert.AreEqual(false, test4.Successfully());
        }

        

    }


[TestClass]

    public class USerBoard_Test
    {
        [TestMethod]

        public void QuerySearch_Test()
        {
            string mode;
            string type;

            string[] feltetel = new string[3];
            feltetel[0] = "Teszt László";
            feltetel[1] = "Teszt";
            feltetel[2] = "2";
            mode = "1";
            type = "Id";
            bool result;
            ControlStreetUserboard us= new ControlStreetUserboard(feltetel);
            PrivateObject privatobj = new PrivateObject(us);
            Object obj;
            try
            { 
                obj = privatobj.Invoke("QuerySearch", type, mode);
                result = true;
            } catch (Exception) { result = false; }
            Assert.AreEqual(true,result );
            result = false;

            try
            {
                mode = "";
                type = "";
                obj = privatobj.Invoke("QuerySearch",type,mode);
                result=true;
            }catch (Exception) { result = false; }
            Assert.AreEqual(true, result);
            result = false;

            try
            {
                mode = "1";
                type = "as";
                obj = privatobj.Invoke("QuerySearch",type,mode);
                result = true;
            }
            catch (Exception) { result = false; }
            Assert.AreEqual(true, result);

           
        }

        [TestMethod]
        public void QueryTrue()
        {
            string[] feltetel = new string[3];
            feltetel[0] = "Teszt László";
            feltetel[1] = "Teszt";
            feltetel[2] = "2";
            bool result;
            ControlStreetUserboard us = new ControlStreetUserboard(feltetel);
            PrivateObject privatobj = new PrivateObject(us);
            Object obj;
            string status;
            int id;

            status = "Elfogadva";
            id = 1;
            try
            {
                obj = privatobj.Invoke("QueryTrue", status, id);
                result = true;
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "");
                result = false; }
            Assert.AreEqual(true, result);
            result = false;

            status = "Elutasitva";
            id = 1;
            try
            {
                obj = privatobj.Invoke("QueryTrue", status, id);
                result = true;
            }
            catch (Exception) { result = false; }
            Assert.AreEqual(true, result);
            result = false;


            status = "";
            id = 1;
            try
            {
                obj = privatobj.Invoke("QueryTrue", status, id);
                result = true;
            }
            catch (Exception) { result = false; }
            Assert.AreEqual(true, result);
            result = false;
        }
    }





}
