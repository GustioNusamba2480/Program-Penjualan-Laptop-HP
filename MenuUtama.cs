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
    public partial class MenuUtama : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        public static MenuUtama mnUtama;
        MenuStrip mnStrip;
        FormLoginAdmin frmLoginAdmin;
        FormLoginPelanggan frmLoginPelanggan;
        FormDaftarPelanggan frmDaftarPelanggan;
        InputBarang inputBarang;
        DataPelanggan dtPelanggan;
        Barang brg;
        PembelianBarang pblBarang;
        NotaPembelian ntPembelian;
        LaporanTransaksi laporanTransaksi;

        void inputBarang_formClosed(object sender, FormClosedEventArgs e)
        {
            inputBarang = null;
        }
        void frmLoginAdmin_formClosed(object sender, FormClosedEventArgs e)
        {
            frmLoginAdmin = null;
        }

        void frmLoginPelanggan_formClosed(object sender, FormClosedEventArgs e)
        {
            frmLoginPelanggan = null;
        }

        void dtPelanggan_formClosed(object sender, FormClosedEventArgs e)
        {
            dtPelanggan = null;
        }

        void brg_formClosed(object sender, FormClosedEventArgs e)
        {
            brg = null;
        }
        void frmDaftarPelanggan_formClosed(object sender, FormClosedEventArgs e)
        {
            frmDaftarPelanggan = null;
        }

        void pblBarang_formClosed(object sender, FormClosedEventArgs e)
        {
            pblBarang = null;
        }

        void ntPembelian_formClosed(object sender, FormClosedEventArgs e)
        {
            ntPembelian = null;
        }
        void laporanTransaksi_formClosed(object sender, FormClosedEventArgs e)
        {
            laporanTransaksi = null;
        }

        public void TerkunciSemuanya()
        {
            menuLoginAdmin.Enabled = true;
            menuLogoutAdmin.Enabled = false;
            menuLoginPelanggan.Enabled = true;
            menuLogoutPelanggan.Enabled = false;
            menuMaster.Enabled = false;
            menuLaporan.Enabled = false;
            menuData.Enabled = false;
            btnBarangPelanggan.Enabled = false;
            btnPembelianPelanggan.Enabled = false;
            btnNotaPembayaranPelanggan.Enabled = false;
            mnUtama = this;
        }
        public MenuUtama()
        {
            InitializeComponent();

        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            TerkunciSemuanya();
           

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin keluar dari aplikasi ini", 
                "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                System.Windows.Forms.Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void menuLoginAdmin_Click(object sender, EventArgs e)
        {
            if (frmLoginAdmin == null)
            {
                frmLoginAdmin = new FormLoginAdmin();
                frmLoginAdmin.FormClosed += new FormClosedEventHandler(frmLoginAdmin_formClosed);
                frmLoginAdmin.ShowDialog();
                //TerkunciMenuPelanggan();
            }
            else
            {
                frmLoginAdmin.Activate();
                
            }
        }

        private void menuLoginPelanggan_Click(object sender, EventArgs e)
        {
            if (frmLoginPelanggan == null)
            {
                frmLoginPelanggan = new FormLoginPelanggan();
                frmLoginPelanggan.FormClosed += new FormClosedEventHandler(frmLoginPelanggan_formClosed);
                frmLoginPelanggan.ShowDialog();
                //TerkunciMenuAdmin();
            }
            else
            {
                frmLoginPelanggan.Activate();
                
            }
        }

        private void menuLogoutAdmin_Click(object sender, EventArgs e)
        {
            TerkunciSemuanya();
        }

        private void menuLogoutPelanggan_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Konn.Konektor();
            connection.Open();
            cmd = new SqlCommand("update Pelanggan set IsOnline = 0 where IsOnline = 1 ", connection);
               
            cmd.ExecuteNonQuery();
            TerkunciSemuanya();
        }

        private void menuInputBarang_Click(object sender, EventArgs e)
        {
            if (inputBarang == null)
            {
                inputBarang = new InputBarang();
                inputBarang.FormClosed += new FormClosedEventHandler(inputBarang_formClosed);
                inputBarang.ShowDialog();
                
            }
            else
            {
                inputBarang.Activate();

            }
        }

        private void menuDataPelanggan_Click(object sender, EventArgs e)
        {
            if (dtPelanggan == null)
            {
                dtPelanggan = new DataPelanggan();
                dtPelanggan.FormClosed += new FormClosedEventHandler(dtPelanggan_formClosed);
                dtPelanggan.ShowDialog();

            }
            else
            {
                dtPelanggan.Activate();

            }
        }

        private void btnBarangPelanggan_Click(object sender, EventArgs e)
        {
            if (brg == null)
            {
                brg = new Barang();
                brg.FormClosed += new FormClosedEventHandler(brg_formClosed);
                brg.ShowDialog();

            }
            else
            {
                brg.Activate();

            }
        }

        private void menuDaftarPelanggan_Click(object sender, EventArgs e)
        {
            if (frmDaftarPelanggan == null)
            {
                frmDaftarPelanggan = new FormDaftarPelanggan();
                frmDaftarPelanggan.FormClosed += new FormClosedEventHandler(frmDaftarPelanggan_formClosed);
                frmDaftarPelanggan.ShowDialog();

            }
            else
            {
                frmDaftarPelanggan.Activate();

            }
        }

        private void btnPembelianPelanggan_Click(object sender, EventArgs e)
        {
            if (pblBarang == null)
            {
                pblBarang = new PembelianBarang();
                pblBarang.FormClosed += new FormClosedEventHandler(pblBarang_formClosed);
                pblBarang.ShowDialog();

            }
            else
            {
                pblBarang.Activate();

            }
        }

        private void btnNotaPembayaranPelanggan_Click(object sender, EventArgs e)
        {
            if (ntPembelian == null)
            {
                ntPembelian = new NotaPembelian();
                ntPembelian.FormClosed += new FormClosedEventHandler(ntPembelian_formClosed);
                ntPembelian.ShowDialog();

            }
            else
            {
                ntPembelian.Activate();

            }
        }

        private void menuLaporanTransaksi_Click(object sender, EventArgs e)
        {
            if (laporanTransaksi == null)
            {
                laporanTransaksi = new LaporanTransaksi();
                laporanTransaksi.FormClosed += new FormClosedEventHandler(laporanTransaksi_formClosed);
                laporanTransaksi.ShowDialog();

            }
            else
            {
                laporanTransaksi.Activate();

            }
        }
    }
}
