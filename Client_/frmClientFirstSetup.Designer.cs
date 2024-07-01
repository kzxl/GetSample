namespace Client_
{
    partial class frmClientFirstSetup
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
            txtLine = new TextBox();
            txtip = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btSave = new Button();
            dxError = new ErrorProvider(components);
            fbdFolder = new FolderBrowserDialog();
            txtFolder = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dxError).BeginInit();
            SuspendLayout();
            // 
            // txtLine
            // 
            txtLine.Location = new Point(80, 12);
            txtLine.Name = "txtLine";
            txtLine.Size = new Size(208, 23);
            txtLine.TabIndex = 0;
            // 
            // txtip
            // 
            txtip.Location = new Point(80, 41);
            txtip.Name = "txtip";
            txtip.Size = new Size(208, 23);
            txtip.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "LINE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 44);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "IP Server";
            // 
            // btSave
            // 
            btSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.Location = new Point(80, 107);
            btSave.Name = "btSave";
            btSave.Size = new Size(208, 23);
            btSave.TabIndex = 2;
            btSave.Text = "Save Information";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // dxError
            // 
            dxError.ContainerControl = this;
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(80, 70);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(208, 23);
            txtFolder.TabIndex = 0;
            txtFolder.Click += textBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 73);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 1;
            label3.Text = "Folder Save";
            // 
            // frmClientFirstSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 159);
            Controls.Add(btSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFolder);
            Controls.Add(txtip);
            Controls.Add(txtLine);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmClientFirstSetup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FirstSetup";
            Load += frmClientFirstSetup_Load;
            ((System.ComponentModel.ISupportInitialize)dxError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLine;
        private TextBox txtip;
        private Label label1;
        private Label label2;
        private Button btSave;
        private ErrorProvider dxError;
        private Label label3;
        private TextBox txtFolder;
        private FolderBrowserDialog fbdFolder;
    }
}