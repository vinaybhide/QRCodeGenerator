using QRCodeGenerator;
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
        //List<string> inputList = new List<string>();
        List<string> filenameList = new List<string>();
        List<System.Windows.Forms.Label> labelList = new List<System.Windows.Forms.Label>();
        int listCounter = 0;

        private void GenerateQRCode(string qrInputData, string inputfileName)
        {
            using (QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator())
            //using (QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCoder.QRCodeGenerator.ECCLevel.Q))
            //using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCoder.QRCodeGenerator.ECCLevel.Q))
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrInputData, QRCoder.QRCodeGenerator.ECCLevel.Q))
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                Bitmap qrCodeImage = qrCode.GetGraphic(3);
                //qrCodeImage.Save(@"d:\img.png", System.Drawing.Imaging.ImageFormat.Png);
                //pbQRCode.Image= qrCodeImage;
                PictureBox pictureBox = new PictureBox();
                //if (listCounter == -1)
                if (listCounter == 0)
                {
                    pictureBox.Location = new Point(70, 185);
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                //else if (((listCounter != 0) && (listCounter % 5) == 0))
                else if ((listCounter % 5) == 0)
                {
                    pictureBox.Location = new Point(70, pbList[(listCounter - 1)].Location.Y + pbList[(listCounter - 1)].Height + 20);
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                else
                {
                    pictureBox.Location = new Point(pbList[(listCounter - 1)].Location.X + pbList[(listCounter - 1)].Width + 10, pbList[(listCounter - 1)].Location.Y);
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                pictureBox.Image = qrCodeImage;
                pictureBox.Visible = true;
                pictureBox.Show();

                this.Controls.Add(pictureBox);

                bitmapList.Add(qrCodeImage);
                pbList.Add(pictureBox);
                //inputList.Add(tbInput.Text);

                //string filename = tbVendorGSTInvoiceNo.Text + ".png";
                filenameList.Add(inputfileName);

                System.Windows.Forms.Label pbName = new System.Windows.Forms.Label();
                pbName.Text = inputfileName;
                pbName.Location = new Point(pbList[listCounter].Location.X, pbList[listCounter].Location.Y + pbList[listCounter].Height + 2);
                pbName.AutoSize = true;
                pbName.Visible = true;
                pbName.Show();
                this.Controls.Add(pbName);
                labelList.Add(pbName);
                listCounter++;
            }
        }
        private void btnGenerateQRCode_Click(object sender, EventArgs e)
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

            //tbInput.Text = qrText;

            GenerateQRCode(qrText, tbVendorGSTInvoiceNo.Text + ".png");
        }

        private void btnGenerateQRLine_Click(object sender, EventArgs e)
        {
            string[] fields;
            string line = tbInput.Text;
            fields = line.Split(',');
            //if (fields.Length == 20)
            //{
            //GenerateQRCode(line, fields[3] + ".png");
            GenerateQRCode(line, fields[3] + ".png");
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (bitmapList.Count <= 0)
            {
                MessageBox.Show("Nothing to save!");
            }
            else
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        for (int i = 0; i < listCounter; i++)
                        {
                            bitmapList[i].Save(fbd.SelectedPath + "\\" + filenameList[i], System.Drawing.Imaging.ImageFormat.Png);
                        }
                        MessageBox.Show("All QR Codes saved in - " + fbd.SelectedPath);
                    }
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportInputs inputParam = new ImportInputs();
            if (inputParam.DialogResult != DialogResult.Cancel)
            {
                DialogResult inputResults = inputParam.ShowDialog(this);
                if (inputResults == DialogResult.OK)
                {
                    using (var filedlg = new OpenFileDialog())
                    {
                        filedlg.Multiselect = false;
                        filedlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                        DialogResult result = filedlg.ShowDialog();
                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(filedlg.FileName))
                        {
                            string fileContent = File.ReadAllText(filedlg.FileName);
                            string[] fields;
                            using (TextReader textReader = new StringReader(fileContent))
                            {
                                string line = string.Empty;
                                while (string.IsNullOrEmpty(line = textReader.ReadLine()) == false)
                                {
                                    //fields = line.Split(',');
                                    fields = line.Split(inputParam.fieldSeparator.ToCharArray()[0]);
                                    //if (fields.Length == 20)
                                    //{
                                    //GenerateQRCode(line, fields[3] + ".png");
                                    GenerateQRCode(line, fields[inputParam.uniqueFieldNumber - 1] + ".png");
                                    //}
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            if (pbList.Count > 0)
            {
                foreach (var item in pbList)
                {
                    this.Controls.Remove(item);
                }
                pbList.Clear();
            }
            if (labelList.Count > 0)
            {
                foreach (var item in labelList)
                {
                    this.Controls.Remove(item);
                }
                labelList.Clear();
            }

            if (bitmapList.Count > 0)
            {
                bitmapList.Clear();
            }
            //if (inputList.Count > 0)
            //{
            //    inputList.Clear();
            //}
            if (filenameList.Count > 0)
            {
                filenameList.Clear();
            }

            listCounter = 0;
        }

        private void btnCopyGenerateQR_Click(object sender, EventArgs e)
        {
            CopyLineGenerate hyundaiinputParam = new CopyLineGenerate();
            DialogResult inputResults = hyundaiinputParam.ShowDialog(this);
        }

    }
}
