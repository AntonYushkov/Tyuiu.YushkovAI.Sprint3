using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YushkovAI.Sprint3.Task7.V29.Lib
{
    public class DataService : ISprint3Task7V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] res = new double[length];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) - 2 * x;

                if (denominator == 0)
                {
                    res[index] = 0;
                }
                else
                {
                    res[index] = Math.Round((2 * x - 3) / denominator + 5 * x - 6, 2);
                }

                index++;
            }

            return res;
        }
    }
}
