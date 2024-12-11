namespace Tuyiu.KosyanovDV.Sprint6.Task7.V21
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
            buttonResultPrint = new Button();
            buttonOpenFile = new Button();
            buttonSaveFile = new Button();
            buttonInfo = new Button();
            labelTextIn = new Label();
            labelTextOut = new Label();
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            toolTip = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogTask = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // labelTextCondition
            // 
            labelTextCondition.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextCondition.Location = new Point(12, 126);
            labelTextCondition.Name = "labelTextCondition";
            labelTextCondition.Size = new Size(1289, 104);
            labelTextCondition.TabIndex = 0;
            labelTextCondition.Text = resources.GetString("labelTextCondition.Text");
            // 
            // buttonResultPrint
            // 
            buttonResultPrint.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonResultPrint.Location = new Point(12, 12);
            buttonResultPrint.Name = "buttonResultPrint";
            buttonResultPrint.Size = new Size(165, 96);
            buttonResultPrint.TabIndex = 1;
            buttonResultPrint.Text = "Выполнить";
            buttonResultPrint.UseVisualStyleBackColor = true;
            buttonResultPrint.Click += buttonResultPrint_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOpenFile.Location = new Point(210, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(168, 96);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSaveFile.Location = new Point(410, 12);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(164, 96);
            buttonSaveFile.TabIndex = 3;
            buttonSaveFile.Text = "Сохранить файл";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonInfo.Location = new Point(1130, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(171, 96);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // labelTextIn
            // 
            labelTextIn.AutoSize = true;
            labelTextIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextIn.Location = new Point(30, 259);
            labelTextIn.Name = "labelTextIn";
            labelTextIn.Size = new Size(65, 31);
            labelTextIn.TabIndex = 5;
            labelTextIn.Text = "Ввод";
            // 
            // labelTextOut
            // 
            labelTextOut.AutoSize = true;
            labelTextOut.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextOut.Location = new Point(614, 269);
            labelTextOut.Name = "labelTextOut";
            labelTextOut.Size = new Size(81, 31);
            labelTextOut.TabIndex = 6;
            labelTextOut.Text = "Вывод";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(30, 325);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(443, 332);
            dataGridViewIn.TabIndex = 7;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(614, 325);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(521, 332);
            dataGridViewOut.TabIndex = 8;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 688);
            Controls.Add(dataGridViewOut);
            Controls.Add(dataGridViewIn);
            Controls.Add(labelTextOut);
            Controls.Add(labelTextIn);
            Controls.Add(buttonInfo);
            Controls.Add(buttonSaveFile);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonResultPrint);
            Controls.Add(labelTextCondition);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 21 | Косьянов Д.В.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTextCondition;
        private Button buttonResultPrint;
        private Button buttonOpenFile;
        private Button buttonSaveFile;
        private Button buttonInfo;
        private Label labelTextIn;
        private Label labelTextOut;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogTask;
    }
}
