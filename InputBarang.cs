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
    public partial class InputBarang : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        void BersihInputBarang()
        {
            txtKodeBarangIB.Text = "";
            txtNamaBarangIB.Text = "";
            txtMerkBarangIB.Text = "";
            txtStokBarangIB.Text = "";
            txtHargaBarangIB.Text = "";
            cmbSatuanBarangIB.Text = "";
        }

        void TampilanInputBarang()
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

        void IsiComboBoxInputBarang()
        {
            cmbSatuanBarangIB.Items.Add("Unit");
            cmbSatuanBarangIB.Items.Add("PCS");
            cmbSatuanBarangIB.Items.Add("Botol");
            cmbSatuanBarangIB.Items.Add("Ikat");
            cmbSatuanBarangIB.Items.Add("Buah");
        }

        void CariInputBarang()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Barang WHERE Kode_Barang LIKE '%" + txtPencarianInputBarang.Text 
                    + "%' or Merk_Barang LIKE '%" + txtPencarianInputBarang.Text + "%' ", connection);
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
        public InputBarang()
        {
            InitializeComponent();
        }

        private void btnKeluarInputBarang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputBarang_Load(object sender, EventArgs e)
        {
            TampilanInputBarang();
            BersihInputBarang();
            IsiComboBoxInputBarang();
        }

        private void btnInsertIB_Click(object sender, EventArgs e)
        {
            if (txtKodeBarangIB.Text.Trim() == "" || txtNamaBarangIB.Text.Trim() == "" || txtMerkBarangIB.Text.Trim() == "" 
                || txtStokBarangIB.Text.Trim() == "" || txtHargaBarangIB.Text.Trim() == "" || cmbSatuanBarangIB.Text.Trim() == "")
            {
                MessageBox.Show("Data barang belum lengkap");
            }
            else
            {
                SqlConnection connection = Konn.Konektor();
                try
                {
                    cmd = new SqlCommand("INSERT INTO Barang VALUES('" + txtKodeBarangIB.Text + "','" + txtNamaBarangIB.Text + "','" + txtMerkBarangIB.Text + "','" + txtStokBarangIB.Text + "' ,'" + txtHargaBarangIB.Text + "','" + cmbSatuanBarangIB.Text + "')", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Barang berhasil ditambahkan");
                    TampilanInputBarang();
                    BersihInputBarang();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtKodeBarangIB.Text = row.Cells["Kode_Barang"].Value.ToString();
                txtNamaBarangIB.Text = row.Cells["Nama_Barang"].Value.ToString();
                txtMerkBarangIB.Text = row.Cells["Merk_Barang"].Value.ToString();
                txtStokBarangIB.Text = row.Cells["Stok_Barang"].Value.ToString();
                txtHargaBarangIB.Text = row.Cells["Harga_Barang"].Value.ToString();
                cmbSatuanBarangIB.Text = row.Cells["Satuan_Barang"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void btnUpdateIB_Click(object sender, EventArgs e)
        {
            if (txtKodeBarangIB.Text.Trim() == "" || txtNamaBarangIB.Text.Trim() == "" || txtMerkBarangIB.Text.Trim() == "" || txtStokBarangIB.Text.Trim() == "" || txtHargaBarangIB.Text.Trim() == "" || cmbSatuanBarangIB.Text.Trim() == "")
            {
                MessageBox.Show("Data barang belum lengkap");
            }
            else
            {
                SqlConnection connection = Konn.Konektor();
                try
                {
                    cmd = new SqlCommand("UPDATE Barang SET Nama_Barang = '" + txtNamaBarangIB.Text + "', Merk_Barang = '" + txtMerkBarangIB.Text + "', Harga_Barang = '" + txtStokBarangIB.Text + "', Stok_Barang = '" + txtHargaBarangIB.Text + "', Satuan_Barang = '" + cmbSatuanBarangIB.Text + "' WHERE Kode_Barang = '" + txtKodeBarangIB.Text + "'", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data barang berhasil diupdate");
                    TampilanInputBarang();
                    BersihInputBarang();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void btnDeleteIB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin akan menghapus merk barang : " + txtKodeBarangIB.Text + " ?", "Konfirmasi", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection connection = Konn.Konektor();

                {
                    cmd = new SqlCommand("DELETE FROM Barang WHERE Kode_Barang = '" + txtKodeBarangIB.Text + "'", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data barang berhasil dihapus");
                    TampilanInputBarang();
                    BersihInputBarang();
                }
            }
        }

        private void btnRefreshIB_Click(object sender, EventArgs e)
        {
            BersihInputBarang();
        }

        private void txtPencarianInputBarang_TextChanged(object sender, EventArgs e)
        {
            CariInputBarang();
        }
    }
}
