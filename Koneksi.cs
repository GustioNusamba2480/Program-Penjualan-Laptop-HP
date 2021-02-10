using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aplikasi_PenjualanPC
{
    class Koneksi
    {
        public SqlConnection Konektor()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=LAPTOP-I7GNGHIU;Initial Catalog=DB_PENJUALANPC;Integrated Security=True";
            return Conn;
        }
    }
}
