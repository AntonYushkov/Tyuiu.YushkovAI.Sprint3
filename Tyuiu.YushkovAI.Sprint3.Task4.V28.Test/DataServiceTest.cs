using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint3.Task4.V28.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void FuncExample()
        {
            double res = ds.Calculate(-5, 5);

            Assert.AreEqual(1.924, res);
        }

        [TestMethod]
        public void CheckSkipZero()
        {
            double res = ds.Calculate(-1, 1);

            Assert.AreEqual(1.683, res);
        }
    }
}
