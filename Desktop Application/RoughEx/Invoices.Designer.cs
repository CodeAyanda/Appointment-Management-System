
namespace RoughEx
{
    partial class Invoices
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
            System.Windows.Forms.Label sERVICE_APPOINTMENT_DATELabel;
            System.Windows.Forms.Label sERVICE_APPOINTMENT_START_TIMELabel;
            System.Windows.Forms.Label pAYMENT_METHODLabel;
            System.Windows.Forms.Label cLIENT_IDLabel;
            System.Windows.Forms.Label pEST_CONTROLLER_IDLabel;
            System.Windows.Forms.Label sERVICE_APPOINTMENT_STATUSLabel;
            System.Windows.Forms.Label sERVICE_APPOINTMENT_PRICELabel;
            System.Windows.Forms.Label sERVICE_APPOINTMENT_END_TIMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices));
            this.invoicesDS = new RoughEx.InvoicesDS();
            this.service_AppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service_AppointmentTableAdapter = new RoughEx.InvoicesDSTableAdapters.Service_AppointmentTableAdapter();
            this.tableAdapterManager = new RoughEx.InvoicesDSTableAdapters.TableAdapterManager();
            this.service_AppointmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.service_AppointmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtStartT = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtClientIDI = new System.Windows.Forms.TextBox();
            this.txtPCIDI = new System.Windows.Forms.TextBox();
            this.txtStatusID = new System.Windows.Forms.TextBox();
            this.btnInvoicesSearch = new System.Windows.Forms.Button();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.txtISASearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.invoicesRDS = new RoughEx.InvoicesRDS();
            this.service_AppointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.service_AppointmentTableAdapter1 = new RoughEx.InvoicesRDSTableAdapters.Service_AppointmentTableAdapter();
            this.tableAdapterManager1 = new RoughEx.InvoicesRDSTableAdapters.TableAdapterManager();
            this.InvoiceDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.TXTendTime = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            sERVICE_APPOINTMENT_DATELabel = new System.Windows.Forms.Label();
            sERVICE_APPOINTMENT_START_TIMELabel = new System.Windows.Forms.Label();
            pAYMENT_METHODLabel = new System.Windows.Forms.Label();
            cLIENT_IDLabel = new System.Windows.Forms.Label();
            pEST_CONTROLLER_IDLabel = new System.Windows.Forms.Label();
            sERVICE_APPOINTMENT_STATUSLabel = new System.Windows.Forms.Label();
            sERVICE_APPOINTMENT_PRICELabel = new System.Windows.Forms.Label();
            sERVICE_APPOINTMENT_END_TIMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentBindingNavigator)).BeginInit();
            this.service_AppointmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesRDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sERVICE_APPOINTMENT_DATELabel
            // 
            sERVICE_APPOINTMENT_DATELabel.AutoSize = true;
            sERVICE_APPOINTMENT_DATELabel.Location = new System.Drawing.Point(25, 229);
            sERVICE_APPOINTMENT_DATELabel.Name = "sERVICE_APPOINTMENT_DATELabel";
            sERVICE_APPOINTMENT_DATELabel.Size = new System.Drawing.Size(169, 13);
            sERVICE_APPOINTMENT_DATELabel.TabIndex = 4;
            sERVICE_APPOINTMENT_DATELabel.Text = "SERVICE APPOINTMENT DATE:";
            // 
            // sERVICE_APPOINTMENT_START_TIMELabel
            // 
            sERVICE_APPOINTMENT_START_TIMELabel.AutoSize = true;
            sERVICE_APPOINTMENT_START_TIMELabel.Location = new System.Drawing.Point(25, 260);
            sERVICE_APPOINTMENT_START_TIMELabel.Name = "sERVICE_APPOINTMENT_START_TIMELabel";
            sERVICE_APPOINTMENT_START_TIMELabel.Size = new System.Drawing.Size(205, 13);
            sERVICE_APPOINTMENT_START_TIMELabel.TabIndex = 6;
            sERVICE_APPOINTMENT_START_TIMELabel.Text = "SERVICE APPOINTMENT START TIME:";
            // 
            // pAYMENT_METHODLabel
            // 
            pAYMENT_METHODLabel.AutoSize = true;
            pAYMENT_METHODLabel.Location = new System.Drawing.Point(423, 264);
            pAYMENT_METHODLabel.Name = "pAYMENT_METHODLabel";
            pAYMENT_METHODLabel.Size = new System.Drawing.Size(112, 13);
            pAYMENT_METHODLabel.TabIndex = 10;
            pAYMENT_METHODLabel.Text = "PAYMENT METHOD:";
            // 
            // cLIENT_IDLabel
            // 
            cLIENT_IDLabel.AutoSize = true;
            cLIENT_IDLabel.Location = new System.Drawing.Point(126, 194);
            cLIENT_IDLabel.Name = "cLIENT_IDLabel";
            cLIENT_IDLabel.Size = new System.Drawing.Size(62, 13);
            cLIENT_IDLabel.TabIndex = 12;
            cLIENT_IDLabel.Text = "CLIENT ID:";
            // 
            // pEST_CONTROLLER_IDLabel
            // 
            pEST_CONTROLLER_IDLabel.AutoSize = true;
            pEST_CONTROLLER_IDLabel.Location = new System.Drawing.Point(424, 191);
            pEST_CONTROLLER_IDLabel.Name = "pEST_CONTROLLER_IDLabel";
            pEST_CONTROLLER_IDLabel.Size = new System.Drawing.Size(128, 13);
            pEST_CONTROLLER_IDLabel.TabIndex = 14;
            pEST_CONTROLLER_IDLabel.Text = "PEST CONTROLLER ID:";
            // 
            // sERVICE_APPOINTMENT_STATUSLabel
            // 
            sERVICE_APPOINTMENT_STATUSLabel.AutoSize = true;
            sERVICE_APPOINTMENT_STATUSLabel.Location = new System.Drawing.Point(368, 226);
            sERVICE_APPOINTMENT_STATUSLabel.Name = "sERVICE_APPOINTMENT_STATUSLabel";
            sERVICE_APPOINTMENT_STATUSLabel.Size = new System.Drawing.Size(183, 13);
            sERVICE_APPOINTMENT_STATUSLabel.TabIndex = 16;
            sERVICE_APPOINTMENT_STATUSLabel.Text = "SERVICE APPOINTMENT STATUS:";
            // 
            // sERVICE_APPOINTMENT_PRICELabel
            // 
            sERVICE_APPOINTMENT_PRICELabel.AutoSize = true;
            sERVICE_APPOINTMENT_PRICELabel.Location = new System.Drawing.Point(380, 301);
            sERVICE_APPOINTMENT_PRICELabel.Name = "sERVICE_APPOINTMENT_PRICELabel";
            sERVICE_APPOINTMENT_PRICELabel.Size = new System.Drawing.Size(172, 13);
            sERVICE_APPOINTMENT_PRICELabel.TabIndex = 24;
            sERVICE_APPOINTMENT_PRICELabel.Text = "SERVICE APPOINTMENT PRICE:";
            // 
            // sERVICE_APPOINTMENT_END_TIMELabel
            // 
            sERVICE_APPOINTMENT_END_TIMELabel.AutoSize = true;
            sERVICE_APPOINTMENT_END_TIMELabel.Location = new System.Drawing.Point(38, 306);
            sERVICE_APPOINTMENT_END_TIMELabel.Name = "sERVICE_APPOINTMENT_END_TIMELabel";
            sERVICE_APPOINTMENT_END_TIMELabel.Size = new System.Drawing.Size(192, 13);
            sERVICE_APPOINTMENT_END_TIMELabel.TabIndex = 25;
            sERVICE_APPOINTMENT_END_TIMELabel.Text = "SERVICE APPOINTMENT END TIME:";
            // 
            // invoicesDS
            // 
            this.invoicesDS.DataSetName = "InvoicesDS";
            this.invoicesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // service_AppointmentBindingSource
            // 
            this.service_AppointmentBindingSource.DataMember = "Service_Appointment";
            this.service_AppointmentBindingSource.DataSource = this.invoicesDS;
            // 
            // service_AppointmentTableAdapter
            // 
            this.service_AppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Service_AppointmentTableAdapter = this.service_AppointmentTableAdapter;
            this.tableAdapterManager.UpdateOrder = RoughEx.InvoicesDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // service_AppointmentBindingNavigator
            // 
            this.service_AppointmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.service_AppointmentBindingNavigator.BindingSource = this.service_AppointmentBindingSource;
            this.service_AppointmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.service_AppointmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.service_AppointmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.service_AppointmentBindingNavigatorSaveItem});
            this.service_AppointmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.service_AppointmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.service_AppointmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.service_AppointmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.service_AppointmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.service_AppointmentBindingNavigator.Name = "service_AppointmentBindingNavigator";
            this.service_AppointmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.service_AppointmentBindingNavigator.Size = new System.Drawing.Size(1038, 25);
            this.service_AppointmentBindingNavigator.TabIndex = 0;
            this.service_AppointmentBindingNavigator.Text = "bindingNavigator1";
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
            // service_AppointmentBindingNavigatorSaveItem
            // 
            this.service_AppointmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.service_AppointmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("service_AppointmentBindingNavigatorSaveItem.Image")));
            this.service_AppointmentBindingNavigatorSaveItem.Name = "service_AppointmentBindingNavigatorSaveItem";
            this.service_AppointmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.service_AppointmentBindingNavigatorSaveItem.Text = "Save Data";
            this.service_AppointmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.service_AppointmentBindingNavigatorSaveItem_Click);
            // 
            // txtStartT
            // 
            this.txtStartT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_AppointmentBindingSource, "SERVICE_APPOINTMENT_START_TIME", true));
            this.txtStartT.Location = new System.Drawing.Point(236, 253);
            this.txtStartT.Name = "txtStartT";
            this.txtStartT.Size = new System.Drawing.Size(100, 20);
            this.txtStartT.TabIndex = 7;
            // 
            // txtPayment
            // 
            this.txtPayment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_AppointmentBindingSource, "PAYMENT_METHOD", true));
            this.txtPayment.Location = new System.Drawing.Point(558, 264);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 20);
            this.txtPayment.TabIndex = 11;
            // 
            // txtClientIDI
            // 
            this.txtClientIDI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_AppointmentBindingSource, "CLIENT_ID", true));
            this.txtClientIDI.Location = new System.Drawing.Point(236, 191);
            this.txtClientIDI.Name = "txtClientIDI";
            this.txtClientIDI.Size = new System.Drawing.Size(100, 20);
            this.txtClientIDI.TabIndex = 13;
            // 
            // txtPCIDI
            // 
            this.txtPCIDI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_AppointmentBindingSource, "PEST_CONTROLLER_ID", true));
            this.txtPCIDI.Location = new System.Drawing.Point(558, 188);
            this.txtPCIDI.Name = "txtPCIDI";
            this.txtPCIDI.Size = new System.Drawing.Size(100, 20);
            this.txtPCIDI.TabIndex = 15;
            // 
            // txtStatusID
            // 
            this.txtStatusID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_AppointmentBindingSource, "SERVICE_APPOINTMENT_STATUS", true));
            this.txtStatusID.Location = new System.Drawing.Point(558, 226);
            this.txtStatusID.Name = "txtStatusID";
            this.txtStatusID.Size = new System.Drawing.Size(100, 20);
            this.txtStatusID.TabIndex = 17;
            // 
            // btnInvoicesSearch
            // 
            this.btnInvoicesSearch.Location = new System.Drawing.Point(476, 40);
            this.btnInvoicesSearch.Name = "btnInvoicesSearch";
            this.btnInvoicesSearch.Size = new System.Drawing.Size(75, 23);
            this.btnInvoicesSearch.TabIndex = 18;
            this.btnInvoicesSearch.Text = "Search";
            this.btnInvoicesSearch.UseVisualStyleBackColor = true;
            this.btnInvoicesSearch.Click += new System.EventHandler(this.btnInvoicesSearch_Click);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Location = new System.Drawing.Point(383, 392);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(215, 23);
            this.btnGenerateInvoice.TabIndex = 19;
            this.btnGenerateInvoice.Text = "Generate and Print Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = true;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // txtISASearch
            // 
            this.txtISASearch.Location = new System.Drawing.Point(340, 43);
            this.txtISASearch.Name = "txtISASearch";
            this.txtISASearch.Size = new System.Drawing.Size(100, 20);
            this.txtISASearch.TabIndex = 22;
            this.txtISASearch.TextChanged += new System.EventHandler(this.txtISASearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search Appointment using Service Appointment ID";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // invoicesRDS
            // 
            this.invoicesRDS.DataSetName = "InvoicesRDS";
            this.invoicesRDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // service_AppointmentBindingSource1
            // 
            this.service_AppointmentBindingSource1.DataMember = "Service_Appointment";
            this.service_AppointmentBindingSource1.DataSource = this.invoicesRDS;
            // 
            // service_AppointmentTableAdapter1
            // 
            this.service_AppointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Service_AppointmentTableAdapter = this.service_AppointmentTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = RoughEx.InvoicesRDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // InvoiceDataGrid
            // 
            this.InvoiceDataGrid.AutoGenerateColumns = false;
            this.InvoiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.InvoiceDataGrid.DataSource = this.service_AppointmentBindingSource1;
            this.InvoiceDataGrid.Location = new System.Drawing.Point(12, 96);
            this.InvoiceDataGrid.Name = "InvoiceDataGrid";
            this.InvoiceDataGrid.Size = new System.Drawing.Size(945, 83);
            this.InvoiceDataGrid.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SERVICE_APPOINTMENT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SERVICE_APPOINTMENT_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CLIENT_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CLIENT_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SERVICE_APPOINTMENT_DATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "SERVICE_APPOINTMENT_DATE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SERVICE_APPOINTMENT_START_TIME";
            this.dataGridViewTextBoxColumn4.HeaderText = "SERVICE_APPOINTMENT_START_TIME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SERVICE_APPOINTMENT_END_TIME";
            this.dataGridViewTextBoxColumn5.HeaderText = "SERVICE_APPOINTMENT_END_TIME";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PEST_CONTROLLER_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "PEST_CONTROLLER_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SERVICE_APPOINTMENT_STATUS";
            this.dataGridViewTextBoxColumn7.HeaderText = "SERVICE_APPOINTMENT_STATUS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PAYMENT_METHOD";
            this.dataGridViewTextBoxColumn8.HeaderText = "PAYMENT_METHOD";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SERVICE_APPOINTMENT_PRICE";
            this.dataGridViewTextBoxColumn9.HeaderText = "SERVICE_APPOINTMENT_PRICE";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_AppointmentBindingSource1, "SERVICE_APPOINTMENT_PRICE", true));
            this.txtPrice.Location = new System.Drawing.Point(558, 290);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 25;
            // 
            // TXTendTime
            // 
            this.TXTendTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_AppointmentBindingSource1, "SERVICE_APPOINTMENT_END_TIME", true));
            this.TXTendTime.Location = new System.Drawing.Point(236, 298);
            this.TXTendTime.Name = "TXTendTime";
            this.TXTendTime.Size = new System.Drawing.Size(100, 20);
            this.TXTendTime.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(679, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(236, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(sERVICE_APPOINTMENT_END_TIMELabel);
            this.Controls.Add(this.TXTendTime);
            this.Controls.Add(sERVICE_APPOINTMENT_PRICELabel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.InvoiceDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtISASearch);
            this.Controls.Add(this.btnGenerateInvoice);
            this.Controls.Add(this.btnInvoicesSearch);
            this.Controls.Add(sERVICE_APPOINTMENT_STATUSLabel);
            this.Controls.Add(this.txtStatusID);
            this.Controls.Add(pEST_CONTROLLER_IDLabel);
            this.Controls.Add(this.txtPCIDI);
            this.Controls.Add(cLIENT_IDLabel);
            this.Controls.Add(this.txtClientIDI);
            this.Controls.Add(pAYMENT_METHODLabel);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(sERVICE_APPOINTMENT_START_TIMELabel);
            this.Controls.Add(this.txtStartT);
            this.Controls.Add(sERVICE_APPOINTMENT_DATELabel);
            this.Controls.Add(this.service_AppointmentBindingNavigator);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentBindingNavigator)).EndInit();
            this.service_AppointmentBindingNavigator.ResumeLayout(false);
            this.service_AppointmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesRDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InvoicesDS invoicesDS;
        private System.Windows.Forms.BindingSource service_AppointmentBindingSource;
        private InvoicesDSTableAdapters.Service_AppointmentTableAdapter service_AppointmentTableAdapter;
        private InvoicesDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator service_AppointmentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton service_AppointmentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtStartT;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtClientIDI;
        private System.Windows.Forms.TextBox txtPCIDI;
        private System.Windows.Forms.TextBox txtStatusID;
        private System.Windows.Forms.Button btnInvoicesSearch;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.TextBox txtISASearch;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private InvoicesRDS invoicesRDS;
        private System.Windows.Forms.BindingSource service_AppointmentBindingSource1;
        private InvoicesRDSTableAdapters.Service_AppointmentTableAdapter service_AppointmentTableAdapter1;
        private InvoicesRDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView InvoiceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox TXTendTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}