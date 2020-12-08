using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathNet.Numerics.Financial;
using NUnit.Framework;
using MathNet.Numerics;
using Assert = NUnit.Framework.Assert;

namespace MusuUnitTestai
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
        [TestCase(new double[] { 5, 4, 3, 0, 2 }, "5 + 4x + 3x^2 + 2x^4")]
        [TestCase(new double[0], "0")]
        [TestCase(new double[] { 0, 4, 3, 0, 0 }, "4x + 3x^2")]
        [TestCase(new double[] { 0, -4, 3 }, "-4x + 3x^2")]
        [TestCase(new double[] { 0, -4, -3 }, "-4x - 3x^2")]
        [TestCase(new double[] { 0, 4, -3 }, "4x - 3x^2")]
        public void ToStringTest(double[] x, string expected)
        {
            var p = new Polynomial(x);
            Assert.AreEqual(expected, p.ToString());
        }
    }
}
