
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            lbLINE = new Label();
            groupBox2 = new GroupBox();
            txtCF = new TextBox();
            groupBox3 = new GroupBox();
            txtCODE = new TextBox();
            groupBox4 = new GroupBox();
            txtQuatity = new TextBox();
            btSend = new Button();
            dxErr = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dxErr).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbLINE);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "LINE";
            // 
            // lbLINE
            // 
            lbLINE.AutoSize = true;
            lbLINE.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbLINE.Location = new Point(165, 34);
            lbLINE.Name = "lbLINE";
            lbLINE.Size = new Size(94, 40);
            lbLINE.TabIndex = 0;
            lbLINE.Text = "label1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCF);
            groupBox2.Location = new Point(12, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(479, 108);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "TÊN C/F";
            // 
            // txtCF
            // 
            txtCF.Location = new Point(6, 38);
            txtCF.Name = "txtCF";
            txtCF.Size = new Size(443, 23);
            txtCF.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCODE);
            groupBox3.Location = new Point(12, 216);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(479, 108);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "CODE";
            // 
            // txtCODE
            // 
            txtCODE.Location = new Point(6, 40);
            txtCODE.Name = "txtCODE";
            txtCODE.Size = new Size(443, 23);
            txtCODE.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtQuatity);
            groupBox4.Location = new Point(12, 322);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(479, 108);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "SỐ LƯỢNG";
            // 
            // txtQuatity
            // 
            txtQuatity.Location = new Point(6, 44);
            txtQuatity.Name = "txtQuatity";
            txtQuatity.Size = new Size(443, 23);
            txtQuatity.TabIndex = 0;
            // 
            // btSend
            // 
            btSend.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btSend.Location = new Point(132, 436);
            btSend.Name = "btSend";
            btSend.Size = new Size(208, 67);
            btSend.TabIndex = 1;
            btSend.Text = "Send";
            btSend.UseVisualStyleBackColor = true;
            btSend.Click += btSend_Click;
            // 
            // dxErr
            // 
            dxErr.ContainerControl = this;
            // 
            // frmClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 515);
            Controls.Add(btSend);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            Load += frmClient_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dxErr).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btSend;
        private GroupBox groupBox5;
        private Label lbLINE;
        private TextBox txtCF;
        private TextBox txtCODE;
        private TextBox txtQuatity;
        private TextBox txtReason;
        private ErrorProvider dxErr;
    }
}
