using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration  ;


namespace SuzukiSupplier.DAL
{
    public static class Connection
    {
        public static SqlConnection getConnection()
        {
            string CS = ConfigurationManager.ConnectionStrings["API"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(CS);
            return conn;
        }
    }
}
