using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using SuzukiSupplier.DAL;

namespace SuzukiSupplier
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }

        private void Expense_Load(object sender, EventArgs e)
        {
            Exit.Show();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClearSelection();
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


        private void button1_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count != 0)
            {
                Exit.Hide();
                label2.Text = "Edit Expense Info";
                AUbtn.Text = "Edit";
                EditBtn.Enabled = false;
                AddBtn.Enabled = true;
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                idtext.Text = row.Cells["id"].Value.ToString();
                Nametxt.Text = row.Cells["Name"].Value.ToString();
                Amounttext.Text = row.Cells["Amount"].Value.ToString();
                DateText.Text = row.Cells["Date"].Value.ToString();
                DateText.ReadOnly = true;
                dataGridView1.Hide();
                groupBox1.Show();
                dataGridView1.ClearSelection();
                bck.Show();
            }
            else
            {
                MessageBox.Show("Select the row you want to edit");
                dataGridView1.Show();
                groupBox1.Hide();
                Expense_Load(sender, e);

            }
        }

        private void AUbtn_Click(object sender, EventArgs e)
        {

            if (AUbtn.Text == "Edit")
            {
                if (Nametxt.Text.Equals("") || Amounttext.Text.Equals("") || DateText.Text.Equals(""))
                {
                    MessageBox.Show("Required Fields are empty");
                }
                else
                {
                   

                        ExpenseDao Exp = new ExpenseDao();
                        String ID = idtext.Text;
                        String name = Nametxt.Text;
                        String amount = Amounttext.Text;
                        String date = DateText.Text;

                        Exp.Update(ID, name, amount, date);
                        MessageBox.Show("Edited!");
                        Expense_Load(sender, e);
                   
                }
            }
            if (AUbtn.Text == "Add")
            {
                if (Nametxt.Text.Equals("") || Amounttext.Text.Equals("") || DateText.Text.Equals(""))
                {
                    MessageBox.Show("Required Fields are empty");
                }
                else
                {
                   
                        ExpenseDao Exp = new ExpenseDao();

                        String name = Nametxt.Text;
                        String amount = Amounttext.Text;
                        String date = DateText.Text;

                        Exp.insert(name, amount, date);

                        AddBtn.Enabled = true;
                        EditBtn.Enabled = true;

                        MessageBox.Show("Added!");
                        Expense_Load(sender, e);
                  

                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Exit.Hide();
            idtext.Text = "Auto Generated";
            label2.Text = "Add Expense Info";
            Nametxt.Text = "";
            Amounttext.Text = "";
            DateText.Text = DateTime.Now.ToString();
            dataGridView1.ClearSelection();
            AUbtn.Text = "Add";
            EditBtn.Enabled = true;
            AddBtn.Enabled = false;
            groupBox1.Show();
            dataGridView1.Hide();
            bck.Show();
        }

        private void bck_Click(object sender, EventArgs e)
        {
            Expense_Load(sender, e);
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
                        ExpenseDao d = new ExpenseDao();
                        d.delete(id);
                        showlist();
                        MessageBox.Show("Deleted");
                        Expense_Load(sender, e);


                    }
                    else
                    {
                        ///leave
                    }

                }

                else
                {
                    MessageBox.Show("Select the row you want to delete");
                    Expense_Load(sender, e);

                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message.ToString());
            }


        }
        public void showlist()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Expenses", conn);
            DataTable dtstudent = new DataTable();
            sda.Fill(dtstudent);
            dataGridView1.DataSource = dtstudent;
            dataGridView1.CancelEdit();

            conn.Close();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1.PublicMainForm.showExpenses();
            this.Close();
        }

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Amounttext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amounttext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

        }

    }
}
