
namespace Aplikasi_PenjualanPC
{
    partial class LaporanTransaksi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLaporanTransaksi = new System.Windows.Forms.Label();
            this.btnKeluarLaporanTransaksi = new System.Windows.Forms.Button();
            this.pctLaporanTransaksi = new System.Windows.Forms.PictureBox();
            this.pctCariLaporanTransaksi = new System.Windows.Forms.PictureBox();
            this.txtCariLaporanTransaksi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNamaAdminLT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLaporanTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCariLaporanTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(949, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.lblLaporanTransaksi);
            this.groupBox1.Controls.Add(this.btnKeluarLaporanTransaksi);
            this.groupBox1.Controls.Add(this.pctLaporanTransaksi);
            this.groupBox1.Location = new System.Drawing.Point(-5, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblLaporanTransaksi
            // 
            this.lblLaporanTransaksi.AutoSize = true;
            this.lblLaporanTransaksi.Font = new System.Drawing.Font("Roboto Bk", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaporanTransaksi.ForeColor = System.Drawing.Color.White;
            this.lblLaporanTransaksi.Location = new System.Drawing.Point(319, 57);
            this.lblLaporanTransaksi.Name = "lblLaporanTransaksi";
            this.lblLaporanTransaksi.Size = new System.Drawing.Size(428, 48);
            this.lblLaporanTransaksi.TabIndex = 2;
            this.lblLaporanTransaksi.Text = "LAPORAN TRANSAKSI";
            // 
            // btnKeluarLaporanTransaksi
            // 
            this.btnKeluarLaporanTransaksi.BackColor = System.Drawing.Color.IndianRed;
            this.btnKeluarLaporanTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluarLaporanTransaksi.Image = global::Aplikasi_PenjualanPC.Properties.Resources.cancel__1_;
            this.btnKeluarLaporanTransaksi.Location = new System.Drawing.Point(916, 17);
            this.btnKeluarLaporanTransaksi.Name = "btnKeluarLaporanTransaksi";
            this.btnKeluarLaporanTransaksi.Size = new System.Drawing.Size(50, 45);
            this.btnKeluarLaporanTransaksi.TabIndex = 1;
            this.btnKeluarLaporanTransaksi.UseVisualStyleBackColor = false;
            this.btnKeluarLaporanTransaksi.Click += new System.EventHandler(this.btnKeluarLaporanTransaksi_Click);
            // 
            // pctLaporanTransaksi
            // 
            this.pctLaporanTransaksi.Image = global::Aplikasi_PenjualanPC.Properties.Resources.laptop;
            this.pctLaporanTransaksi.Location = new System.Drawing.Point(49, 21);
            this.pctLaporanTransaksi.Name = "pctLaporanTransaksi";
            this.pctLaporanTransaksi.Size = new System.Drawing.Size(118, 120);
            this.pctLaporanTransaksi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLaporanTransaksi.TabIndex = 0;
            this.pctLaporanTransaksi.TabStop = false;
            // 
            // pctCariLaporanTransaksi
            // 
            this.pctCariLaporanTransaksi.Image = global::Aplikasi_PenjualanPC.Properties.Resources.search_engine;
            this.pctCariLaporanTransaksi.Location = new System.Drawing.Point(12, 170);
            this.pctCariLaporanTransaksi.Name = "pctCariLaporanTransaksi";
            this.pctCariLaporanTransaksi.Size = new System.Drawing.Size(35, 32);
            this.pctCariLaporanTransaksi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCariLaporanTransaksi.TabIndex = 2;
            this.pctCariLaporanTransaksi.TabStop = false;
            // 
            // txtCariLaporanTransaksi
            // 
            this.txtCariLaporanTransaksi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariLaporanTransaksi.Location = new System.Drawing.Point(66, 170);
            this.txtCariLaporanTransaksi.Name = "txtCariLaporanTransaksi";
            this.txtCariLaporanTransaksi.Size = new System.Drawing.Size(415, 32);
            this.txtCariLaporanTransaksi.TabIndex = 3;
            this.txtCariLaporanTransaksi.TextChanged += new System.EventHandler(this.txtCariLaporanTransaksi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Laporan Transaksi Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(721, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin";
            // 
            // lblNamaAdminLT
            // 
            this.lblNamaAdminLT.AutoSize = true;
            this.lblNamaAdminLT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaAdminLT.Location = new System.Drawing.Point(817, 173);
            this.lblNamaAdminLT.Name = "lblNamaAdminLT";
            this.lblNamaAdminLT.Size = new System.Drawing.Size(0, 24);
            this.lblNamaAdminLT.TabIndex = 6;
            // 
            // LaporanTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 725);
            this.Controls.Add(this.lblNamaAdminLT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCariLaporanTransaksi);
            this.Controls.Add(this.pctCariLaporanTransaksi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaporanTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanTransaksi";
            this.Load += new System.EventHandler(this.LaporanTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLaporanTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCariLaporanTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctLaporanTransaksi;
        private System.Windows.Forms.Button btnKeluarLaporanTransaksi;
        private System.Windows.Forms.Label lblLaporanTransaksi;
        private System.Windows.Forms.PictureBox pctCariLaporanTransaksi;
        private System.Windows.Forms.TextBox txtCariLaporanTransaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNamaAdminLT;
    }
}