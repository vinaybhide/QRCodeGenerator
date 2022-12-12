using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnamaQRCodeGenerator
{
    public partial class ImportInputs : Form
    {
        public string fieldSeparator = string.Empty;
        public int uniqueFieldNumber = -1;
        public string appDirectoryPath = string.Empty;
        public string sepFileName = "separator.txt";
        List<SeparatorClass> separatorFields = new List<SeparatorClass>();
        public ImportInputs()
        {
            InitializeComponent();

            cbFieldSeparator.Items.Add("--Select Separator--");
            appDirectoryPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";
            if (File.Exists(appDirectoryPath + sepFileName) == false)
            {
                MessageBox.Show("Separator file is missing! You will not be able to import data");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                string fileContent = File.ReadAllText(appDirectoryPath + sepFileName);
                using (TextReader textReader = new StringReader(fileContent))
                {
                    string line = string.Empty;
                    string[] fields;


                    while (string.IsNullOrEmpty(line = textReader.ReadLine()) == false)
                    {
                        fields = line.Split('=');
                        if (fields.Length > 0)
                        {
                            SeparatorClass separator = new SeparatorClass();
                            separator.showText = fields[0];
                            separator.showValue = char.ConvertFromUtf32(Int32.Parse(fields[1]));
                            separatorFields.Add(separator);
                            cbFieldSeparator.Items.Add(separator.showText);
                        }
                    }
                }
                cbFieldSeparator.SelectedIndex = 0;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbFieldSeparator.SelectedIndex > 0) 
                {
                    fieldSeparator = separatorFields[cbFieldSeparator.SelectedIndex - 1].showValue;
                    uniqueFieldNumber = Int32.Parse(numericFieldNo.Value.ToString());
                }
                else
                {
                    MessageBox.Show("Please select valid field separator or click cancel to close Import");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please provide correct inputs. Or click cancel to stop Import." + Environment.NewLine + "Exception:" + ex.Message);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fieldSeparator = string.Empty;
            uniqueFieldNumber = -1;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
    public class SeparatorClass
    {
        public string showText = string.Empty;
        public string showValue;
    }

}
