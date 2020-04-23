namespace FileGeneratorApp
{
    partial class FrmTestFileGenerator
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
            this.lblOpenFile = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnDownloadXMl = new System.Windows.Forms.Button();
            this.btnTestFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOpenFile
            // 
            this.lblOpenFile.AutoSize = true;
            this.lblOpenFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenFile.Location = new System.Drawing.Point(7, 87);
            this.lblOpenFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpenFile.Name = "lblOpenFile";
            this.lblOpenFile.Size = new System.Drawing.Size(128, 19);
            this.lblOpenFile.TabIndex = 5;
            this.lblOpenFile.Text = "Select XML file*:";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenFile.Location = new System.Drawing.Point(570, 84);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(66, 29);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(161, 84);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(389, 26);
            this.txtFilePath.TabIndex = 4;
            // 
            // btnDownloadXMl
            // 
            this.btnDownloadXMl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadXMl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadXMl.Location = new System.Drawing.Point(11, 2);
            this.btnDownloadXMl.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownloadXMl.Name = "btnDownloadXMl";
            this.btnDownloadXMl.Size = new System.Drawing.Size(539, 28);
            this.btnDownloadXMl.TabIndex = 6;
            this.btnDownloadXMl.Text = "Download Xml configuration file";
            this.btnDownloadXMl.UseVisualStyleBackColor = true;
            this.btnDownloadXMl.Click += new System.EventHandler(this.btnDownloadXMl_Click);
            // 
            // btnTestFile
            // 
            this.btnTestFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestFile.Location = new System.Drawing.Point(161, 135);
            this.btnTestFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnTestFile.Name = "btnTestFile";
            this.btnTestFile.Size = new System.Drawing.Size(120, 28);
            this.btnTestFile.TabIndex = 7;
            this.btnTestFile.Text = "Get test file";
            this.btnTestFile.UseVisualStyleBackColor = true;
            this.btnTestFile.Click += new System.EventHandler(this.btnTestFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "FilrDialog";
            this.openFileDialog.Title = "Select XML File";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnTestFile);
            this.panel1.Controls.Add(this.btnDownloadXMl);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.lblOpenFile);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 274);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 47);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test file generator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTestFileGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTestFileGenerator";
            this.Text = "FrmTestFileGenerator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOpenFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnDownloadXMl;
        private System.Windows.Forms.Button btnTestFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}