namespace Tuyiu.KosyanovDV.Sprint6.Task0.V17
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
            resources.ApplyResources(labelTextCondition1, "labelTextCondition1");
            labelTextCondition1.Name = "labelTextCondition1";
            // 
            // LabelTextCondition2
            // 
            resources.ApplyResources(LabelTextCondition2, "LabelTextCondition2");
            LabelTextCondition2.Name = "LabelTextCondition2";
            // 
            // resultButton
            // 
            resultButton.BackColor = SystemColors.ControlDark;
            resources.ApplyResources(resultButton, "resultButton");
            resultButton.Name = "resultButton";
            resultButton.UseVisualStyleBackColor = false;
            resultButton.Click += resultButton_Click;
            // 
            // resultText
            // 
            resources.ApplyResources(resultText, "resultText");
            resultText.Name = "resultText";
            // 
            // resultBox
            // 
            resources.ApplyResources(resultBox, "resultBox");
            resultBox.Name = "resultBox";
            // 
            // formulaPicture
            // 
            resources.ApplyResources(formulaPicture, "formulaPicture");
            formulaPicture.Name = "formulaPicture";
            formulaPicture.TabStop = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ControlDarkDark;
            resources.ApplyResources(buttonHelp, "buttonHelp");
            buttonHelp.Name = "buttonHelp";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonHelp);
            Controls.Add(formulaPicture);
            Controls.Add(resultBox);
            Controls.Add(resultText);
            Controls.Add(resultButton);
            Controls.Add(LabelTextCondition2);
            Controls.Add(labelTextCondition1);
            Name = "FormMain";
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
