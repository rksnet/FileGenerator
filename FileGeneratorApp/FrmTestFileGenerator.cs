using BusinessLayer.DataProcessing;
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
using System.Xml;

namespace FileGeneratorApp
{
    public partial class FrmTestFileGenerator : Form
    {
        XmlDocument docXmlDocument = new XmlDocument();
        public FrmTestFileGenerator()
        {
            InitializeComponent();
        }
        private void btnTestFile_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {

                docXmlDocument.Load(txtFilePath.Text);
                Mapper mapper = new Mapper();
                mapper.GetTestFile(docXmlDocument.InnerXml, saveFileDialog.FileName);

            }
            MessageBox.Show("Test file sucessfully generated at " + saveFileDialog.FileName);
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
                catch
                {

                }
            }
        }

        private void btnDownloadXMl_Click(object sender, EventArgs e)
        {
            string downLoadPath = Application.StartupPath + "/XMlConfiguarationFile.XML";
            docXmlDocument = new XmlDocument();
            docXmlDocument.Load(GetFilePath.GetXmlConfigFile());
            // save the document to a file and auto-indent the output.
            docXmlDocument.Save(downLoadPath);
            MessageBox.Show("XMl file downloaded at -" + downLoadPath);
        }
    }
}
