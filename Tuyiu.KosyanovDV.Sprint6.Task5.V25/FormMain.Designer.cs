namespace Tuyiu.KosyanovDV.Sprint6.Task5.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            conditionLabelText = new Label();
            resultPrintButton = new Button();
            openFileButton = new Button();
            helpButton = new Button();
            dataGridViewResultPrint = new DataGridView();
            chartPrintResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultPrint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPrintResult).BeginInit();
            SuspendLayout();
            // 
            // conditionLabelText
            // 
            conditionLabelText.AutoSize = true;
            conditionLabelText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            conditionLabelText.Location = new Point(12, 64);
            conditionLabelText.Name = "conditionLabelText";
            conditionLabelText.Size = new Size(472, 224);
            conditionLabelText.TabIndex = 0;
            conditionLabelText.Text = resources.GetString("conditionLabelText.Text");
            // 
            // resultPrintButton
            // 
            resultPrintButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultPrintButton.Location = new Point(12, 392);
            resultPrintButton.Name = "resultPrintButton";
            resultPrintButton.Size = new Size(199, 83);
            resultPrintButton.TabIndex = 1;
            resultPrintButton.Text = "Выполнить";
            resultPrintButton.UseVisualStyleBackColor = true;
            resultPrintButton.Click += resultPrintButton_Click;
            // 
            // openFileButton
            // 
            openFileButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            openFileButton.Location = new Point(259, 392);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(200, 83);
            openFileButton.TabIndex = 2;
            openFileButton.Text = "Открыть файл";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // helpButton
            // 
            helpButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            helpButton.Location = new Point(112, 534);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(246, 81);
            helpButton.TabIndex = 3;
            helpButton.Text = "Справка";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // dataGridViewResultPrint
            // 
            dataGridViewResultPrint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultPrint.ColumnHeadersVisible = false;
            dataGridViewResultPrint.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewResultPrint.Location = new Point(533, 12);
            dataGridViewResultPrint.Name = "dataGridViewResultPrint";
            dataGridViewResultPrint.RowHeadersVisible = false;
            dataGridViewResultPrint.RowHeadersWidth = 51;
            dataGridViewResultPrint.Size = new Size(113, 637);
            dataGridViewResultPrint.TabIndex = 4;
            // 
            // chartPrintResult
            // 
            chartArea1.Name = "ChartArea1";
            chartPrintResult.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartPrintResult.Legends.Add(legend1);
            chartPrintResult.Location = new Point(747, 32);
            chartPrintResult.Name = "chartPrintResult";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPrintResult.Series.Add(series1);
            chartPrintResult.Size = new Size(987, 617);
            chartPrintResult.TabIndex = 5;
            chartPrintResult.Text = "chart1";
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 60;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1746, 661);
            Controls.Add(chartPrintResult);
            Controls.Add(dataGridViewResultPrint);
            Controls.Add(helpButton);
            Controls.Add(openFileButton);
            Controls.Add(resultPrintButton);
            Controls.Add(conditionLabelText);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultPrint).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPrintResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label conditionLabelText;
        private Button resultPrintButton;
        private Button openFileButton;
        private Button helpButton;
        private DataGridView dataGridViewResultPrint;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrintResult;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
