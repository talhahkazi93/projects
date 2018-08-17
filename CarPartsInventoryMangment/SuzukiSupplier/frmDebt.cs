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
    public partial class frmDebt : Form
    {
        public frmDebt()
        {
            InitializeComponent();
        }
        int debtId = -1;

        private void button1_Click(object sender, EventArgs e)
        {
            DebtDao debtdao = new DebtDao();
            //InsertDebt(DateTimePicker dtpdealdate, Label GrantTotal, Label PayedAmount, ComboBox Party, DateTimePicker LastPaymentDate)
            int debtId = debtdao.InsertDebt(dtpDealDate, lblGrandTotal, txtPayment, cbParty, dtpLastPaymentDate);


            MessageBox.Show(debtId.ToString());
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count < 0)
            {

                listView1.Items.Remove(listView1.SelectedItems[0]);
                float GrandTotal = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {

                    GrandTotal += float.Parse(listView1.Items[i].SubItems[4].Text);

                }
                lblGrandTotal.Text = GrandTotal.ToString();
            }
            else
            {
                MessageBox.Show("No Items Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDebt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPIDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.aPIDataSet.Parts);
            // TODO: This line of code loads data into the 'aPIDataSet.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.aPIDataSet.Party);
            listView1.FullRowSelect = true;

        }

        private void cbSelectPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSellingPrice.Enabled = true;
            SellDao selldao = new SellDao();
            selldao.GetPartDetails(cbSelectPart.Text, lblSelectedPartName, lblAvailableQuantity, lblDisplayModel, lblDisplayCar, lblDisplayCostPrice);
        }

        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            SellDao salesdao = new SellDao();

            if (salesdao.Available(cbSelectPart.Text, int.Parse(txtQty.Text)))
            {

                float rowTotal = (int.Parse(txtQty.Text) * float.Parse(txtSellingPrice.Text));
                ListViewItem Item = new ListViewItem(cbSelectPart.Text);

                Item.SubItems.Add(txtSellingPrice.Text);

                Item.SubItems.Add(cbParty.SelectedValue.ToString());

                Item.SubItems.Add(txtQty.Text);

                Item.SubItems.Add(rowTotal.ToString());
                listView1.Items.AddRange(new ListViewItem[] { Item });

                cbSelectPart.ResetText();
                txtSellingPrice.Clear();
                txtQty.Clear();

                float GrandTotal = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {

                    GrandTotal += float.Parse(listView1.Items[i].SubItems[4].Text);

                }

                lblGrandTotal.Text = GrandTotal.ToString();
                
            }
                
            else
            {

                MessageBox.Show("Requested amount of quanity is not available in the shop.");
            }
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0 && txtPayment.Text != "")
            {

                DebtDao debtdao = new DebtDao();

                debtId = debtdao.InsertDebt(dtpDealDate, lblGrandTotal, txtPayment, cbParty, dtpLastPaymentDate);

                SellDao selldao = new SellDao();

                String query = "INSERT INTO DebtDetails(PartNo, DebtId, Qty, SellPrice) VALUES(@PartNo, @DeptId, @Qty, @SellPrice)";
                using (SqlConnection Conn = Connection.getConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.CommandType = CommandType.Text;


                    Conn.Open();

                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@PartNo", listView1.Items[i].SubItems[0].Text);
                        cmd.Parameters.AddWithValue("@SellPrice", listView1.Items[i].SubItems[1].Text);
                        cmd.Parameters.AddWithValue("@Qty", listView1.Items[i].SubItems[3].Text);
                        cmd.Parameters.AddWithValue("@DeptId", debtId);

                        cmd.ExecuteNonQuery();
                        selldao.DecreaseQuanity(listView1.Items[i].SubItems[0].Text, int.Parse(listView1.Items[i].SubItems[3].Text));
                    }
                }
                MessageBox.Show("Debt Transaction Done!");
                Form1.PublicMainForm.DisplayStockEndingAlert();
                this.Close();
            }
            else
            {
                MessageBox.Show("Select items and payment amount.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (int)Keys.Back);
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}

