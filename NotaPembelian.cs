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
    public partial class NotaPembelian : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        
        public NotaPembelian()
        {
            InitializeComponent();
        }
        private void NotaPembelian_Load(object sender, EventArgs e)
        {
            SqlConnection connection = Konn.Konektor();
            try
            {

                cmd = new SqlCommand("Select Nama_Admin, Nama_Pelanggan, Nama_Barang, Merk_Barang, Harga_Barang, " +
                    "Jumlah_Item, Total_Harga from Nota"
                    , connection);
                connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    lblNamaAdminNP.Text = (dataReader["Nama_Admin"].ToString());
                    lblNamaPelangganNP.Text = (dataReader["Nama_Pelanggan"].ToString());
                    lblNamaBarangNP.Text = (dataReader["Nama_Barang"].ToString());
                    lblMerkBarangNP.Text = (dataReader["Merk_Barang"].ToString());
                    lblHargaBarangNP.Text = (dataReader["Harga_Barang"].ToString());
                    lblJumlahItemNP.Text = (dataReader["Jumlah_Item"].ToString());
                    lblTotalHargaNP.Text = (dataReader["Total_Harga"].ToString());
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
