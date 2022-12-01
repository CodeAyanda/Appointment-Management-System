
namespace RoughEx
{
    partial class UpdateClient
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblClientEmail;
            System.Windows.Forms.Label lblClientContactNumber;
            System.Windows.Forms.Label lblClientcity;
            System.Windows.Forms.Label lblClinetDistrict;
            System.Windows.Forms.Label lblClientAddress;
            System.Windows.Forms.Label lblCompName;
            System.Windows.Forms.Label lblCLientLname;
            System.Windows.Forms.Label lblClientfName;
            System.Windows.Forms.Label lblClientID;
            this.clientDS = new RoughEx.ClientDS();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new RoughEx.ClientDSTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new RoughEx.ClientDSTableAdapters.TableAdapterManager();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClientUpdate = new System.Windows.Forms.Button();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.txtClinetNo = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.txtCLname = new System.Windows.Forms.TextBox();
            this.txtCfName = new System.Windows.Forms.TextBox();
            this.lblAddC = new System.Windows.Forms.Label();
            lblClientEmail = new System.Windows.Forms.Label();
            lblClientContactNumber = new System.Windows.Forms.Label();
            lblClientcity = new System.Windows.Forms.Label();
            lblClinetDistrict = new System.Windows.Forms.Label();
            lblClientAddress = new System.Windows.Forms.Label();
            lblCompName = new System.Windows.Forms.Label();
            lblCLientLname = new System.Windows.Forms.Label();
            lblClientfName = new System.Windows.Forms.Label();
            lblClientID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientDS
            // 
            this.clientDS.DataSetName = "ClientDS";
            this.clientDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.clientDS;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = RoughEx.ClientDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(12, 30);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(943, 220);
            this.clientsDataGridView.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CLIENT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CLIENT_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CLIENTFNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "CLIENTFNAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CLIENTLNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "CLIENTLNAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CLIENTCOMPANYNAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "CLIENTCOMPANYNAME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CLIENTADDRESS";
            this.dataGridViewTextBoxColumn5.HeaderText = "CLIENTADDRESS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CLIENTDISTRICT";
            this.dataGridViewTextBoxColumn6.HeaderText = "CLIENTDISTRICT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CLIENTCITY";
            this.dataGridViewTextBoxColumn7.HeaderText = "CLIENTCITY";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CLIENTCONTACTNUMBER";
            this.dataGridViewTextBoxColumn8.HeaderText = "CLIENTCONTACTNUMBER";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CLIENTEMAILADDRESS";
            this.dataGridViewTextBoxColumn9.HeaderText = "CLIENTEMAILADDRESS";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Search By Surname";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(264, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 59;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClientUpdate);
            this.groupBox1.Controls.Add(lblClientEmail);
            this.groupBox1.Controls.Add(this.txtCEmail);
            this.groupBox1.Controls.Add(lblClientContactNumber);
            this.groupBox1.Controls.Add(this.txtClinetNo);
            this.groupBox1.Controls.Add(lblClientcity);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(lblClinetDistrict);
            this.groupBox1.Controls.Add(this.txtDistrict);
            this.groupBox1.Controls.Add(lblClientAddress);
            this.groupBox1.Controls.Add(this.txtCAddress);
            this.groupBox1.Controls.Add(lblCompName);
            this.groupBox1.Controls.Add(this.txtCompName);
            this.groupBox1.Controls.Add(lblCLientLname);
            this.groupBox1.Controls.Add(this.txtCLname);
            this.groupBox1.Controls.Add(lblClientfName);
            this.groupBox1.Controls.Add(this.txtCfName);
            this.groupBox1.Controls.Add(lblClientID);
            this.groupBox1.Controls.Add(this.lblAddC);
            this.groupBox1.Location = new System.Drawing.Point(21, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 319);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 81;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(467, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 38);
            this.btnExit.TabIndex = 80;
            this.btnExit.Text = "Close Client page";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClientUpdate
            // 
            this.btnClientUpdate.Location = new System.Drawing.Point(250, 262);
            this.btnClientUpdate.Name = "btnClientUpdate";
            this.btnClientUpdate.Size = new System.Drawing.Size(165, 33);
            this.btnClientUpdate.TabIndex = 79;
            this.btnClientUpdate.Text = "Update Client Details";
            this.btnClientUpdate.UseVisualStyleBackColor = true;
            // 
            // lblClientEmail
            // 
            lblClientEmail.AutoSize = true;
            lblClientEmail.Location = new System.Drawing.Point(323, 229);
            lblClientEmail.Name = "lblClientEmail";
            lblClientEmail.Size = new System.Drawing.Size(132, 13);
            lblClientEmail.TabIndex = 77;
            lblClientEmail.Text = "CLIENTEMAILADDRESS:";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(491, 218);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(208, 20);
            this.txtCEmail.TabIndex = 78;
            // 
            // lblClientContactNumber
            // 
            lblClientContactNumber.AutoSize = true;
            lblClientContactNumber.Location = new System.Drawing.Point(323, 193);
            lblClientContactNumber.Name = "lblClientContactNumber";
            lblClientContactNumber.Size = new System.Drawing.Size(152, 13);
            lblClientContactNumber.TabIndex = 75;
            lblClientContactNumber.Text = "CLIENT CONTACT NUMBER:";
            // 
            // txtClinetNo
            // 
            this.txtClinetNo.Location = new System.Drawing.Point(491, 182);
            this.txtClinetNo.MaxLength = 10;
            this.txtClinetNo.Name = "txtClinetNo";
            this.txtClinetNo.Size = new System.Drawing.Size(154, 20);
            this.txtClinetNo.TabIndex = 76;
            // 
            // lblClientcity
            // 
            lblClientcity.AutoSize = true;
            lblClientcity.Location = new System.Drawing.Point(323, 150);
            lblClientcity.Name = "lblClientcity";
            lblClientcity.Size = new System.Drawing.Size(75, 13);
            lblClientcity.TabIndex = 73;
            lblClientcity.Text = "CLIENT CITY:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(491, 147);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(154, 20);
            this.txtCity.TabIndex = 74;
            // 
            // lblClinetDistrict
            // 
            lblClinetDistrict.AutoSize = true;
            lblClinetDistrict.Location = new System.Drawing.Point(323, 113);
            lblClinetDistrict.Name = "lblClinetDistrict";
            lblClinetDistrict.Size = new System.Drawing.Size(101, 13);
            lblClinetDistrict.TabIndex = 71;
            lblClinetDistrict.Text = "CLIENT DISTRICT:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(491, 110);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(154, 20);
            this.txtDistrict.TabIndex = 72;
            // 
            // lblClientAddress
            // 
            lblClientAddress.AutoSize = true;
            lblClientAddress.Location = new System.Drawing.Point(20, 225);
            lblClientAddress.Name = "lblClientAddress";
            lblClientAddress.Size = new System.Drawing.Size(103, 13);
            lblClientAddress.TabIndex = 69;
            lblClientAddress.Text = "CLIENT ADDRESS:";
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(133, 222);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(154, 20);
            this.txtCAddress.TabIndex = 70;
            // 
            // lblCompName
            // 
            lblCompName.AutoSize = true;
            lblCompName.Location = new System.Drawing.Point(-11, 189);
            lblCompName.Name = "lblCompName";
            lblCompName.Size = new System.Drawing.Size(138, 13);
            lblCompName.TabIndex = 67;
            lblCompName.Text = "CLIENT COMPANY NAME:";
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(133, 186);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(154, 20);
            this.txtCompName.TabIndex = 68;
            // 
            // lblCLientLname
            // 
            lblCLientLname.AutoSize = true;
            lblCLientLname.Location = new System.Drawing.Point(11, 150);
            lblCLientLname.Name = "lblCLientLname";
            lblCLientLname.Size = new System.Drawing.Size(112, 13);
            lblCLientLname.TabIndex = 65;
            lblCLientLname.Text = "CLIENT LAST NAME:";
            // 
            // txtCLname
            // 
            this.txtCLname.Location = new System.Drawing.Point(133, 147);
            this.txtCLname.Name = "txtCLname";
            this.txtCLname.Size = new System.Drawing.Size(154, 20);
            this.txtCLname.TabIndex = 66;
            // 
            // lblClientfName
            // 
            lblClientfName.AutoSize = true;
            lblClientfName.Location = new System.Drawing.Point(11, 113);
            lblClientfName.Name = "lblClientfName";
            lblClientfName.Size = new System.Drawing.Size(116, 13);
            lblClientfName.TabIndex = 63;
            lblClientfName.Text = "CLIENT FIRST NAME:";
            // 
            // txtCfName
            // 
            this.txtCfName.Location = new System.Drawing.Point(133, 106);
            this.txtCfName.Name = "txtCfName";
            this.txtCfName.Size = new System.Drawing.Size(154, 20);
            this.txtCfName.TabIndex = 64;
            // 
            // lblClientID
            // 
            lblClientID.AutoSize = true;
            lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblClientID.Location = new System.Drawing.Point(10, 58);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new System.Drawing.Size(103, 24);
            lblClientID.TabIndex = 62;
            lblClientID.Text = "CLIENT ID:";
            // 
            // lblAddC
            // 
            this.lblAddC.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddC.Location = new System.Drawing.Point(219, 16);
            this.lblAddC.Name = "lblAddC";
            this.lblAddC.Size = new System.Drawing.Size(361, 49);
            this.lblAddC.TabIndex = 61;
            this.lblAddC.Text = "Update client details";
            // 
            // UpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 696);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientsDataGridView);
            this.Name = "UpdateClient";
            this.Text = "UpdateClient";
            this.Load += new System.EventHandler(this.UpdateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ClientDS clientDS;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ClientDSTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private ClientDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClientUpdate;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.TextBox txtClinetNo;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.TextBox txtCLname;
        private System.Windows.Forms.TextBox txtCfName;
        private System.Windows.Forms.Label lblAddC;
    }
}