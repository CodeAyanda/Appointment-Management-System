
namespace RoughEx
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblNameU = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtNameU = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.loginDS1 = new RoughEx.LoginDS();
            this.loginTableAdapter1 = new RoughEx.LoginDSTableAdapters.LoginTableAdapter();
            this.tableAdapterManager1 = new RoughEx.LoginDSTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPCLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameU
            // 
            this.lblNameU.AutoSize = true;
            this.lblNameU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameU.Location = new System.Drawing.Point(77, 72);
            this.lblNameU.Name = "lblNameU";
            this.lblNameU.Size = new System.Drawing.Size(116, 18);
            this.lblNameU.TabIndex = 0;
            this.lblNameU.Text = "Enter Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(77, 107);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(114, 18);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Enter Password";
            // 
            // txtNameU
            // 
            this.txtNameU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameU.Location = new System.Drawing.Point(205, 72);
            this.txtNameU.Name = "txtNameU";
            this.txtNameU.Size = new System.Drawing.Size(100, 24);
            this.txtNameU.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(205, 107);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 24);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(205, 157);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(192, 34);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Login for manager";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(311, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // loginDS1
            // 
            this.loginDS1.DataSetName = "LoginDS";
            this.loginDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.LoginTableAdapter = this.loginTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = RoughEx.LoginDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "JustEnvironmentalServices Login ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnPCLogin
            // 
            this.btnPCLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCLogin.Location = new System.Drawing.Point(205, 206);
            this.btnPCLogin.Name = "btnPCLogin";
            this.btnPCLogin.Size = new System.Drawing.Size(195, 29);
            this.btnPCLogin.TabIndex = 10;
            this.btnPCLogin.Text = "Login for PestController";
            this.btnPCLogin.UseVisualStyleBackColor = true;
            this.btnPCLogin.Click += new System.EventHandler(this.btnPCLogin_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPCLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNameU);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNameU);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameU;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtNameU;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnClear;
        private LoginDS loginDS1;
        private LoginDSTableAdapters.LoginTableAdapter loginTableAdapter1;
        private LoginDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPCLogin;
    }
}