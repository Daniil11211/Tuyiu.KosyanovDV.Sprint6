using System.Globalization;
using Tuyiu.KosyanovDV.Sprint6.Task7.V21.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int cols;

        public static int[,] LoadDataFromFile(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = Convert.ToInt32(values[j]);
                }
            }
            return array;
        }

        
        private void buttonResultPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] arrayValues = ds.GetMatrix(openFilePath);

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        dataGridViewOut.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                buttonSaveFile.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить данную операцию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {

            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = LoadDataFromFile(openFilePath);

            dataGridViewIn.ColumnCount = cols;
            dataGridViewOut.ColumnCount = cols;

            dataGridViewIn.RowCount = rows;
            dataGridViewOut.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewIn.Columns[i].Width = 35;
                dataGridViewOut.Columns[i].Width = 35;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonOpenFile.Enabled = true;
        }

    

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogTask.FileName = "OutPutFileTask7.csv";
                saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogTask.ShowDialog();

                string path = saveFileDialogTask.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExist = fileInfo.Exists;
                if (fileExist)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewIn.RowCount;
                int cols = dataGridViewIn.ColumnCount;

                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (j != cols - 1)
                        {
                            str = str + dataGridViewIn.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewIn.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn.ColumnCount = 50;
            dataGridViewIn.RowCount = 50;

            dataGridViewOut.ColumnCount = 50;
            dataGridViewOut.RowCount = 50;

            for (int i = 0; i < dataGridViewIn.RowCount; i++)
            {
               dataGridViewIn.Columns[i].Width = 25;
               dataGridViewOut.Columns[i].Width = 25;
                
            }

        }
    }
}
