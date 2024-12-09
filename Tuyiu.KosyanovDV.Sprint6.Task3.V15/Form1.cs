using Tuyiu.KosyanovDV.Sprint6.Task3.V15.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task3.V15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] matrix = new int[5, 5] { { 33, 28, 31, 19, 4},
                                        { 1, 32, -3, -17, -12 },
                                        { 24, -19, 26, 31, -3 },
                                        { 30, -16, 29, 28, 8 },
                                        { 30, 5, 11, 7, 32 } };

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            int[,] resMatrix = ds.Calculate(matrix);

            int rows = resMatrix.GetUpperBound(0) + 1;
            int cols = resMatrix.Length / rows;

            dataGridViewMatrixResult.ColumnCount = cols;
            dataGridViewMatrixResult.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrixResult.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrixResult.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            dataGridViewMatrix.ColumnCount = cols;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-24-1 Косьянов Даниил Васильевич", "Справка");
        }
    }
}
