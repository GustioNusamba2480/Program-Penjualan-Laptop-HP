using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikasi_PenjualanPC
{
    public partial class FormLoginPelanggan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        int ID_plg;
        string nama_plg;
        public void LoginPelanggan()
        {

            SqlDataReader reader = null;
            SqlConnection connection = Konn.Konektor();
            {
                connection.Open();
                cmd = new SqlCommand("select * from Pelanggan where Username_Pelanggan = '" 
                    + txtUsernameLoginPelanggan.Text + "' and  Password_Pelanggan = '"
                    + mtxPasswordLoginPelanggan.Text + "'" + "update Pelanggan set IsOnline = 1 where Username_Pelanggan = '" 
                    + txtUsernameLoginPelanggan.Text + "'", connection);
                
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    
                    MenuUtama mnUtama = new MenuUtama();
                    MenuUtama.mnUtama.menuLoginAdmin.Enabled = true;
                    MenuUtama.mnUtama.menuLogoutAdmin.Enabled = false;
                    MenuUtama.mnUtama.menuLoginPelanggan.Enabled = false;
                    MenuUtama.mnUtama.menuLogoutPelanggan.Enabled = true;
                    MenuUtama.mnUtama.menuMaster.Enabled = false;
                    MenuUtama.mnUtama.menuLaporan.Enabled = false;
                    MenuUtama.mnUtama.menuData.Enabled = false;
                    MenuUtama.mnUtama.btnBarangPelanggan.Enabled = true;
                    MenuUtama.mnUtama.btnPembelianPelanggan.Enabled = true;
                    MenuUtama.mnUtama.btnNotaPembayaranPelanggan.Enabled = true;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username dan Password anda salah");
                }
            }
        }
        public FormLoginPelanggan()
        {
            InitializeComponent();
        }

        private void btnLoginPelanggan_Click(object sender, EventArgs e)
        {
            LoginPelanggan(); 
        }

        private void btnKeluarLoginPelanggan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLoginPelanggan_Load(object sender, EventArgs e)
        {
           
        }
    }
}
