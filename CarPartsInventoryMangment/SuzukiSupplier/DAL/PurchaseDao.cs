using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuzukiSupplier.DAL
{
    class PurchaseDao
    {
        public void delete(String id)
        {

            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"Delete From purchase where Id ='" + id + "'";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void insert(String slngprz, String date, String prtyid,String qty,String prtno,String id)
        {

            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"Insert into purchase(SellingPrice,DatePurchased,PartyId,Qty,PartNo)
            values ('" + slngprz + "',convert(date,GETDATE()),'" + prtyid + "','" + qty + "','" + prtno + "')";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Update(String slngprz, String date, String prtyid, String qty, String prtno, String id)
        {

            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand(); //Update Expenses set Name='Tea and Biscuits' where Id='10';
            cmd.CommandText = @"update purchase set SellingPrice = '" + slngprz + "', DatePurchased = '"
                + date + "', PartyId='"+prtyid+"', QTY ='"+qty+ "', PartNo ='"+prtno+"' where id= '" + id + "'";
            cmd.ExecuteNonQuery();

            conn.Close();

        }
    }
}
