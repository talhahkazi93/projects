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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPIDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.aPIDataSet.Parts);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Show();
            groupBox1.Hide();
            btnBack.Enabled = true;
            btnDelete.Enabled = true;
            Addprt.Enabled = true;
            Editprt.Enabled = true;
            Exit.Visible = true;
            
            
        }


        private void Addprt_Click(object sender, EventArgs e)
        {
            
            AUbtn.Text = "Add";
            label2.Text = "Add Part to Storage";
            Addprt.Enabled = false;
            Editprt.Enabled = false;
            btnDelete.Enabled = false;
            dataGridView1.Hide();
            groupBox1.Show();
            Exit.Visible = false;

            txtCar.Clear();
            txtCost.Clear();
            txtModel.Clear();
            txtPartName.Clear();
            txtPartNo.Clear();
            
        }

        private void Editprt_Click(object sender, EventArgs e)
        {
           
            AUbtn.Text = "Edit";
            label2.Text="Edit Part to Storage";
            groupBox1.Show();

            Exit.Visible = false;
            btnDelete.Enabled = false;
            AUbtn.Enabled = true;
            dataGridView1.Hide();
            Addprt.Enabled = false;
            Editprt.Enabled = false;
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            txtPartNo.ReadOnly = true;
            txtPartName.Text = Convert.ToString(selectedRow.Cells[1].Value);
            txtPartNo.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtModel.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txtCar.Text = Convert.ToString(selectedRow.Cells[3].Value);
            txtCost.Text = Convert.ToString(selectedRow.Cells[4].Value);


            
        }

        private void AUbtn_Click(object sender, EventArgs e)
        {
            String aubtn = AUbtn.Text;
            if (txtPartName.Text != "" || txtPartNo.Text != "" || txtModel.Text != "" || txtCost.Text != "" || txtCar.Text != "")
            {
                if (aubtn.Equals("Add"))
                {

                    SqlConnection Conn = Connection.getConnection();
                    String query = "INSERT INTO Parts(PartNo, Name, Model, Car, CostPrice) VALUES (@PartNo, @Name, @Model, @Car, @Cost)";
                    using (Conn)
                    {
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@PartNo", txtPartNo.Text);
                        cmd.Parameters.AddWithValue("@Name", txtPartName.Text);
                        cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                        cmd.Parameters.AddWithValue("@Car", txtCar.Text);
                        cmd.Parameters.AddWithValue("@Cost", decimal.Parse(txtCost.Text));

                        Conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Part successfully added");
                    Parts_Load(sender, e);

                }

                else if (aubtn.Equals("Edit"))
                {
                    SqlConnection Conn = Connection.getConnection();
                    String query = "UPDATE Parts SET Name = @Name, Model = @Model, Car = @Car, CostPrice = @CostPrice WHERE PartNo = @PartNo";
                    using (Conn)
                    {
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@PartNo", txtPartNo.Text);
                        cmd.Parameters.AddWithValue("@Name", txtPartName.Text);
                        cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                        cmd.Parameters.AddWithValue("@Car", txtCar.Text);
                        cmd.Parameters.AddWithValue("@CostPrice", decimal.Parse(txtCost.Text));

                        Conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Part successfully edited.");
                    Parts_Load(sender, e);

                }

                this.partsTableAdapter.Fill(this.aPIDataSet.Parts);

            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void Removeprt_Click(object sender, EventArgs e)
        {

            
            Editprt.Enabled = true;
            Addprt.Enabled = true;
            dataGridView1.Show();
            groupBox1.Hide();
            btnDelete.Visible = true;
            btnDelete.Enabled = true;



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string PartNo = Convert.ToString(selectedRow.Cells[0].Value);

            SqlConnection Conn = Connection.getConnection();
            string query = "DELETE FROM Parts WHERE PartNo= @PartNo";

            var confirmResult = MessageBox.Show("Are you sure you want to delete this part ?", "Confirm Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirmResult == DialogResult.Yes)
            {
                using (Conn)
                {
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.Parameters.AddWithValue("@PartNo", PartNo);

                    Conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Part has been deleted.");

            }
            this.partsTableAdapter.Fill(this.aPIDataSet.Parts);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Parts_Load(sender, e);

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtPartName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtCar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

    }
}
