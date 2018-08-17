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
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPIDataSet.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.aPIDataSet.Party);

            // TODO: This line of code loads data into the 'aPIDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.aPIDataSet.Parts);


            listView1.Items.Clear();
            
            listView1.FullRowSelect = true;
            List<string> CustomerType = new List<string>();

            CustomerType.Add("Party");
            CustomerType.Add("Customer");

            cbCustomerType.DataSource = CustomerType;




        }

        private void prtcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSellingPrice.Enabled = true;
            SellDao selldao = new SellDao();
            selldao.GetPartDetails(cbSelectPart.Text, lblSelectedPartName, lblAvailableQuantity, lblDisplayModel, lblDisplayCar, lblDisplayCostPrice);


        }

        private void dtsld_ValueChanged(object sender, EventArgs e)
        {
            cbCustomerType.Enabled = true;
        }

        private void partyId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQty.Enabled = true;
        }

        private void cstmrType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomerType.Text == "Customer")
            {
                cbParty.Enabled = false;
            }
            else
            {
                cbParty.Enabled = true;
            }
        }

        private void slngprz_TextChanged(object sender, EventArgs e)
        {
            cbDate.Enabled = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to cancel the transaction ?", "exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                cbSelectPart.Enabled = true;
                txtSellingPrice.Enabled = false;
                cbDate.Enabled = false;
                cbCustomerType.Enabled = false;
                cbParty.Enabled = false;
                txtQty.Enabled = false;

                cbSelectPart.Text = "";
                txtSellingPrice.Text = "";
                cbDate.Text = "";
                cbCustomerType.Text = "";
                cbParty.Text = "";
                txtQty.Text = "";

                this.Close();
            }
            else
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellDao salesdao = new SellDao();
            
            if(salesdao.Available(cbSelectPart.Text, int.Parse(txtQty.Text)))
            {

            float rowTotal = (int.Parse(txtQty.Text) * float.Parse(txtSellingPrice.Text));
            ListViewItem Item = new ListViewItem(cbSelectPart.Text);

            Item.SubItems.Add(txtSellingPrice.Text);
            Item.SubItems.Add(cbDate.Text);
            Item.SubItems.Add(cbCustomerType.Text);
            if (cbCustomerType.Text.Equals("Customer"))
            {
                Item.SubItems.Add(String.Empty);
            }
            else
            {
                Item.SubItems.Add(cbParty.SelectedValue.ToString());
            }
            Item.SubItems.Add(txtQty.Text);

            Item.SubItems.Add(rowTotal.ToString());
            listView1.Items.AddRange(new ListViewItem[] { Item });

            cbSelectPart.ResetText();
            txtSellingPrice.Clear();
            txtQty.Clear();

            float GrandTotal = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {

                GrandTotal += float.Parse(listView1.Items[i].SubItems[6].Text);

            }

            lblGrandTotal.Text = GrandTotal.ToString();
            }
            else{

                MessageBox.Show("Requested amount of quanity is not available in the shop.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
            float GrandTotal = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {

                GrandTotal += float.Parse(listView1.Items[i].SubItems[6].Text);

            }

            lblGrandTotal.Text = GrandTotal.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                SellDao selldao = new SellDao();


                SqlConnection Conn = Connection.getConnection();
                String query = "Insert INTO Sales(PartNo, SellingPrice, DateSold, CustomerType, PartyId, Qty) VALUES(@PartNo, @SellingPrice, @DateSold, @CustomerType, @PartyId, @Qty)";
                using (Conn)
                {
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.CommandType = CommandType.Text;


                    Conn.Open();

                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@PartNo", listView1.Items[i].SubItems[0].Text);
                        cmd.Parameters.AddWithValue("@SellingPrice", decimal.Parse(listView1.Items[i].SubItems[1].Text));
                        cmd.Parameters.AddWithValue("@DateSold", DateTime.Parse(listView1.Items[i].SubItems[2].Text));
                        cmd.Parameters.AddWithValue("@CustomerType", listView1.Items[i].SubItems[3].Text);
                        if (listView1.Items[i].SubItems[3].Text.Equals("Customer"))
                        {
                            cmd.Parameters.AddWithValue("@PartyId", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@PartyId", int.Parse(listView1.Items[i].SubItems[4].Text));
                        }
                        cmd.Parameters.AddWithValue("@Qty", int.Parse(listView1.Items[i].SubItems[5].Text));

                        cmd.ExecuteNonQuery();
                        selldao.DecreaseQuanity(listView1.Items[i].SubItems[0].Text, int.Parse(listView1.Items[i].SubItems[5].Text));
                    }
                }
                MessageBox.Show("Transaction Done!");
                Form1.PublicMainForm.showSales();
                Form1.PublicMainForm.DisplayStockEndingAlert();
                this.Close();
            }
            else
            {
                MessageBox.Show("Select items and payment amount.");
            }
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) )
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
