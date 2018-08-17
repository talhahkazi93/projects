namespace SuzukiSupplier
{
    partial class Sell
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCustomerType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Party = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbParty = new System.Windows.Forms.ComboBox();
            this.partyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPIDataSet = new SuzukiSupplier.APIDataSet();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.DateTimePicker();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.cbSelectPart = new System.Windows.Forms.ComboBox();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.partsTableAdapter = new SuzukiSupplier.APIDataSetTableAdapters.PartsTableAdapter();
            this.partyTableAdapter = new SuzukiSupplier.APIDataSetTableAdapters.PartyTableAdapter();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.Enabled = false;
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(227)))));
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnRemoveItem);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.btnAddtoList);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbParty);
            this.groupBox1.Controls.Add(this.cbCustomerType);
            this.groupBox1.Controls.Add(this.cbDate);
            this.groupBox1.Controls.Add(this.txtSellingPrice);
            this.groupBox1.Controls.Add(this.cbSelectPart);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 388);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
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
            this.panel3.Location = new System.Drawing.Point(408, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 153);
            this.panel3.TabIndex = 63;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.lblDisplayCostPrice.Location = new System.Drawing.Point(107, 92);
            this.lblDisplayCostPrice.Name = "lblDisplayCostPrice";
            this.lblDisplayCostPrice.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayCostPrice.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(9, 92);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(85, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Cost Price / Unit";
            // 
            // lblDisplayModel
            // 
            this.lblDisplayModel.AutoSize = true;
            this.lblDisplayModel.Location = new System.Drawing.Point(107, 67);
            this.lblDisplayModel.Name = "lblDisplayModel";
            this.lblDisplayModel.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayModel.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Model";
            // 
            // lblDisplayCar
            // 
            this.lblDisplayCar.AutoSize = true;
            this.lblDisplayCar.Location = new System.Drawing.Point(106, 42);
            this.lblDisplayCar.Name = "lblDisplayCar";
            this.lblDisplayCar.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayCar.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Car";
            // 
            // lblSelectedPartName
            // 
            this.lblSelectedPartName.AutoSize = true;
            this.lblSelectedPartName.Location = new System.Drawing.Point(106, 17);
            this.lblSelectedPartName.Name = "lblSelectedPartName";
            this.lblSelectedPartName.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedPartName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 17);
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
            this.panel2.Location = new System.Drawing.Point(350, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 24);
            this.panel2.TabIndex = 62;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(100, 5);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(11, 13);
            this.lblGrandTotal.TabIndex = 1;
            this.lblGrandTotal.Text = " ";
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
            this.btnRemoveItem.FlatAppearance.BorderSize = 2;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveItem.Location = new System.Drawing.Point(193, 338);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(92, 35);
            this.btnRemoveItem.TabIndex = 61;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(9, 167);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(180, 20);
            this.txtQty.TabIndex = 60;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // btnAddtoList
            // 
            this.btnAddtoList.FlatAppearance.BorderSize = 2;
            this.btnAddtoList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddtoList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddtoList.Location = new System.Drawing.Point(55, 338);
            this.btnAddtoList.Name = "btnAddtoList";
            this.btnAddtoList.Size = new System.Drawing.Size(92, 35);
            this.btnAddtoList.TabIndex = 57;
            this.btnAddtoList.Text = "Add";
            this.btnAddtoList.UseVisualStyleBackColor = true;
            this.btnAddtoList.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PartNo,
            this.SellingPrice,
            this.Date,
            this.chCustomerType,
            this.Party,
            this.Quantity,
            this.chtotal});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 216);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(638, 97);
            this.listView1.TabIndex = 56;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PartNo
            // 
            this.PartNo.Text = "PartNo";
            this.PartNo.Width = 89;
            // 
            // SellingPrice
            // 
            this.SellingPrice.Text = "SellingPrice";
            this.SellingPrice.Width = 103;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 137;
            // 
            // chCustomerType
            // 
            this.chCustomerType.Text = "Customer Type";
            this.chCustomerType.Width = 87;
            // 
            // Party
            // 
            this.Party.Text = "Party";
            this.Party.Width = 63;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 67;
            // 
            // chtotal
            // 
            this.chtotal.Text = "Total";
            this.chtotal.Width = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Party";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Customer Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Date Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Selling Price / Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Part Number";
            // 
            // cbParty
            // 
            this.cbParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbParty.DataSource = this.partyBindingSource;
            this.cbParty.DisplayMember = "Name";
            this.cbParty.Enabled = false;
            this.cbParty.FormattingEnabled = true;
            this.cbParty.Location = new System.Drawing.Point(211, 166);
            this.cbParty.Name = "cbParty";
            this.cbParty.Size = new System.Drawing.Size(180, 21);
            this.cbParty.TabIndex = 48;
            this.cbParty.ValueMember = "Id";
            this.cbParty.SelectedIndexChanged += new System.EventHandler(this.partyId_SelectedIndexChanged);
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
            // cbCustomerType
            // 
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Location = new System.Drawing.Point(210, 117);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(180, 21);
            this.cbCustomerType.TabIndex = 47;
            this.cbCustomerType.SelectedIndexChanged += new System.EventHandler(this.cstmrType_SelectedIndexChanged);
            // 
            // cbDate
            // 
            this.cbDate.Location = new System.Drawing.Point(210, 59);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(180, 20);
            this.cbDate.TabIndex = 46;
            this.cbDate.ValueChanged += new System.EventHandler(this.dtsld_ValueChanged);
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(9, 117);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(180, 20);
            this.txtSellingPrice.TabIndex = 45;
            this.txtSellingPrice.TextChanged += new System.EventHandler(this.slngprz_TextChanged);
            this.txtSellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellingPrice_KeyPress);
            // 
            // cbSelectPart
            // 
            this.cbSelectPart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelectPart.DataSource = this.partsBindingSource;
            this.cbSelectPart.DisplayMember = "PartNo";
            this.cbSelectPart.FormattingEnabled = true;
            this.cbSelectPart.Location = new System.Drawing.Point(9, 62);
            this.cbSelectPart.Name = "cbSelectPart";
            this.cbSelectPart.Size = new System.Drawing.Size(180, 21);
            this.cbSelectPart.TabIndex = 44;
            this.cbSelectPart.ValueMember = "PartNo";
            this.cbSelectPart.SelectedIndexChanged += new System.EventHandler(this.prtcmb_SelectedIndexChanged);
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.aPIDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 54);
            this.panel1.TabIndex = 29;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit.Location = new System.Drawing.Point(551, 11);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 36);
            this.Exit.TabIndex = 43;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.FlatAppearance.BorderSize = 2;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddBtn.Location = new System.Drawing.Point(14, 11);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(113, 36);
            this.AddBtn.TabIndex = 42;
            this.AddBtn.Text = "Sale";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // partyTableAdapter
            // 
            this.partyTableAdapter.ClearBeforeFill = true;
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(668, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Parts";
            this.Load += new System.EventHandler(this.Sale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox cbSelectPart;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private System.Windows.Forms.DateTimePicker cbDate;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.ComboBox cbParty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddtoList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PartNo;
        private System.Windows.Forms.ColumnHeader SellingPrice;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Party;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.TextBox txtQty;
        private APIDataSet aPIDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private APIDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.BindingSource partyBindingSource;
        private APIDataSetTableAdapters.PartyTableAdapter partyTableAdapter;
        private System.Windows.Forms.ColumnHeader chCustomerType;
        private System.Windows.Forms.ColumnHeader chtotal;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSelectedPartName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDisplayModel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDisplayCar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDisplayCostPrice;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblAvailableQuantity;
        private System.Windows.Forms.Label label11;
    }
}