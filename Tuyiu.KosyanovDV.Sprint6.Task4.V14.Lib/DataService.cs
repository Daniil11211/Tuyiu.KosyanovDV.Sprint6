using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tuyiu.KosyanovDV.Sprint6.Task4.V14.Lib
{
    public class DataService : ISprint6Task4V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;

            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];

            double y = 0;

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1))), 2);

                if (double.IsInfinity(y) || double.IsNaN(y))
                {
                    valueArray[count] = 0;
                    count++;
                }
                else
                {
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }
            }

            return valueArray;
        }
    }
}
