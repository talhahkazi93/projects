using SuzukiSupplier.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuzukiSupplier.DAL
{
    class ExpenseDao
    {
        public void delete(String id)
        {

            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"Delete From Expenses where Id ='"+id+"'";
            cmd.ExecuteNonQuery();
            
            conn.Close();
        }

        public void insert(String name, String Amount, String Date)
        {

            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"Insert into Expenses(Name,Amount,Date) values ('" + name + "','" + Amount + "',convert(date,GETDATE()))";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Update(String id, String name, String Amount, String Date)
        {

            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand(); //Update Expenses set Name='Tea and Biscuits' where Id='10';
            cmd.CommandText = @"update Expenses set Name = '" + name + "', Amount = '" + Amount +"' where id= '"+id+"'";
            cmd.ExecuteNonQuery();
        
            conn.Close();

        }
    }
}
