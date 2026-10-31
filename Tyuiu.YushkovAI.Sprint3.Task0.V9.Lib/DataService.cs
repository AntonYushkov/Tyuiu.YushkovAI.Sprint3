using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YushkovAI.Sprint3.Task0.V9.Lib
{
    public class DataService : ISprint3Task0V9
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                res = res + Math.Pow(
                    1.0 / (3.0 + Math.Pow(value, i)),
                    i
                );
            }

            return Math.Round(res, 3);
        }
    }
}