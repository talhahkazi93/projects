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
    public partial class frmInverntory : Form
    {
        public frmInverntory()
        {
            InitializeComponent();
        }

        private void frmInverntory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPIDataSet1.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.ShowInventory(this.aPIDataSet1.Inventory);
            
            this.partsTableAdapter.Fill(this.aPIDataSet.Parts);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            grpbxAdd.Hide();
            grpbxEdit.Hide(); 
            dataGridView1.Show();

            
        }

        private void Addprt_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            grpbxAdd.Show();
            grpbxEdit.Hide();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnBack.Text = "Back";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSelectModel.Enabled = false;
            cbSelectPartNo.Enabled = false;
            txtQty.Enabled = false;

            cbSelectPartName.Enabled = true;
            DataTable dt = new DataTable();
            SqlConnection Conn = Connection.getConnection();
            string query = "Select Distinct Name FROM Parts Where Car = " + "'" + cbSelectCar.SelectedValue.ToString() + "'";
            
            using (Conn)
            {
                Conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
                sda.Fill(dt);
                cbSelectPartName.DataSource = dt;
                cbSelectPartName.DisplayMember = "Name";
                cbSelectPartName.ValueMember = "Name";
            }
            
        }

        private void cbSelectModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            SqlConnection Conn = Connection.getConnection();
            string query = "Select Distinct PartNo FROM Parts Where Car = " + "'" + cbSelectCar.SelectedValue.ToString() + "'" + "AND Model =" + "'" + cbSelectModel.SelectedValue.ToString() + "'" + "AND Name = " + "'" + cbSelectPartName.SelectedValue.ToString() + "'";
            using (Conn)
            {
                Conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
                sda.Fill(dt);
                cbSelectPartNo.DataSource = dt;
                cbSelectPartNo.DisplayMember = "PartNo";
                cbSelectPartNo.ValueMember = "PartNo";
            }
            cbSelectPartNo.Enabled = true;
        }

        private void cbSelectPartName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbSelectModel.Enabled = true;
            DataTable dt = new DataTable();
            SqlConnection Conn = Connection.getConnection();
            string query = "Select Distinct Model FROM Parts Where Name = " + "'" + cbSelectPartName.SelectedValue.ToString() + "'";

            using (Conn)
            {
                Conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
                sda.Fill(dt);
                cbSelectModel.DataSource = dt;
                cbSelectModel.DisplayMember = "Model";
                cbSelectModel.ValueMember = "Model";
            }
        }

        private void cbSelectPartNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            SqlConnection Conn = Connection.getConnection();
            string query = "Select * from Store";
            using (Conn)
            {
                Conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, Conn);
                sda.Fill(dt);
                cbSelectStore.DataSource = dt;
                cbSelectStore.DisplayMember = "Name";
                cbSelectStore.ValueMember = "Id";
            }
            cbSelectStore.Enabled = true;
            txtQty.Enabled = true;
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {
            if (txtCar.Text != "" || txtEditQty.Text != "" || txtModel.Text != "" || txtPartName.Text != "" || txtPartNo.Text != "" || txtQty.Text != "" || txtStore.Text != "")
            {
                string Oper = btnAddToInventory.Text;

                if (Oper.Equals("Add"))
                {
                    SqlConnection Conn = Connection.getConnection();

                    using (Conn)
                    {
                        SqlCommand cmd = new SqlCommand("AddPartsToInventory", Conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PartNo", cbSelectPartNo.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@StoreId", cbSelectStore.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@Qty", txtQty.Text);
                        Conn.Open();
                        cmd.ExecuteScalar();

                    }
                    MessageBox.Show("Parts added to the inventory Successfully.");
                    frmInverntory_Load(sender, e);                 

                }

            }
            else
            {
                MessageBox.Show("Please fill all the fields", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.FillBy(this.aPIDataSet.Inventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.FillBy1(this.aPIDataSet.Inventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            grpbxEdit.Show();

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            
            txtPartNo.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtEditQty.Text = Convert.ToString(selectedRow.Cells[1].Value);
            txtPartName.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txtCar.Text = Convert.ToString(selectedRow.Cells[3].Value);
            txtModel.Text = Convert.ToString(selectedRow.Cells[4].Value);
            txtStore.Text = Convert.ToString(selectedRow.Cells[5].Value);
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnBack.Text = "Back";
        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            if (txtCar.Text != "" || txtEditQty.Text != "" || txtModel.Text != "" || txtPartName.Text != "" 
                || txtPartNo.Text != "" || txtQty.Text != "" || txtStore.Text != "" ||txtEditQty.Enabled==false||
                txtModel.Enabled==false||txtPartName.Enabled==false||txtPartNo.Enabled==false
                ||txtQty.Enabled==false||txtStore.Enabled==false)
            {
                SqlConnection Conn = Connection.getConnection();
                string query = "Update Inventory Set Qty = @Qty WHERE PartNo = @PartNo AND StoreId = (SELECT Id from Store WHERE Name = @Store)";
                using (Conn)
                {
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@PartNo", txtPartNo.Text);
                    cmd.Parameters.AddWithValue("@Store", txtStore.Text);
                    cmd.Parameters.AddWithValue("@Qty", txtEditQty.Text);
                    Conn.Open();
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Inventory details edited Successfully.");
                this.inventoryTableAdapter.ShowInventory(this.aPIDataSet1.Inventory);
                frmInverntory_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string Oper = btnBack.Text;


            if(Oper.Equals("Exit"))
            {
                this.Close();
            }
            else if (Oper.Equals("Back"))
            {
                grpbxAdd.Hide();
                grpbxEdit.Hide();
                dataGridView1.Show();
                btnEdit.Enabled = true;
                btnAdd.Enabled = true;
                btnBack.Text = "Exit";
            }
        }

        private void txtEditQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtQty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
