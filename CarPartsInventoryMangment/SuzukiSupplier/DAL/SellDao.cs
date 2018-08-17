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
    public class SellDao
    {

        public float getCostPrice(string PartNo)
        {
            float CostPrice = 0.0F;

            SqlConnection Conn = Connection.getConnection();
            String query = "Select CostPrice FROM Parts WHERE PartNo = @PartNo";
            using (Conn)
            {
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PartNo", PartNo);

                Conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    CostPrice = float.Parse(sdr["CostPrice"].ToString());
                }

            }

            return CostPrice;
        }


        public bool Available(string PartNo, int CheckQty)
        {
            int Quantity = 0;

            SqlConnection Conn = Connection.getConnection();
            String query = "Select Qty FROM Inventory WHERE PartNo = @PartNo and StoreId = (Select StoreId FROM Store WHERE Name = 'Shop')";
            using (Conn)
            {
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@PartNo", PartNo);

                Conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Quantity = int.Parse(sdr["Qty"].ToString());

                }
            }
            return (Quantity >= CheckQty);
        }


        public void GetPartDetails(string PartNo, Label PartName, Label Quantity, Label Model, Label Car, Label CostPrice)
        {
            SqlConnection Conn = Connection.getConnection();
            String query = "SELECT P.PartNo, P.Name, P.Model, P.Car, P.CostPrice, I.Qty FROM Parts P INNER JOIN Inventory I On P.PartNo = I.PartNo  WHERE P.PartNo=@PartNo";
            using (Conn)
            {
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@PartNo", PartNo);

                Conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    PartName.Text = sdr[1].ToString();
                    Quantity.Text = sdr[5].ToString();
                    Model.Text = sdr[2].ToString();
                    Car.Text = sdr[3].ToString();
                    CostPrice.Text = sdr[4].ToString();

                }
            }
        }


        public void DecreaseQuanity(string PartNo, int Qty)
        {
            SqlConnection Conn = Connection.getConnection();
            String query = "UPDATE Inventory SET Qty = (Qty-@Qty) WHERE PartNo = @PartNo and StoreId = (Select StoreId FROM Store WHERE Name = 'Shop')";
            using (Conn)
            {
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@PartNo", PartNo);

                Conn.Open();
                cmd.ExecuteScalar();
            }
        }


    }
}
