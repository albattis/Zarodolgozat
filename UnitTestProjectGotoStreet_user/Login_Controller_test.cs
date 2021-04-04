using System;
using System.Windows.Forms;
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
            string variacio = "1";
            string variacioketto = "2";
            Assert.AreEqual(false, Lg.Login(variacio, variacioketto));

            variacio = "1";
            variacioketto = "asdfghjk";
            Assert.AreEqual(true, Lg.Login(variacio, variacioketto));

            variacio = "";
            Assert.AreEqual(false, Lg.Login(variacio, variacioketto));

            variacio = "";
            variacioketto = "asdfghjk";
            Assert.AreEqual(false, Lg.Login(variacio, variacioketto));

            variacio = "1";
            variacioketto = "";
            Assert.AreEqual(false, Lg.Login(variacio, variacioketto));
        }
    }

    [TestClass]
    public class PaswordHash_test
    {
        [TestMethod]
        public void XSHA256_test()
        {
            PasswordHash po = new PasswordHash();
            PrivateObject Po = new PrivateObject(po);

            object obj = Po.Invoke("XSha256","2");
            Assert.IsNotNull(obj,"Sikeres");
            Assert.AreEqual("d4735e3a265e16eee03f59718b9b5d03019c07d8b6c51f90da3a666eec13ab35", obj);

            obj = Po.Invoke("XSha256", "@&[]^˘$ß\\äđĐ");
            Assert.IsNotNull(obj, "Sikeres");
            Assert.AreEqual("4e40cfb7e40c24314309cfdbace4dfea2aa0fb3dbc7483a6ffcdd4a6831fd30c",obj );

            obj = Po.Invoke("XSha256", "");
            Assert.IsNotNull(obj, "Sikeres");
            Assert.AreEqual((string) obj,"");

            obj = Po.Invoke("XSha256", "asdfghjk");
            Assert.AreEqual("5be0888bbe2087f962fee5748d9cf52e37e4c6a24af79675ff7e1ca0a1b12739", (string)obj);

        }
        [TestMethod]
        public void Sha256_test()
        {
            PasswordHash Ps = new PasswordHash();
            Ps.Sha256("");
            Assert.AreEqual("5be0888bbe2087f962fee5748d9cf52e37e4c6a24af79675ff7e1ca0a1b12739", Ps.Sha256("asdfghjk"));
            Assert.AreEqual("4e40cfb7e40c24314309cfdbace4dfea2aa0fb3dbc7483a6ffcdd4a6831fd30c",Ps.Sha256("@&[]^˘$ß\\äđĐ"));


        }


    }

    [TestClass]
    public class GotoStreet_Controller_test
    {
        [TestMethod]

        public void CheckTry_Test()
        {
            DateTime date = DateTime.Parse("2021.12.12");
            int id = 1;
            string trys = "Munka";
            GotoStreet_Controller gc = new GotoStreet_Controller(id, date, trys);
            PrivateObject Gcobj = new PrivateObject(gc);
            object obj = Gcobj.Invoke("CheckTry");
            Assert.AreEqual(true, (Boolean)obj);

            gc = new GotoStreet_Controller(id, date, "Bevásárlás");
            Gcobj = new PrivateObject(gc);
            obj = Gcobj.Invoke("CheckTry");
            Assert.AreEqual(true, (Boolean)obj);

            gc = new GotoStreet_Controller(id, date, "bevásárlás");
            Gcobj = new PrivateObject(gc);
            obj = Gcobj.Invoke("CheckTry");
            Assert.AreEqual(false, (Boolean)obj);

            gc = new GotoStreet_Controller(id, date, "");
            Gcobj = new PrivateObject(gc);
            obj = Gcobj.Invoke("CheckTry");
            Assert.AreEqual(false, (Boolean)obj);


            gc = new GotoStreet_Controller(id, date, "Orvos");
            Gcobj = new PrivateObject(gc);
            obj = Gcobj.Invoke("CheckTry");
            Assert.AreEqual(true, (Boolean)obj);

            gc = new GotoStreet_Controller(id, date, "Gyógyszertár");
            Gcobj = new PrivateObject(gc);
            obj = Gcobj.Invoke("CheckTry");
            Assert.AreEqual(true, (Boolean)obj);
        } //Jegyzökönyvezve

        [TestMethod]

        public void CheckDate_Test()
        {
            DateTime date = DateTime.Parse("2021.12.12");
            int id = 1;
            string trys = "Munka";

            PrivateObject objectes = new PrivateObject(typeof(GotoStreet_Controller), id, date, trys);
            bool result = Convert.ToBoolean(objectes.Invoke("CheckDate"));
            Assert.AreEqual(true, result);


            date = DateTime.Parse("1111.11.11");
            objectes = new PrivateObject(typeof(GotoStreet_Controller), 1, date, trys);
            result = Convert.ToBoolean(objectes.Invoke("CheckDate"));
            Assert.AreEqual(false, result);


        } //Jegyzőkőnyvezve.
        [TestMethod]
        public void CheckGo_Test()
        {
            int id = 1;
            DateTime date = DateTime.Parse("2021.04.11");
            string trys = "Orvos";
            PrivateObject obj = new PrivateObject(typeof(GotoStreet_Controller), id, date, trys);
            bool result = Convert.ToBoolean(obj.Invoke("CheckGo"));
            Assert.AreEqual(true, result);

            date = DateTime.Parse("2021.02.10");
            obj = new PrivateObject(typeof(GotoStreet_Controller), id, date, trys);
            result = Convert.ToBoolean(obj.Invoke("CheckGo"));
            Assert.AreEqual(false, result);
        } //Jegyzőkőnyvezve.

        [TestMethod]

        public void FullCheck_Test()
        {
            int id = 1;
            DateTime time = DateTime.Parse("2021.04.10");
            string trying = "Munka";
            GotoStreet_Controller control = new GotoStreet_Controller(id,time,trying);
            Assert.AreEqual(true, control.FullCheck());

            time = DateTime.Parse("2021.02.10");


            control = new GotoStreet_Controller(id, time, trying);
            Assert.IsFalse( control.FullCheck());

            trying = "blabla";
            time = DateTime.Parse("2021.04.30");
            control = new GotoStreet_Controller(id, time, trying);
            Assert.IsFalse(control.FullCheck());

        } //Jegyzökönyvezve
    }// Kész

    [TestClass]
    public class AuthenticatedNow_Test
    { 
    [TestMethod]
        public void AuthemticatedNow_Testes()
        {
            int id = 120;
            string mn = "Minta Anna";
            string icn = "111111AA";
            DateTime date = DateTime.Parse("1900.01.01");
            AuthenticatedNow now;

            Assert.IsNotNull( now = new AuthenticatedNow(id, mn, date, icn));
            id = 12;
            Assert.IsNotNull(now = new AuthenticatedNow(id, mn, date, icn));
            id = 13;
            PrivateObject obj = new PrivateObject(typeof(AuthenticatedNow), id,mn, date,icn);
            id = 17;
            bool result = Convert.ToBoolean(obj.Invoke("Authenticate",id,mn,date,icn));
            Assert.AreNotEqual(true, result);

             id = 120;
             mn = "Minta Anna";
             icn = "111111AA";
             date = DateTime.Parse("1900.01.01");
            

            Assert.IsNotNull(now = new AuthenticatedNow(id, mn, date, icn));
            id = 12;
            Assert.IsNotNull(now = new AuthenticatedNow(id, mn, date, icn));
            id = 13;
            obj = new PrivateObject(typeof(AuthenticatedNow), id, mn, date, icn);
            id = 18;
            result = Convert.ToBoolean(obj.Invoke("Authenticate", id, mn, date, icn));
            Assert.AreEqual(false, result);

        }

    }

    [TestClass]
    public class GotoStreetRegistration_Test
    {
        [TestMethod]

        public void GotoStreetRegistration_Construktor_Test()
        {
            TextBox fn = new TextBox();
            TextBox ln = new TextBox();
            TextBox zip = new TextBox();
            TextBox city = new TextBox();
            TextBox street = new TextBox();
            TextBox place = new TextBox();
            TextBox housenumber = new TextBox();
            TextBox pass = new TextBox();
            TextBox repass = new TextBox();

            fn.Text = "Minta";
            ln.Text = "Aladár";
            zip.Text = "1171";
            city.Text = "Budapest";
            street.Text = "Sáránd";
            place.Text = "Utca";
            housenumber.Text = "2";
            pass.Text = "asdfghjk";
            repass.Text="asdfghjk";

            GotoStreetRegistation gs = new GotoStreetRegistation(
                fn, ln, zip, city, street, place, housenumber, pass, repass);

            PrivateObject obj = new PrivateObject(gs);
            bool result = Convert.ToBoolean(obj.Invoke("Controll"));
            Assert.AreEqual(true, result);

            result = Convert.ToBoolean(obj.Invoke("PasswordControll"));
            Assert.AreEqual(true, result);

            repass.Text = "asdfghjks";
             gs = new GotoStreetRegistation(
               fn, ln, zip, city, street, place, housenumber, pass, repass);
            result = Convert.ToBoolean(obj.Invoke("PasswordControll"));
            Assert.AreEqual(false, result);

            place.Text = "";
            gs = new GotoStreetRegistation(
              fn, ln, zip, city, street, place, housenumber, pass, repass);

            result = Convert.ToBoolean(obj.Invoke("Controll"));
            Assert.AreEqual(false, result);

            Assert.AreEqual(false,gs.Registration());

            place.Text = "utca";
            repass.Text = "asdfghjk";
            Assert.AreEqual(true, gs.Registration());

        }

    } //Jegyzökönyvezve
   

  
}
