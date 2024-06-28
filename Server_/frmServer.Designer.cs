namespace Server_
{
    partial class frmServer
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
            lstUser = new ListView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            label4 = new Label();
            statusStrip1 = new StatusStrip();
            lbComputerName = new ToolStripStatusLabel();
            lbIP = new ToolStripStatusLabel();
            btChecked = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstUser
            // 
            lstUser.Dock = DockStyle.Left;
            lstUser.Location = new Point(0, 0);
            lstUser.Name = "lstUser";
            lstUser.Size = new Size(216, 515);
            lstUser.TabIndex = 0;
            lstUser.UseCompatibleStateImageBehavior = false;
            lstUser.View = View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 38);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(222, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "LINE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(222, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(751, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "TÊN C/F";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 38);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(222, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(751, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "CODE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 38);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "label1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(222, 330);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(751, 100);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vị Trí";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 38);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 1;
            label4.Text = "label1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbComputerName, lbIP });
            statusStrip1.Location = new Point(216, 493);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(769, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbComputerName
            // 
            lbComputerName.Name = "lbComputerName";
            lbComputerName.Size = new Size(99, 17);
            lbComputerName.Text = "Computer Name:";
            // 
            // lbIP
            // 
            lbIP.Name = "lbIP";
            lbIP.Size = new Size(77, 17);
            lbIP.Text = "Computer IP:";
            // 
            // btChecked
            // 
            btChecked.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btChecked.Location = new Point(831, 436);
            btChecked.Name = "btChecked";
            btChecked.Size = new Size(142, 54);
            btChecked.TabIndex = 4;
            btChecked.Text = "Confirm";
            btChecked.UseVisualStyleBackColor = true;
            // 
            // frmServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 515);
            Controls.Add(btChecked);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lstUser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmServer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            Load += frmServer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstUser;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox3;
        private Label label3;
        private GroupBox groupBox4;
        private Label label4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbComputerName;
        private ToolStripStatusLabel lbIP;
        private Button btChecked;
    }
}
