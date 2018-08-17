using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuzukiSupplier.DAL
{
    public class DebtDao
    {
        public int InsertDebt(DateTimePicker dtpdealdate, Label GrantTotal, TextBox PayedAmount, ComboBox Party, DateTimePicker LastPaymentDate)
        {
            
            int debtId = -1;
            using (SqlConnection Conn = Connection.getConnection())
            {
                SqlCommand cmd = new SqlCommand("InsertDebt", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DealDate", dtpdealdate.Value);
                cmd.Parameters.AddWithValue("@Total", float.Parse(GrantTotal.Text));
                cmd.Parameters.AddWithValue("@Payed", PayedAmount.Text);
                cmd.Parameters.AddWithValue("@PartyId", Party.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@LastPaymentDate", LastPaymentDate.Value);
                Conn.Open();
                debtId = (int)cmd.ExecuteScalar();
            }
            return debtId;
        }


        

    }
}
