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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }
        private void Store_Load(object sender, EventArgs e)
        {
            Exit.Show();
            
            Typetxt.Items.Add("Main Storage");
            Typetxt.Items.Add("Secondary Storage");
            

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Show();
            groupBox1.Hide();
            bck.Hide();

            try
            {
                AddBtn.Enabled = true;
                EditBtn.Enabled = true;
                showlist();
                dataGridView1.ClearSelection();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public void showlist()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Store", conn);
            DataTable dtstudent = new DataTable();
            sda.Fill(dtstudent);
            dataGridView1.DataSource = dtstudent;
            dataGridView1.CancelEdit();

            conn.Close();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Exit.Hide();
            idtext.Text = "Auto Generated";
            label2.Text = "Add Store Info";
            Nametxt.Text = "";
            
            dataGridView1.ClearSelection();
            AUbtn.Text = "Add";
            EditBtn.Enabled = true;
            AddBtn.Enabled = false;
            groupBox1.Show();
            dataGridView1.Hide();
            bck.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Exit.Hide();
                label2.Text = "Edit Store Info";
                AUbtn.Text = "Edit";
                EditBtn.Enabled = false;
                AddBtn.Enabled = true;
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                idtext.Text = row.Cells["id"].Value.ToString();
                Nametxt.Text = row.Cells["Name"].Value.ToString();
                Typetxt.Text = row.Cells["Type"].Value.ToString();
               
                dataGridView1.Hide();
                groupBox1.Show();
                dataGridView1.ClearSelection();
                bck.Show();
            }
            else
            {
                MessageBox.Show("Select the row you want to edit");
                Store_Load(sender, e);

            }
        }

        private void RmvBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                        string id = row.Cells["id"].Value.ToString();
                        StoreDao store = new StoreDao();
                        store.delete(id);
                        showlist();
                        MessageBox.Show("Deleted");


                    }
                }

                else
                {
                    MessageBox.Show("Select the row you want to delete");
                    Store_Load(sender, e);

                }
            }
            catch (SqlException error)
            {
                if (error.Message.ToString()!="")
                {
                    MessageBox.Show("Shop cannot be removed without clearing the inventory");
                }
            }
            dataGridView1.ClearSelection();
        }

        private void bck_Click(object sender, EventArgs e)
        {
            Store_Load(sender, e);
        }

        private void AUbtn_Click(object sender, EventArgs e)
        {
            if (AUbtn.Text == "Edit")
            {
                if (Nametxt.Text.Equals("") || Typetxt.Text.Equals(""))
                {
                    MessageBox.Show("Required Fields are empty");
                }
                else
                {
                    

                        StoreDao store = new StoreDao();

                        String name = Nametxt.Text;
                        String Type = Typetxt.Text;
                        String id = idtext.Text;

                        store.Update(id, name, Type);

                        MessageBox.Show("Edited!");
                        
                        Store_Load(sender, e);
                   
                }
            }
            if (AUbtn.Text == "Add")
            {
                if (Nametxt.Text.Equals("") || Typetxt.Text.Equals("") )
                {
                    MessageBox.Show("Required Fields are empty");
                }
                else
                {
                    
                        StoreDao store = new StoreDao();

                        String name = Nametxt.Text;
                        String Type = Typetxt.Text;

                        store.insert(name, Type);

                        AddBtn.Enabled = true;
                        EditBtn.Enabled = true;

                        MessageBox.Show("Added!");

                        Store_Load(sender, e);
                    
                    
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}
