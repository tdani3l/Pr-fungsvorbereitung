using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using uebung_3;

namespace uebung_3_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Napoletana pizza1 = new Napoletana();
            pizza1.AddTopping(new Käse());
            pizza1.AddTopping(new Spinat());

            Assert.AreEqual(9.6m, pizza1.getPrice());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Chicago pizza2 = new Chicago(8m);
            pizza2.AddTopping(new Ananas());
            pizza2.AddTopping(new Ananas());
            pizza2.AddTopping(new Ananas());

            Assert.AreEqual(9.5m, pizza2.getPrice());
        }
    }
}
