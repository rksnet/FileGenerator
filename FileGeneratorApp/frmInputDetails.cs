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
using BusinessLayer;

namespace FileGeneratorApp
{
    public partial class frmInputDetails : Form
    {

        public frmInputDetails()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    txtFilePath.Text = file;

                }
                catch (IOException)
                {
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInputDetails_Load(object sender, EventArgs e)
        {
            cmbFileType.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // When user clicks button, show the dialog.
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Get file name.
            string name = saveFileDialog.FileName;
            txtSaveFileLocation.Text = name;
            // Write to the file name selected.
            // ... You can write the text from a TextBox instead of a string literal.
            // File.WriteAllText(name, "test");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            BindDataAndProcess();
        }

        private bool ValidateInput()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txtFilePath.Text) || string.IsNullOrWhiteSpace(txtFilePath.Text))
                result = false;

            if (string.IsNullOrEmpty(txtSaveFileLocation.Text) || string.IsNullOrWhiteSpace(txtSaveFileLocation.Text))
                result = false;

            if (cmbFileType.SelectedIndex <= 0)
                result = false;

            return result;
        }
        private void BindDataAndProcess()
        {
            if (!ValidateInput())
            {
                lblError.Text = "Fields marked with (*) are mandatory.";
            }
            else
            {
                lblError.Text = "";
                XmlProcessing xmlProcessing = new XmlProcessing(txtFilePath.Text);
                xmlProcessing.RecordCount = Convert.ToInt32(recordsCount.Value);
                xmlProcessing.DateFormat = txtDateFormat.Text;
                xmlProcessing.Delimeter = Convert.ToChar(txtDelimeter.Text);
                xmlProcessing.OutputFileType = cmbFileType.SelectedItem.ToString();
                xmlProcessing.OutputFileName = Path.GetFileName(txtSaveFileLocation.Text);
                xmlProcessing.OutputFilePath = txtSaveFileLocation.Text;

                //bool result = xmlProcessing.ParseAndGenerateFile();
                //if (result)
                //    MessageBox.Show("File generated and saved on the given location.", "Information", MessageBoxButtons.OK);
                //else
                //    MessageBox.Show("File generation process failedq.", "Information", MessageBoxButtons.OK);
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            BindDataAndProcess();
        }
    }
}