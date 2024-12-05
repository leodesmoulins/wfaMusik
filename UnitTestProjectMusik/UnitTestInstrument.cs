using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wfaMUSIK;

namespace UnitTestProjectMusik
{
    [TestClass]
    public class UnitTestInstrument
    {
        Instrument unInstrument = new Instrument(1, "violon");


        [TestMethod]
        public void TestConstructeur()
        {
            Assert.AreEqual(1, unInstrument.idInstru, "Prob initialisation indentifiant");
            Assert.AreEqual("violon", unInstrument.Intitule, "Prob initialisation libellé");
        }

        [TestMethod]
        public void TestSetterIntitule()
        {
            unInstrument.Intitule = "guitare";

            Assert.AreEqual("guitare", unInstrument.Intitule, "pb setter Intitule");
        }
    }
}
