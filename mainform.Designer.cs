namespace OnamaQRCodeGenerator
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnGenerateQRCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTMLPONumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTMLPOOrderItemNo = new System.Windows.Forms.TextBox();
            this.tbVendorInvoicePartQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVendorGSTInvoiceNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVendorInvoiceDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVendorInvoiceBasicGrossRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbVendorInvoiceNetRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbVendorCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbInvoicePartNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTaxValueCGST = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTaxValuesSGST = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTaxValuesIGST = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTaxValuesUGST = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTaxRateCGSTPct = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbTaxRateSGSTPct = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTaxRateIGSTPct = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbTaxRateUGSTPct = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCess = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbTotalInvoiceValue = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbHSNSACCode = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QR Code Input:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(136, 10);
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(1232, 26);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "2540151302,10,128,206080108203,11.03.2019,2980.78,2980.78,K63440,215340100123,534" +
    "15.60,53415.60,0.00,0.00,14.00,14.00,0.00,0.00,0.00,488371.20,87087000";
            // 
            // btnGenerateQRCode
            // 
            this.btnGenerateQRCode.Location = new System.Drawing.Point(1391, 12);
            this.btnGenerateQRCode.Name = "btnGenerateQRCode";
            this.btnGenerateQRCode.Size = new System.Drawing.Size(163, 31);
            this.btnGenerateQRCode.TabIndex = 3;
            this.btnGenerateQRCode.Text = "Generate QR Code";
            this.btnGenerateQRCode.UseVisualStyleBackColor = true;
            this.btnGenerateQRCode.Click += new System.EventHandler(this.btnGenerateQRCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "TML PO Number:";
            // 
            // tbTMLPONumber
            // 
            this.tbTMLPONumber.Location = new System.Drawing.Point(150, 56);
            this.tbTMLPONumber.Name = "tbTMLPONumber";
            this.tbTMLPONumber.Size = new System.Drawing.Size(123, 26);
            this.tbTMLPONumber.TabIndex = 5;
            this.tbTMLPONumber.Text = "2540151302";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TML PO Order Item NO:";
            // 
            // tbTMLPOOrderItemNo
            // 
            this.tbTMLPOOrderItemNo.Location = new System.Drawing.Point(475, 53);
            this.tbTMLPOOrderItemNo.Name = "tbTMLPOOrderItemNo";
            this.tbTMLPOOrderItemNo.Size = new System.Drawing.Size(123, 26);
            this.tbTMLPOOrderItemNo.TabIndex = 7;
            this.tbTMLPOOrderItemNo.Text = "10";
            // 
            // tbVendorInvoicePartQty
            // 
            this.tbVendorInvoicePartQty.Location = new System.Drawing.Point(800, 53);
            this.tbVendorInvoicePartQty.Name = "tbVendorInvoicePartQty";
            this.tbVendorInvoicePartQty.Size = new System.Drawing.Size(123, 26);
            this.tbVendorInvoicePartQty.TabIndex = 9;
            this.tbVendorInvoicePartQty.Text = "128";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vendor Invoice Part Qty:";
            // 
            // tbVendorGSTInvoiceNo
            // 
            this.tbVendorGSTInvoiceNo.Location = new System.Drawing.Point(1124, 53);
            this.tbVendorGSTInvoiceNo.Name = "tbVendorGSTInvoiceNo";
            this.tbVendorGSTInvoiceNo.Size = new System.Drawing.Size(123, 26);
            this.tbVendorGSTInvoiceNo.TabIndex = 11;
            this.tbVendorGSTInvoiceNo.Text = "206080108203";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(941, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vendor GST Invoice No:";
            // 
            // tbVendorInvoiceDate
            // 
            this.tbVendorInvoiceDate.Location = new System.Drawing.Point(1423, 57);
            this.tbVendorInvoiceDate.Name = "tbVendorInvoiceDate";
            this.tbVendorInvoiceDate.Size = new System.Drawing.Size(123, 26);
            this.tbVendorInvoiceDate.TabIndex = 13;
            this.tbVendorInvoiceDate.Text = "11.03.2019";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1262, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vendor Invoice date:";
            // 
            // tbVendorInvoiceBasicGrossRate
            // 
            this.tbVendorInvoiceBasicGrossRate.Location = new System.Drawing.Point(276, 102);
            this.tbVendorInvoiceBasicGrossRate.Name = "tbVendorInvoiceBasicGrossRate";
            this.tbVendorInvoiceBasicGrossRate.Size = new System.Drawing.Size(123, 26);
            this.tbVendorInvoiceBasicGrossRate.TabIndex = 15;
            this.tbVendorInvoiceBasicGrossRate.Text = "2980.78";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vendor Invoice Basic / Gross Rate :";
            // 
            // tbVendorInvoiceNetRate
            // 
            this.tbVendorInvoiceNetRate.Location = new System.Drawing.Point(598, 105);
            this.tbVendorInvoiceNetRate.Name = "tbVendorInvoiceNetRate";
            this.tbVendorInvoiceNetRate.Size = new System.Drawing.Size(123, 26);
            this.tbVendorInvoiceNetRate.TabIndex = 17;
            this.tbVendorInvoiceNetRate.Text = "2980.78";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vendor Invoice Net Rate:";
            // 
            // tbVendorCode
            // 
            this.tbVendorCode.Location = new System.Drawing.Point(849, 102);
            this.tbVendorCode.Name = "tbVendorCode";
            this.tbVendorCode.Size = new System.Drawing.Size(123, 26);
            this.tbVendorCode.TabIndex = 19;
            this.tbVendorCode.Text = "K63440";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(736, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vendor Code:";
            // 
            // tbInvoicePartNo
            // 
            this.tbInvoicePartNo.Location = new System.Drawing.Point(1152, 98);
            this.tbInvoicePartNo.Name = "tbInvoicePartNo";
            this.tbInvoicePartNo.Size = new System.Drawing.Size(123, 26);
            this.tbInvoicePartNo.TabIndex = 21;
            this.tbInvoicePartNo.Text = "215340100123";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(990, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Invoice Part Number:";
            // 
            // tbTaxValueCGST
            // 
            this.tbTaxValueCGST.Location = new System.Drawing.Point(1450, 98);
            this.tbTaxValueCGST.Name = "tbTaxValueCGST";
            this.tbTaxValueCGST.Size = new System.Drawing.Size(123, 26);
            this.tbTaxValueCGST.TabIndex = 23;
            this.tbTaxValueCGST.Text = "53415.60";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1288, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tax Values CGST:";
            // 
            // tbTaxValuesSGST
            // 
            this.tbTaxValuesSGST.Location = new System.Drawing.Point(180, 143);
            this.tbTaxValuesSGST.Name = "tbTaxValuesSGST";
            this.tbTaxValuesSGST.Size = new System.Drawing.Size(123, 26);
            this.tbTaxValuesSGST.TabIndex = 25;
            this.tbTaxValuesSGST.Text = "53415.60";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tax Values SGST :";
            // 
            // tbTaxValuesIGST
            // 
            this.tbTaxValuesIGST.Location = new System.Drawing.Point(488, 143);
            this.tbTaxValuesIGST.Name = "tbTaxValuesIGST";
            this.tbTaxValuesIGST.Size = new System.Drawing.Size(123, 26);
            this.tbTaxValuesIGST.TabIndex = 27;
            this.tbTaxValuesIGST.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(326, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Tax Values IGST:";
            // 
            // tbTaxValuesUGST
            // 
            this.tbTaxValuesUGST.Location = new System.Drawing.Point(799, 143);
            this.tbTaxValuesUGST.Name = "tbTaxValuesUGST";
            this.tbTaxValuesUGST.Size = new System.Drawing.Size(123, 26);
            this.tbTaxValuesUGST.TabIndex = 29;
            this.tbTaxValuesUGST.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(637, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tax Values UGST:";
            // 
            // tbTaxRateCGSTPct
            // 
            this.tbTaxRateCGSTPct.Location = new System.Drawing.Point(1107, 143);
            this.tbTaxRateCGSTPct.Name = "tbTaxRateCGSTPct";
            this.tbTaxRateCGSTPct.Size = new System.Drawing.Size(123, 26);
            this.tbTaxRateCGSTPct.TabIndex = 31;
            this.tbTaxRateCGSTPct.Text = "14.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(945, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Tax Rate CGST %:";
            // 
            // tbTaxRateSGSTPct
            // 
            this.tbTaxRateSGSTPct.Location = new System.Drawing.Point(1409, 143);
            this.tbTaxRateSGSTPct.Name = "tbTaxRateSGSTPct";
            this.tbTaxRateSGSTPct.Size = new System.Drawing.Size(123, 26);
            this.tbTaxRateSGSTPct.TabIndex = 33;
            this.tbTaxRateSGSTPct.Text = "14.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1247, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Tax Rate SGST %:";
            // 
            // tbTaxRateIGSTPct
            // 
            this.tbTaxRateIGSTPct.Location = new System.Drawing.Point(180, 189);
            this.tbTaxRateIGSTPct.Name = "tbTaxRateIGSTPct";
            this.tbTaxRateIGSTPct.Size = new System.Drawing.Size(123, 26);
            this.tbTaxRateIGSTPct.TabIndex = 35;
            this.tbTaxRateIGSTPct.Text = "0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Tax Rate IGST %:";
            // 
            // tbTaxRateUGSTPct
            // 
            this.tbTaxRateUGSTPct.Location = new System.Drawing.Point(494, 189);
            this.tbTaxRateUGSTPct.Name = "tbTaxRateUGSTPct";
            this.tbTaxRateUGSTPct.Size = new System.Drawing.Size(123, 26);
            this.tbTaxRateUGSTPct.TabIndex = 37;
            this.tbTaxRateUGSTPct.Text = "0.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(332, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = "Tax Rate UGST %:";
            // 
            // tbCess
            // 
            this.tbCess.Location = new System.Drawing.Point(692, 189);
            this.tbCess.Name = "tbCess";
            this.tbCess.Size = new System.Drawing.Size(123, 26);
            this.tbCess.TabIndex = 39;
            this.tbCess.Text = "0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(637, 195);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 20);
            this.label19.TabIndex = 38;
            this.label19.Text = "Cess:";
            // 
            // tbTotalInvoiceValue
            // 
            this.tbTotalInvoiceValue.Location = new System.Drawing.Point(998, 189);
            this.tbTotalInvoiceValue.Name = "tbTotalInvoiceValue";
            this.tbTotalInvoiceValue.Size = new System.Drawing.Size(123, 26);
            this.tbTotalInvoiceValue.TabIndex = 41;
            this.tbTotalInvoiceValue.Text = "488371.20";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(843, 195);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 20);
            this.label20.TabIndex = 40;
            this.label20.Text = "Total Invoice Value :";
            // 
            // tbHSNSACCode
            // 
            this.tbHSNSACCode.Location = new System.Drawing.Point(1294, 189);
            this.tbHSNSACCode.Name = "tbHSNSACCode";
            this.tbHSNSACCode.Size = new System.Drawing.Size(123, 26);
            this.tbHSNSACCode.TabIndex = 43;
            this.tbHSNSACCode.Text = "87087000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1139, 195);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 20);
            this.label21.TabIndex = 42;
            this.label21.Text = "HSN/  SAC Code:";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(1574, 10);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(86, 35);
            this.btnSaveFile.TabIndex = 44;
            this.btnSaveFile.Text = "Save All";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(1666, 9);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 37);
            this.btnPrint.TabIndex = 45;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1828, 695);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.tbHSNSACCode);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tbTotalInvoiceValue);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbCess);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbTaxRateUGSTPct);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbTaxRateIGSTPct);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbTaxRateSGSTPct);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbTaxRateCGSTPct);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbTaxValuesUGST);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbTaxValuesIGST);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbTaxValuesSGST);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbTaxValueCGST);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbInvoicePartNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbVendorCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbVendorInvoiceNetRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbVendorInvoiceBasicGrossRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbVendorInvoiceDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbVendorGSTInvoiceNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVendorInvoicePartQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTMLPOOrderItemNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTMLPONumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateQRCode);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label1);
            this.Name = "mainform";
            this.Text = "QR Code Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnGenerateQRCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTMLPONumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTMLPOOrderItemNo;
        private System.Windows.Forms.TextBox tbVendorInvoicePartQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVendorGSTInvoiceNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVendorInvoiceDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVendorInvoiceBasicGrossRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbVendorInvoiceNetRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbVendorCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbInvoicePartNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTaxValueCGST;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTaxValuesSGST;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTaxValuesIGST;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTaxValuesUGST;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTaxRateCGSTPct;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbTaxRateSGSTPct;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTaxRateIGSTPct;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbTaxRateUGSTPct;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCess;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbTotalInvoiceValue;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbHSNSACCode;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

