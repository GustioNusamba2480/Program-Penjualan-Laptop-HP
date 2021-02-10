
namespace Aplikasi_PenjualanPC
{
    partial class Barang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDaftarBarangBeli = new System.Windows.Forms.Label();
            this.pctBeliBarang = new System.Windows.Forms.PictureBox();
            this.btnKeluarBarang = new System.Windows.Forms.Button();
            this.cmbKategoriBarang = new System.Windows.Forms.ComboBox();
            this.txtCariBarang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBeliBarang = new System.Windows.Forms.Button();
            this.lblKategoriBarang = new System.Windows.Forms.Label();
            this.pctCariBarang = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBeliBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCariBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.lblDaftarBarangBeli);
            this.groupBox1.Controls.Add(this.pctBeliBarang);
            this.groupBox1.Controls.Add(this.btnKeluarBarang);
            this.groupBox1.Location = new System.Drawing.Point(-5, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblDaftarBarangBeli
            // 
            this.lblDaftarBarangBeli.AutoSize = true;
            this.lblDaftarBarangBeli.Font = new System.Drawing.Font("Roboto Bk", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaftarBarangBeli.ForeColor = System.Drawing.Color.White;
            this.lblDaftarBarangBeli.Location = new System.Drawing.Point(355, 58);
            this.lblDaftarBarangBeli.Name = "lblDaftarBarangBeli";
            this.lblDaftarBarangBeli.Size = new System.Drawing.Size(336, 48);
            this.lblDaftarBarangBeli.TabIndex = 1;
            this.lblDaftarBarangBeli.Text = "DAFTAR BARANG";
            // 
            // pctBeliBarang
            // 
            this.pctBeliBarang.Image = global::Aplikasi_PenjualanPC.Properties.Resources.laptop;
            this.pctBeliBarang.Location = new System.Drawing.Point(49, 21);
            this.pctBeliBarang.Name = "pctBeliBarang";
            this.pctBeliBarang.Size = new System.Drawing.Size(118, 120);
            this.pctBeliBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBeliBarang.TabIndex = 0;
            this.pctBeliBarang.TabStop = false;
            // 
            // btnKeluarBarang
            // 
            this.btnKeluarBarang.BackColor = System.Drawing.Color.IndianRed;
            this.btnKeluarBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluarBarang.Image = global::Aplikasi_PenjualanPC.Properties.Resources.cancel__1_;
            this.btnKeluarBarang.Location = new System.Drawing.Point(875, 17);
            this.btnKeluarBarang.Name = "btnKeluarBarang";
            this.btnKeluarBarang.Size = new System.Drawing.Size(50, 45);
            this.btnKeluarBarang.TabIndex = 0;
            this.btnKeluarBarang.UseVisualStyleBackColor = false;
            this.btnKeluarBarang.Click += new System.EventHandler(this.btnKeluarBarang_Click);
            // 
            // cmbKategoriBarang
            // 
            this.cmbKategoriBarang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategoriBarang.FormattingEnabled = true;
            this.cmbKategoriBarang.Location = new System.Drawing.Point(115, 166);
            this.cmbKategoriBarang.Name = "cmbKategoriBarang";
            this.cmbKategoriBarang.Size = new System.Drawing.Size(243, 32);
            this.cmbKategoriBarang.TabIndex = 2;
            this.cmbKategoriBarang.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriBarang_SelectedIndexChanged);
            // 
            // txtCariBarang
            // 
            this.txtCariBarang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariBarang.Location = new System.Drawing.Point(115, 213);
            this.txtCariBarang.Name = "txtCariBarang";
            this.txtCariBarang.Size = new System.Drawing.Size(396, 32);
            this.txtCariBarang.TabIndex = 3;
            this.txtCariBarang.TextChanged += new System.EventHandler(this.txtCariBarang_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(908, 401);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnBeliBarang
            // 
            this.btnBeliBarang.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBeliBarang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeliBarang.ForeColor = System.Drawing.Color.White;
            this.btnBeliBarang.Location = new System.Drawing.Point(811, 228);
            this.btnBeliBarang.Name = "btnBeliBarang";
            this.btnBeliBarang.Size = new System.Drawing.Size(109, 53);
            this.btnBeliBarang.TabIndex = 5;
            this.btnBeliBarang.Text = "Beli";
            this.btnBeliBarang.UseVisualStyleBackColor = false;
            this.btnBeliBarang.Click += new System.EventHandler(this.btnBeliBarang_Click);
            // 
            // lblKategoriBarang
            // 
            this.lblKategoriBarang.AutoSize = true;
            this.lblKategoriBarang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategoriBarang.Location = new System.Drawing.Point(13, 166);
            this.lblKategoriBarang.Name = "lblKategoriBarang";
            this.lblKategoriBarang.Size = new System.Drawing.Size(80, 24);
            this.lblKategoriBarang.TabIndex = 6;
            this.lblKategoriBarang.Text = "Kategori";
            // 
            // pctCariBarang
            // 
            this.pctCariBarang.Image = global::Aplikasi_PenjualanPC.Properties.Resources.search_engine;
            this.pctCariBarang.Location = new System.Drawing.Point(17, 213);
            this.pctCariBarang.Name = "pctCariBarang";
            this.pctCariBarang.Size = new System.Drawing.Size(35, 32);
            this.pctCariBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCariBarang.TabIndex = 7;
            this.pctCariBarang.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Daftar Barang";
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctCariBarang);
            this.Controls.Add(this.lblKategoriBarang);
            this.Controls.Add(this.btnBeliBarang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCariBarang);
            this.Controls.Add(this.cmbKategoriBarang);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Barang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barang";
            this.Load += new System.EventHandler(this.Barang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBeliBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCariBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeluarBarang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctBeliBarang;
        private System.Windows.Forms.Label lblDaftarBarangBeli;
        private System.Windows.Forms.ComboBox cmbKategoriBarang;
        private System.Windows.Forms.TextBox txtCariBarang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBeliBarang;
        private System.Windows.Forms.Label lblKategoriBarang;
        private System.Windows.Forms.PictureBox pctCariBarang;
        private System.Windows.Forms.Label label1;
    }
}