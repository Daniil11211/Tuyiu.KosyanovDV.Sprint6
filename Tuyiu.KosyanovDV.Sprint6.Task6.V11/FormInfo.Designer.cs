namespace Tuyiu.KosyanovDV.Sprint6.Task6.V11
{
    partial class FormInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            pictureMe = new PictureBox();
            labelTextInfo = new Label();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureMe).BeginInit();
            SuspendLayout();
            // 
            // pictureMe
            // 
            pictureMe.Image = (Image)resources.GetObject("pictureMe.Image");
            pictureMe.Location = new Point(37, 12);
            pictureMe.Name = "pictureMe";
            pictureMe.Size = new Size(165, 280);
            pictureMe.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureMe.TabIndex = 0;
            pictureMe.TabStop = false;
            // 
            // labelTextInfo
            // 
            labelTextInfo.AutoSize = true;
            labelTextInfo.Location = new Point(287, 61);
            labelTextInfo.Name = "labelTextInfo";
            labelTextInfo.Size = new Size(387, 180);
            labelTextInfo.TabIndex = 1;
            labelTextInfo.Text = resources.GetString("labelTextInfo.Text");
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(639, 328);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(130, 38);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "Ок";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 378);
            Controls.Add(buttonOK);
            Controls.Add(labelTextInfo);
            Controls.Add(pictureMe);
            Name = "FormInfo";
            Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)pictureMe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureMe;
        private Label labelTextInfo;
        private Button buttonOK;
    }
}