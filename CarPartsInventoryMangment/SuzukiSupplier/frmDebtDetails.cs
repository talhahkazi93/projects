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
    public partial class frmDebtDetails : Form
    {
        public int debtId;
        public frmDebtDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDebtDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadData();
        }
        public void loadData()
        {
            SqlConnection conn = Connection.getConnection();
            string Query = "Select PartNo as [Part No], SellPrice as [Sell Price], Qty as [Quantity] from DebtDetails WHERE DebtId =" + "'" + debtId.ToString() + "'";

            using (SqlConnection Conn = Connection.getConnection())
            {

                SqlDataAdapter sda = new SqlDataAdapter(Query, Conn);
                DataTable dtdeptdetails = new DataTable();
                sda.Fill(dtdeptdetails);
                dataGridView1.DataSource = dtdeptdetails;
                dataGridView1.CancelEdit();

            }
        }

        private void dgvSalesMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
