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
    public partial class frmShowStockAlert : Form
    {
        public frmShowStockAlert()
        {
            InitializeComponent();
        }

        private void vtbCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();

            
        }

        private void frmShowStockAlert_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClearSelection();
            loadData();
            
        }

        private void loadData()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT P.Name, P.PartNo, I.Qty as [Quantity Available] FROM Inventory I INNER JOIN Parts P ON P.PartNo = I.PartNo WHERE StoreId=(SELECT Id FROM Store WHERE Name='Shop') AND Qty < 5", conn);
            DataTable dtstudent = new DataTable();
            sda.Fill(dtstudent);
            dataGridView1.DataSource = dtstudent;
            dataGridView1.CancelEdit();

            conn.Close();
        }
    }
}
