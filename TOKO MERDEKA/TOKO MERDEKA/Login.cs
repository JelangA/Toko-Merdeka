using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TOKO_MERDEKA
{
    public partial class Login : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader rd;

        Koneksi koneksi = new Koneksi();

        public Login()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlConnection conn = koneksi.getKon();
                conn.Open();
                cmd = new MySqlCommand("select * from tbl_user where username='" + bunifuTextBox1.Text + "' and password='" + bunifuTextBox2.Text + "'", conn);
                rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    if (rd[1].ToString() == "admin")
                    {
                        MessageBox.Show("admin");
                    }
                }
                rd.Close();
                conn.Clone();
            }
            catch (Exception x)
            {
                MessageBox.Show("gagal Terhubung = " + x.Message);
            }

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = "";
            bunifuTextBox2.Text = "";
        }
    }
}
