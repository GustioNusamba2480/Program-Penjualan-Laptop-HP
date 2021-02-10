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
    public partial class Barang : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        string nmBrg;
        string mrkBrg;
        int hrgBrg;
        string nmPlg;
        
        void IsiComboBoxKategoriBarang()
        {
            cmbKategoriBarang.Items.Add("Laptop");
            cmbKategoriBarang.Items.Add("Ponsel");
        }

        void TampilBarang()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Barang", connection);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Barang");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Barang";
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
        void TampilanBarangLaptop()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Barang where Nama_Barang = 'Laptop' ", connection);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Barang");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Barang";
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
        void TampilanBarangPonsel()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Barang where Nama_Barang = 'Ponsel' ", connection);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Barang");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Barang";
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

        void CariBarang()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Barang WHERE Kode_Barang LIKE '%" + txtCariBarang.Text 
                    + "%' or Merk_Barang LIKE '%" + txtCariBarang.Text + "%' ", connection);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Barang");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Barang";
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
        public Barang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                row.Cells["Kode_Barang"].Value.ToString();
                nmBrg = row.Cells["Nama_Barang"].Value.ToString();
                mrkBrg = row.Cells["Merk_Barang"].Value.ToString();
                hrgBrg = (int)row.Cells["Harga_Barang"].Value;
                row.Cells["Satuan_Barang"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void Barang_Load(object sender, EventArgs e)
        {
            TampilBarang();
            IsiComboBoxKategoriBarang();
            SqlConnection connection = Konn.Konektor();
            try
            {
                
                cmd = new SqlCommand("select Nama_Pelanggan from Pelanggan where IsOnline = 1"
                    , connection);
                connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    nmPlg = (dataReader["Nama_Pelanggan"].ToString());
                    
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        
        private void cmbKategoriBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (string.Equals(cmbKategoriBarang.Text, "Laptop"))
            {
                TampilanBarangLaptop();
            }
            else
            {
                TampilanBarangPonsel();
            }
        }

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            CariBarang();
        }

        private void btnBeliBarang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                
                cmd = new SqlCommand( 
                    "INSERT INTO Pembelian(Nama_Pelanggan, Nama_Barang, Merk_Barang, Harga_Barang) Values (@1, @2, @3, @4) ", connection);
                connection.Open();
                //SqlDataReader dataReader = cmd.ExecuteReader();
                //while (dataReader.Read())
                //{
                //    nmPlg = (dataReader["Nama_Pelanggan"].ToString());
                //}
                cmd.Parameters.AddWithValue("@1", nmPlg);
                cmd.Parameters.AddWithValue("@2", nmBrg);
                cmd.Parameters.AddWithValue("@3", mrkBrg);
                cmd.Parameters.AddWithValue("@4", hrgBrg);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Silahkan menuju ke tabel pembeliaan barang");
            }
            catch (Exception X)
            {
                    MessageBox.Show(X.ToString());
            }

        }



        private void btnKeluarBarang_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
