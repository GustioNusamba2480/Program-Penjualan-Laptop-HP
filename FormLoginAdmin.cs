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

    public partial class FormLoginAdmin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        public void LoginAdmin()
        {
            SqlDataReader reader = null;
            SqlConnection connection = Konn.Konektor();
            {
                connection.Open();
                cmd = new SqlCommand("select * from Pegawai where Username_Admin ='" 
                    + txtUsernameLoginAdmin.Text + "' and  Password_Admin = '"
                    + mtxPasswordLoginAdmin.Text + "'", connection);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MenuUtama mnUtama = new MenuUtama();
                    //mnUtama.Show();

                    //mnUtama.TerkunciMenuPelanggan();

                    MenuUtama.mnUtama.menuLoginAdmin.Enabled = false;
                    MenuUtama.mnUtama.menuLogoutAdmin.Enabled = true;
                    MenuUtama.mnUtama.menuLoginPelanggan.Enabled = true;
                    MenuUtama.mnUtama.menuLogoutPelanggan.Enabled = false;
                    MenuUtama.mnUtama.menuMaster.Enabled = true;
                    MenuUtama.mnUtama.menuLaporan.Enabled = true;
                    MenuUtama.mnUtama.menuData.Enabled = true;
                    MenuUtama.mnUtama.btnBarangPelanggan.Enabled = false;
                    MenuUtama.mnUtama.btnPembelianPelanggan.Enabled = false;
                    MenuUtama.mnUtama.btnNotaPembayaranPelanggan.Enabled = false;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username dan Password anda salah");
                }
            }
        }

        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin();
        }

        

        private void btnKeluarLoginAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
