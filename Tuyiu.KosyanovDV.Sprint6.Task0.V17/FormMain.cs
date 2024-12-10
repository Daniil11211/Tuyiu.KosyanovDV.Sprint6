using Tuyiu.KosyanovDV.Sprint6.Task0.V17.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
    }
}
