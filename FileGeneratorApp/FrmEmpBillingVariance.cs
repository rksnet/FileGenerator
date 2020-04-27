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
using System.IO;

namespace FileGeneratorApp
{
    public partial class FrmEmpBillingVariance : Form
    {
        public FrmEmpBillingVariance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sourceInputFile1 = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\ConfigFiles\\Input1.xlsx";
            string sourceInputFile2 = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\ConfigFiles\\Input1.xlsx";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string destPath = folderBrowserDialog1.SelectedPath;
                if (!string.IsNullOrEmpty(destPath))
                {
                    File.Copy(sourceInputFile1, destPath + "\\Input.xlsx", true);
                    File.Copy(sourceInputFile2, destPath + "\\Input2.xlsx", true);
                }
                MessageBox.Show("File saved on the given location.", "Information", MessageBoxButtons.OK);
            }
        }

        private void btnOpenFile1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                
                try
                {
                    txtInputFile1.Text = file;

                }
                catch
                {

                }
            }
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    txtInputFile2.Text = file;

                }
                catch
                {

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if(!ValidateInput())
                {
                    MessageBox.Show("Please select input File1 and input file2", "Information", MessageBoxButtons.OK);
                    return;
                }
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        EmployeeTimeSheet obj = new EmployeeTimeSheet();
                        string fileWriteStatus = obj.GetEmpBillingCompOutputFile(txtInputFile1.Text, txtInputFile2.Text, saveFileDialog.FileName);
                        if (fileWriteStatus != string.Empty)
                        {
                            MessageBox.Show("File generated and saved on the given location.", "Information", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("File generated and saved on the given location.", "Failed", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Output File Path.", "Information", MessageBoxButtons.OK);
                    }
                    Cursor.Current = Cursors.Default;
                }

            }
            catch (Exception ex)
            {
               // Cursor.Current = Cursors.Default;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private bool ValidateInput()
        {
            bool inputfileSelectStatus = true;
            if (string.IsNullOrEmpty(txtInputFile1.Text) || string.IsNullOrWhiteSpace(txtInputFile1.Text))
                inputfileSelectStatus = false;
            if (string.IsNullOrEmpty(txtInputFile2.Text) || string.IsNullOrWhiteSpace(txtInputFile2.Text))
                inputfileSelectStatus = false;
            return inputfileSelectStatus;
        }
    }
}
