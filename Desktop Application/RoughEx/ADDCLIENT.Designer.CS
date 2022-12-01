
namespace RoughEx
{
    partial class ADDCLIENT
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
            System.Windows.Forms.Label lblClientID;
            System.Windows.Forms.Label lblClientfName;
            System.Windows.Forms.Label lblCLientLname;
            System.Windows.Forms.Label lblCompName;
            System.Windows.Forms.Label lblClientAddress;
            System.Windows.Forms.Label lblClinetDistrict;
            System.Windows.Forms.Label lblClientcity;
            System.Windows.Forms.Label lblClientContactNumber;
            System.Windows.Forms.Label lblClientEmail;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDCLIENT));
            this.clientDS = new RoughEx.ClientDS();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new RoughEx.ClientDSTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new RoughEx.ClientDSTableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lblAddC = new System.Windows.Forms.Label();
            this.btnAddC = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLastC = new System.Windows.Forms.Button();
            this.btnPreviousC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCfName = new System.Windows.Forms.TextBox();
            this.txtCLname = new System.Windows.Forms.TextBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtClinetNo = new System.Windows.Forms.TextBox();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            lblClientID = new System.Windows.Forms.Label();
            lblClientfName = new System.Windows.Forms.Label();
            lblCLientLname = new System.Windows.Forms.Label();
            lblCompName = new System.Windows.Forms.Label();
            lblClientAddress = new System.Windows.Forms.Label();
            lblClinetDistrict = new System.Windows.Forms.Label();
            lblClientcity = new System.Windows.Forms.Label();
            lblClientContactNumber = new System.Windows.Forms.Label();
            lblClientEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
            this.clientsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientID
            // 
            lblClientID.AutoSize = true;
            lblClientID.Location = new System.Drawing.Point(61, 221);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new System.Drawing.Size(62, 13);
            lblClientID.TabIndex = 3;
            lblClientID.Text = "CLIENT ID:";
            // 
            // lblClientfName
            // 
            lblClientfName.AutoSize = true;
            lblClientfName.Location = new System.Drawing.Point(38, 259);
            lblClientfName.Name = "lblClientfName";
            lblClientfName.Size = new System.Drawing.Size(116, 13);
            lblClientfName.TabIndex = 5;
            lblClientfName.Text = "CLIENT FIRST NAME:";
            // 
            // lblCLientLname
            // 
            lblCLientLname.AutoSize = true;
            lblCLientLname.Location = new System.Drawing.Point(38, 296);
            lblCLientLname.Name = "lblCLientLname";
            lblCLientLname.Size = new System.Drawing.Size(112, 13);
            lblCLientLname.TabIndex = 7;
            lblCLientLname.Text = "CLIENT LAST NAME:";
            // 
            // lblCompName
            // 
            lblCompName.AutoSize = true;
            lblCompName.Location = new System.Drawing.Point(16, 335);
            lblCompName.Name = "lblCompName";
            lblCompName.Size = new System.Drawing.Size(138, 13);
            lblCompName.TabIndex = 9;
            lblCompName.Text = "CLIENT COMPANY NAME:";
            // 
            // lblClientAddress
            // 
            lblClientAddress.AutoSize = true;
            lblClientAddress.Location = new System.Drawing.Point(47, 372);
            lblClientAddress.Name = "lblClientAddress";
            lblClientAddress.Size = new System.Drawing.Size(103, 13);
            lblClientAddress.TabIndex = 11;
            lblClientAddress.Text = "CLIENT ADDRESS:";
            // 
            // lblClinetDistrict
            // 
            lblClinetDistrict.AutoSize = true;
            lblClinetDistrict.Location = new System.Drawing.Point(355, 249);
            lblClinetDistrict.Name = "lblClinetDistrict";
            lblClinetDistrict.Size = new System.Drawing.Size(101, 13);
            lblClinetDistrict.TabIndex = 13;
            lblClinetDistrict.Text = "CLIENT DISTRICT:";
            // 
            // lblClientcity
            // 
            lblClientcity.AutoSize = true;
            lblClientcity.Location = new System.Drawing.Point(355, 283);
            lblClientcity.Name = "lblClientcity";
            lblClientcity.Size = new System.Drawing.Size(75, 13);
            lblClientcity.TabIndex = 15;
            lblClientcity.Text = "CLIENT CITY:";
            // 
            // lblClientContactNumber
            // 
            lblClientContactNumber.AutoSize = true;
            lblClientContactNumber.Location = new System.Drawing.Point(355, 315);
            lblClientContactNumber.Name = "lblClientContactNumber";
            lblClientContactNumber.Size = new System.Drawing.Size(152, 13);
            lblClientContactNumber.TabIndex = 17;
            lblClientContactNumber.Text = "CLIENT CONTACT NUMBER:";
            // 
            // lblClientEmail
            // 
            lblClientEmail.AutoSize = true;
            lblClientEmail.Location = new System.Drawing.Point(355, 355);
            lblClientEmail.Name = "lblClientEmail";
            lblClientEmail.Size = new System.Drawing.Size(132, 13);
            lblClientEmail.TabIndex = 19;
            lblClientEmail.Text = "CLIENTEMAILADDRESS:";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // clientsBindingNavigatorSaveItem
            // 
            this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
            this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
            this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientsBindingNavigatorSaveItem.Text = "Save Data";
            this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
            // 
            // clientsBindingNavigator
            // 
            this.clientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
            this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientsBindingNavigatorSaveItem});
            this.clientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientsBindingNavigator.Name = "clientsBindingNavigator";
            this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientsBindingNavigator.Size = new System.Drawing.Size(1119, 25);
            this.clientsBindingNavigator.TabIndex = 0;
            this.clientsBindingNavigator.Text = "bindingNavigator1";
            this.clientsBindingNavigator.RefreshItems += new System.EventHandler(this.clientsBindingNavigator_RefreshItems);
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
            this.clientsDataGridView.Location = new System.Drawing.Point(21, 44);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(956, 122);
            this.clientsDataGridView.TabIndex = 1;
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
            // lblAddC
            // 
            this.lblAddC.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddC.Location = new System.Drawing.Point(296, 169);
            this.lblAddC.Name = "lblAddC";
            this.lblAddC.Size = new System.Drawing.Size(361, 49);
            this.lblAddC.TabIndex = 2;
            this.lblAddC.Text = "Add client details";
            this.lblAddC.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddC
            // 
            this.btnAddC.Location = new System.Drawing.Point(729, 178);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(165, 36);
            this.btnAddC.TabIndex = 21;
            this.btnAddC.Text = "Add New Clients Details";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1041, 73);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLastC
            // 
            this.btnLastC.Location = new System.Drawing.Point(1041, 111);
            this.btnLastC.Name = "btnLastC";
            this.btnLastC.Size = new System.Drawing.Size(75, 23);
            this.btnLastC.TabIndex = 25;
            this.btnLastC.Text = "Last";
            this.btnLastC.UseVisualStyleBackColor = true;
            this.btnLastC.Click += new System.EventHandler(this.btnLastC_Click);
            // 
            // btnPreviousC
            // 
            this.btnPreviousC.Location = new System.Drawing.Point(1041, 44);
            this.btnPreviousC.Name = "btnPreviousC";
            this.btnPreviousC.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousC.TabIndex = 26;
            this.btnPreviousC.Text = "Previous";
            this.btnPreviousC.UseVisualStyleBackColor = true;
            this.btnPreviousC.Click += new System.EventHandler(this.btnPreviousC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1049, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Navigation";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(729, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 38);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Close Client page";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(358, 395);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(692, 395);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(337, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 33;
            // 
            // txtCfName
            // 
            this.txtCfName.Location = new System.Drawing.Point(169, 259);
            this.txtCfName.Name = "txtCfName";
            this.txtCfName.Size = new System.Drawing.Size(139, 20);
            this.txtCfName.TabIndex = 34;
            // 
            // txtCLname
            // 
            this.txtCLname.Location = new System.Drawing.Point(169, 296);
            this.txtCLname.Name = "txtCLname";
            this.txtCLname.Size = new System.Drawing.Size(139, 20);
            this.txtCLname.TabIndex = 35;
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(169, 335);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(139, 20);
            this.txtCompName.TabIndex = 36;
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(169, 369);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(139, 20);
            this.txtCAddress.TabIndex = 37;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(523, 249);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(154, 20);
            this.txtDistrict.TabIndex = 38;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(523, 283);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(154, 20);
            this.txtCity.TabIndex = 39;
            // 
            // txtClinetNo
            // 
            this.txtClinetNo.Location = new System.Drawing.Point(523, 315);
            this.txtClinetNo.Name = "txtClinetNo";
            this.txtClinetNo.Size = new System.Drawing.Size(154, 20);
            this.txtClinetNo.TabIndex = 40;
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(523, 348);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(210, 20);
            this.txtCEmail.TabIndex = 41;
            // 
            // ADDCLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1119, 475);
            this.Controls.Add(this.txtCEmail);
            this.Controls.Add(this.txtClinetNo);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.txtCAddress);
            this.Controls.Add(this.txtCompName);
            this.Controls.Add(this.txtCLname);
            this.Controls.Add(this.txtCfName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreviousC);
            this.Controls.Add(this.btnLastC);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddC);
            this.Controls.Add(lblClientEmail);
            this.Controls.Add(lblClientContactNumber);
            this.Controls.Add(lblClientcity);
            this.Controls.Add(lblClinetDistrict);
            this.Controls.Add(lblClientAddress);
            this.Controls.Add(lblCompName);
            this.Controls.Add(lblCLientLname);
            this.Controls.Add(lblClientfName);
            this.Controls.Add(lblClientID);
            this.Controls.Add(this.lblAddC);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.clientsBindingNavigator);
            this.Name = "ADDCLIENT";
            this.Text = "ADDCLIENT";
            this.Load += new System.EventHandler(this.ADDCLIENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
            this.clientsBindingNavigator.ResumeLayout(false);
            this.clientsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClientDS clientDS;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ClientDSTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private ClientDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
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
        private System.Windows.Forms.Label lblAddC;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLastC;
        private System.Windows.Forms.Button btnPreviousC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCfName;
        private System.Windows.Forms.TextBox txtCLname;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtClinetNo;
        private System.Windows.Forms.TextBox txtCEmail;
    }
}