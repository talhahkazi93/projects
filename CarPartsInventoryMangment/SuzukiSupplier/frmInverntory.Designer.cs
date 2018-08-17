namespace SuzukiSupplier
{
    partial class frmInverntory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpbxAdd = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSelectStore = new System.Windows.Forms.ComboBox();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPIDataSet = new SuzukiSupplier.APIDataSet();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSelectPartNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSelectModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSelectPartName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSelectCar = new System.Windows.Forms.ComboBox();
            this.btnAddToInventory = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpbxEdit = new System.Windows.Forms.GroupBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEditQty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditInventory = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aPIDataSet1 = new SuzukiSupplier.APIDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.partsTableAdapter = new SuzukiSupplier.APIDataSetTableAdapters.PartsTableAdapter();
            this.inventoryTableAdapter = new SuzukiSupplier.APIDataSetTableAdapters.InventoryTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSet)).BeginInit();
            this.grpbxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(540, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 31);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Exit";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpbxAdd
            // 
            this.grpbxAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.grpbxAdd.Controls.Add(this.label8);
            this.grpbxAdd.Controls.Add(this.cbSelectStore);
            this.grpbxAdd.Controls.Add(this.txtQty);
            this.grpbxAdd.Controls.Add(this.label7);
            this.grpbxAdd.Controls.Add(this.label6);
            this.grpbxAdd.Controls.Add(this.cbSelectPartNo);
            this.grpbxAdd.Controls.Add(this.label5);
            this.grpbxAdd.Controls.Add(this.cbSelectModel);
            this.grpbxAdd.Controls.Add(this.label4);
            this.grpbxAdd.Controls.Add(this.cbSelectPartName);
            this.grpbxAdd.Controls.Add(this.label3);
            this.grpbxAdd.Controls.Add(this.cbSelectCar);
            this.grpbxAdd.Controls.Add(this.btnAddToInventory);
            this.grpbxAdd.Controls.Add(this.lblTitle);
            this.grpbxAdd.Location = new System.Drawing.Point(12, 12);
            this.grpbxAdd.Name = "grpbxAdd";
            this.grpbxAdd.Size = new System.Drawing.Size(608, 385);
            this.grpbxAdd.TabIndex = 38;
            this.grpbxAdd.TabStop = false;
            this.grpbxAdd.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Select Store";
            // 
            // cbSelectStore
            // 
            this.cbSelectStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelectStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelectStore.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsBindingSource, "Name", true));
            this.cbSelectStore.Enabled = false;
            this.cbSelectStore.FormattingEnabled = true;
            this.cbSelectStore.Location = new System.Drawing.Point(239, 240);
            this.cbSelectStore.Name = "cbSelectStore";
            this.cbSelectStore.Size = new System.Drawing.Size(143, 21);
            this.cbSelectStore.TabIndex = 44;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.aPIDataSet;
            // 
            // aPIDataSet
            // 
            this.aPIDataSet.DataSetName = "APIDataSet";
            this.aPIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(398, 241);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(143, 20);
            this.txtQty.TabIndex = 43;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Select PartNo";
            // 
            // cbSelectPartNo
            // 
            this.cbSelectPartNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelectPartNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelectPartNo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsBindingSource, "Name", true));
            this.cbSelectPartNo.Enabled = false;
            this.cbSelectPartNo.FormattingEnabled = true;
            this.cbSelectPartNo.Location = new System.Drawing.Point(82, 240);
            this.cbSelectPartNo.Name = "cbSelectPartNo";
            this.cbSelectPartNo.Size = new System.Drawing.Size(143, 21);
            this.cbSelectPartNo.TabIndex = 39;
            this.cbSelectPartNo.SelectionChangeCommitted += new System.EventHandler(this.cbSelectPartNo_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Select Model";
            // 
            // cbSelectModel
            // 
            this.cbSelectModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelectModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelectModel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsBindingSource, "Name", true));
            this.cbSelectModel.Enabled = false;
            this.cbSelectModel.FormattingEnabled = true;
            this.cbSelectModel.Location = new System.Drawing.Point(400, 141);
            this.cbSelectModel.Name = "cbSelectModel";
            this.cbSelectModel.Size = new System.Drawing.Size(143, 21);
            this.cbSelectModel.TabIndex = 37;
            this.cbSelectModel.SelectionChangeCommitted += new System.EventHandler(this.cbSelectModel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Select Part";
            // 
            // cbSelectPartName
            // 
            this.cbSelectPartName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelectPartName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelectPartName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsBindingSource, "Name", true));
            this.cbSelectPartName.Enabled = false;
            this.cbSelectPartName.FormattingEnabled = true;
            this.cbSelectPartName.Location = new System.Drawing.Point(241, 141);
            this.cbSelectPartName.Name = "cbSelectPartName";
            this.cbSelectPartName.Size = new System.Drawing.Size(143, 21);
            this.cbSelectPartName.TabIndex = 35;
            this.cbSelectPartName.SelectionChangeCommitted += new System.EventHandler(this.cbSelectPartName_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Select Car";
            // 
            // cbSelectCar
            // 
            this.cbSelectCar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelectCar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelectCar.DataSource = this.partsBindingSource;
            this.cbSelectCar.DisplayMember = "Car";
            this.cbSelectCar.FormattingEnabled = true;
            this.cbSelectCar.Location = new System.Drawing.Point(82, 141);
            this.cbSelectCar.Name = "cbSelectCar";
            this.cbSelectCar.Size = new System.Drawing.Size(143, 21);
            this.cbSelectCar.TabIndex = 33;
            this.cbSelectCar.ValueMember = "Car";
            this.cbSelectCar.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAddToInventory
            // 
            this.btnAddToInventory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddToInventory.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddToInventory.FlatAppearance.BorderSize = 2;
            this.btnAddToInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToInventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddToInventory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddToInventory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddToInventory.Location = new System.Drawing.Point(254, 313);
            this.btnAddToInventory.Name = "btnAddToInventory";
            this.btnAddToInventory.Size = new System.Drawing.Size(109, 31);
            this.btnAddToInventory.TabIndex = 32;
            this.btnAddToInventory.Text = "Add";
            this.btnAddToInventory.UseVisualStyleBackColor = false;
            this.btnAddToInventory.Click += new System.EventHandler(this.btnAddToInventory_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(229, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Part to Inventory";
            // 
            // grpbxEdit
            // 
            this.grpbxEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.grpbxEdit.Controls.Add(this.txtStore);
            this.grpbxEdit.Controls.Add(this.label13);
            this.grpbxEdit.Controls.Add(this.txtEditQty);
            this.grpbxEdit.Controls.Add(this.label11);
            this.grpbxEdit.Controls.Add(this.txtPartNo);
            this.grpbxEdit.Controls.Add(this.label12);
            this.grpbxEdit.Controls.Add(this.txtModel);
            this.grpbxEdit.Controls.Add(this.label10);
            this.grpbxEdit.Controls.Add(this.txtPartName);
            this.grpbxEdit.Controls.Add(this.label2);
            this.grpbxEdit.Controls.Add(this.txtCar);
            this.grpbxEdit.Controls.Add(this.label9);
            this.grpbxEdit.Controls.Add(this.btnEditInventory);
            this.grpbxEdit.Controls.Add(this.lblTitle2);
            this.grpbxEdit.Location = new System.Drawing.Point(12, 12);
            this.grpbxEdit.Name = "grpbxEdit";
            this.grpbxEdit.Size = new System.Drawing.Size(608, 379);
            this.grpbxEdit.TabIndex = 46;
            this.grpbxEdit.TabStop = false;
            this.grpbxEdit.Visible = false;
            // 
            // txtStore
            // 
            this.txtStore.Enabled = false;
            this.txtStore.Location = new System.Drawing.Point(233, 234);
            this.txtStore.Name = "txtStore";
            this.txtStore.ReadOnly = true;
            this.txtStore.Size = new System.Drawing.Size(143, 20);
            this.txtStore.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Store";
            // 
            // txtEditQty
            // 
            this.txtEditQty.Location = new System.Drawing.Point(398, 235);
            this.txtEditQty.Name = "txtEditQty";
            this.txtEditQty.Size = new System.Drawing.Size(143, 20);
            this.txtEditQty.TabIndex = 51;
            this.txtEditQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditQty_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(395, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Qty";
            // 
            // txtPartNo
            // 
            this.txtPartNo.Enabled = false;
            this.txtPartNo.Location = new System.Drawing.Point(64, 234);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.ReadOnly = true;
            this.txtPartNo.Size = new System.Drawing.Size(143, 20);
            this.txtPartNo.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "PartNo";
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(398, 142);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(143, 20);
            this.txtModel.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Model";
            // 
            // txtPartName
            // 
            this.txtPartName.Enabled = false;
            this.txtPartName.Location = new System.Drawing.Point(233, 142);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.ReadOnly = true;
            this.txtPartName.Size = new System.Drawing.Size(143, 20);
            this.txtPartName.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Part Name";
            // 
            // txtCar
            // 
            this.txtCar.Enabled = false;
            this.txtCar.Location = new System.Drawing.Point(64, 143);
            this.txtCar.Name = "txtCar";
            this.txtCar.ReadOnly = true;
            this.txtCar.Size = new System.Drawing.Size(143, 20);
            this.txtCar.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Car";
            // 
            // btnEditInventory
            // 
            this.btnEditInventory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditInventory.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditInventory.FlatAppearance.BorderSize = 2;
            this.btnEditInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditInventory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditInventory.Location = new System.Drawing.Point(254, 317);
            this.btnEditInventory.Name = "btnEditInventory";
            this.btnEditInventory.Size = new System.Drawing.Size(109, 31);
            this.btnEditInventory.TabIndex = 32;
            this.btnEditInventory.Text = "Edit";
            this.btnEditInventory.UseVisualStyleBackColor = false;
            this.btnEditInventory.Click += new System.EventHandler(this.btnEditInventory_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(215, 50);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(187, 20);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "Edit Part Info in Inventory";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(147, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 31);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNoDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.carDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.storeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(608, 385);
            this.dataGridView1.TabIndex = 35;
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "PartNo";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "PartNo";
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            this.partNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carDataGridViewTextBoxColumn
            // 
            this.carDataGridViewTextBoxColumn.DataPropertyName = "Car";
            this.carDataGridViewTextBoxColumn.HeaderText = "Car";
            this.carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            this.carDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeDataGridViewTextBoxColumn
            // 
            this.storeDataGridViewTextBoxColumn.DataPropertyName = "Store";
            this.storeDataGridViewTextBoxColumn.HeaderText = "Store";
            this.storeDataGridViewTextBoxColumn.Name = "storeDataGridViewTextBoxColumn";
            this.storeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.aPIDataSet1;
            // 
            // aPIDataSet1
            // 
            this.aPIDataSet1.DataSetName = "APIDataSet";
            this.aPIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.aPIDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(12, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 31);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Addprt_Click);
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 47;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 71);
            this.panel1.TabIndex = 48;
            // 
            // frmInverntory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpbxEdit);
            this.Controls.Add(this.grpbxAdd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInverntory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInverntory_Load);
            this.grpbxAdd.ResumeLayout(false);
            this.grpbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSet)).EndInit();
            this.grpbxEdit.ResumeLayout(false);
            this.grpbxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpbxAdd;
        private System.Windows.Forms.Button btnAddToInventory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbSelectCar;
        private APIDataSet aPIDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private APIDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSelectPartName;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private APIDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSelectModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSelectPartNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSelectStore;
        private APIDataSet aPIDataSet1;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grpbxEdit;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditInventory;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}