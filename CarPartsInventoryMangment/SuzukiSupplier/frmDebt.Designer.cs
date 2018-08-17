namespace SuzukiSupplier
{
    partial class frmDebt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpLastPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAvailableQuantity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDisplayCostPrice = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblDisplayModel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDisplayCar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSelectedPartName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnAddtoList = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PartNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SellingPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbParty = new System.Windows.Forms.ComboBox();
            this.partyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPIDataSet = new SuzukiSupplier.APIDataSet();
            this.dtpDealDate = new System.Windows.Forms.DateTimePicker();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.cbSelectPart = new System.Windows.Forms.ComboBox();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.partyTableAdapter = new SuzukiSupplier.APIDataSetTableAdapters.PartyTableAdapter();
            this.partsTableAdapter = new SuzukiSupplier.APIDataSetTableAdapters.PartsTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSetBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtpLastPaymentDate);
            this.panel1.Controls.Add(this.txtPayment);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRemoveItem);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.btnAddtoList);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbParty);
            this.panel1.Controls.Add(this.dtpDealDate);
            this.panel1.Controls.Add(this.txtSellingPrice);
            this.panel1.Controls.Add(this.cbSelectPart);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 366);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(318, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 84;
            this.label9.Text = "Last Payment Date";
            // 
            // dtpLastPaymentDate
            // 
            this.dtpLastPaymentDate.CustomFormat = "";
            this.dtpLastPaymentDate.Enabled = false;
            this.dtpLastPaymentDate.Location = new System.Drawing.Point(320, 337);
            this.dtpLastPaymentDate.Name = "dtpLastPaymentDate";
            this.dtpLastPaymentDate.Size = new System.Drawing.Size(180, 20);
            this.dtpLastPaymentDate.TabIndex = 83;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(16, 337);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(180, 20);
            this.txtPayment.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Current Payment";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblAvailableQuantity);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lblDisplayCostPrice);
            this.panel3.Controls.Add(this.lbl);
            this.panel3.Controls.Add(this.lblDisplayModel);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblDisplayCar);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblSelectedPartName);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(393, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 135);
            this.panel3.TabIndex = 80;
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Location = new System.Drawing.Point(107, 112);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(0, 13);
            this.lblAvailableQuantity.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Available Quantity";
            // 
            // lblDisplayCostPrice
            // 
            this.lblDisplayCostPrice.AutoSize = true;
            this.lblDisplayCostPrice.Location = new System.Drawing.Point(107, 90);
            this.lblDisplayCostPrice.Name = "lblDisplayCostPrice";
            this.lblDisplayCostPrice.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayCostPrice.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(9, 90);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(85, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Cost Price / Unit";
            // 
            // lblDisplayModel
            // 
            this.lblDisplayModel.AutoSize = true;
            this.lblDisplayModel.Location = new System.Drawing.Point(107, 65);
            this.lblDisplayModel.Name = "lblDisplayModel";
            this.lblDisplayModel.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayModel.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Model";
            // 
            // lblDisplayCar
            // 
            this.lblDisplayCar.AutoSize = true;
            this.lblDisplayCar.Location = new System.Drawing.Point(106, 40);
            this.lblDisplayCar.Name = "lblDisplayCar";
            this.lblDisplayCar.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayCar.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Car";
            // 
            // lblSelectedPartName
            // 
            this.lblSelectedPartName.AutoSize = true;
            this.lblSelectedPartName.Location = new System.Drawing.Point(106, 15);
            this.lblSelectedPartName.Name = "lblSelectedPartName";
            this.lblSelectedPartName.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedPartName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Part Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblGrandTotal);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(16, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 24);
            this.panel2.TabIndex = 79;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(100, 5);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(0, 13);
            this.lblGrandTotal.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Grand Total = ";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemoveItem.FlatAppearance.BorderSize = 2;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveItem.Location = new System.Drawing.Point(506, 233);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(88, 45);
            this.btnRemoveItem.TabIndex = 78;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(16, 125);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(155, 20);
            this.txtQty.TabIndex = 77;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // btnAddtoList
            // 
            this.btnAddtoList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddtoList.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddtoList.FlatAppearance.BorderSize = 2;
            this.btnAddtoList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddtoList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddtoList.Location = new System.Drawing.Point(505, 162);
            this.btnAddtoList.Name = "btnAddtoList";
            this.btnAddtoList.Size = new System.Drawing.Size(89, 44);
            this.btnAddtoList.TabIndex = 76;
            this.btnAddtoList.Text = "Add Item";
            this.btnAddtoList.UseVisualStyleBackColor = false;
            this.btnAddtoList.Click += new System.EventHandler(this.btnAddtoList_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PartNo,
            this.SellingPrice,
            this.Quantity,
            this.chtotal});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 162);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(483, 116);
            this.listView1.TabIndex = 75;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PartNo
            // 
            this.PartNo.Text = "PartNo";
            this.PartNo.Width = 115;
            // 
            // SellingPrice
            // 
            this.SellingPrice.Text = "SellingPrice";
            this.SellingPrice.Width = 134;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 76;
            // 
            // chtotal
            // 
            this.chtotal.Text = "Total";
            this.chtotal.Width = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Party";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Deal Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Selling Price / Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Part Number";
            // 
            // cbParty
            // 
            this.cbParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbParty.DataSource = this.partyBindingSource;
            this.cbParty.DisplayMember = "Name";
            this.cbParty.FormattingEnabled = true;
            this.cbParty.Location = new System.Drawing.Point(195, 73);
            this.cbParty.Name = "cbParty";
            this.cbParty.Size = new System.Drawing.Size(180, 21);
            this.cbParty.TabIndex = 68;
            this.cbParty.ValueMember = "Id";
            // 
            // partyBindingSource
            // 
            this.partyBindingSource.DataMember = "Party";
            this.partyBindingSource.DataSource = this.aPIDataSet;
            // 
            // aPIDataSet
            // 
            this.aPIDataSet.DataSetName = "APIDataSet";
            this.aPIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDealDate
            // 
            this.dtpDealDate.Location = new System.Drawing.Point(194, 27);
            this.dtpDealDate.Name = "dtpDealDate";
            this.dtpDealDate.Size = new System.Drawing.Size(180, 20);
            this.dtpDealDate.TabIndex = 66;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(16, 74);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(155, 20);
            this.txtSellingPrice.TabIndex = 65;
            this.txtSellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellingPrice_KeyPress);
            // 
            // cbSelectPart
            // 
            this.cbSelectPart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelectPart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelectPart.DataSource = this.partsBindingSource;
            this.cbSelectPart.DisplayMember = "PartNo";
            this.cbSelectPart.FormattingEnabled = true;
            this.cbSelectPart.Location = new System.Drawing.Point(16, 26);
            this.cbSelectPart.Name = "cbSelectPart";
            this.cbSelectPart.Size = new System.Drawing.Size(155, 21);
            this.cbSelectPart.TabIndex = 64;
            this.cbSelectPart.ValueMember = "PartNo";
            this.cbSelectPart.SelectedIndexChanged += new System.EventHandler(this.cbSelectPart_SelectedIndexChanged);
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.aPIDataSetBindingSource;
            // 
            // aPIDataSetBindingSource
            // 
            this.aPIDataSetBindingSource.DataSource = this.aPIDataSet;
            this.aPIDataSetBindingSource.Position = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.Location = new System.Drawing.Point(528, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 35);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddDept.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDept.FlatAppearance.BorderSize = 2;
            this.btnAddDept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDept.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddDept.Location = new System.Drawing.Point(12, 13);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(92, 35);
            this.btnAddDept.TabIndex = 85;
            this.btnAddDept.Text = "Add Debt";
            this.btnAddDept.UseVisualStyleBackColor = false;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // partyTableAdapter
            // 
            this.partyTableAdapter.ClearBeforeFill = true;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.btnAddDept);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Location = new System.Drawing.Point(0, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(632, 61);
            this.panel4.TabIndex = 87;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 88;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 468);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDebt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debt";
            this.Load += new System.EventHandler(this.frmDebt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSetBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAvailableQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDisplayCostPrice;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblDisplayModel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDisplayCar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSelectedPartName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnAddtoList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PartNo;
        private System.Windows.Forms.ColumnHeader SellingPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader chtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbParty;
        private System.Windows.Forms.DateTimePicker dtpDealDate;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.ComboBox cbSelectPart;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpLastPaymentDate;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Button btnCancel;
        private APIDataSet aPIDataSet;
        private System.Windows.Forms.BindingSource partyBindingSource;
        private APIDataSetTableAdapters.PartyTableAdapter partyTableAdapter;
        private System.Windows.Forms.BindingSource aPIDataSetBindingSource;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private APIDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}