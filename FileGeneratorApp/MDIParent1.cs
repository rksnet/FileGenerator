using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.DataProcessing;
using System.Xml;
using System.IO;
namespace FileGeneratorApp
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
          

        }

        private void OpenFile(object sender, EventArgs e)
        {

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testDataTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sourceInputFile = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\ConfigFiles\\XMLFIle.XML";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string destPath = folderBrowserDialog1.SelectedPath;
                if (!string.IsNullOrEmpty(destPath))
                {
                    File.Copy(sourceInputFile, destPath, true);
                }
                MessageBox.Show("File saved on the given location.", "Information", MessageBoxButtons.OK);
            }
        }

        private void billingVarianceTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sourceInputFile1 = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\ConfigFiles\\Input1.xlsx";
            string sourceInputFile2 = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\ConfigFiles\\Input1.xlsx";
            DialogResult result =folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string destPath = folderBrowserDialog1.SelectedPath;
                if (!string.IsNullOrEmpty(destPath))
                {
                    File.Copy(sourceInputFile1, destPath+"\\Input.xlsx", true);
                    File.Copy(sourceInputFile2, destPath+"\\Input2.xlsx", true);
                }
                MessageBox.Show("File saved on the given location.", "Information", MessageBoxButtons.OK);
            }
           
        }

        private void mnu_TestFileGenerator(object sender, EventArgs e)
        {
            Boolean IsFormShown = false;
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name == "FrmTestFileGenerator")
                {
                    IsFormShown = true;
                    ChildForm.Focus();
                }  // End if
            }
            if (!IsFormShown)
            {
                FrmTestFileGenerator frm = new FrmTestFileGenerator();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuBillingVariance_Click(object sender, EventArgs e)
        {
            Boolean IsFormShown = false;
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name == "FrmEmpBillingVariance")
                {
                    IsFormShown = true;
                    ChildForm.Focus();
                }  // End if
            }
            if (!IsFormShown)
            {
                FrmEmpBillingVariance frm = new FrmEmpBillingVariance();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
