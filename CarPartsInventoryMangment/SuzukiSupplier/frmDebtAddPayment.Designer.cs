namespace SuzukiSupplier
{
    partial class frmDebtAddPayment
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
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.txtAmountPayed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDebtDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDealDate = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblPartyName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPayed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chbChangeDate = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PartNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SellPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btnAddPayment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPayment.Location = new System.Drawing.Point(202, 148);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(94, 27);
            this.btnAddPayment.TabIndex = 1;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // txtAmountPayed
            // 
            this.txtAmountPayed.Location = new System.Drawing.Point(96, 25);
            this.txtAmountPayed.Name = "txtAmountPayed";
            this.txtAmountPayed.Size = new System.Drawing.Size(200, 22);
            this.txtAmountPayed.TabIndex = 2;
            this.txtAmountPayed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountPayed_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount Payed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // dtpDebtDate
            // 
            this.dtpDebtDate.Enabled = false;
            this.dtpDebtDate.Location = new System.Drawing.Point(96, 66);
            this.dtpDebtDate.Name = "dtpDebtDate";
            this.dtpDebtDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDebtDate.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.lblDealDate);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.lblPartyName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblPayed);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(311, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 156);
            this.panel2.TabIndex = 0;
            // 
            // lblDealDate
            // 
            this.lblDealDate.AutoSize = true;
            this.lblDealDate.Location = new System.Drawing.Point(72, 128);
            this.lblDealDate.Name = "lblDealDate";
            this.lblDealDate.Size = new System.Drawing.Size(0, 13);
            this.lblDealDate.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 128);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 13);
            this.label.TabIndex = 9;
            this.label.Text = "Deal Date:";
            // 
            // lblPartyName
            // 
            this.lblPartyName.AutoSize = true;
            this.lblPartyName.Location = new System.Drawing.Point(72, 110);
            this.lblPartyName.Name = "lblPartyName";
            this.lblPartyName.Size = new System.Drawing.Size(0, 13);
            this.lblPartyName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Party Name:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(72, 89);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Balance:";
            // 
            // lblPayed
            // 
            this.lblPayed.AutoSize = true;
            this.lblPayed.Location = new System.Drawing.Point(72, 65);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(0, 13);
            this.lblPayed.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Payed:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(72, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Debt Details";
            // 
            // chbChangeDate
            // 
            this.chbChangeDate.AutoSize = true;
            this.chbChangeDate.Location = new System.Drawing.Point(96, 95);
            this.chbChangeDate.Name = "chbChangeDate";
            this.chbChangeDate.Size = new System.Drawing.Size(93, 17);
            this.chbChangeDate.TabIndex = 5;
            this.chbChangeDate.Text = "Change Date";
            this.chbChangeDate.UseVisualStyleBackColor = true;
            this.chbChangeDate.CheckedChanged += new System.EventHandler(this.chbChangeDate_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PartNo,
            this.SellPrice,
            this.Qty});
            this.listView1.Location = new System.Drawing.Point(12, 182);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 10);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // PartNo
            // 
            this.PartNo.Text = "PartNo";
            this.PartNo.Width = 132;
            // 
            // SellPrice
            // 
            this.SellPrice.Text = "Sell Price";
            this.SellPrice.Width = 101;
            // 
            // Qty
            // 
            this.Qty.Text = "Quanitity";
            this.Qty.Width = 216;
            // 
            // frmDebtAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(499, 198);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chbChangeDate);
            this.Controls.Add(this.dtpDebtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmountPayed);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDebtAddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay Debt Episode";
            this.Load += new System.EventHandler(this.frmDebtAddPayment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.TextBox txtAmountPayed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDebtDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPayed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chbChangeDate;
        private System.Windows.Forms.Label lblPartyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PartNo;
        private System.Windows.Forms.ColumnHeader SellPrice;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.Label lblDealDate;
        private System.Windows.Forms.Label label;
    }
}