namespace QRCodeGenerator
{
    partial class CopyLineGenerate
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
            this.tbInputDataLine = new System.Windows.Forms.TextBox();
            this.btnGenerateQRCode = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copy & paste input data in below text box and click Generate QR Code button (1 QR" +
    " at a time)";
            // 
            // tbInputDataLine
            // 
            this.tbInputDataLine.Location = new System.Drawing.Point(14, 67);
            this.tbInputDataLine.Multiline = true;
            this.tbInputDataLine.Name = "tbInputDataLine";
            this.tbInputDataLine.Size = new System.Drawing.Size(1796, 121);
            this.tbInputDataLine.TabIndex = 1;
            // 
            // btnGenerateQRCode
            // 
            this.btnGenerateQRCode.Location = new System.Drawing.Point(766, 18);
            this.btnGenerateQRCode.Name = "btnGenerateQRCode";
            this.btnGenerateQRCode.Size = new System.Drawing.Size(176, 37);
            this.btnGenerateQRCode.TabIndex = 2;
            this.btnGenerateQRCode.Text = "Generate &QR Code";
            this.btnGenerateQRCode.UseVisualStyleBackColor = true;
            this.btnGenerateQRCode.Click += new System.EventHandler(this.btnGenerateQRCode_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1219, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(948, 18);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(171, 35);
            this.btnSaveFile.TabIndex = 45;
            this.btnSaveFile.Text = "Save A&ll QR Code";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(1125, 19);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(88, 35);
            this.btnResetAll.TabIndex = 48;
            this.btnResetAll.Text = "&Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // CopyLineGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1822, 799);
            this.ControlBox = false;
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerateQRCode);
            this.Controls.Add(this.tbInputDataLine);
            this.Controls.Add(this.label1);
            this.Name = "CopyLineGenerate";
            this.Text = "Copy Data Line & Generate QR Code";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputDataLine;
        private System.Windows.Forms.Button btnGenerateQRCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnResetAll;
    }
}