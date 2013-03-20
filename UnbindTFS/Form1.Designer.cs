namespace UnbindTFS
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dlgFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbIgnore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btOpen = new System.Windows.Forms.Button();
            this.btUnbind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lkLogFile = new System.Windows.Forms.LinkLabel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder location";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(113, 16);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(397, 20);
            this.tbLocation.TabIndex = 1;
            // 
            // tbIgnore
            // 
            this.tbIgnore.Location = new System.Drawing.Point(113, 45);
            this.tbIgnore.Name = "tbIgnore";
            this.tbIgnore.Size = new System.Drawing.Size(397, 20);
            this.tbIgnore.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ignore folders";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(531, 15);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 3;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // btUnbind
            // 
            this.btUnbind.Location = new System.Drawing.Point(531, 44);
            this.btUnbind.Name = "btUnbind";
            this.btUnbind.Size = new System.Drawing.Size(75, 23);
            this.btUnbind.TabIndex = 3;
            this.btUnbind.Text = "Unbind";
            this.btUnbind.UseVisualStyleBackColor = true;
            this.btUnbind.Click += new System.EventHandler(this.Unbind_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Log file";
            // 
            // lkLogFile
            // 
            this.lkLogFile.AutoSize = true;
            this.lkLogFile.Location = new System.Drawing.Point(113, 107);
            this.lkLogFile.Name = "lkLogFile";
            this.lkLogFile.Size = new System.Drawing.Size(41, 13);
            this.lkLogFile.TabIndex = 4;
            this.lkLogFile.TabStop = true;
            this.lkLogFile.Text = "Log file";
            this.lkLogFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogFile_LinkClicked);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(113, 78);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(59, 13);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Not started";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 138);
            this.Controls.Add(this.lkLogFile);
            this.Controls.Add(this.btUnbind);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbIgnore);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unbind Tfs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderBrowser;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbIgnore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btUnbind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lkLogFile;
        private System.Windows.Forms.Label lbStatus;
    }
}

