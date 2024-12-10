using Tuyiu.KosyanovDV.Sprint6.Task4.V14.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task4.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void PrintResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(StartValueTextBox.Text);
                int stopValue = Convert.ToInt32(StopValueTextBox.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.PrintResultChart.Titles.Add("������ �������");

                this.PrintResultChart.ChartAreas[0].AxisX.Title = "��� �";
                this.PrintResultChart.ChartAreas[0].AxisY.Title = "��� Y";

                ResultPrintTextBox.Text = "";

                for (int i = 0; i <= len; i++)
                {
                    this.PrintResultChart.Series[0].Points.AddXY(startValue, valueArray[i]);
                    ResultPrintTextBox.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("������� ������������ ������", "������");
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ����-24-1", "�������");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V14.txt";

                File.WriteAllText(path, ResultPrintTextBox.Text);

                DialogResult dialogResult = MessageBox.Show($"���� {path} ������� �������\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("������ ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            StartValueTextBox.Text = "-5";
            StopValueTextBox.Text = "5";
        }
    }
}
