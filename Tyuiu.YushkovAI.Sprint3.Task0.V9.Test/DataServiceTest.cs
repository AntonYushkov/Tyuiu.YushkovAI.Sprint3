using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint3.Task0.V9.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckSigmaFunc()
        {
            double x = 0.5;

            int StartValue = 1;

            int StopValue = 15;

            double res = ds.GetSumSeries(x, StartValue, StopValue);

            Assert.AreEqual(0.430, res);
        }
    }
}