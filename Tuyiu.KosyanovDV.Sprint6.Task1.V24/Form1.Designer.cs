namespace Tuyiu.KosyanovDV.Sprint6.Task1.V24
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
            ConditionImage = new PictureBox();
            TextCondition1 = new Label();
            TextCondition2 = new Label();
            startValueTextBox = new TextBox();
            stopValueTextBox = new TextBox();
            resultPrintButton = new Button();
            helpButton = new Button();
            resultTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ConditionImage).BeginInit();
            SuspendLayout();
            // 
            // ConditionImage
            // 
            ConditionImage.Image = (Image)resources.GetObject("ConditionImage.Image");
            ConditionImage.Location = new Point(12, 68);
            ConditionImage.Name = "ConditionImage";
            ConditionImage.Size = new Size(733, 251);
            ConditionImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ConditionImage.TabIndex = 0;
            ConditionImage.TabStop = false;
            ConditionImage.Click += pictureBox1_Click;
            // 
            // TextCondition1
            // 
            TextCondition1.AutoSize = true;
            TextCondition1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextCondition1.Location = new Point(12, 411);
            TextCondition1.Name = "TextCondition1";
            TextCondition1.Size = new Size(285, 38);
            TextCondition1.TabIndex = 1;
            TextCondition1.Text = "Начальное значение";
            TextCondition1.Click += label1_Click;
            // 
            // TextCondition2
            // 
            TextCondition2.AutoSize = true;
            TextCondition2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TextCondition2.Location = new Point(20, 530);
            TextCondition2.Name = "TextCondition2";
            TextCondition2.Size = new Size(271, 38);
            TextCondition2.TabIndex = 2;
            TextCondition2.Text = "Конечное значение";
            // 
            // startValueTextBox
            // 
            startValueTextBox.Location = new Point(320, 422);
            startValueTextBox.Name = "startValueTextBox";
            startValueTextBox.Size = new Size(125, 27);
            startValueTextBox.TabIndex = 3;
            // 
            // stopValueTextBox
            // 
            stopValueTextBox.Location = new Point(320, 541);
            stopValueTextBox.Name = "stopValueTextBox";
            stopValueTextBox.Size = new Size(125, 27);
            stopValueTextBox.TabIndex = 4;
            // 
            // resultPrintButton
            // 
            resultPrintButton.BackColor = SystemColors.ControlDarkDark;
            resultPrintButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultPrintButton.ForeColor = SystemColors.ButtonHighlight;
            resultPrintButton.Location = new Point(808, 560);
            resultPrintButton.Name = "resultPrintButton";
            resultPrintButton.Size = new Size(214, 73);
            resultPrintButton.TabIndex = 5;
            resultPrintButton.Text = "Вычислить";
            resultPrintButton.UseVisualStyleBackColor = false;
            resultPrintButton.Click += resultPrintButton_Click;
            // 
            // helpButton
            // 
            helpButton.BackColor = SystemColors.GrayText;
            helpButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            helpButton.Location = new Point(705, 561);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(70, 70);
            helpButton.TabIndex = 6;
            helpButton.Text = "?";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += button1_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(762, 36);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(285, 452);
            resultTextBox.TabIndex = 7;
            resultTextBox.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 668);
            Controls.Add(resultTextBox);
            Controls.Add(helpButton);
            Controls.Add(resultPrintButton);
            Controls.Add(stopValueTextBox);
            Controls.Add(startValueTextBox);
            Controls.Add(TextCondition2);
            Controls.Add(TextCondition1);
            Controls.Add(ConditionImage);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 24 | Косьянов Д.В.";
            ((System.ComponentModel.ISupportInitialize)ConditionImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ConditionImage;
        private Label TextCondition1;
        private Label TextCondition2;
        private TextBox startValueTextBox;
        private TextBox stopValueTextBox;
        private Button resultPrintButton;
        private Button helpButton;
        private TextBox resultTextBox;
    }
}
