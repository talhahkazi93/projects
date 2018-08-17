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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        public void showSales()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ID,PartNo as [Part No], SellingPrice as [Sell Price], Qty as [Quantity], (SELECT Name FROM Party WHERE Id=s.PartyId) as [Party Name] , DateSold as [Date Sold] from sales s", conn);
            DataTable dtstudent = new DataTable();
            sda.Fill(dtstudent);
            dataGridView1.DataSource = dtstudent;
            dataGridView1.CancelEdit();

            conn.Close();
        }

        private void Sales_Load_1(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showSales();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
