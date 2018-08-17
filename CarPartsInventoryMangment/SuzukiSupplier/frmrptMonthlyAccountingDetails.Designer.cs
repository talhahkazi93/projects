namespace SuzukiSupplier
{
    partial class frmrptMonthlyAccountingDetails
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ExpensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.APIv2DataSet = new SuzukiSupplier.APIv2DataSet();
            this.MonthlyDebtDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MonthlySalesDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MonthlyPurchaseDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExpensesTableAdapter = new SuzukiSupplier.APIv2DataSetTableAdapters.ExpensesTableAdapter();
            this.MonthlyDebtDetailsTableAdapter = new SuzukiSupplier.APIv2DataSetTableAdapters.MonthlyDebtDetailsTableAdapter();
            this.MonthlySalesDetailTableAdapter = new SuzukiSupplier.APIv2DataSetTableAdapters.MonthlySalesDetailTableAdapter();
            this.MonthlyPurchaseDetailTableAdapter = new SuzukiSupplier.APIv2DataSetTableAdapters.MonthlyPurchaseDetailTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSHowMonthRecord = new System.Windows.Forms.Button();
            this.cbMonthsList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIv2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyDebtDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlySalesDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyPurchaseDetailBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExpensesBindingSource
            // 
            this.ExpensesBindingSource.DataMember = "Expenses";
            this.ExpensesBindingSource.DataSource = this.APIv2DataSet;
            // 
            // APIv2DataSet
            // 
            this.APIv2DataSet.DataSetName = "APIv2DataSet";
            this.APIv2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MonthlyDebtDetailsBindingSource
            // 
            this.MonthlyDebtDetailsBindingSource.DataMember = "MonthlyDebtDetails";
            this.MonthlyDebtDetailsBindingSource.DataSource = this.APIv2DataSet;
            // 
            // MonthlySalesDetailBindingSource
            // 
            this.MonthlySalesDetailBindingSource.DataMember = "MonthlySalesDetail";
            this.MonthlySalesDetailBindingSource.DataSource = this.APIv2DataSet;
            // 
            // MonthlyPurchaseDetailBindingSource
            // 
            this.MonthlyPurchaseDetailBindingSource.DataMember = "MonthlyPurchaseDetail";
            this.MonthlyPurchaseDetailBindingSource.DataSource = this.APIv2DataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 2;
            reportDataSource1.Name = "MonthlyExpensesDetailsDataset";
            reportDataSource1.Value = this.ExpensesBindingSource;
            reportDataSource2.Name = "MonthlyDebtDetailsDataset";
            reportDataSource2.Value = this.MonthlyDebtDetailsBindingSource;
            reportDataSource3.Name = "MonthlySalesDataset";
            reportDataSource3.Value = this.MonthlySalesDetailBindingSource;
            reportDataSource4.Name = "MonthlyPurchaseDataset";
            reportDataSource4.Value = this.MonthlyPurchaseDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SuzukiSupplier.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(734, 672);
            this.reportViewer1.TabIndex = 0;
            // 
            // ExpensesTableAdapter
            // 
            this.ExpensesTableAdapter.ClearBeforeFill = true;
            // 
            // MonthlyDebtDetailsTableAdapter
            // 
            this.MonthlyDebtDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // MonthlySalesDetailTableAdapter
            // 
            this.MonthlySalesDetailTableAdapter.ClearBeforeFill = true;
            // 
            // MonthlyPurchaseDetailTableAdapter
            // 
            this.MonthlyPurchaseDetailTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSHowMonthRecord);
            this.panel1.Controls.Add(this.cbMonthsList);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 36);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Month";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSHowMonthRecord
            // 
            this.btnSHowMonthRecord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSHowMonthRecord.Location = new System.Drawing.Point(620, 7);
            this.btnSHowMonthRecord.Name = "btnSHowMonthRecord";
            this.btnSHowMonthRecord.Size = new System.Drawing.Size(102, 23);
            this.btnSHowMonthRecord.TabIndex = 1;
            this.btnSHowMonthRecord.Text = "Show";
            this.btnSHowMonthRecord.UseVisualStyleBackColor = true;
            this.btnSHowMonthRecord.Click += new System.EventHandler(this.btnSHowMonthRecord_Click);
            // 
            // cbMonthsList
            // 
            this.cbMonthsList.FormattingEnabled = true;
            this.cbMonthsList.Location = new System.Drawing.Point(445, 8);
            this.cbMonthsList.Name = "cbMonthsList";
            this.cbMonthsList.Size = new System.Drawing.Size(168, 21);
            this.cbMonthsList.TabIndex = 0;
            // 
            // frmrptMonthlyAccountingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmrptMonthlyAccountingDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mothly Accounting Report";
            this.Load += new System.EventHandler(this.frmrptMonthlyAccountingDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIv2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyDebtDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlySalesDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyPurchaseDetailBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExpensesBindingSource;
        private APIv2DataSet APIv2DataSet;
        private System.Windows.Forms.BindingSource MonthlyDebtDetailsBindingSource;
        private System.Windows.Forms.BindingSource MonthlySalesDetailBindingSource;
        private System.Windows.Forms.BindingSource MonthlyPurchaseDetailBindingSource;
        private APIv2DataSetTableAdapters.ExpensesTableAdapter ExpensesTableAdapter;
        private APIv2DataSetTableAdapters.MonthlyDebtDetailsTableAdapter MonthlyDebtDetailsTableAdapter;
        private APIv2DataSetTableAdapters.MonthlySalesDetailTableAdapter MonthlySalesDetailTableAdapter;
        private APIv2DataSetTableAdapters.MonthlyPurchaseDetailTableAdapter MonthlyPurchaseDetailTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMonthsList;
        private System.Windows.Forms.Button btnSHowMonthRecord;
        private System.Windows.Forms.Label label1;
    }
}