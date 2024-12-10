using Tuyiu.KosyanovDV.Sprint6.Task1.V24.Lib;
namespace Tuyiu.KosyanovDV.Sprint6.Task1.V24
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultPrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultTextBox.Text = "";
                resultTextBox.AppendText(" +-----------+-----------+ " + Environment.NewLine);
                resultTextBox.AppendText(" |        X         |       F(X)     | " + Environment.NewLine);
                resultTextBox.AppendText(" +-----------+-----------+ " + Environment.NewLine);

                int len = ds.GetMassFunction(Convert.ToInt32(startValueTextBox.Text), Convert.ToInt32(stopValueTextBox.Text)).Length;

                double[] valueArray = new double[len];

                string strLine;

                int startValue = Convert.ToInt32(startValueTextBox.Text);

                valueArray = ds.GetMassFunction(Convert.ToInt32(startValueTextBox.Text), Convert.ToInt32(stopValueTextBox.Text));

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format(" | {0, 5:d}      |  {1, 9:f2}   | ", startValue, valueArray[i]);
                    resultTextBox.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                Console.WriteLine("* +-----------+-----------+                                     ");
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка");
            }


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            startValueTextBox.Text = "-5";
            stopValueTextBox.Text = "5";
        }
    }
}
