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
    public partial class frmDebtAddPayment : Form
    {

        public int DebtId;
        private int PartyId;
        public frmDebtAddPayment()
        {
            InitializeComponent();

        }

        private void chbChangeDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbChangeDate.Checked)
            {
                dtpDebtDate.Enabled = true;
            }
            else
            {
                dtpDebtDate.Enabled = false;
            }
        }

        private void showDetails()
        {
            SqlConnection Conn = Connection.getConnection();
            String query = "SELECT D.Total,D.Payed,(D.Total-D.Payed) as [Balance],P.Name, D.Dealdate,D.PartyId FROM Debt D  INNER JOIN Party P On P.Id=D.PartyId WHERE  D.DebtId = @DebtId";
            using (Conn)
            {
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@DebtId", DebtId);

                Conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    lblTotal.Text = sdr[0].ToString();
                    lblPayed.Text = sdr[1].ToString();
                    lblBalance.Text = sdr[2].ToString();
                    lblPartyName.Text = sdr[3].ToString();
                    lblDealDate.Text = sdr[4].ToString();
                    PartyId = int.Parse(sdr[5].ToString());
                }
            }
        }

        private void frmDebtAddPayment_Load(object sender, EventArgs e)
        {
            showDetails();
            loadListView();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            decimal payedtotal = decimal.Parse(lblPayed.Text) + decimal.Parse(txtAmountPayed.Text);
            if (payedtotal == decimal.Parse(lblTotal.Text))
            {
                SqlConnection Conn = Connection.getConnection();
                String query = "Insert INTO Sales(PartNo, SellingPrice, DateSold, CustomerType, PartyId, Qty) VALUES(@PartNo, @SellingPrice, @DateSold, @CustomerType, @PartyId, @Qty)";
                String query2 = "Delete FROM Debt WHERE DebtId = @DebtId";
                String query3 = "Delete FROM DebtDetails WHERE DebtId = @DebtId";

                using (Conn)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Conn;
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;


                    Conn.Open();

                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@PartNo", listView1.Items[i].SubItems[0].Text);
                        cmd.Parameters.AddWithValue("@SellingPrice", decimal.Parse(listView1.Items[i].SubItems[1].Text));
                        cmd.Parameters.AddWithValue("@DateSold", DateTime.Parse(lblDealDate.Text));
                        cmd.Parameters.AddWithValue("@CustomerType", "Party");
                        cmd.Parameters.AddWithValue("@PartyId", PartyId);
                        cmd.Parameters.AddWithValue("@Qty", listView1.Items[i].SubItems[2].Text);

                        cmd.ExecuteNonQuery();
                    }
                    cmd.Parameters.Clear();
                    cmd.CommandText = query3;
                    cmd.Parameters.AddWithValue("@DebtId", DebtId);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.CommandText = query2;
                    cmd.Parameters.AddWithValue("@DebtId", DebtId);
                    cmd.ExecuteNonQuery();

                }

            }
            else
            {
                SqlConnection Conn = Connection.getConnection();
                String query = "UPDATE Debt SET Payed = @Payed, LastPaymentDate =  @LastPaymentDate WHERE DebtId=@DebtId";
                using (Conn)
                {
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.CommandType = CommandType.Text;

                    Conn.Open();

                    cmd.Parameters.AddWithValue("@Payed", payedtotal);
                    cmd.Parameters.AddWithValue("@LastPaymentDate", dtpDebtDate.Value);
                    cmd.Parameters.AddWithValue("@DebtId", DebtId);

                    cmd.ExecuteNonQuery();

                }
                
            }
            MessageBox.Show("Debt Payment Done Successfully.");
            frmPayDebt.PublicPayDebtForm.Dispose();
            this.Dispose();
        }

        private void loadListView()
        {
            SqlConnection Conn = Connection.getConnection();
            String query = "SELECT DD.PartNo, DD.Qty, DD.SellPrice FROM Debt D INNER JOIN DebtDetails DD ON DD.DebtId = D.DebtId WHERE D.DebtId = @DebtId";
            using (Conn)
            {
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@DebtId", DebtId);

                Conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    ListViewItem Item = new ListViewItem(sdr[0].ToString());
                    Item.SubItems.Add(sdr[2].ToString());
                    Item.SubItems.Add(sdr[1].ToString());
                    listView1.Items.AddRange(new ListViewItem[] { Item });
                }
            }



        }

        private void txtAmountPayed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

    }
}
