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
    public partial class Parties : Form
    {
        public Parties()
        {
            InitializeComponent();
        }

        private void btnAddParty_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text != "" || txtName.Text != "")
            {
                String Oper = btnAddParty.Text;
                if (Oper.Equals("Add"))
                {

                    SqlConnection Conn = Connection.getConnection();
                    String query = "INSERT INTO Party(Name, Location) VALUES (@Name, @Location)";
                    using (Conn)
                    {
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Location", txtLocation.Text);


                        Conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Party successfully added");
                    Parties_Load(sender, e);
                }

                else if (Oper.Equals("Edit"))
                {
                    SqlConnection Conn = Connection.getConnection();
                    String query = "UPDATE Party SET Name = @Name, Location = @Location WHERE id = @id";
                    using (Conn)
                    {
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                        cmd.Parameters.AddWithValue("@id", txtID.Text);

                        Conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Party successfully edited.");
                    Parties_Load(sender, e);

                }
                
                this.partyTableAdapter.Fill(this.aPIDataSet.Party);
            }
            else
            {
                MessageBox.Show("Please Fill all Fields");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = "Auto Generated";
            Exit.Visible = false;
            btnAddParty.Text = "Add";
            lblTitle.Text = "Add Party Details";
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            dataGridView1.Hide();
            grpbxParty.Show();

            txtLocation.Clear();
            txtName.Clear();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Exit.Visible = false;
            btnAddParty.Text = "Edit";
            lblTitle.Text = "Edit Party Details";
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            dataGridView1.Hide();
            grpbxParty.Show();

            txtLocation.Clear();
            txtName.Clear();


            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            
            txtID.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtName.Text = Convert.ToString(selectedRow.Cells[1].Value);
            txtLocation.Text = Convert.ToString(selectedRow.Cells[2].Value);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells[0].Value);

                SqlConnection Conn = Connection.getConnection();
                string query = "DELETE FROM Party WHERE Id= @Id";

                var confirmResult = MessageBox.Show("Are you sure you want to delete this party ?", "Confirm Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (confirmResult == DialogResult.Yes)
                {
                    using (Conn)
                    {
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.AddWithValue("@Id", id);

                        Conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Party has been deleted.");
                    this.partyTableAdapter.Fill(this.aPIDataSet.Party);
                }
                Parties_Load(sender, e);
            }
            catch (SqlException error)
            {
                if(error.Message.ToString() != "")
                {
                    MessageBox.Show("Party Record cannot be removed they are in debt");
                }
            }
        }

        private void Parties_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPIDataSet.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.aPIDataSet.Party);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Exit.Visible = true;
            dataGridView1.Show();
            grpbxParty.Hide();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Parties_Load(sender, e);
            

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')
                && (e.KeyChar != ' ') && (e.KeyChar != ',') && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')
                && (e.KeyChar != ' ') && (e.KeyChar != ',') && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
