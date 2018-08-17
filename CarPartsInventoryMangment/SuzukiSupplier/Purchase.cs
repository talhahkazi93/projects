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
using SuzukiSupplier.DAL;

namespace SuzukiSupplier
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1.PublicMainForm.showPurchases();

            this.Close();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            Exit.Show();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            listprtno();
            listprtyno();
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

        private void bck_Click(object sender, EventArgs e)
        {
            Purchase_Load(sender, e);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Exit.Hide();
            slngprizetxt.Text = "Auto Generated";
            label2.Text = "Add Purchase Info";
            slngprizetxt.Text = "";
            dtetxt.Text = DateTime.Now.ToString();
            partyidtxt.Text = "";
            Qtytxt.Text = "";
            prtnotxt.Text = "";
            idtxt.Text = "Auto Generated";
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
               label2.Text = "Edit purchase Info";
               AUbtn.Text = "Edit";
               EditBtn.Enabled = false;
               AddBtn.Enabled = true;
               DataGridViewRow row = this.dataGridView1.SelectedRows[0];
               slngprizetxt.Text = row.Cells["SellingPrice"].Value.ToString();
               dtetxt.Text = row.Cells["DatePurchased"].Value.ToString();
               partyidtxt.Text = row.Cells["Partyid"].Value.ToString();
               Qtytxt.Text = row.Cells["Qty"].Value.ToString();
               prtnotxt.Text = row.Cells["Partno"].Value.ToString();
               idtxt.Text = row.Cells["id"].Value.ToString();
               
               
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
                Purchase_Load(sender, e);

            }
        }

        private void AUbtn_Click(object sender, EventArgs e)
        {

            if (AUbtn.Text == "Edit")
            {
                if (prtnotxt.Text.Equals("") || partyidtxt.Text.Equals("") || Qtytxt.Text.Equals("")||slngprizetxt.Text.Equals(""))
                {
                    MessageBox.Show("Required Fields are empty");
                }
                else
                {

                    PurchaseDao pd = new PurchaseDao();
                    string sp = slngprizetxt.Text;
                    string date = dtetxt.Text;
                    string prtyid = partyidtxt.Text;
                    string Qty = Qtytxt.Text;
                    string prtno = prtnotxt.Text;
                    string id = idtxt.Text;


                    pd.Update(sp, date, prtyid, Qty, prtno, id);

                    MessageBox.Show("Updated!");
                    Purchase_Load(sender, e);

                }
            }
            if (AUbtn.Text == "Add")
            {
                if (prtnotxt.Text.Equals("") || partyidtxt.Text.Equals("") || Qtytxt.Text.Equals("") || slngprizetxt.Text.Equals(""))
                {
                    MessageBox.Show("Required Fields are empty");
                }
                else
                {

                    PurchaseDao pd = new PurchaseDao();
                    string sp = slngprizetxt.Text;
                    string date = dtetxt.Text;
                    string prtyid = partyidtxt.Text;
                    string Qty = Qtytxt.Text;
                    string prtno = prtnotxt.Text;
                    string id = idtxt.Text;
                    

                    pd.insert(sp,date,prtyid,Qty,prtno,id);

                    MessageBox.Show("added!");
                    Purchase_Load(sender, e);
                }
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
                        PurchaseDao d = new PurchaseDao();
                        d.delete(id);
                        showlist();
                        MessageBox.Show("Deleted");
                        Purchase_Load(sender, e);


                    }
                    else
                    {
                        ///leave
                    }

                }

                else
                {
                    MessageBox.Show("Select the row you want to delete");
                    Purchase_Load(sender, e);

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
            SqlDataAdapter sda = new SqlDataAdapter("select * from purchase", conn);
            DataTable dtstudent = new DataTable();
            sda.Fill(dtstudent);
            dataGridView1.DataSource = dtstudent;
            dataGridView1.CancelEdit();

            conn.Close();

        }
        public void listprtno()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            
            SqlDataAdapter sda = new SqlDataAdapter("select PartNo from parts", conn);
            DataSet dtstudent = new DataSet();
            sda.Fill(dtstudent);

            prtnotxt.DataSource = dtstudent.Tables[0];
            prtnotxt.DisplayMember = "PartNo";
            conn.Close();

        }
        public void listprtyno()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select id from party", conn);
            DataSet dtstudent = new DataSet();
            sda.Fill(dtstudent);
            partyidtxt.DataSource = dtstudent.Tables[0];
            partyidtxt.DisplayMember = "id";
           
            conn.Close();

        }

        private void slngprizetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void Qtytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }


    }
}
