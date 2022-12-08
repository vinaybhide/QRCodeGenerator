using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace OnamaQRCodeGenerator
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        public Bitmap previewBitmap;
        public string qrToPrint;

        List<Bitmap> bitmapList = new List<Bitmap>();
        List<PictureBox> pbList = new List<PictureBox>();
        List<string> inputList = new List<string>();
        List<string> filenameList = new List<string>();
        int listCounter = -1;
        private void GenerateQR()
        {
            var qrText = tbTMLPONumber.Text + "," +
            tbTMLPOOrderItemNo.Text + "," +
            tbVendorInvoicePartQty.Text + "," +
            tbVendorGSTInvoiceNo.Text + "," +
            tbVendorInvoiceDate.Text + "," +
            tbVendorInvoiceBasicGrossRate.Text + "," +
            tbVendorInvoiceNetRate.Text + "," +
            tbVendorCode.Text + "," +
            tbInvoicePartNo.Text + "," +
            tbTaxValueCGST.Text + "," +
            tbTaxValuesSGST.Text + "," +
            tbTaxValuesIGST.Text + "," +
            tbTaxValuesUGST.Text + "," +
            tbTaxRateCGSTPct.Text + "," +
            tbTaxRateSGSTPct.Text + "," +
            tbTaxRateIGSTPct.Text + "," +
            tbTaxRateUGSTPct.Text + "," +
            tbCess.Text + "," +
            tbTotalInvoiceValue.Text + "," +
            tbHSNSACCode.Text;
            
            tbInput.Text = qrText;

            using (QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator())
            //using (QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCoder.QRCodeGenerator.ECCLevel.Q))
            //using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCoder.QRCodeGenerator.ECCLevel.Q))
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(tbInput.Text, QRCoder.QRCodeGenerator.ECCLevel.Q))
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                Bitmap qrCodeImage = qrCode.GetGraphic(3);
                //qrCodeImage.Save(@"d:\img.png", System.Drawing.Imaging.ImageFormat.Png);
                //pbQRCode.Image= qrCodeImage;
                PictureBox pictureBox = new PictureBox();
                if(listCounter == -1)
                {
                    pictureBox.Location = new Point(70, 185);
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    //qrCodeImage.Save(@"d:\img2.png", System.Drawing.Imaging.ImageFormat.Png);
                }
                else if (((listCounter != 0) && (listCounter % 5) == 0))
                {
                    pictureBox.Location = new Point(70, pbList[listCounter].Location.Y + pbList[listCounter].Height + 20);
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    //qrCodeImage.Save(@"d:\img2.png", System.Drawing.Imaging.ImageFormat.Png);
                }
                else
                {
                    pictureBox.Location = new Point(pbList[listCounter].Location.X + pbList[listCounter].Width + 10, pbList[listCounter].Location.Y);
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                pictureBox.Image = qrCodeImage;
                pictureBox.Visible = true;
                pictureBox.Show();

                this.Controls.Add(pictureBox);

                bitmapList.Add(qrCodeImage);
                pbList.Add(pictureBox);
                inputList.Add(tbInput.Text);

                string filename = tbVendorGSTInvoiceNo.Text + ".png";//tbInput.Text.Split(',')[0] + ".png";
                filenameList.Add(filename);

                System.Windows.Forms.Label pbName = new System.Windows.Forms.Label();
                pbName.Text = filename;
                listCounter++;
                pbName.Location = new Point(pbList[listCounter].Location.X, pbList[listCounter].Location.Y + pbList[listCounter].Height + 2);
                pbName.AutoSize= true;
                pbName.Visible = true;
                pbName.Show();
                this.Controls.Add(pbName);
            }
        }
        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            GenerateQR();
            //var qrText = tbTMLPONumber.Text + "\n" +
            //tbTMLPOOrderItemNo.Text + "\n" +
            //tbVendorInvoicePartQty.Text + "\n" +
            //tbVendorGSTInvoiceNo.Text + "\n" +
            //tbVendorInvoiceDate.Text + "\n" +
            //tbVendorInvoiceBasicGrossRate.Text + "\n" +
            //tbVendorInvoiceNetRate.Text + "\n" +
            //tbVendorCode.Text + "\n" +
            //tbInvoicePartNo.Text + "\n" +
            //tbTaxValueCGST.Text + "\n" +
            //tbTaxValuesSGST.Text + "\n" +
            //tbTaxValuesIGST.Text + "\n" +
            //tbTaxValuesUGST.Text + "\n" +
            //tbTaxRateCGSTPct.Text + "\n" +
            //tbTaxRateSGSTPct.Text + "\n" +
            //tbTaxRateIGSTPct.Text + "\n" +
            //tbTaxRateUGSTPct.Text + "\n" +
            //tbCess.Text + "\n" +
            //tbTotalInvoiceValue.Text + "\n" +
            //tbHSNSACCode.Text;

            //using (QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator())
            ////using (QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCoder.QRCodeGenerator.ECCLevel.Q))
            ////using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCoder.QRCodeGenerator.ECCLevel.Q))
            //using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(tbInput.Text, QRCoder.QRCodeGenerator.ECCLevel.Q))
            //using (QRCode qrCode = new QRCode(qrCodeData))
            //{

            //    //Bitmap qrCodeImage = qrCode.GetGraphic(3);
            //    generatedBitmap = qrCode.GetGraphic(3);
            //    //qrCodeImage.Save(@"d:\img.png", System.Drawing.Imaging.ImageFormat.Png);
            //    //pbQRCode.Image= qrCodeImage;
            //    pbQRCode.Image = generatedBitmap;

            //}

            //using (QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator())
            //using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCoder.QRCodeGenerator.ECCLevel.Q))
            //using (QRCode qrCode = new QRCode(qrCodeData))
            //{
            //    Bitmap qrCodeImage = qrCode.GetGraphic(3);
            //    PictureBox test1 = new PictureBox();
            //    //70,285
            //    test1.Location = new Point(pbQRCode.Location.X + pbQRCode.Width + 10, pbQRCode.Location.Y);
            //    test1.Size = new Size(200, 200);
            //    test1.SizeMode = PictureBoxSizeMode.AutoSize;
            //    qrCodeImage.Save(@"d:\img2.png", System.Drawing.Imaging.ImageFormat.Png);
            //    test1.Image = qrCodeImage;
            //    test1.Visible = true;
            //    test1.Show();
            //    this.Controls.Add(test1);
            //}
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    for(int i =0; i <= listCounter; i++)
                    {
                        bitmapList[i].Save(fbd.SelectedPath + "\\" + filenameList[i], System.Drawing.Imaging.ImageFormat.Png);
                    }
                    MessageBox.Show("All QR Codes saved in - " + fbd.SelectedPath);
                }
            }

            //saveFileDialog1= new SaveFileDialog();
            //if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    generatedBitmap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            //}

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (var filedlg = new OpenFileDialog())
            {
                filedlg.Multiselect = false;
                filedlg.Filter = "image files (*.png)|*.png|All files (*.*)|*.*";
                DialogResult result = filedlg.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(filedlg.FileName))
                {
                    qrToPrint = System.IO.Path.GetFileName(filedlg.FileName);
                    printDocument1.DocumentName = qrToPrint;
                    previewBitmap = new Bitmap(filedlg.FileName);
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();

                    //printForm printDoc = new printForm(filedlg.FileName);
                    //printDoc.Show(this);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(previewBitmap, 0, 0);

        }
    }
}
