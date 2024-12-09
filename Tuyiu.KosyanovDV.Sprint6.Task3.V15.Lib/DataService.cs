using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tuyiu.KosyanovDV.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            int columnToSort = 2;

            int temp;
            int[] columnData = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                columnData[i] = matrix[i, columnToSort];
            }


            for (int i = 0; i < columnData.Length; i++)
            {
                for (int j = i + 1; j < columnData.Length; j++)
                {
                    if (columnData[i] > columnData[j])
                    {
                        temp = columnData[i];
                        columnData[i] = columnData[j];
                        columnData[j] = temp;
                    }
                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, columnToSort] = columnData[i];
            }

            return matrix;
        }
    }
}
