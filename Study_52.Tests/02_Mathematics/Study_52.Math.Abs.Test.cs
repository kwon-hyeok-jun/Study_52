using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Study_52.Tests.Mathematics
{
    [TestClass]
    public class Study_52MathTest
    {
        [TestMethod]
        public void AbsTest()
        {
            var expected = 1234;

            var actual = Study_52.Math.Abs(-1234);

            Assert.AreEqual(expected, actual);
        }
    }
}