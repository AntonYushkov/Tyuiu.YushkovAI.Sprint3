using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YushkovAI.Sprint3.Task7.V29.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void FuncTest()
        {
            double[] res = ds.GetMassFunction(-5, 5);
            double[] res_wait = { -32.26, -27.50, -22.80, -17.95, -12.97, -9.00,
                                  -0.31, 3.77, 8.57, 13.42, 18.28 };

            CollectionAssert.AreEqual(res_wait, res);
        }

        [TestMethod]
        public void CheckPositiveRange()
        {
            double[] res = ds.GetMassFunction(1, 3);
            double[] res_wait = { -0.31, 3.77, 8.57 };

            CollectionAssert.AreEqual(res_wait, res);
        }
    }
}
