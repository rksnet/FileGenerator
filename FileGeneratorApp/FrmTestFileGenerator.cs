using BusinessLayer.DataProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FileGeneratorApp
{
    public partial class FrmTestFileGenerator : Form
    {
        public FrmTestFileGenerator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(txtFilePath.Text);
                Mapper mapper = new Mapper();
                mapper.GetTestFile(doc.InnerXml, saveFileDialog.FileName);

            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
