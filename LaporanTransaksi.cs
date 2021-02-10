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
    public partial class LaporanTransaksi : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        public LaporanTransaksi()
        {
            InitializeComponent();
        }

        void TampilanLaporanTransaksi()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT Kode_Nota, Nama_Pelanggan, Nama_Barang, " +
                    "Merk_Barang, Harga_Barang, Jumlah_Item, Total_Harga FROM Nota", connection);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Nota");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Nota";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception C)
            {
                MessageBox.Show(C.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        void CariLaporanTransaksi()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Nota WHERE Kode_Nota LIKE '%" + txtCariLaporanTransaksi.Text 
                    + "%' or Nama_Pelanggan LIKE '%" + txtCariLaporanTransaksi.Text + "%' ", connection);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Nota");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Nota";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception C)
            {
                MessageBox.Show(C.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void LaporanTransaksi_Load(object sender, EventArgs e)
        {
            TampilanLaporanTransaksi();
            SqlConnection connection = Konn.Konektor();
            try
            {

                cmd = new SqlCommand("Select Nama_Admin from Pegawai", connection);
                connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    lblNamaAdminLT.Text = (dataReader["Nama_Admin"].ToString());
                    
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                row.Cells["Kode_Nota"].Value.ToString();
                row.Cells["Nama_Pelanggan"].Value.ToString();
                row.Cells["Nama_Barang"].Value.ToString();
                row.Cells["Merk_Barang"].Value.ToString();
                row.Cells["Harga_Barang"].Value.ToString();
                row.Cells["Jumlah_Item"].Value.ToString();
                row.Cells["Total_Harga"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void txtCariLaporanTransaksi_TextChanged(object sender, EventArgs e)
        {
            CariLaporanTransaksi();
        }

        private void btnKeluarLaporanTransaksi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
