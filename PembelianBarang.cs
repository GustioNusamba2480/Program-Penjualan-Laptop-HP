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
    public partial class PembelianBarang : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        int kdPbl;
        string nmAdm;
        string kdBrg;
        public PembelianBarang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Pembelian" , connection);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {

                    txtNamaPelangganPembelianBarang.Text = (dataReader["Nama_Pelanggan"].ToString());
                    txtNamaBarangPembelianBarang.Text = (dataReader["Nama_Barang"].ToString());
                    txtMerkBarangPembelianBarang.Text = (dataReader["Merk_Barang"].ToString());
                    txtHargaBarangPembelianBarang.Text = (dataReader["Harga_Barang"].ToString());
                    txtJumlahItemPembelianBarang.Text = (dataReader["Jumlah_Item"].ToString());
                    txtTotalHargaPembelianBarang.Text = (dataReader["Total_Harga"].ToString());
                    kdPbl = ((int)dataReader["Kode_Pembelian"]);
                    
                }
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

        private void LoadNamaAdmin()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("select Nama_Admin from Pegawai", connection);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    nmAdm = (dataReader["Nama_Admin"].ToString());
                }
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
        private void PembelianBarang_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadNamaAdmin();
        }
 
        private void btnInputPembelianBarang_Click(object sender, EventArgs e)
        {
            if (txtJumlahItemPembelianBarang.Text.Trim() == "")
            {
                MessageBox.Show("Isikan jumlah item terelebih dahulu");
            }
            else
            {

                SqlConnection connection = Konn.Konektor();
                try
                {
                    cmd = new SqlCommand("UPDATE Pembelian SET Jumlah_Item = @1,  Total_Harga = " +
                        "(select Harga_Barang * Jumlah_Item from Pembelian where Kode_Pembelian = @2) where Kode_Pembelian = @2", connection);
                    //cmd = new SqlCommand("UPDATE Pembelian SET Total_Harga = " +
                    //    "(select Harga_Barang * Jumlah_Item from Pembelian where Kode_Pembelian = @2), Jumlah_Item = @1 where Kode_Pembelian = @2", connection);
                    connection.Open();
                    MessageBox.Show("Data anda berhasil masuk ke pembelian");
                    cmd.Parameters.AddWithValue("@1", txtJumlahItemPembelianBarang.Text);
                    cmd.Parameters.AddWithValue("@2", kdPbl);
                    

                    cmd.ExecuteNonQuery();
                    LoadData();
                    
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void btnBeliPembelianBarang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Konn.Konektor();
            connection.Open();
            try
            {

                cmd = new SqlCommand("INSERT INTO Nota(Nama_Admin, Nama_Pelanggan, Nama_Barang, " +
                    "Merk_Barang, Harga_Barang, Jumlah_Item, Total_Harga) Values (@1, @2, @3, @4, @5, @6, @7)", 
                    connection);
                
                
                cmd.Parameters.AddWithValue("@1", nmAdm);
                cmd.Parameters.AddWithValue("@2", txtNamaPelangganPembelianBarang.Text);
                cmd.Parameters.AddWithValue("@3", txtNamaBarangPembelianBarang.Text);
                cmd.Parameters.AddWithValue("@4", txtMerkBarangPembelianBarang.Text);
                cmd.Parameters.AddWithValue("@5", txtHargaBarangPembelianBarang.Text);
                cmd.Parameters.AddWithValue("@6", txtJumlahItemPembelianBarang.Text);
                cmd.Parameters.AddWithValue("@7", txtTotalHargaPembelianBarang.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Silahkan menuju ke nota pembayaran");
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }

            try
            {
                
                cmd = new SqlCommand("Update Barang set Stok_Barang = Stok_Barang - @1 where Merk_Barang = @2", connection);
                cmd.Parameters.AddWithValue("@1", txtJumlahItemPembelianBarang.Text);
                cmd.Parameters.AddWithValue("@2", txtMerkBarangPembelianBarang.Text);
                //connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void btnKeluarPembelianBarang_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
