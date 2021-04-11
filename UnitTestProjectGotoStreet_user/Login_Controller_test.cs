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

        public void FullCheck_Test()
        {
            int id = 1;
            DateTime time = DateTime.Parse("2021.04.10");
            string trying = "Munka";
            GotoStreet_Controller control = new GotoStreet_Controller(id,time,trying);
            Assert.AreEqual(false, control.FullCheck());

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
            int id = 1;
            string mn = "Minta Anna";
            string icn = "111111AA";
            DateTime date = DateTime.Parse("1900.01.01");
            AuthenticatedNow now;

            Assert.IsNotNull( now = new AuthenticatedNow(id, mn, date, icn));
            id = 12;
            Assert.IsNotNull(now = new AuthenticatedNow(id, mn, date, icn));
            id = 13;
       
             id = 120;
             mn = "Minta Anna";
             icn = "111111AA";
             date = DateTime.Parse("1900.01.01");
            

            Assert.IsNotNull(now = new AuthenticatedNow(id, mn, date, icn));
            id = 12;
            Assert.IsNotNull(now = new AuthenticatedNow(id, mn, date, icn));
            id = 13;
            
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

    [TestClass]

    public class GotoStreetWriteDatabase_test
    {
        [TestMethod]

        public void Write_Test()
        {
            Label lab = new Label();

            lab.Text = "2021.04.05";
            TextBox tx = new TextBox();
            tx.Text = "2021.04.12";
            TextBox tb = new TextBox();
            tb.Text = "Munka";


            GotoStreetWriteDatabase g = new GotoStreetWriteDatabase();
            Assert.AreEqual(true,g.NewGotoStreetWrite(lab, tx, tb, 1));
            Assert.AreEqual(true, g.NewGotoStreetWrite(lab, tx, tb, 1));
        }
        
    }

    [TestClass]

    public class Print_Test
    {

        [TestMethod]

        public void PrintMethod_Test()
        {

            PrintClass p = new PrintClass();
            Label l = new Label();
            l.Text = "Sikeres nyomtatás";
            bool result = false;
            try
            {
                p.Print(l);
                result = true;
            }
            catch (Exception) { result = false; }

            Assert.IsTrue(result);
            

        }

    }
}
