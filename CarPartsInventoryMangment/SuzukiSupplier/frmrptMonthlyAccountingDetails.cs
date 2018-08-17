using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuzukiSupplier
{

    public partial class frmrptMonthlyAccountingDetails : Form
    {

        public frmrptMonthlyAccountingDetails()
        {
            InitializeComponent();
        }

        private void frmrptMonthlyAccountingDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'APIv2DataSet.Expenses' table. You can move, or remove it, as needed.
            this.ExpensesTableAdapter.Fill(this.APIv2DataSet.Expenses, DateTime.Now.Month);
            // TODO: This line of code loads data into the 'APIv2DataSet.MonthlyDebtDetails' table. You can move, or remove it, as needed.
            this.MonthlyDebtDetailsTableAdapter.Fill(this.APIv2DataSet.MonthlyDebtDetails, DateTime.Now.Month);
            // TODO: This line of code loads data into the 'APIv2DataSet.MonthlySalesDetail' table. You can move, or remove it, as needed.
            this.MonthlySalesDetailTableAdapter.Fill(this.APIv2DataSet.MonthlySalesDetail, DateTime.Now.Month);
            // TODO: This line of code loads data into the 'APIv2DataSet.MonthlyPurchaseDetail' table. You can move, or remove it, as needed.
            this.MonthlyPurchaseDetailTableAdapter.Fill(this.APIv2DataSet.MonthlyPurchaseDetail, DateTime.Now.Month);
            this.reportViewer1.RefreshReport();
            loadcombobox();

        }

        void loadcombobox()
        {
            this.cbMonthsList.DisplayMember = "Text";
            this.cbMonthsList.ValueMember = "Value";

                var items = new[] { 
                new { Text = "January", Value = "1" }, 
                new { Text = "February", Value = "2" }, 
                new { Text = "March", Value = "3" },
                new { Text = "April", Value = "4" },
                new { Text = "May", Value = "5" },
                new { Text = "June", Value = "6" },
                new { Text = "July", Value = "7" },
                new { Text = "August", Value = "8" },
                new { Text = "September", Value = "9" },
                new { Text = "October", Value = "10" },
                new { Text = "November", Value = "11" },
                new { Text = "December", Value = "12" },
            };

            this.cbMonthsList.DataSource = items;
        }

        private void btnSHowMonthRecord_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'APIv2DataSet.Expenses' table. You can move, or remove it, as needed.
            this.ExpensesTableAdapter.Fill(this.APIv2DataSet.Expenses, int.Parse(cbMonthsList.SelectedValue.ToString()));
            // TODO: This line of code loads data into the 'APIv2DataSet.MonthlyDebtDetails' table. You can move, or remove it, as needed.
            this.MonthlyDebtDetailsTableAdapter.Fill(this.APIv2DataSet.MonthlyDebtDetails, int.Parse(cbMonthsList.SelectedValue.ToString()));
            // TODO: This line of code loads data into the 'APIv2DataSet.MonthlySalesDetail' table. You can move, or remove it, as needed.
            this.MonthlySalesDetailTableAdapter.Fill(this.APIv2DataSet.MonthlySalesDetail, int.Parse(cbMonthsList.SelectedValue.ToString()));
            // TODO: This line of code loads data into the 'APIv2DataSet.MonthlyPurchaseDetail' table. You can move, or remove it, as needed.
            this.MonthlyPurchaseDetailTableAdapter.Fill(this.APIv2DataSet.MonthlyPurchaseDetail, int.Parse(cbMonthsList.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
