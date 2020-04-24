namespace FileGeneratorApp
{
    partial class FrmEmpBillingVariance
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInputFile2 = new System.Windows.Forms.TextBox();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.lblInputFile2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInputFile1 = new System.Windows.Forms.TextBox();
            this.btnOpenFile1 = new System.Windows.Forms.Button();
            this.lblInputFile1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Billing  Variance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtInputFile2);
            this.panel1.Controls.Add(this.btnOpen2);
            this.panel1.Controls.Add(this.lblInputFile2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtInputFile1);
            this.panel1.Controls.Add(this.btnOpenFile1);
            this.panel1.Controls.Add(this.lblInputFile1);
            this.panel1.Location = new System.Drawing.Point(29, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 274);
            this.panel1.TabIndex = 11;
            // 
            // txtInputFile2
            // 
            this.txtInputFile2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFile2.Location = new System.Drawing.Point(162, 131);
            this.txtInputFile2.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputFile2.Name = "txtInputFile2";
            this.txtInputFile2.ReadOnly = true;
            this.txtInputFile2.Size = new System.Drawing.Size(389, 26);
            this.txtInputFile2.TabIndex = 9;
            // 
            // btnOpen2
            // 
            this.btnOpen2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen2.Location = new System.Drawing.Point(571, 131);
            this.btnOpen2.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(66, 29);
            this.btnOpen2.TabIndex = 8;
            this.btnOpen2.Text = "Open";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // lblInputFile2
            // 
            this.lblInputFile2.AutoSize = true;
            this.lblInputFile2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFile2.Location = new System.Drawing.Point(8, 134);
            this.lblInputFile2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputFile2.Name = "lblInputFile2";
            this.lblInputFile2.Size = new System.Drawing.Size(135, 19);
            this.lblInputFile2.TabIndex = 10;
            this.lblInputFile2.Text = "Select InputFile2*:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(161, 188);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Get file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(98, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(539, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Download Input Format File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInputFile1
            // 
            this.txtInputFile1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFile1.Location = new System.Drawing.Point(161, 84);
            this.txtInputFile1.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputFile1.Name = "txtInputFile1";
            this.txtInputFile1.ReadOnly = true;
            this.txtInputFile1.Size = new System.Drawing.Size(389, 26);
            this.txtInputFile1.TabIndex = 4;
            // 
            // btnOpenFile1
            // 
            this.btnOpenFile1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenFile1.Location = new System.Drawing.Point(570, 84);
            this.btnOpenFile1.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFile1.Name = "btnOpenFile1";
            this.btnOpenFile1.Size = new System.Drawing.Size(66, 29);
            this.btnOpenFile1.TabIndex = 3;
            this.btnOpenFile1.Text = "Open";
            this.btnOpenFile1.UseVisualStyleBackColor = true;
            this.btnOpenFile1.Click += new System.EventHandler(this.btnOpenFile1_Click);
            // 
            // lblInputFile1
            // 
            this.lblInputFile1.AutoSize = true;
            this.lblInputFile1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFile1.Location = new System.Drawing.Point(7, 87);
            this.lblInputFile1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputFile1.Name = "lblInputFile1";
            this.lblInputFile1.Size = new System.Drawing.Size(135, 19);
            this.lblInputFile1.TabIndex = 5;
            this.lblInputFile1.Text = "Select InputFile1*:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = " \"Excel Files (*.xlsx;*.xls;)|*.xlsx;*.xls\" ";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "FilrDialog";
            this.openFileDialog.Filter = " \"Excel Files (*.xlsx;*.xls;)|*.xlsx;*.xls\" ";
            this.openFileDialog.Title = "Select Excel File";
            // 
            // FrmEmpBillingVariance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmEmpBillingVariance";
            this.Text = "FrmEmpBillingVariance";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInputFile2;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Label lblInputFile2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInputFile1;
        private System.Windows.Forms.Button btnOpenFile1;
        private System.Windows.Forms.Label lblInputFile1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}