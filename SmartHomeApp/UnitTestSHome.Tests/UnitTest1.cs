using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHomeApp;
using System;
using System.Diagnostics;

namespace UnitTestSHome.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //public void TestMethod1()
        //{
        //    throw new Exception("Testi epäonnistui, arvon tarkastus ei toimi!");
        //}
        public void TestSauna() 
        {
            Sauna testiSauna = new Sauna();
            testiSauna.Aste = 1;
            try
            {
                testiSauna.Aste = 101;
                Assert.Fail("*Poikkeuksen nosto epäonnistui*");
            }
            catch (ArgumentOutOfRangeException)
            {
                Debug.WriteLine("*Nyt meni oikein*");
            }
        }
    }
}
