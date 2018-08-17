namespace SuzukiSupplier
{
    partial class frmShiftPartsToShop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbWarehouseList = new System.Windows.Forms.ComboBox();
            this.aPIDataSet = new SuzukiSupplier.APIDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.dgListWarehouseItems = new System.Windows.Forms.DataGridView();
            this.btnShift = new System.Windows.Forms.Button();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeTableAdapter = new SuzukiSupplier.APIDataSetTableAdapters.StoreTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListWarehouseItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.panel2.Controls.Add(this.cbWarehouseList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 30);
            this.panel2.TabIndex = 37;
            // 
            // cbWarehouseList
            // 
            this.cbWarehouseList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aPIDataSet, "Store.Type", true));
            this.cbWarehouseList.FormattingEnabled = true;
            this.cbWarehouseList.Location = new System.Drawing.Point(315, 5);
            this.cbWarehouseList.Name = "cbWarehouseList";
            this.cbWarehouseList.Size = new System.Drawing.Size(172, 21);
            this.cbWarehouseList.TabIndex = 1;
            this.cbWarehouseList.SelectedIndexChanged += new System.EventHandler(this.cbWarehouseList_SelectedIndexChanged);
            // 
            // aPIDataSet
            // 
            this.aPIDataSet.DataSetName = "APIDataSet";
            this.aPIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select your desired warehouse";
            // 
            // dgListWarehouseItems
            // 
            this.dgListWarehouseItems.AllowUserToAddRows = false;
            this.dgListWarehouseItems.AllowUserToDeleteRows = false;
            this.dgListWarehouseItems.AllowUserToResizeColumns = false;
            this.dgListWarehouseItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            this.dgListWarehouseItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgListWarehouseItems.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgListWarehouseItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListWarehouseItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListWarehouseItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgListWarehouseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListWarehouseItems.Location = new System.Drawing.Point(0, 30);
            this.dgListWarehouseItems.MultiSelect = false;
            this.dgListWarehouseItems.Name = "dgListWarehouseItems";
            this.dgListWarehouseItems.ReadOnly = true;
            this.dgListWarehouseItems.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgListWarehouseItems.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgListWarehouseItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListWarehouseItems.Size = new System.Drawing.Size(526, 468);
            this.dgListWarehouseItems.TabIndex = 37;
            // 
            // btnShift
            // 
            this.btnShift.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnShift.Location = new System.Drawing.Point(416, 501);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(105, 30);
            this.btnShift.TabIndex = 3;
            this.btnShift.Text = "Shift";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.aPIDataSet;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // frmShiftPartsToShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(525, 534);
            this.Controls.Add(this.btnShift);
            this.Controls.Add(this.dgListWarehouseItems);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShiftPartsToShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Parts To Shop From Warehouse";
            this.Load += new System.EventHandler(this.frmShiftPartsToShop_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListWarehouseItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbWarehouseList;
        private System.Windows.Forms.DataGridView dgListWarehouseItems;
        private System.Windows.Forms.Button btnShift;
        private APIDataSet aPIDataSet;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private APIDataSetTableAdapters.StoreTableAdapter storeTableAdapter;
    }
}