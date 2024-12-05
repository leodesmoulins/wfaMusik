using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wfaMUSIK;

namespace UnitTestProjectMusik
{
    [TestClass]
    public class UnitTestJour
    {
        Jour unJour = new Jour(1, "Lundi");


        [TestMethod]
        public void TestContructeur()
        {
            Assert.AreEqual(1, unJour.Id, "Prob initialisation indentifiant");
            Assert.AreEqual("Lundi", unJour.Libelle, "Prob initialisation indentifiant");
        }

        [TestMethod]
        public void TestSetterLibelle()
        {
            unJour.Libelle = "Mardi";

            Assert.AreEqual("Mardi", unJour.Libelle, "pb setter Libelle");
        }
    }
}
