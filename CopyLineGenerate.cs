using OnamaQRCodeGenerator;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class CopyLineGenerate : Form
    {
        List<Bitmap> bitmapList = new List<Bitmap>();
        List<PictureBox> pbList = new List<PictureBox>();
        //List<string> inputList = new List<string>();
        List<string> filenameList = new List<string>();
        List<System.Windows.Forms.Label> labelList = new List<System.Windows.Forms.Label>();
        int listCounter = 0;
        public CopyLineGenerate()
        {
            InitializeComponent();
        }

        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            string filename = GetQRFileName();
            GenerateQRCode(tbInputDataLine.Text, filename);
        }
        private void btnSaveFile_Click(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please make sure you have saved QR codes. Do you want to close this window?", "Close Window", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private string GetQRFileName()
        {
            string filename = string.Empty;
            try
            {
                string input = tbInputDataLine.Text;
                if (input.IndexOf('\n') >= 0)
                {
                    filename = input.Substring(input.IndexOf('\n') + 1, input.IndexOf('\t') - input.IndexOf('\n') - 1) + ".png";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching file name:" + ex.Message);
                filename = string.Empty;
            }
            return filename;
        }
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


    }
}
