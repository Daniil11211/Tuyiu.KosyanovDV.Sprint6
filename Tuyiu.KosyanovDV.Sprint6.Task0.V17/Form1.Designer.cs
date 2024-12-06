namespace Tuyiu.KosyanovDV.Sprint6.Task0.V17
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
            labelTextCondition1 = new Label();
            LabelTextCondition2 = new Label();
            resultButton = new Button();
            resultText = new Label();
            resultBox = new TextBox();
            formulaPicture = new PictureBox();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)formulaPicture).BeginInit();
            SuspendLayout();
            // 
            // labelTextCondition1
            // 
            labelTextCondition1.AutoSize = true;
            labelTextCondition1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelTextCondition1.Location = new Point(12, 9);
            labelTextCondition1.Name = "labelTextCondition1";
            labelTextCondition1.Size = new Size(143, 46);
            labelTextCondition1.TabIndex = 0;
            labelTextCondition1.Text = "Условие";
            // 
            // LabelTextCondition2
            // 
            LabelTextCondition2.AutoSize = true;
            LabelTextCondition2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelTextCondition2.Location = new Point(12, 77);
            LabelTextCondition2.Name = "LabelTextCondition2";
            LabelTextCondition2.Size = new Size(763, 84);
            LabelTextCondition2.TabIndex = 1;
            LabelTextCondition2.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. \r\nОкруглить до трёх знаков после запятой. Графический интерфейс оформить \r\nпо шаблону из лекции.";
            LabelTextCondition2.Click += label2_Click;
            // 
            // resultButton
            // 
            resultButton.BackColor = SystemColors.ControlDark;
            resultButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultButton.Location = new Point(656, 429);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(217, 69);
            resultButton.TabIndex = 2;
            resultButton.Text = "Вычислить";
            resultButton.UseVisualStyleBackColor = false;
            resultButton.Click += resultButton_Click;
            // 
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultText.Location = new Point(12, 449);
            resultText.Name = "resultText";
            resultText.Size = new Size(116, 31);
            resultText.TabIndex = 3;
            resultText.Text = "Результат";
            // 
            // resultBox
            // 
            resultBox.Location = new Point(134, 455);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(174, 27);
            resultBox.TabIndex = 4;
            // 
            // formulaPicture
            // 
            formulaPicture.Image = (Image)resources.GetObject("formulaPicture.Image");
            formulaPicture.InitialImage = (Image)resources.GetObject("formulaPicture.InitialImage");
            formulaPicture.Location = new Point(46, 210);
            formulaPicture.Name = "formulaPicture";
            formulaPicture.Size = new Size(262, 177);
            formulaPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            formulaPicture.TabIndex = 5;
            formulaPicture.TabStop = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ControlDarkDark;
            buttonHelp.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.Location = new Point(535, 419);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(93, 79);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 521);
            Controls.Add(buttonHelp);
            Controls.Add(formulaPicture);
            Controls.Add(resultBox);
            Controls.Add(resultText);
            Controls.Add(resultButton);
            Controls.Add(LabelTextCondition2);
            Controls.Add(labelTextCondition1);
            Name = "Form1";
            Text = "Спринт 6 | Таск 0 | Вариант 17 | Косьянов Д.В.";
            ((System.ComponentModel.ISupportInitialize)formulaPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTextCondition1;
        private Label LabelTextCondition2;
        private Button resultButton;
        private Label resultText;
        private TextBox resultBox;
        private PictureBox formulaPicture;
        private Button buttonHelp;
    }
}
