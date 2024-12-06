using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tuyiu.KosyanovDV.Sprint6.Task0.V17.Lib
{
    public class DataService : ISprint6Task0V17
    {
        public double Calculate(int x)
        {
            return Math.Round(((Math.Pow(2.718281828459045, x)) / (x)), 3);
        }
    }
}
