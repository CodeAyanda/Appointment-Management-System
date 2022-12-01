
namespace RoughEx
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accessControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pestControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPestControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPestControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppointmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateServiceAppointmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelServiceAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePaymentReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePestControllerReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateClientsReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLogged = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchClientDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessControlToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.pestControllerToolStripMenuItem,
            this.serviceAppointmentToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(153, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accessControlToolStripMenuItem
            // 
            this.accessControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.accessControlToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accessControlToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.accessControlToolStripMenuItem.Name = "accessControlToolStripMenuItem";
            this.accessControlToolStripMenuItem.Size = new System.Drawing.Size(120, 19);
            this.accessControlToolStripMenuItem.Text = "Access_Control";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.searchClientDetailsToolStripMenuItem,
            this.searchClientDetailsToolStripMenuItem1});
            this.clientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(120, 19);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addToolStripMenuItem.Text = "Add  New Client details";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // searchClientDetailsToolStripMenuItem
            // 
            this.searchClientDetailsToolStripMenuItem.Name = "searchClientDetailsToolStripMenuItem";
            this.searchClientDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.searchClientDetailsToolStripMenuItem.Text = "Update Client details ";
            this.searchClientDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchClientDetailsToolStripMenuItem_Click);
            // 
            // pestControllerToolStripMenuItem
            // 
            this.pestControllerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPestControllerToolStripMenuItem,
            this.searchPestControllerToolStripMenuItem});
            this.pestControllerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pestControllerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.pestControllerToolStripMenuItem.Name = "pestControllerToolStripMenuItem";
            this.pestControllerToolStripMenuItem.Size = new System.Drawing.Size(120, 19);
            this.pestControllerToolStripMenuItem.Text = "PestController";
            // 
            // addPestControllerToolStripMenuItem
            // 
            this.addPestControllerToolStripMenuItem.Name = "addPestControllerToolStripMenuItem";
            this.addPestControllerToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.addPestControllerToolStripMenuItem.Text = "Add/ Update Pest Controller details";
            this.addPestControllerToolStripMenuItem.Click += new System.EventHandler(this.addPestControllerToolStripMenuItem_Click);
            // 
            // searchPestControllerToolStripMenuItem
            // 
            this.searchPestControllerToolStripMenuItem.Name = "searchPestControllerToolStripMenuItem";
            this.searchPestControllerToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.searchPestControllerToolStripMenuItem.Text = "Search Pest Controller";
            this.searchPestControllerToolStripMenuItem.Click += new System.EventHandler(this.searchPestControllerToolStripMenuItem_Click);
            // 
            // serviceAppointmentToolStripMenuItem
            // 
            this.serviceAppointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppointmentDetailsToolStripMenuItem,
            this.updateServiceAppointmentDetailsToolStripMenuItem,
            this.cancelServiceAppointmentToolStripMenuItem});
            this.serviceAppointmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serviceAppointmentToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.serviceAppointmentToolStripMenuItem.Name = "serviceAppointmentToolStripMenuItem";
            this.serviceAppointmentToolStripMenuItem.Size = new System.Drawing.Size(120, 19);
            this.serviceAppointmentToolStripMenuItem.Text = "ServiceAppointment";
            // 
            // addAppointmentDetailsToolStripMenuItem
            // 
            this.addAppointmentDetailsToolStripMenuItem.Name = "addAppointmentDetailsToolStripMenuItem";
            this.addAppointmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.addAppointmentDetailsToolStripMenuItem.Text = "Add  appointment Details";
            this.addAppointmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.addAppointmentDetailsToolStripMenuItem_Click);
            // 
            // updateServiceAppointmentDetailsToolStripMenuItem
            // 
            this.updateServiceAppointmentDetailsToolStripMenuItem.Name = "updateServiceAppointmentDetailsToolStripMenuItem";
            this.updateServiceAppointmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.updateServiceAppointmentDetailsToolStripMenuItem.Text = "Update Service Appointment Details";
            this.updateServiceAppointmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateServiceAppointmentDetailsToolStripMenuItem_Click);
            // 
            // cancelServiceAppointmentToolStripMenuItem
            // 
            this.cancelServiceAppointmentToolStripMenuItem.Name = "cancelServiceAppointmentToolStripMenuItem";
            this.cancelServiceAppointmentToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.cancelServiceAppointmentToolStripMenuItem.Text = "Cancel Service appointment";
            this.cancelServiceAppointmentToolStripMenuItem.Click += new System.EventHandler(this.cancelServiceAppointmentToolStripMenuItem_Click_1);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportsToolStripMenuItem,
            this.generateInvoiceToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(120, 19);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // generateReportsToolStripMenuItem
            // 
            this.generateReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatePaymentReportsToolStripMenuItem,
            this.generatePestControllerReportsToolStripMenuItem,
            this.generateClientsReportsToolStripMenuItem});
            this.generateReportsToolStripMenuItem.Name = "generateReportsToolStripMenuItem";
            this.generateReportsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.generateReportsToolStripMenuItem.Text = "Generate reports";
            this.generateReportsToolStripMenuItem.Click += new System.EventHandler(this.generateReportsToolStripMenuItem_Click);
            // 
            // generatePaymentReportsToolStripMenuItem
            // 
            this.generatePaymentReportsToolStripMenuItem.Name = "generatePaymentReportsToolStripMenuItem";
            this.generatePaymentReportsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.generatePaymentReportsToolStripMenuItem.Text = "Generate Payment reports";
            this.generatePaymentReportsToolStripMenuItem.Click += new System.EventHandler(this.generatePaymentReportsToolStripMenuItem_Click);
            // 
            // generatePestControllerReportsToolStripMenuItem
            // 
            this.generatePestControllerReportsToolStripMenuItem.Name = "generatePestControllerReportsToolStripMenuItem";
            this.generatePestControllerReportsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.generatePestControllerReportsToolStripMenuItem.Text = "Generate Pest Controller Reports";
            this.generatePestControllerReportsToolStripMenuItem.Click += new System.EventHandler(this.generatePestControllerReportsToolStripMenuItem_Click);
            // 
            // generateClientsReportsToolStripMenuItem
            // 
            this.generateClientsReportsToolStripMenuItem.Name = "generateClientsReportsToolStripMenuItem";
            this.generateClientsReportsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.generateClientsReportsToolStripMenuItem.Text = "Generate Clients Reports";
            this.generateClientsReportsToolStripMenuItem.Click += new System.EventHandler(this.generateClientsReportsToolStripMenuItem_Click);
            // 
            // generateInvoiceToolStripMenuItem
            // 
            this.generateInvoiceToolStripMenuItem.Name = "generateInvoiceToolStripMenuItem";
            this.generateInvoiceToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.generateInvoiceToolStripMenuItem.Text = "Generate Invoice";
            this.generateInvoiceToolStripMenuItem.Click += new System.EventHandler(this.generateInvoiceToolStripMenuItem_Click);
            // 
            // lblLogged
            // 
            this.lblLogged.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogged.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogged.Location = new System.Drawing.Point(0, 209);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(153, 24);
            this.lblLogged.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // searchClientDetailsToolStripMenuItem1
            // 
            this.searchClientDetailsToolStripMenuItem1.Name = "searchClientDetailsToolStripMenuItem1";
            this.searchClientDetailsToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.searchClientDetailsToolStripMenuItem1.Text = "Search Client Details";
            this.searchClientDetailsToolStripMenuItem1.Click += new System.EventHandler(this.searchClientDetailsToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogged);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "JustEnvironmentalServices";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accessControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pestControllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPestControllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppointmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchClientDetailsToolStripMenuItem;
        private System.Windows.Forms.Label lblLogged;
        private System.Windows.Forms.ToolStripMenuItem generateInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePaymentReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePestControllerReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateClientsReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPestControllerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem updateServiceAppointmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelServiceAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchClientDetailsToolStripMenuItem1;
    }
}

