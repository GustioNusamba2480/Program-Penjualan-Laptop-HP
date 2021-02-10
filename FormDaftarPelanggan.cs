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
    public partial class FormDaftarPelanggan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        void BersihPendaftaran()
        {
            txtDaftarNamaPelanggan.Text = "";
            txtDaftarUsernamePelanggan.Text = "";
            txtDaftarEmailPelanggan.Text = "";
            mtxDaftarPasswordPelanggan.Text = "";
        }
        public FormDaftarPelanggan()
        {
            InitializeComponent();
        }

        private void btnDaftarPelanggan_Click(object sender, EventArgs e)
        {
            if (txtDaftarNamaPelanggan.Text.Trim() == "" || txtDaftarUsernamePelanggan.Text.Trim() == "" ||
                txtDaftarEmailPelanggan.Text.Trim() == "" || mtxDaftarPasswordPelanggan.Text.Trim() == "")
            {
                MessageBox.Show("Isikan data diri anda terlebih dahulu");
            }
            else
            {
                SqlConnection connection = Konn.Konektor();
                try
                {
                    cmd = new SqlCommand("INSERT INTO Pelanggan" +
                        "(Nama_Pelanggan, Username_Pelanggan, Email_Pelanggan, Password_Pelanggan) VALUES" +
                        "('" + txtDaftarNamaPelanggan.Text + "','" + txtDaftarUsernamePelanggan.Text + "'," +
                        "'" + txtDaftarEmailPelanggan.Text + "','" + mtxDaftarPasswordPelanggan.Text + "')", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Anda berhasil terdaftar");

                    BersihPendaftaran();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void btnKeluardiDaftar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDaftarPelanggan_Load(object sender, EventArgs e)
        {
           
        }
    }
}
