
namespace RoughEx
{
    partial class PaymentReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentReport));
            this.serviceAppointmentDS = new RoughEx.ServiceAppointmentDS();
            this.service_AppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service_AppointmentTableAdapter = new RoughEx.ServiceAppointmentDSTableAdapters.Service_AppointmentTableAdapter();
            this.tableAdapterManager = new RoughEx.ServiceAppointmentDSTableAdapters.TableAdapterManager();
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
            this.service_AppointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerateP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPSEarch = new System.Windows.Forms.Button();
            this.txtPaymentSearch = new System.Windows.Forms.TextBox();
            this.txtNoUsed = new System.Windows.Forms.TextBox();
            this.txtPaymentM = new System.Windows.Forms.TextBox();
            this.txtLeast = new System.Windows.Forms.TextBox();
            this.txtUsed = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviceAppointmentDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentBindingNavigator)).BeginInit();
            this.service_AppointmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceAppointmentDS
            // 
            this.serviceAppointmentDS.DataSetName = "ServiceAppointmentDS";
            this.serviceAppointmentDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // service_AppointmentBindingSource
            // 
            this.service_AppointmentBindingSource.DataMember = "Service_Appointment";
            this.service_AppointmentBindingSource.DataSource = this.serviceAppointmentDS;
            // 
            // service_AppointmentTableAdapter
            // 
            this.service_AppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Service_AppointmentTableAdapter = this.service_AppointmentTableAdapter;
            this.tableAdapterManager.UpdateOrder = RoughEx.ServiceAppointmentDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.service_AppointmentBindingNavigator.Size = new System.Drawing.Size(960, 25);
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
            // service_AppointmentDataGridView
            // 
            this.service_AppointmentDataGridView.AutoGenerateColumns = false;
            this.service_AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.service_AppointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.service_AppointmentDataGridView.DataSource = this.service_AppointmentBindingSource;
            this.service_AppointmentDataGridView.Location = new System.Drawing.Point(12, 293);
            this.service_AppointmentDataGridView.Name = "service_AppointmentDataGridView";
            this.service_AppointmentDataGridView.Size = new System.Drawing.Size(936, 193);
            this.service_AppointmentDataGridView.TabIndex = 1;
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
            // btnGenerateP
            // 
            this.btnGenerateP.Location = new System.Drawing.Point(320, 12);
            this.btnGenerateP.Name = "btnGenerateP";
            this.btnGenerateP.Size = new System.Drawing.Size(179, 31);
            this.btnGenerateP.TabIndex = 2;
            this.btnGenerateP.Text = "Generate Reports";
            this.btnGenerateP.UseVisualStyleBackColor = true;
            this.btnGenerateP.Click += new System.EventHandler(this.btnGenerateP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Most used payment method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of times used :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of times used :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Least used payment method :";
            // 
            // btnPSEarch
            // 
            this.btnPSEarch.Location = new System.Drawing.Point(346, 169);
            this.btnPSEarch.Name = "btnPSEarch";
            this.btnPSEarch.Size = new System.Drawing.Size(75, 23);
            this.btnPSEarch.TabIndex = 9;
            this.btnPSEarch.Text = "Search";
            this.btnPSEarch.UseVisualStyleBackColor = true;
            this.btnPSEarch.Click += new System.EventHandler(this.btnPSEarch_Click);
            // 
            // txtPaymentSearch
            // 
            this.txtPaymentSearch.Location = new System.Drawing.Point(204, 171);
            this.txtPaymentSearch.Name = "txtPaymentSearch";
            this.txtPaymentSearch.Size = new System.Drawing.Size(47, 20);
            this.txtPaymentSearch.TabIndex = 10;
            // 
            // txtNoUsed
            // 
            this.txtNoUsed.Location = new System.Drawing.Point(255, 61);
            this.txtNoUsed.Name = "txtNoUsed";
            this.txtNoUsed.Size = new System.Drawing.Size(125, 20);
            this.txtNoUsed.TabIndex = 11;
            // 
            // txtPaymentM
            // 
            this.txtPaymentM.Location = new System.Drawing.Point(255, 35);
            this.txtPaymentM.Name = "txtPaymentM";
            this.txtPaymentM.Size = new System.Drawing.Size(125, 20);
            this.txtPaymentM.TabIndex = 12;
            // 
            // txtLeast
            // 
            this.txtLeast.Location = new System.Drawing.Point(255, 87);
            this.txtLeast.Name = "txtLeast";
            this.txtLeast.Size = new System.Drawing.Size(125, 20);
            this.txtLeast.TabIndex = 13;
            // 
            // txtUsed
            // 
            this.txtUsed.Location = new System.Drawing.Point(255, 113);
            this.txtUsed.Name = "txtUsed";
            this.txtUsed.Size = new System.Drawing.Size(125, 20);
            this.txtUsed.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtUsed);
            this.groupBox2.Controls.Add(this.btnPSEarch);
            this.groupBox2.Controls.Add(this.txtLeast);
            this.groupBox2.Controls.Add(this.txtPaymentM);
            this.groupBox2.Controls.Add(this.txtNoUsed);
            this.groupBox2.Controls.Add(this.txtPaymentSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(98, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 214);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Report";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Search by Month and Date";
            // 
            // PaymentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGenerateP);
            this.Controls.Add(this.service_AppointmentDataGridView);
            this.Controls.Add(this.service_AppointmentBindingNavigator);
            this.Name = "PaymentReport";
            this.Text = "PaymentReport";
            this.Load += new System.EventHandler(this.PaymentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceAppointmentDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentBindingNavigator)).EndInit();
            this.service_AppointmentBindingNavigator.ResumeLayout(false);
            this.service_AppointmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_AppointmentDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ServiceAppointmentDS serviceAppointmentDS;
        private System.Windows.Forms.BindingSource service_AppointmentBindingSource;
        private ServiceAppointmentDSTableAdapters.Service_AppointmentTableAdapter service_AppointmentTableAdapter;
        private ServiceAppointmentDSTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView service_AppointmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnGenerateP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPSEarch;
        private System.Windows.Forms.TextBox txtPaymentSearch;
        private System.Windows.Forms.TextBox txtNoUsed;
        private System.Windows.Forms.TextBox txtPaymentM;
        private System.Windows.Forms.TextBox txtLeast;
        private System.Windows.Forms.TextBox txtUsed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}