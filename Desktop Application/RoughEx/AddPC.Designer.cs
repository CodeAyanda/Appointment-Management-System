
namespace RoughEx
{
    partial class AddPC
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
            System.Windows.Forms.Label lblPCID;
            System.Windows.Forms.Label lblPCName;
            System.Windows.Forms.Label lblPCSurname;
            System.Windows.Forms.Label lblPCPhoneNumber;
            System.Windows.Forms.Label lblPCEmail;
            System.Windows.Forms.Label lblPCAvail;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPC));
            this.btnPCADD = new System.Windows.Forms.Button();
            this.pCDS = new RoughEx.PCDS();
            this.pest_ControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pest_ControllerTableAdapter = new RoughEx.PCDSTableAdapters.Pest_ControllerTableAdapter();
            this.tableAdapterManager = new RoughEx.PCDSTableAdapters.TableAdapterManager();
            this.pest_ControllerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pest_ControllerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pest_ControllerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPCID = new System.Windows.Forms.TextBox();
            this.txtPCName = new System.Windows.Forms.TextBox();
            this.txtPCSurname = new System.Windows.Forms.TextBox();
            this.txtPCPhoneNo = new System.Windows.Forms.TextBox();
            this.txtPCEMail = new System.Windows.Forms.TextBox();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.btnAddPCExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPcUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            lblPCID = new System.Windows.Forms.Label();
            lblPCName = new System.Windows.Forms.Label();
            lblPCSurname = new System.Windows.Forms.Label();
            lblPCPhoneNumber = new System.Windows.Forms.Label();
            lblPCEmail = new System.Windows.Forms.Label();
            lblPCAvail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pCDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pest_ControllerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pest_ControllerBindingNavigator)).BeginInit();
            this.pest_ControllerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pest_ControllerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPCID
            // 
            lblPCID.AutoSize = true;
            lblPCID.Location = new System.Drawing.Point(11, 269);
            lblPCID.Name = "lblPCID";
            lblPCID.Size = new System.Drawing.Size(128, 13);
            lblPCID.TabIndex = 4;
            lblPCID.Text = "PEST CONTROLLER ID:";
            // 
            // lblPCName
            // 
            lblPCName.AutoSize = true;
            lblPCName.Location = new System.Drawing.Point(98, 307);
            lblPCName.Name = "lblPCName";
            lblPCName.Size = new System.Drawing.Size(41, 13);
            lblPCName.TabIndex = 6;
            lblPCName.Text = "NAME:";
            // 
            // lblPCSurname
            // 
            lblPCSurname.AutoSize = true;
            lblPCSurname.Location = new System.Drawing.Point(75, 341);
            lblPCSurname.Name = "lblPCSurname";
            lblPCSurname.Size = new System.Drawing.Size(64, 13);
            lblPCSurname.TabIndex = 8;
            lblPCSurname.Text = "SURNAME:";
            // 
            // lblPCPhoneNumber
            // 
            lblPCPhoneNumber.AutoSize = true;
            lblPCPhoneNumber.Location = new System.Drawing.Point(390, 269);
            lblPCPhoneNumber.Name = "lblPCPhoneNumber";
            lblPCPhoneNumber.Size = new System.Drawing.Size(98, 13);
            lblPCPhoneNumber.TabIndex = 10;
            lblPCPhoneNumber.Text = "PHONE NUMBER:";
            // 
            // lblPCEmail
            // 
            lblPCEmail.AutoSize = true;
            lblPCEmail.Location = new System.Drawing.Point(446, 304);
            lblPCEmail.Name = "lblPCEmail";
            lblPCEmail.Size = new System.Drawing.Size(42, 13);
            lblPCEmail.TabIndex = 12;
            lblPCEmail.Text = "EMAIL:";
            // 
            // lblPCAvail
            // 
            lblPCAvail.AutoSize = true;
            lblPCAvail.Location = new System.Drawing.Point(315, 341);
            lblPCAvail.Name = "lblPCAvail";
            lblPCAvail.Size = new System.Drawing.Size(187, 13);
            lblPCAvail.TabIndex = 14;
            lblPCAvail.Text = "PEST CONTROLLER AVAILABILITY:";
            // 
            // btnPCADD
            // 
            this.btnPCADD.Location = new System.Drawing.Point(229, 379);
            this.btnPCADD.Name = "btnPCADD";
            this.btnPCADD.Size = new System.Drawing.Size(152, 37);
            this.btnPCADD.TabIndex = 0;
            this.btnPCADD.Text = "Add Pest controller";
            this.btnPCADD.UseVisualStyleBackColor = true;
            this.btnPCADD.Click += new System.EventHandler(this.btnPCADD_Click);
            // 
            // pCDS
            // 
            this.pCDS.DataSetName = "PCDS";
            this.pCDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pest_ControllerBindingSource
            // 
            this.pest_ControllerBindingSource.DataMember = "Pest_Controller";
            this.pest_ControllerBindingSource.DataSource = this.pCDS;
            // 
            // pest_ControllerTableAdapter
            // 
            this.pest_ControllerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Pest_ControllerTableAdapter = this.pest_ControllerTableAdapter;
            this.tableAdapterManager.UpdateOrder = RoughEx.PCDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pest_ControllerBindingNavigator
            // 
            this.pest_ControllerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pest_ControllerBindingNavigator.BindingSource = this.pest_ControllerBindingSource;
            this.pest_ControllerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pest_ControllerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pest_ControllerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pest_ControllerBindingNavigatorSaveItem});
            this.pest_ControllerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pest_ControllerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pest_ControllerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pest_ControllerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pest_ControllerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pest_ControllerBindingNavigator.Name = "pest_ControllerBindingNavigator";
            this.pest_ControllerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pest_ControllerBindingNavigator.Size = new System.Drawing.Size(1132, 25);
            this.pest_ControllerBindingNavigator.TabIndex = 2;
            this.pest_ControllerBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // pest_ControllerBindingNavigatorSaveItem
            // 
            this.pest_ControllerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pest_ControllerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pest_ControllerBindingNavigatorSaveItem.Image")));
            this.pest_ControllerBindingNavigatorSaveItem.Name = "pest_ControllerBindingNavigatorSaveItem";
            this.pest_ControllerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pest_ControllerBindingNavigatorSaveItem.Text = "Save Data";
            this.pest_ControllerBindingNavigatorSaveItem.Click += new System.EventHandler(this.pest_ControllerBindingNavigatorSaveItem_Click);
            // 
            // pest_ControllerDataGridView
            // 
            this.pest_ControllerDataGridView.AutoGenerateColumns = false;
            this.pest_ControllerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pest_ControllerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pest_ControllerDataGridView.DataSource = this.pest_ControllerBindingSource;
            this.pest_ControllerDataGridView.Location = new System.Drawing.Point(12, 39);
            this.pest_ControllerDataGridView.Name = "pest_ControllerDataGridView";
            this.pest_ControllerDataGridView.Size = new System.Drawing.Size(653, 130);
            this.pest_ControllerDataGridView.TabIndex = 3;
            this.pest_ControllerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pest_ControllerDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PEST_CONTROLLER_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PEST_CONTROLLER_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SURNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "SURNAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PHONE_NUMBER";
            this.dataGridViewTextBoxColumn4.HeaderText = "PHONE_NUMBER";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn5.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PEST_CONTROLLER_AVAILABILITY";
            this.dataGridViewTextBoxColumn6.HeaderText = "PEST_CONTROLLER_AVAILABILITY";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // txtPCID
            // 
            this.txtPCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pest_ControllerBindingSource, "PEST_CONTROLLER_ID", true));
            this.txtPCID.Location = new System.Drawing.Point(145, 266);
            this.txtPCID.Name = "txtPCID";
            this.txtPCID.Size = new System.Drawing.Size(131, 20);
            this.txtPCID.TabIndex = 5;
            // 
            // txtPCName
            // 
            this.txtPCName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pest_ControllerBindingSource, "NAME", true));
            this.txtPCName.Location = new System.Drawing.Point(145, 304);
            this.txtPCName.Name = "txtPCName";
            this.txtPCName.Size = new System.Drawing.Size(131, 20);
            this.txtPCName.TabIndex = 7;
            // 
            // txtPCSurname
            // 
            this.txtPCSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pest_ControllerBindingSource, "SURNAME", true));
            this.txtPCSurname.Location = new System.Drawing.Point(145, 338);
            this.txtPCSurname.Name = "txtPCSurname";
            this.txtPCSurname.Size = new System.Drawing.Size(131, 20);
            this.txtPCSurname.TabIndex = 9;
            // 
            // txtPCPhoneNo
            // 
            this.txtPCPhoneNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pest_ControllerBindingSource, "PHONE_NUMBER", true));
            this.txtPCPhoneNo.Location = new System.Drawing.Point(508, 266);
            this.txtPCPhoneNo.MaxLength = 10;
            this.txtPCPhoneNo.Name = "txtPCPhoneNo";
            this.txtPCPhoneNo.Size = new System.Drawing.Size(150, 20);
            this.txtPCPhoneNo.TabIndex = 11;
            this.txtPCPhoneNo.TextChanged += new System.EventHandler(this.txtPCPhoneNo_TextChanged);
            this.txtPCPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPCPhoneNo_KeyPress);
            // 
            // txtPCEMail
            // 
            this.txtPCEMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pest_ControllerBindingSource, "EMAIL", true));
            this.txtPCEMail.Location = new System.Drawing.Point(508, 304);
            this.txtPCEMail.Name = "txtPCEMail";
            this.txtPCEMail.Size = new System.Drawing.Size(150, 20);
            this.txtPCEMail.TabIndex = 13;
            // 
            // txtAvail
            // 
            this.txtAvail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pest_ControllerBindingSource, "PEST_CONTROLLER_AVAILABILITY", true));
            this.txtAvail.Location = new System.Drawing.Point(508, 338);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.Size = new System.Drawing.Size(150, 20);
            this.txtAvail.TabIndex = 15;
            // 
            // btnAddPCExit
            // 
            this.btnAddPCExit.Location = new System.Drawing.Point(623, 384);
            this.btnAddPCExit.Name = "btnAddPCExit";
            this.btnAddPCExit.Size = new System.Drawing.Size(111, 32);
            this.btnAddPCExit.TabIndex = 16;
            this.btnAddPCExit.Text = "Exit";
            this.btnAddPCExit.UseVisualStyleBackColor = true;
            this.btnAddPCExit.Click += new System.EventHandler(this.btnAddPCExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 49);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add / Update  Pest Controller Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(811, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPcUpdate
            // 
            this.btnPcUpdate.Location = new System.Drawing.Point(425, 379);
            this.btnPcUpdate.Name = "btnPcUpdate";
            this.btnPcUpdate.Size = new System.Drawing.Size(152, 37);
            this.btnPcUpdate.TabIndex = 22;
            this.btnPcUpdate.Text = "Update Pest Controller Details";
            this.btnPcUpdate.UseVisualStyleBackColor = true;
            this.btnPcUpdate.Click += new System.EventHandler(this.btnPcUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPcUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPCExit);
            this.Controls.Add(lblPCAvail);
            this.Controls.Add(this.txtAvail);
            this.Controls.Add(lblPCEmail);
            this.Controls.Add(this.txtPCEMail);
            this.Controls.Add(lblPCPhoneNumber);
            this.Controls.Add(this.txtPCPhoneNo);
            this.Controls.Add(lblPCSurname);
            this.Controls.Add(this.txtPCSurname);
            this.Controls.Add(lblPCName);
            this.Controls.Add(this.txtPCName);
            this.Controls.Add(lblPCID);
            this.Controls.Add(this.txtPCID);
            this.Controls.Add(this.pest_ControllerDataGridView);
            this.Controls.Add(this.pest_ControllerBindingNavigator);
            this.Controls.Add(this.btnPCADD);
            this.Name = "AddPC";
            this.Text = "AddPC";
            this.Load += new System.EventHandler(this.AddPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pest_ControllerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pest_ControllerBindingNavigator)).EndInit();
            this.pest_ControllerBindingNavigator.ResumeLayout(false);
            this.pest_ControllerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pest_ControllerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPCADD;
        private PCDS pCDS;
        private System.Windows.Forms.BindingSource pest_ControllerBindingSource;
        private PCDSTableAdapters.Pest_ControllerTableAdapter pest_ControllerTableAdapter;
        private PCDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pest_ControllerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pest_ControllerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pest_ControllerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txtPCID;
        private System.Windows.Forms.TextBox txtPCName;
        private System.Windows.Forms.TextBox txtPCSurname;
        private System.Windows.Forms.TextBox txtPCPhoneNo;
        private System.Windows.Forms.TextBox txtPCEMail;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.Button btnAddPCExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPcUpdate;
        private System.Windows.Forms.Button button1;
    }
}