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
    
  
    public partial class Form1 : Form
    {
        public static Form1 PublicMainForm;

        //private Parts p;
        public Form1()
        {
            InitializeComponent();
        }

        Purchase purch = new Purchase();
        Expense ex = new Expense();
        Parts pts = new Parts();
        Parties pop = new Parties();
        Sales sale = new Sales();
        Store store = new Store();
        Sell sell = new Sell();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool StockNotAvailable()
        {
            int Count = 0;

            SqlConnection Conn = Connection.getConnection();
            String query = "SELECT COUNT(*) FROM Inventory Where StoreId=(SELECT Id FROM Store WHERE Name='Shop') and Qty < 5";
            using (Conn)
            {
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.CommandType = CommandType.Text;

                Conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Count = int.Parse(sdr[0].ToString());
                }
            }
            return (Count <= 5);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgvSalesMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesMain.ClearSelection();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ClearSelection();
            PurchaseDao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PurchaseDao.ClearSelection();
            showExpenses();
            showSales();
            showPurchases();

            PublicMainForm = this;


            DateTime startDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime startDay2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 2);
            DateTime startDay3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 3);
            DateTime secondlastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - 1));
            DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            DateTime Now = DateTime.Now;

            if (Now.Day == startDay.Day || Now.Day == startDay2.Day || Now.Day == startDay3.Day ||
                Now.Day == secondlastDay.Day || Now.Day == lastDay.Day)
            {
                frmShowDebts frmShowDebts = new frmShowDebts();
                frmShowDebts.ShowDialog();
            }

            DisplayStockEndingAlert();

            
            
        }


        public void DisplayStockEndingAlert()
        {
            
            if(StockNotAvailable())
            {
                frmShowStockAlert frmShowStockAlert = new frmShowStockAlert();
                frmShowStockAlert.ShowDialog();
            }

        }

        public void LoadList()
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }  

        private void Partbtn_Click(object sender, EventArgs e)
        {
            
            pts.ShowDialog();
        }

        private void Partiesbtn_Click(object sender, EventArgs e)
        {
            
            pop.ShowDialog();
        }

        private void Expbtn_Click(object sender, EventArgs e)
        {
            
            ex.ShowDialog();
        }

        private void Salebtn_Click(object sender, EventArgs e)
        {
            
            sell.ShowDialog();
        }

        private void Purchasebtn_Click(object sender, EventArgs e)
        {
        
            purch.ShowDialog();
        }

        private void showparts_Click(object sender, EventArgs e)
        {
        
        }

        private void showstore_Click(object sender, EventArgs e)
        {
           
        }

        private void showListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Exit?", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                Application.Exit();
            }
            else
            {
            }
        }

        public void showExpenses()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 30 Name as [Reason], Amount, [Date] FROM Expenses WHERE Date = convert(date,GETDATE())", conn);
            DataTable dtstudent = new DataTable();
            sda.Fill(dtstudent);
            dataGridView2.DataSource = dtstudent;
            dataGridView2.CancelEdit();

            conn.Close();

        }

        public void showPurchases()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 30 pt.Name as [Part Name], P.Name as [Party Name], Pur.SellingPrice as [Cost Price], Pur.Qty as [Quanitity] FROM Purchase Pur INNER JOIN Party P ON P.Id = Pur.PartyId  INNER JOIN Parts pt ON pt.PartNo = Pur.PartNo WHERE DatePurchased = convert(date,GETDATE())", conn);
            DataTable dtstudent = new DataTable();
            sda.Fill(dtstudent);
            PurchaseDao.DataSource = dtstudent;
            PurchaseDao.CancelEdit();

            conn.Close();

        }

        public void showSales()
        {
            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 30 S.PartNo as [Part No], pt.Name as [Part Name], p.Name as [Party Name], SellingPrice as [Selling Price], Qty as [Quantity] from Sales S INNER JOIN Party P ON P.Id = S.PartyId  INNER JOIN Parts pt ON pt.PartNo = S.PartNo WHERE DateSold = convert(date,GETDATE())", conn);
            DataTable dtstudent = new DataTable();
            sda.Fill(dtstudent);
            dgvSalesMain.DataSource = dtstudent;
            dgvSalesMain.CancelEdit();

            conn.Close();

        }

        private void storeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            store.ShowDialog();
        }

        private void partyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pts.ShowDialog();
        }

        private void partsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pop.ShowDialog();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ex.ShowDialog();
        }

        private void salesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void showSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            sale.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInverntory frmInventory = new frmInverntory();
            frmInventory.ShowDialog();
        }

        private void sellItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell frmSell = new Sell();
            frmSell.ShowDialog();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            frmInverntory frm = new frmInverntory();
            frm.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDebt frmdebt = new frmDebt();
            frmdebt.ShowDialog();
        }

        private void btndebt_Click(object sender, EventArgs e)
        {
            frmDebt debt = new frmDebt();
            debt.ShowDialog();
        }

        private void showDebtorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDebts frmShowDebts = new frmShowDebts();
            frmShowDebts.ShowDialog();
        }

        private void showPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase frmPurchase = new Purchase();
            frmPurchase.ShowDialog();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowStockAlert frmShowStockAlert = new frmShowStockAlert();
            frmShowStockAlert.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthlySalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptMonthlyAccountingDetails frmmonthlyreport = new frmrptMonthlyAccountingDetails();
            frmmonthlyreport.Show();
        }

        private void addPaymentDebtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayDebt frmPayDebt = new frmPayDebt();
            frmPayDebt.ShowDialog();
        }

        private void shiftPartsToShopToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShiftPartsToShop frmShiftPartsToShop = new frmShiftPartsToShop();
            frmShiftPartsToShop.ShowDialog();

        }

        private void customMonthSalesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showEndingStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowStockAlert frmShowStockAlert = new frmShowStockAlert();
            frmShowStockAlert.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayStockEndingAlert();
        }
    }
}
