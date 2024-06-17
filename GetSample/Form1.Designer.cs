namespace GetSample
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
            btLoadImg = new Button();
            picBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // btLoadImg
            // 
            btLoadImg.Location = new Point(693, 12);
            btLoadImg.Name = "btLoadImg";
            btLoadImg.Size = new Size(95, 23);
            btLoadImg.TabIndex = 0;
            btLoadImg.Text = "Load Image";
            btLoadImg.UseVisualStyleBackColor = true;
            btLoadImg.Click += button1_Click;
            // 
            // picBox
            // 
            picBox.Dock = DockStyle.Left;
            picBox.Location = new Point(0, 0);
            picBox.Name = "picBox";
            picBox.Size = new Size(362, 450);
            picBox.TabIndex = 1;
            picBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picBox);
            Controls.Add(btLoadImg);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btLoadImg;
        private PictureBox picBox;
    }
}
