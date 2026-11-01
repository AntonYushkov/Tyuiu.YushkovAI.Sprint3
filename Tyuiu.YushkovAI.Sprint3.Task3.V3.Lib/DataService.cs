using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YushkovAI.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            int minCount = 0;

            foreach (char c in value)
            {
                if (c == item)
                {
                    count++;
                }
                else
                {
                    if (count > 0 && (minCount == 0 || count < minCount))
                    {
                        minCount = count;
                    }
                    count = 0;
                }
            }

            if (count > 0 && (minCount == 0 || count < minCount))
            {
                minCount = count;
            }

            return minCount;
        }
    }
}
