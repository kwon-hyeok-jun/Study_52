using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Study_52.Tests
{
    [TestClass]
    public class CreatorTest
    {
        [TestMethod]
        public void GetNameTest()
        {
            const string expected = "RedPlus";

            var actual = Creator.GetName();

            Assert.AreEqual(expected, actual);
        }
    }
}