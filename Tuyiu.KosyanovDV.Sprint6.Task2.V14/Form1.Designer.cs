namespace Tuyiu.KosyanovDV.Sprint6.Task2.V14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ConditionPicture = new PictureBox();
            startValueLabel = new Label();
            stopValueLabel = new Label();
            startValueTextBox = new TextBox();
            stopValueTextBox = new TextBox();
            resultLabel = new Label();
            resultDataGridView = new DataGridView();
            xValue = new DataGridViewTextBoxColumn();
            funcValue = new DataGridViewTextBoxColumn();
            resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            resultPrintButton = new Button();
            helpButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ConditionPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultChart).BeginInit();
            SuspendLayout();
            // 
            // ConditionPicture
            // 
            ConditionPicture.Image = (Image)resources.GetObject("ConditionPicture.Image");
            ConditionPicture.Location = new Point(12, 12);
            ConditionPicture.Name = "ConditionPicture";
            ConditionPicture.Size = new Size(672, 224);
            ConditionPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ConditionPicture.TabIndex = 0;
            ConditionPicture.TabStop = false;
            // 
            // startValueLabel
            // 
            startValueLabel.AutoSize = true;
            startValueLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startValueLabel.Location = new Point(12, 256);
            startValueLabel.Name = "startValueLabel";
            startValueLabel.Size = new Size(233, 31);
            startValueLabel.TabIndex = 1;
            startValueLabel.Text = "Начальное значение";
            // 
            // stopValueLabel
            // 
            stopValueLabel.AutoSize = true;
            stopValueLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            stopValueLabel.Location = new Point(12, 330);
            stopValueLabel.Name = "stopValueLabel";
            stopValueLabel.Size = new Size(220, 31);
            stopValueLabel.TabIndex = 2;
            stopValueLabel.Text = "Конечное значение";
            // 
            // startValueTextBox
            // 
            startValueTextBox.Location = new Point(251, 262);
            startValueTextBox.Name = "startValueTextBox";
            startValueTextBox.Size = new Size(99, 27);
            startValueTextBox.TabIndex = 3;
            // 
            // stopValueTextBox
            // 
            stopValueTextBox.Location = new Point(251, 330);
            stopValueTextBox.Name = "stopValueTextBox";
            stopValueTextBox.Size = new Size(99, 27);
            stopValueTextBox.TabIndex = 4;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultLabel.Location = new Point(727, 9);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(134, 23);
            resultLabel.TabIndex = 5;
            resultLabel.Text = "Вывод данных";
            resultLabel.Click += label3_Click;
            // 
            // resultDataGridView
            // 
            resultDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { xValue, funcValue });
            resultDataGridView.Location = new Point(727, 48);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.RowHeadersVisible = false;
            resultDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            resultDataGridView.Size = new Size(117, 377);
            resultDataGridView.TabIndex = 6;
            // 
            // xValue
            // 
            xValue.HeaderText = "X";
            xValue.MinimumWidth = 6;
            xValue.Name = "xValue";
            xValue.Width = 47;
            // 
            // funcValue
            // 
            funcValue.HeaderText = "F(X)";
            funcValue.MinimumWidth = 6;
            funcValue.Name = "funcValue";
            funcValue.Width = 64;
            // 
            // resultChart
            // 
            chartArea2.Name = "ChartArea1";
            resultChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            resultChart.Legends.Add(legend2);
            resultChart.Location = new Point(870, 66);
            resultChart.Name = "resultChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            resultChart.Series.Add(series2);
            resultChart.Size = new Size(585, 340);
            resultChart.TabIndex = 7;
            // 
            // resultPrintButton
            // 
            resultPrintButton.BackColor = SystemColors.ButtonShadow;
            resultPrintButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultPrintButton.ForeColor = SystemColors.ControlText;
            resultPrintButton.Location = new Point(546, 369);
            resultPrintButton.Name = "resultPrintButton";
            resultPrintButton.Size = new Size(153, 57);
            resultPrintButton.TabIndex = 8;
            resultPrintButton.Text = "Выполнить";
            resultPrintButton.UseVisualStyleBackColor = false;
            resultPrintButton.Click += resultPrintButton_Click;
            resultPrintButton.MouseEnter += resultPrintButton_MouseEnter;
            resultPrintButton.MouseLeave += resultPrintButton_MouseLeave;
            // 
            // helpButton
            // 
            helpButton.BackColor = Color.White;
            helpButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            helpButton.Location = new Point(356, 366);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(170, 59);
            helpButton.TabIndex = 9;
            helpButton.Text = "?";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += button2_Click;
            helpButton.MouseEnter += helpButton_MouseEnter;
            helpButton.MouseLeave += helpButton_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1467, 450);
            Controls.Add(helpButton);
            Controls.Add(resultPrintButton);
            Controls.Add(resultChart);
            Controls.Add(resultDataGridView);
            Controls.Add(resultLabel);
            Controls.Add(stopValueTextBox);
            Controls.Add(startValueTextBox);
            Controls.Add(stopValueLabel);
            Controls.Add(startValueLabel);
            Controls.Add(ConditionPicture);
            Name = "Form1";
            Text = "Спринт 6 | Таск 2 | Вариант 14 | Косьянов Д.В.";
            ((System.ComponentModel.ISupportInitialize)ConditionPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ConditionPicture;
        private Label startValueLabel;
        private Label stopValueLabel;
        private TextBox startValueTextBox;
        private TextBox stopValueTextBox;
        private Label resultLabel;
        private DataGridView resultDataGridView;
        private DataGridViewTextBoxColumn xValue;
        private DataGridViewTextBoxColumn funcValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
        private Button resultPrintButton;
        private Button helpButton;
    }
}
