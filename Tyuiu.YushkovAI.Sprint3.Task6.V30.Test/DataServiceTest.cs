using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint3.Task6.V30.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void SummaDeliteliNum()
        {
            int res = ds.GetSumTheDivisors(11, 17);

            Assert.AreEqual(25, res);
        }

        [TestMethod]
        public void CheckSingleNumber()
        {
            int res = ds.GetSumTheDivisors(16, 16);

            Assert.AreEqual(5, res);
        }
    }
}
