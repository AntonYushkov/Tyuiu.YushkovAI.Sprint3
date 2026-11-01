using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint3.Task1.V20.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckSigmaExample()
        {
            int startValue = 1;
            int stopValue = 16;

            double res = ds.GetSumSeries(startValue, stopValue);
            double res_wait = 51191.405;

            Assert.AreEqual(res_wait, res);
        }
    }
}
