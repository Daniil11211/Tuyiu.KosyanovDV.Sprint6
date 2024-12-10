namespace Tuyiu.KosyanovDV.Sprint6.Task4.V14
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ConditionPicture = new PictureBox();
            PrintResultButton = new Button();
            SaveButton = new Button();
            HelpButton = new Button();
            ResultPrintTextBox = new TextBox();
            ConditionLabelText1 = new Label();
            ConditionLabelText2 = new Label();
            StopValueTextBox = new TextBox();
            StartValueTextBox = new TextBox();
            PrintResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)ConditionPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrintResultChart).BeginInit();
            SuspendLayout();
            // 
            // ConditionPicture
            // 
            ConditionPicture.Image = (Image)resources.GetObject("ConditionPicture.Image");
            ConditionPicture.Location = new Point(12, 23);
            ConditionPicture.Name = "ConditionPicture";
            ConditionPicture.Size = new Size(727, 276);
            ConditionPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ConditionPicture.TabIndex = 0;
            ConditionPicture.TabStop = false;
            // 
            // PrintResultButton
            // 
            PrintResultButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PrintResultButton.Location = new Point(29, 355);
            PrintResultButton.Name = "PrintResultButton";
            PrintResultButton.Size = new Size(224, 75);
            PrintResultButton.TabIndex = 1;
            PrintResultButton.Text = "Выполнить";
            PrintResultButton.UseVisualStyleBackColor = true;
            PrintResultButton.Click += PrintResultButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveButton.Location = new Point(273, 355);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(233, 75);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // HelpButton
            // 
            HelpButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            HelpButton.Location = new Point(29, 485);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(224, 76);
            HelpButton.TabIndex = 3;
            HelpButton.Text = "Справка";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // ResultPrintTextBox
            // 
            ResultPrintTextBox.Location = new Point(757, 23);
            ResultPrintTextBox.Multiline = true;
            ResultPrintTextBox.Name = "ResultPrintTextBox";
            ResultPrintTextBox.Size = new Size(125, 571);
            ResultPrintTextBox.TabIndex = 4;
            // 
            // ConditionLabelText1
            // 
            ConditionLabelText1.AutoSize = true;
            ConditionLabelText1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConditionLabelText1.Location = new Point(300, 472);
            ConditionLabelText1.Name = "ConditionLabelText1";
            ConditionLabelText1.Size = new Size(285, 38);
            ConditionLabelText1.TabIndex = 5;
            ConditionLabelText1.Text = "Начальное значение";
            // 
            // ConditionLabelText2
            // 
            ConditionLabelText2.AutoSize = true;
            ConditionLabelText2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConditionLabelText2.Location = new Point(300, 523);
            ConditionLabelText2.Name = "ConditionLabelText2";
            ConditionLabelText2.Size = new Size(271, 38);
            ConditionLabelText2.TabIndex = 6;
            ConditionLabelText2.Text = "Конечное значение";
            // 
            // StopValueTextBox
            // 
            StopValueTextBox.Location = new Point(590, 534);
            StopValueTextBox.Name = "StopValueTextBox";
            StopValueTextBox.Size = new Size(89, 27);
            StopValueTextBox.TabIndex = 7;
            // 
            // StartValueTextBox
            // 
            StartValueTextBox.Location = new Point(591, 483);
            StartValueTextBox.Name = "StartValueTextBox";
            StartValueTextBox.Size = new Size(88, 27);
            StartValueTextBox.TabIndex = 8;
            // 
            // PrintResultChart
            // 
            chartArea1.Name = "ChartArea1";
            PrintResultChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            PrintResultChart.Legends.Add(legend1);
            PrintResultChart.Location = new Point(907, 23);
            PrintResultChart.Name = "PrintResultChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            PrintResultChart.Series.Add(series1);
            PrintResultChart.Size = new Size(792, 571);
            PrintResultChart.TabIndex = 9;
            PrintResultChart.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1720, 614);
            Controls.Add(PrintResultChart);
            Controls.Add(StartValueTextBox);
            Controls.Add(StopValueTextBox);
            Controls.Add(ConditionLabelText2);
            Controls.Add(ConditionLabelText1);
            Controls.Add(ResultPrintTextBox);
            Controls.Add(HelpButton);
            Controls.Add(SaveButton);
            Controls.Add(PrintResultButton);
            Controls.Add(ConditionPicture);
            Name = "Form1";
            Text = "Спринт 6 | Таск 4 | Вариант 14 | Косьянов Д.В.";
            ((System.ComponentModel.ISupportInitialize)ConditionPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrintResultChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ConditionPicture;
        private Button PrintResultButton;
        private Button SaveButton;
        private Button HelpButton;
        private TextBox ResultPrintTextBox;
        private Label ConditionLabelText1;
        private Label ConditionLabelText2;
        private TextBox StopValueTextBox;
        private TextBox StartValueTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart PrintResultChart;
    }
}
