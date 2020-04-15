namespace FileGeneratorApp
{
    partial class frmInputDetails
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblOpenFile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSaveFileLocation = new System.Windows.Forms.TextBox();
            this.lblOutputFileSave = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbFileType = new System.Windows.Forms.ComboBox();
            this.lblFileType = new System.Windows.Forms.Label();
            this.txtDelimeter = new System.Windows.Forms.TextBox();
            this.lblDelimeter = new System.Windows.Forms.Label();
            this.txtDateFormat = new System.Windows.Forms.TextBox();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.recordsCount = new System.Windows.Forms.NumericUpDown();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "FilrDialog";
            this.openFileDialog.Title = "Select XML File";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(677, 31);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(88, 29);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(160, 32);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(517, 24);
            this.txtFilePath.TabIndex = 1;
            // 
            // lblOpenFile
            // 
            this.lblOpenFile.AutoSize = true;
            this.lblOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenFile.Location = new System.Drawing.Point(3, 35);
            this.lblOpenFile.Name = "lblOpenFile";
            this.lblOpenFile.Size = new System.Drawing.Size(133, 18);
            this.lblOpenFile.TabIndex = 2;
            this.lblOpenFile.Text = "Select XML file*:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtSaveFileLocation);
            this.panel1.Controls.Add(this.lblOutputFileSave);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.cmbFileType);
            this.panel1.Controls.Add(this.lblFileType);
            this.panel1.Controls.Add(this.txtDelimeter);
            this.panel1.Controls.Add(this.lblDelimeter);
            this.panel1.Controls.Add(this.txtDateFormat);
            this.panel1.Controls.Add(this.lblDateFormat);
            this.panel1.Controls.Add(this.recordsCount);
            this.panel1.Controls.Add(this.lblRecordCount);
            this.panel1.Controls.Add(this.lblOpenFile);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 425);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Red;
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblError.Location = new System.Drawing.Point(3, 230);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(2, 22);
            this.lblError.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(677, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 29);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSaveFileLocation
            // 
            this.txtSaveFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaveFileLocation.Location = new System.Drawing.Point(160, 185);
            this.txtSaveFileLocation.Name = "txtSaveFileLocation";
            this.txtSaveFileLocation.Size = new System.Drawing.Size(511, 24);
            this.txtSaveFileLocation.TabIndex = 13;
            // 
            // lblOutputFileSave
            // 
            this.lblOutputFileSave.AutoSize = true;
            this.lblOutputFileSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputFileSave.Location = new System.Drawing.Point(3, 191);
            this.lblOutputFileSave.Name = "lblOutputFileSave";
            this.lblOutputFileSave.Size = new System.Drawing.Size(139, 18);
            this.lblOutputFileSave.TabIndex = 4;
            this.lblOutputFileSave.Text = "Output File path*:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(471, 284);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(164, 30);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(143, 284);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(164, 30);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbFileType
            // 
            this.cmbFileType.FormattingEnabled = true;
            this.cmbFileType.Items.AddRange(new object[] {
            "Select",
            "CSV",
            "TXT",
            "XLS",
            "XLSX"});
            this.cmbFileType.Location = new System.Drawing.Point(143, 144);
            this.cmbFileType.Name = "cmbFileType";
            this.cmbFileType.Size = new System.Drawing.Size(86, 24);
            this.cmbFileType.TabIndex = 10;
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileType.Location = new System.Drawing.Point(3, 144);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(133, 18);
            this.lblFileType.TabIndex = 9;
            this.lblFileType.Text = "Output file type*:";
            // 
            // txtDelimeter
            // 
            this.txtDelimeter.Location = new System.Drawing.Point(619, 92);
            this.txtDelimeter.MaxLength = 1;
            this.txtDelimeter.Name = "txtDelimeter";
            this.txtDelimeter.Size = new System.Drawing.Size(56, 22);
            this.txtDelimeter.TabIndex = 8;
            // 
            // lblDelimeter
            // 
            this.lblDelimeter.AutoSize = true;
            this.lblDelimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelimeter.Location = new System.Drawing.Point(518, 93);
            this.lblDelimeter.Name = "lblDelimeter";
            this.lblDelimeter.Size = new System.Drawing.Size(85, 18);
            this.lblDelimeter.TabIndex = 7;
            this.lblDelimeter.Text = "Delimeter:";
            // 
            // txtDateFormat
            // 
            this.txtDateFormat.Location = new System.Drawing.Point(390, 92);
            this.txtDateFormat.MaxLength = 10;
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Size = new System.Drawing.Size(96, 22);
            this.txtDateFormat.TabIndex = 6;
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFormat.Location = new System.Drawing.Point(260, 93);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(107, 18);
            this.lblDateFormat.TabIndex = 5;
            this.lblDateFormat.Text = "Date Format:";
            // 
            // recordsCount
            // 
            this.recordsCount.Location = new System.Drawing.Point(195, 93);
            this.recordsCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.recordsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recordsCount.Name = "recordsCount";
            this.recordsCount.Size = new System.Drawing.Size(46, 22);
            this.recordsCount.TabIndex = 4;
            this.recordsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(3, 93);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(168, 18);
            this.lblRecordCount.TabIndex = 3;
            this.lblRecordCount.Text = "Number of Records*:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // frmInputDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmInputDetails";
            this.Text = "Input Details";
            this.Load += new System.EventHandler(this.frmInputDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblOpenFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFileType;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.TextBox txtDelimeter;
        private System.Windows.Forms.Label lblDelimeter;
        private System.Windows.Forms.TextBox txtDateFormat;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.NumericUpDown recordsCount;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSaveFileLocation;
        private System.Windows.Forms.Label lblOutputFileSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblError;
    }
}

