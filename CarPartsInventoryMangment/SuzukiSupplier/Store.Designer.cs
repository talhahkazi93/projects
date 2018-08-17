namespace SuzukiSupplier
{
    partial class Store
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Typetxt = new System.Windows.Forms.ComboBox();
            this.AUbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.idtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RmvBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.bck = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(608, 381);
            this.dataGridView1.TabIndex = 27;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.Enabled = false;
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.Typetxt);
            this.groupBox1.Controls.Add(this.AUbtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Nametxt);
            this.groupBox1.Controls.Add(this.idtext);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 381);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // Typetxt
            // 
            this.Typetxt.FormattingEnabled = true;
            this.Typetxt.ItemHeight = 13;
            this.Typetxt.Location = new System.Drawing.Point(222, 226);
            this.Typetxt.MaxDropDownItems = 3;
            this.Typetxt.Name = "Typetxt";
            this.Typetxt.Size = new System.Drawing.Size(177, 21);
            this.Typetxt.TabIndex = 33;
            // 
            // AUbtn
            // 
            this.AUbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AUbtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AUbtn.FlatAppearance.BorderSize = 2;
            this.AUbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AUbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AUbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AUbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AUbtn.Location = new System.Drawing.Point(254, 299);
            this.AUbtn.Name = "AUbtn";
            this.AUbtn.Size = new System.Drawing.Size(109, 31);
            this.AUbtn.TabIndex = 32;
            this.AUbtn.Text = "Add Part";
            this.AUbtn.UseVisualStyleBackColor = false;
            this.AUbtn.Click += new System.EventHandler(this.AUbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(360, 138);
            this.Nametxt.MaxLength = 100;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(177, 20);
            this.Nametxt.TabIndex = 2;
            this.Nametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nametxt_KeyPress);
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(78, 138);
            this.idtext.MaxLength = 100;
            this.idtext.Name = "idtext";
            this.idtext.ReadOnly = true;
            this.idtext.Size = new System.Drawing.Size(177, 20);
            this.idtext.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Store Info";
            // 
            // RmvBtn
            // 
            this.RmvBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RmvBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.RmvBtn.FlatAppearance.BorderSize = 2;
            this.RmvBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.RmvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RmvBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RmvBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RmvBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RmvBtn.Location = new System.Drawing.Point(281, 19);
            this.RmvBtn.Name = "RmvBtn";
            this.RmvBtn.Size = new System.Drawing.Size(109, 31);
            this.RmvBtn.TabIndex = 34;
            this.RmvBtn.Text = "Remove";
            this.RmvBtn.UseVisualStyleBackColor = false;
            this.RmvBtn.Click += new System.EventHandler(this.RmvBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.FlatAppearance.BorderSize = 2;
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.EditBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EditBtn.Location = new System.Drawing.Point(147, 19);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(109, 31);
            this.EditBtn.TabIndex = 35;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.FlatAppearance.BorderSize = 2;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddBtn.Location = new System.Drawing.Point(12, 19);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 31);
            this.AddBtn.TabIndex = 36;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // bck
            // 
            this.bck.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bck.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.bck.FlatAppearance.BorderSize = 2;
            this.bck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bck.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bck.Location = new System.Drawing.Point(548, 19);
            this.bck.Name = "bck";
            this.bck.Size = new System.Drawing.Size(72, 31);
            this.bck.TabIndex = 37;
            this.bck.Text = "Back";
            this.bck.UseVisualStyleBackColor = false;
            this.bck.Click += new System.EventHandler(this.bck_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit.Location = new System.Drawing.Point(548, 19);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(72, 31);
            this.Exit.TabIndex = 38;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.bck);
            this.panel1.Controls.Add(this.RmvBtn);
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 67);
            this.panel1.TabIndex = 34;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AUbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RmvBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox Typetxt;
        private System.Windows.Forms.Button bck;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
    }
}