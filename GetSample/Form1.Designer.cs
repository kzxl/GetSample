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
            listBox1 = new ListBox();
            label1 = new Label();
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
            picBox.Size = new Size(561, 450);
            picBox.TabIndex = 1;
            picBox.TabStop = false;
            picBox.Click += picBox_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(567, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 439);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(693, 121);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(picBox);
            Controls.Add(btLoadImg);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLoadImg;
        private PictureBox picBox;
        private ListBox listBox1;
        private Label label1;
    }
}
