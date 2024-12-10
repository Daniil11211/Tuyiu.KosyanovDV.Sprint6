using Tuyiu.KosyanovDV.Sprint6.Task2.V14.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-24-1 Косьянов Даниил Васильевич", "Справка");
        }

        private void resultPrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(startValueTextBox.Text);
                int stopValue = Convert.ToInt32(stopValueTextBox.Text);


                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                this.resultChart.Titles.Add("График функции");

                this.resultChart.ChartAreas[0].AxisX.Title = "Ось Х";
                this.resultChart.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.resultDataGridView.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.resultChart.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void helpButton_MouseEnter(object sender, EventArgs e)
        {
            helpButton.Text = "Справка";
            helpButton.BackColor = Color.Black;
            helpButton.ForeColor = Color.White;
        }

        private void helpButton_MouseLeave(object sender, EventArgs e)
        {
            helpButton.Text = "?";
            helpButton.BackColor = Color.White;
            helpButton.ForeColor = Color.Black;
        }

        private void resultPrintButton_MouseEnter(object sender, EventArgs e)
        {
            resultPrintButton.BackColor = Color.Black;
            resultPrintButton.ForeColor = Color.White;
        }

        private void resultPrintButton_MouseLeave(object sender, EventArgs e)
        {
            resultPrintButton.BackColor = Color.White;
            resultPrintButton.ForeColor = Color.Black;
        }

        private void FormMain_Load_2(object sender, EventArgs e)
        {
            startValueTextBox.Text = "-5";
            stopValueTextBox.Text = "5";
        }
    }
}
