using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wfaMUSIK;
using System.Collections.Generic;

namespace UnitTestProjectMusik
{
    [TestClass]
    public class UnitTestCours
    {
        
        Cours unCours = new Cours(1, 18, new List<Jour>());

        [TestMethod]
        public void TestConstructeur()
        {
            Assert.AreEqual(1, unCours.identifiant, "Prob initialisation indentifiant");
            
        }

        public void testLieuleJour()
        {
            Assert.AreEqual(true, unCours.aLieuLeJour(""), "Prob methode");
        }
    }
}
