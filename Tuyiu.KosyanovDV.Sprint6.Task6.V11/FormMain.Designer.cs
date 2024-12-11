namespace Tuyiu.KosyanovDV.Sprint6.Task6.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelTextCondition = new Label();
            labelTextInPut = new Label();
            textBoxIn = new TextBox();
            labelTextOutPut = new Label();
            textBoxOut = new TextBox();
            buttonOpenFile = new Button();
            buttonResultPrint = new Button();
            buttonInfo = new Button();
            toolTip = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            SuspendLayout();
            // 
            // labelTextCondition
            // 
            labelTextCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextCondition.Location = new Point(12, 140);
            labelTextCondition.Name = "labelTextCondition";
            labelTextCondition.Size = new Size(1089, 91);
            labelTextCondition.TabIndex = 0;
            labelTextCondition.Text = resources.GetString("labelTextCondition.Text");
            // 
            // labelTextInPut
            // 
            labelTextInPut.AutoSize = true;
            labelTextInPut.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextInPut.Location = new Point(12, 244);
            labelTextInPut.Name = "labelTextInPut";
            labelTextInPut.Size = new Size(48, 23);
            labelTextInPut.TabIndex = 1;
            labelTextInPut.Text = "Ввод";
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(12, 276);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(528, 470);
            textBoxIn.TabIndex = 2;
            // 
            // labelTextOutPut
            // 
            labelTextOutPut.AutoSize = true;
            labelTextOutPut.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextOutPut.Location = new Point(582, 244);
            labelTextOutPut.Name = "labelTextOutPut";
            labelTextOutPut.Size = new Size(60, 23);
            labelTextOutPut.TabIndex = 3;
            labelTextOutPut.Text = "Вывод";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(582, 276);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(528, 470);
            textBoxOut.TabIndex = 4;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOpenFile.Location = new Point(12, 21);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(138, 86);
            buttonOpenFile.TabIndex = 5;
            buttonOpenFile.Text = "Открыть файл";
            toolTip.SetToolTip(buttonOpenFile, "Загрузить файл из...\r\nВыберите нужный файл для обработки (в формате *.txt)");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonResultPrint
            // 
            buttonResultPrint.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonResultPrint.Location = new Point(185, 21);
            buttonResultPrint.Name = "buttonResultPrint";
            buttonResultPrint.Size = new Size(139, 86);
            buttonResultPrint.TabIndex = 6;
            buttonResultPrint.Text = "Выполнить";
            toolTip.SetToolTip(buttonResultPrint, "Выполнить\r\nВыполнить оперпацию и загрузить её в окно вывода");
            buttonResultPrint.UseVisualStyleBackColor = true;
            buttonResultPrint.Click += buttonResultPrint_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonInfo.Location = new Point(956, 21);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(145, 86);
            buttonInfo.TabIndex = 7;
            buttonInfo.Text = "Справка";
            toolTip.SetToolTip(buttonInfo, "Справка\r\nУзнать об человеке, сделавшем программу");
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 758);
            Controls.Add(buttonInfo);
            Controls.Add(buttonResultPrint);
            Controls.Add(buttonOpenFile);
            Controls.Add(textBoxOut);
            Controls.Add(labelTextOutPut);
            Controls.Add(textBoxIn);
            Controls.Add(labelTextInPut);
            Controls.Add(labelTextCondition);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 11 | Косьянов Д.В.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTextCondition;
        private Label labelTextInPut;
        private TextBox textBoxIn;
        private Label labelTextOutPut;
        private TextBox textBoxOut;
        private Button buttonOpenFile;
        private Button buttonResultPrint;
        private Button buttonInfo;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogTask;
    }
}
