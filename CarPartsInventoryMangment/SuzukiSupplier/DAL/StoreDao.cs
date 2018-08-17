using SuzukiSupplier.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuzukiSupplier.DAL
{
    class StoreDao
    {
        public void delete(String id)
        {

            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"Delete From Store where Id ='" + id + "'";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void insert(String Name, String Type)
        {

            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"Insert into Store(Name,Type) values ('" + Name + "','" + Type + "')";
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Update(String id, String name, String Type)
        {

            SqlConnection conn = Connection.getConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand(); //Update Expenses set Name='Tea and Biscuits' where Id='10';
            cmd.CommandText = @"update Store set Name = '" + name + "', Type = '" + Type + "' where id= '" + id + "'";
            cmd.ExecuteNonQuery();

            conn.Close();

        }
    }
}
