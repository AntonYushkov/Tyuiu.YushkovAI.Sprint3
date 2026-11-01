using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint3.Task3.V3.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckTwoChar()
        {
            string value = "cvbmzff orffgtrr dkfvfffdr";
            int res = ds.GetMinCharCount(value, 'f');

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void CheckLastCharGroup()
        {
            int res = ds.GetMinCharCount("fffxff", 'f');

            Assert.AreEqual(2, res);
        }
    }
}
