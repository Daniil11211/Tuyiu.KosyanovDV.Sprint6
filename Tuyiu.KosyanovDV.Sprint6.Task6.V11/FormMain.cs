using System.Text;
using Tuyiu.KosyanovDV.Sprint6.Task6.V11.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;

        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            textBoxIn.Multiline = true;

            textBoxIn.Text = File.ReadAllText(openFilePath, Encoding.UTF8);
            labelTextInPut.Text = labelTextInPut.Text + " " + openFileDialogTask.FileName;
            buttonOpenFile.Enabled = true;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog();
        }

        private void buttonResultPrint_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
