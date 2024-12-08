using Tuyiu.KosyanovDV.Sprint6.Task0.V17.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task0.V17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            resultBox.Text = Convert.ToString(ds.Calculate(3));
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТб-24-1 Косьянов Даниил Васильевич", "Сообщение");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
