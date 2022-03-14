using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTest;

namespace MathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
        {
             BasicMaths bm = new BasicMaths();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        public void Test_SubtractionMethod()
        {
            BasicMaths bm = new BasicMaths(); ;
            double res = bm.Subtract(10, 10);
            Assert.AreEqual(res, 0);
        }
        public void Test_DivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        public void Test_MultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
