using SuzukiSupplier.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuzukiSupplier
{
    public partial class frmShiftParts : Form
    {
        public frmShiftParts()
        {
            InitializeComponent();
        }

        public string ShiftFromStoreName;
        public int QtyAvailable;
        public int FromStoreId;
        public string PartNo;
        
        private void frmShiftParts_Load(object sender, EventArgs e)
        {
            lblPartNo.Text = PartNo;
            LoadStoreList();
            

        }
        private void LoadStoreList()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand("SELECT Name,Id from Store WHERE Name <> @Name", conn);
            sda.SelectCommand.Parameters.AddWithValue("@Name", ShiftFromStoreName);
            DataTable dtInventory = new DataTable();
            sda.Fill(dtInventory);
            cbShiftTo.DataSource = dtInventory;
            cbShiftTo.ValueMember = "Id";
            cbShiftTo.DisplayMember = "Name";
            
            conn.Close();
        }

        

        private void AddToInventoryofWarehouse(string PartNo, string StoreId, int Qty, string ShiftFrom)
        {
            SqlConnection Conn = Connection.getConnection();

            using (Conn)
            {
                SqlCommand cmd = new SqlCommand("ShiftPartsToInventory", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PartNo", PartNo);
                cmd.Parameters.AddWithValue("@ShiftTo", cbShiftTo.Text);
                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@ShiftFrom", ShiftFrom);
                Conn.Open();
                cmd.ExecuteScalar();
                

            }
            Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtQuantity.Text) <= int.Parse(lblAvailableQty.Text))
            {
                if (txtQuantity.Text != " " || txtQuantity.Text != String.Empty)
                {

                    MessageBox.Show(cbShiftTo.SelectedValue.ToString());
                    AddToInventoryofWarehouse(PartNo, cbShiftTo.SelectedValue.ToString(), int.Parse(txtQuantity.Text), ShiftFromStoreName);
                }
                else
                {
                    MessageBox.Show("Enter Quantity");
                }
            }
            else
            {
                MessageBox.Show("Available Quanitity Exceeded!");
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
