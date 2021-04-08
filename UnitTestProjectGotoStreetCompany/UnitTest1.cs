
using System;
using System.Windows.Forms;
using GotoStreet_1._0_Company;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectGotoStreetCompany
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    [TestClass]

    public class CertificationControl_Test
    {
        [TestMethod]

        public void CertificationControls_Test()
        {
            CertificationControl c = new CertificationControl();
            c.CertificationControlId(1);
            Assert.AreEqual(true, c.IdsControl);
            c.InsertControl(1);
            Assert.AreEqual(false, c.InsContr);
        }

        [TestMethod]

        public void CompanyContollerLogin_All_Test()
        {
            string loginname;
            string pass;

            CompanyController test;
            CompanyController test2;
            CompanyController test3;
            CompanyController test4;
            CompanyController test5;

            loginname = "1";
            pass = "asdfghjk";
            test = new CompanyController(loginname, pass);
            Assert.AreEqual(true,test.ReturnLogin());

            loginname = "11";
            pass = "asdfghjk";
            test2 = new CompanyController(loginname, pass);
            Assert.AreEqual(false,test2.ReturnLogin());

            loginname = "1";
            pass = "asfghjk";
            test3 = new CompanyController(loginname, pass);
            Assert.AreEqual(false, test3.ReturnLogin());

            loginname = "1";
            pass = "";
            test4 = new CompanyController(loginname, pass);
            Assert.AreEqual(false, test4.ReturnLogin());

            loginname = "";
            pass = "asdfghjk";
            test5 = new CompanyController(loginname, pass);
            Assert.IsFalse(test5.ReturnLogin());
        }

        [TestMethod]

        public void CompanyInsert()
        {
            int testid = 1;
            
            CertificationControl testcontrol = new CertificationControl();
            testcontrol.CertificationControlId(testid);
            testcontrol.InsertControl(testid);
            
            Assert.AreEqual(true, testcontrol.InsContr);
        }
        [TestMethod]
        public void CompanyDelete()
        {
            int id = 1;
            
            CertificationControl Teszt = new CertificationControl();
            Teszt.CertificationControlId(id);
            bool result = true;
            try
            {
                Teszt.Delete_Certification();
            }
            catch (Exception e) { result = false; }
            Assert.AreEqual(true, result);
            id = 1;
            
             Teszt = new CertificationControl();
            Teszt.CertificationControlId(id);
            result = true;
            try
            {
                Teszt.Delete_Certification();
            }
            catch (Exception e) { result = false; }
            Assert.AreEqual(false, result);

        }
    }



}


