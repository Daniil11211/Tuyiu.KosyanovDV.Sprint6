using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tuyiu.KosyanovDV.Sprint6.Task7.V21.Lib
{
    public class DataService : ISprint6Task7V21
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {

                    if (double.TryParse(values[j], NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {
                        array[i, j] = Convert.ToInt32(number);
                    }

                    if (array[i, 7] != 5)
                    {
                        array[i, 7] = -1;
                    }
                }
            }

            return array;
        }
    }
}
