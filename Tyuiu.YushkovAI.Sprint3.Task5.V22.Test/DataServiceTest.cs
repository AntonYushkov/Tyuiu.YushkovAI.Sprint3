using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint3.Task5.V22.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckSigmaFunc()
        {
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(68.991, res);
        }

        [TestMethod]
        public void CheckDifferentRanges()
        {
            double res = ds.GetSumSumSeries(0, 2, 4, 3, 6);

            Assert.AreEqual(12.0, res);
        }
    }
}
