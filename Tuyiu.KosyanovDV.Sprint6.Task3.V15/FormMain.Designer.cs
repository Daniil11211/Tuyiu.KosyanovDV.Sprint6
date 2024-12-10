namespace Tuyiu.KosyanovDV.Sprint6.Task3.V15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            conditionLabelText = new Label();
            dataGridViewMatrix = new DataGridView();
            resultLabelText = new Label();
            dataGridViewMatrixResult = new DataGridView();
            resultPrintButton = new Button();
            helpButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixResult).BeginInit();
            SuspendLayout();
            // 
            // conditionLabelText
            // 
            conditionLabelText.AutoSize = true;
            conditionLabelText.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            conditionLabelText.Location = new Point(12, 21);
            conditionLabelText.Name = "conditionLabelText";
            conditionLabelText.Size = new Size(501, 275);
            conditionLabelText.TabIndex = 0;
            conditionLabelText.Text = resources.GetString("conditionLabelText.Text");
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(502, 65);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(178, 148);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // resultLabelText
            // 
            resultLabelText.AutoSize = true;
            resultLabelText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultLabelText.Location = new Point(725, 21);
            resultLabelText.Name = "resultLabelText";
            resultLabelText.Size = new Size(119, 31);
            resultLabelText.TabIndex = 2;
            resultLabelText.Text = "Результат";
            // 
            // dataGridViewMatrixResult
            // 
            dataGridViewMatrixResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixResult.ColumnHeadersVisible = false;
            dataGridViewMatrixResult.Location = new Point(725, 65);
            dataGridViewMatrixResult.Name = "dataGridViewMatrixResult";
            dataGridViewMatrixResult.RowHeadersVisible = false;
            dataGridViewMatrixResult.RowHeadersWidth = 51;
            dataGridViewMatrixResult.Size = new Size(178, 148);
            dataGridViewMatrixResult.TabIndex = 3;
            // 
            // resultPrintButton
            // 
            resultPrintButton.Location = new Point(915, 433);
            resultPrintButton.Name = "resultPrintButton";
            resultPrintButton.Size = new Size(158, 73);
            resultPrintButton.TabIndex = 4;
            resultPrintButton.Text = "Выполнить";
            resultPrintButton.UseVisualStyleBackColor = true;
            resultPrintButton.Click += resultPrintButton_Click;
            // 
            // helpButton
            // 
            helpButton.Location = new Point(725, 442);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(151, 54);
            helpButton.TabIndex = 5;
            helpButton.Text = "Справка";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 538);
            Controls.Add(helpButton);
            Controls.Add(resultPrintButton);
            Controls.Add(dataGridViewMatrixResult);
            Controls.Add(resultLabelText);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(conditionLabelText);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 15 | Косьянов Д.В.";
            Load += this.FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label conditionLabelText;
        private DataGridView dataGridViewMatrix;
        private Label resultLabelText;
        private DataGridView dataGridViewMatrixResult;
        private Button resultPrintButton;
        private Button helpButton;
    }
}
