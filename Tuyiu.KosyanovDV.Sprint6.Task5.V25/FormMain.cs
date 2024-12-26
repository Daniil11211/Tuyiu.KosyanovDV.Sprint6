using Tuyiu.KosyanovDV.Sprint6.Task5.V25.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V25.txt";

        private void resultPrintButton_Click(object sender, EventArgs e)
        {
            this.chartPrintResult.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartPrintResult.ChartAreas[0].AxisY.Title = "Ось Y";

            chartPrintResult.Series[0].Points.Clear();

            double[] valueArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < valueArray.Length; i++)
            {
                dataGridViewResultPrint.Rows.Add(Convert.ToString(i), Convert.ToString(valueArray[i]));
                chartPrintResult.Series[0].Points.AddXY(i, valueArray[i]);
            }

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-24-1 Косьянов Даниил Васильевич", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
