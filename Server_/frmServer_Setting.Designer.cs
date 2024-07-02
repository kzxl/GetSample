namespace Server_
{
    partial class frmServer_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServer_Setting));
            txtCF = new TextBox();
            label1 = new Label();
            txtLogs = new TextBox();
            label2 = new Label();
            btSave = new Button();
            fbdPath = new FolderBrowserDialog();
            ofdPath = new OpenFileDialog();
            SuspendLayout();
            // 
            // txtCF
            // 
            txtCF.Location = new Point(12, 33);
            txtCF.Name = "txtCF";
            txtCF.ReadOnly = true;
            txtCF.Size = new Size(561, 23);
            txtCF.TabIndex = 0;
            txtCF.Click += txtCF_Click;
            txtCF.TextChanged += txtCF_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 1;
            label1.Text = "Đường dẫn đến file chứa thông tin CF";
            // 
            // txtLogs
            // 
            txtLogs.Location = new Point(12, 77);
            txtLogs.Name = "txtLogs";
            txtLogs.ReadOnly = true;
            txtLogs.Size = new Size(561, 23);
            txtLogs.TabIndex = 0;
            txtLogs.Click += txtLogs_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(209, 15);
            label2.TabIndex = 1;
            label2.Text = "Đường dẫn đến file chứa thông tin log";
            // 
            // btSave
            // 
            btSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.Image = (Image)resources.GetObject("btSave.Image");
            btSave.ImageAlign = ContentAlignment.MiddleLeft;
            btSave.Location = new Point(211, 106);
            btSave.Name = "btSave";
            btSave.Size = new Size(132, 23);
            btSave.TabIndex = 2;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // frmServer_Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 139);
            Controls.Add(btSave);
            Controls.Add(label2);
            Controls.Add(txtLogs);
            Controls.Add(label1);
            Controls.Add(txtCF);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmServer_Setting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setting";
            FormClosed += frmServer_Setting_FormClosed;
            Load += frmServer_Setting_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCF;
        private Label label1;
        private TextBox txtLogs;
        private Label label2;
        private Button btSave;
        private FolderBrowserDialog fbdPath;
        private OpenFileDialog ofdPath;
    }
}