
namespace RoughEx
{
    partial class Report
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
            this.btnReport = new System.Windows.Forms.Button();
            this.RtxtReport = new System.Windows.Forms.RichTextBox();
            this.btnReportExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(468, 76);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(150, 23);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // RtxtReport
            // 
            this.RtxtReport.Location = new System.Drawing.Point(37, 39);
            this.RtxtReport.Name = "RtxtReport";
            this.RtxtReport.Size = new System.Drawing.Size(365, 255);
            this.RtxtReport.TabIndex = 1;
            this.RtxtReport.Text = "";
            // 
            // btnReportExit
            // 
            this.btnReportExit.Location = new System.Drawing.Point(468, 126);
            this.btnReportExit.Name = "btnReportExit";
            this.btnReportExit.Size = new System.Drawing.Size(150, 23);
            this.btnReportExit.TabIndex = 2;
            this.btnReportExit.Text = "Exit";
            this.btnReportExit.UseVisualStyleBackColor = true;
            this.btnReportExit.Click += new System.EventHandler(this.btnReportExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(447, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 144);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReportExit);
            this.Controls.Add(this.RtxtReport);
            this.Controls.Add(this.btnReport);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.RichTextBox RtxtReport;
        private System.Windows.Forms.Button btnReportExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}