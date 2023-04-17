using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TOKO_MERDEKA
{
    internal class Koneksi
    {
        public MySqlConnection getKon()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;username=root;password=;database=toko_merdeka;";
            return conn;
        }
    }
}
