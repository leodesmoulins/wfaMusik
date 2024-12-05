using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wfaMUSIK;
using System.Collections.Generic;

namespace UnitTestProjectMusik
{
    [TestClass]
    public class UnitTestCourCollectif
    {
        CourCollectif unCourCollectif = new CourCollectif(4, 18, new List<Jour>(), "apprentissage du piano", 25, 10);

        [TestMethod]
        public void testDescription()
        {
           
        }
    }
}
