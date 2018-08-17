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
    public partial class frmShowDebts : Form
    {
        public frmShowDebts()
        {
            InitializeComponent();
        }

        private void frmShowDebts_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadData();

        }

        public void loadData()
        {
            SqlConnection conn = Connection.getConnection();
            //P.Name, D.DealDate,
            string Query = "Select D.DebtId, P.Name as Party, D.DealDate, SUM(DD.Qty) as [Total Items] , D.Total, D.Payed, (D.Total-D.Payed) as Balance ,D.LastPaymentDate From Debt D INNER JOIN Party P ON D.PartyId = P.Id INNER JOIN DebtDetails DD ON D.DebtId = DD.DebtID Group By P.Name, D.DealDate, D.Total, D.Payed, D.LastPaymentDate, D.DebtId";

            using (SqlConnection Conn = Connection.getConnection())
            {
                SqlDataAdapter sda = new SqlDataAdapter(Query, Conn);
                DataTable dtdeptorslist = new DataTable();
                sda.Fill(dtdeptorslist);
                dataGridView1.DataSource = dtdeptorslist;
                dataGridView1.CancelEdit();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowDebtDetails_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string debtID = Convert.ToString(selectedRow.Cells[0].Value);

            frmDebtDetails frmShowSelectDebtDetails = new frmDebtDetails();
            frmShowSelectDebtDetails.debtId = int.Parse(debtID);

            frmShowSelectDebtDetails.ShowDialog();
        }

        
    }
}
