
namespace Client_
{
    partial class frmClient
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btSend = new Button();
            groupBox5 = new GroupBox();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "LINE";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "TÊN C/F";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(12, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "CODE";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(12, 330);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(776, 100);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "NỘI DUNG";
            // 
            // btSend
            // 
            btSend.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btSend.Location = new Point(294, 542);
            btSend.Name = "btSend";
            btSend.Size = new Size(208, 67);
            btSend.TabIndex = 1;
            btSend.Text = "Send";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += this.btSend_Click;
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(12, 436);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(776, 100);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "NGUYÊN NHÂN";
            // 
            // frmClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
            Controls.Add(btSend);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            ResumeLayout(false);
        }

        

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btSend;
        private GroupBox groupBox5;
    }
}
