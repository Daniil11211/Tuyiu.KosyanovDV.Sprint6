using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tuyiu.KosyanovDV.Sprint6.Task5.V25.Lib
{
    public class DataService : ISprint6Task5V25
    {

        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            List<double> valueList = new List<double>(); 

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, out double number))
                    {
                        if (number != 0)
                        {
                            valueList.Add(Math.Round(number, 3));
                        }
                    }
                }
            }

            double[] valueArrayFromFile = valueList.ToArray();

            return valueArrayFromFile;
        }
    }
}
