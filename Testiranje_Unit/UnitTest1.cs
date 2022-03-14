using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Predavanja_vaje_14_3;

namespace Testiranje_Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()//Imenuje se lahko poljubno 
        {
            string[] tab = { "Prvo", "Drugo", "Tretje" };
            string iti = DeloTabela.Vrni_iti_element(1, tab);
            string[] tab1 = { "1","2" };
            Assert.AreEqual(iti, "Drugo");
            string n = DeloTabela.Vrni_iti_element(1, tab1);
            Assert.AreEqual(n, "2");
        }
    }
}
