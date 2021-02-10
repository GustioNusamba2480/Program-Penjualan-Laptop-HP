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
    public partial class DataPelanggan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        void TampilanDataPelanggan()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Pelanggan", connection);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Pelanggan");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Pelanggan";
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

        void CariDataPelanggan()
        {
            SqlConnection connection = Konn.Konektor();
            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Pelanggan WHERE Nama_Pelanggan LIKE '%" + txtCariDataPelanggan.Text 
                    + "%' or Username_Pelanggan LIKE '%" + txtCariDataPelanggan.Text + "%' ", connection);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Pelanggan");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Pelanggan";
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
        public DataPelanggan()
        {
            InitializeComponent();
        }

        private void btnKeluarDataPelanggan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                row.Cells["ID_Pelanggan"].Value.ToString();
                row.Cells["Nama_Pelanggan"].Value.ToString();
                row.Cells["Username_Pelanggan"].Value.ToString();
                row.Cells["Email_Pelanggan"].Value.ToString();
                row.Cells["Password_Pelanggan"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void DataPelanggan_Load(object sender, EventArgs e)
        {
            TampilanDataPelanggan();
        }

        private void txtCariDataPelanggan_TextChanged(object sender, EventArgs e)
        {
            CariDataPelanggan();
        }
    }
}
