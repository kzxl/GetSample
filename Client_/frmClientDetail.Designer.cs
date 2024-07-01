namespace Client_
{
    partial class frmClientDetail
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
            components = new System.ComponentModel.Container();
            txtCF = new TextBox();
            txtCODE = new TextBox();
            txtQuatity = new TextBox();
            txtContent = new TextBox();
            txtReason = new TextBox();
            txtFullname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUsername = new TextBox();
            label7 = new Label();
            dxErr = new ErrorProvider(components);
            btConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dxErr).BeginInit();
            SuspendLayout();
            // 
            // txtCF
            // 
            txtCF.Enabled = false;
            txtCF.Location = new Point(91, 10);
            txtCF.Name = "txtCF";
            txtCF.Size = new Size(330, 23);
            txtCF.TabIndex = 0;
            // 
            // txtCODE
            // 
            txtCODE.Enabled = false;
            txtCODE.Location = new Point(91, 39);
            txtCODE.Name = "txtCODE";
            txtCODE.Size = new Size(330, 23);
            txtCODE.TabIndex = 0;
            // 
            // txtQuatity
            // 
            txtQuatity.Enabled = false;
            txtQuatity.Location = new Point(91, 68);
            txtQuatity.Name = "txtQuatity";
            txtQuatity.Size = new Size(330, 23);
            txtQuatity.TabIndex = 0;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(91, 97);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(330, 23);
            txtContent.TabIndex = 0;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(91, 126);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(330, 23);
            txtReason.TabIndex = 0;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(91, 155);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(330, 23);
            txtFullname.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 13);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên CF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 42);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "CODE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 71);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Số Lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 100);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 1;
            label4.Text = "Nội dung";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 129);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 1;
            label5.Text = "Nguyên Nhân";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 192);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 1;
            label6.Text = "Mã Nhân Viên";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(91, 189);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(330, 23);
            txtUsername.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 158);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 1;
            label7.Text = "Tên Nhân Viên";
            // 
            // dxErr
            // 
            dxErr.ContainerControl = this;
            // 
            // btConfirm
            // 
            btConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btConfirm.Location = new Point(121, 222);
            btConfirm.Name = "btConfirm";
            btConfirm.Size = new Size(199, 23);
            btConfirm.TabIndex = 2;
            btConfirm.Text = "Xác nhận";
            btConfirm.UseVisualStyleBackColor = true;
            btConfirm.Click += btConfirm_Click;
            // 
            // frmClientDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 257);
            Controls.Add(btConfirm);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtFullname);
            Controls.Add(txtQuatity);
            Controls.Add(txtReason);
            Controls.Add(txtContent);
            Controls.Add(txtCODE);
            Controls.Add(txtCF);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmClientDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClientDetail";
            Load += frmClientDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dxErr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCF;
        private TextBox txtCODE;
        private TextBox txtQuatity;
        private TextBox txtContent;
        private TextBox txtReason;
        private TextBox txtFullname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUsername;
        private Label label7;
        private ErrorProvider dxErr;
        private Button btConfirm;
    }
}