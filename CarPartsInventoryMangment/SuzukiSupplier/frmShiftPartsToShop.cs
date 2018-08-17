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
    public partial class frmShiftPartsToShop : Form
    {
        public frmShiftPartsToShop()
        {
            InitializeComponent();
        }

        private void frmShiftPartsToShop_Load(object sender, EventArgs e)
        {

            dgListWarehouseItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadStoreList();
            LoadInventoryData(cbWarehouseList.Text);
            
        }

        private void LoadInventoryData(string storeName)
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand("SELECT P.PartNo as [Part No],P.Name as [Part Name], P.[Car ], P.Model, W.Qty as Quantity FROM Inventory W INNER JOIN Parts P ON W.PartNo = P.PartNo WHERE W.StoreId=(Select Id FROM Store WHERE Name = @storeName)", conn);
            sda.SelectCommand.Parameters.AddWithValue("@storeName", storeName);
            DataTable dtInventory = new DataTable();
            sda.Fill(dtInventory);
            dgListWarehouseItems.DataSource = dtInventory;
            dgListWarehouseItems.CancelEdit();
            conn.Close();
        }
        private void LoadStoreList()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand("SELECT Name,Id from Store WHERE Type = 'Secondary Storage'", conn);
           
            DataTable dtInventory = new DataTable();
            sda.Fill(dtInventory);
            cbWarehouseList.DataSource = dtInventory;
            cbWarehouseList.ValueMember = "Id";
            cbWarehouseList.DisplayMember = "Name";
            
            conn.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            LoadInventoryData(cbWarehouseList.Text);
        }

        private void DecreaseQuanityInWarehouse(string PartNo, int Qty, string StoreName)
        {
            SqlConnection Conn = Connection.getConnection();
            String query = "UPDATE Inventory SET Qty = (Qty-@Qty) WHERE PartNo = @PartNo and StoreId = (Select StoreId FROM Store WHERE Name = @Name)";
            using (Conn)
            {
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@PartNo", PartNo);
                cmd.Parameters.AddWithValue("@Name", StoreName);
                Conn.Open();
                cmd.ExecuteScalar();
            }
        }

        private void AddToInventoryofWarehouse(int PartNo, int StoreId, int Qty)
        {
            SqlConnection Conn = Connection.getConnection();

            using (Conn)
            {
                SqlCommand cmd = new SqlCommand("AddPartsToInventory", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PartNo", PartNo);
                cmd.Parameters.AddWithValue("@StoreId", StoreId);
                cmd.Parameters.AddWithValue("@Qty", Qty);
                Conn.Open();
                cmd.ExecuteScalar();

            }
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            
            
            

            if (dgListWarehouseItems.Rows.Count != 0)
            {
                int selectedrowindex;
                selectedrowindex = dgListWarehouseItems.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgListWarehouseItems.Rows[int.Parse(selectedrowindex.ToString())];
                
                frmShiftParts frmShiftParts = new frmShiftParts();
                frmShiftParts.ShiftFromStoreName = cbWarehouseList.Text;
                frmShiftParts.FromStoreId = int.Parse(cbWarehouseList.SelectedValue.ToString());
                frmShiftParts.lblAvailableQty.Text = Convert.ToString(selectedRow.Cells[4].Value);
                frmShiftParts.lblShiftFrom.Text = cbWarehouseList.SelectedValue.ToString();
                frmShiftParts.PartNo = Convert.ToString(selectedRow.Cells[0].Value);
                frmShiftParts.ShowDialog();
            }
            else
            {
                MessageBox.Show("No item available to select!");
                
                
            }



            


        }

        private void cbWarehouseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInventoryData(cbWarehouseList.Text);
        }
    }
}
