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
            components = new System.ComponentModel.Container();
            lbLine = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lbCF = new Label();
            groupBox3 = new GroupBox();
            lbCode = new Label();
            groupBox4 = new GroupBox();
            lbLocation = new Label();
            statusStrip1 = new StatusStrip();
            lbComputerName = new ToolStripStatusLabel();
            lbIP = new ToolStripStatusLabel();
            lbStatus = new ToolStripStatusLabel();
            btChecked = new Button();
            groupBox5 = new GroupBox();
            lbQuantity = new Label();
            dgv = new DataGridView();
            Line = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            CF = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lbLine
            // 
            lbLine.AutoSize = true;
            lbLine.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbLine.Location = new Point(322, 19);
            lbLine.Name = "lbLine";
            lbLine.Size = new Size(27, 25);
            lbLine.TabIndex = 1;
            lbLine.Text = "...";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbLine);
            groupBox1.Location = new Point(222, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 66);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "LINE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbCF);
            groupBox2.Location = new Point(222, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(751, 70);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "TÊN C/F";
            // 
            // lbCF
            // 
            lbCF.AutoSize = true;
            lbCF.Location = new Point(43, 38);
            lbCF.Name = "lbCF";
            lbCF.Size = new Size(16, 15);
            lbCF.TabIndex = 1;
            lbCF.Text = "...";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbCode);
            groupBox3.Location = new Point(222, 160);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(751, 70);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "CODE";
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Location = new Point(43, 38);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(16, 15);
            lbCode.TabIndex = 1;
            lbCode.Text = "...";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbLocation);
            groupBox4.Location = new Point(222, 312);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(751, 70);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vị Trí";
            // 
            // lbLocation
            // 
            lbLocation.AutoSize = true;
            lbLocation.Location = new Point(43, 38);
            lbLocation.Name = "lbLocation";
            lbLocation.Size = new Size(16, 15);
            lbLocation.TabIndex = 1;
            lbLocation.Text = "...";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbComputerName, lbIP, lbStatus });
            statusStrip1.Location = new Point(0, 493);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(985, 22);
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
            // lbStatus
            // 
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 17);
            lbStatus.Text = "Status";
            // 
            // btChecked
            // 
            btChecked.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btChecked.Location = new Point(831, 388);
            btChecked.Name = "btChecked";
            btChecked.Size = new Size(142, 54);
            btChecked.TabIndex = 4;
            btChecked.Text = "Confirm";
            btChecked.UseVisualStyleBackColor = true;
            btChecked.Click += btChecked_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lbQuantity);
            groupBox5.Location = new Point(222, 236);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(751, 70);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "QUANTITY";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(43, 38);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(16, 15);
            lbQuantity.TabIndex = 1;
            lbQuantity.Text = "...";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.BackgroundColor = SystemColors.ControlLightLight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Line, Code, CF, Quantity, id });
            dgv.Dock = DockStyle.Left;
            dgv.Location = new Point(0, 0);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.ShowEditingIcon = false;
            dgv.Size = new Size(216, 493);
            dgv.TabIndex = 5;
            dgv.CellClick += dgv_CellClick;
            // 
            // Line
            // 
            Line.DataPropertyName = "LINE";
            Line.HeaderText = "LINE";
            Line.Name = "Line";
            Line.ReadOnly = true;
            Line.Width = 170;
            // 
            // Code
            // 
            Code.DataPropertyName = "CODE";
            Code.HeaderText = "Code";
            Code.Name = "Code";
            Code.ReadOnly = true;
            Code.Visible = false;
            // 
            // CF
            // 
            CF.DataPropertyName = "CF";
            CF.HeaderText = "CF";
            CF.Name = "CF";
            CF.ReadOnly = true;
            CF.Visible = false;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Visible = false;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 515);
            Controls.Add(dgv);
            Controls.Add(btChecked);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmServer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            FormClosed += frmServer_FormClosed;
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
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbLine;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbCF;
        private GroupBox groupBox3;
        private Label lbCode;
        private GroupBox groupBox4;
        private Label lbLocation;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbComputerName;
        private ToolStripStatusLabel lbIP;
        private Button btChecked;
        private ToolStripStatusLabel lbStatus;
        private GroupBox groupBox5;
        private Label lbQuantity;
        private DataGridView dgv;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Line;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn CF;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn id;
    }
}
