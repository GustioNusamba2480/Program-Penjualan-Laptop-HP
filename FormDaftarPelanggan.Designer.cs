
namespace Aplikasi_PenjualanPC
{
    partial class FormDaftarPelanggan
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
            this.grpSebelumLogin = new System.Windows.Forms.GroupBox();
            this.btnKeluardiDaftar = new System.Windows.Forms.Button();
            this.lblJuduldiDaftar = new System.Windows.Forms.Label();
            this.pctDaftarPelanggan = new System.Windows.Forms.PictureBox();
            this.lblNamaDaftarPelanggan = new System.Windows.Forms.Label();
            this.lblUsernameDaftarPelanggan = new System.Windows.Forms.Label();
            this.lblEmailDaftarPelanggan = new System.Windows.Forms.Label();
            this.lblPasswordDaftarPelanggan = new System.Windows.Forms.Label();
            this.txtDaftarNamaPelanggan = new System.Windows.Forms.TextBox();
            this.txtDaftarUsernamePelanggan = new System.Windows.Forms.TextBox();
            this.txtDaftarEmailPelanggan = new System.Windows.Forms.TextBox();
            this.mtxDaftarPasswordPelanggan = new System.Windows.Forms.MaskedTextBox();
            this.btnDaftarPelanggan = new System.Windows.Forms.Button();
            this.lblSilahkanLogin = new System.Windows.Forms.Label();
            this.grpSebelumLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDaftarPelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSebelumLogin
            // 
            this.grpSebelumLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpSebelumLogin.Controls.Add(this.btnKeluardiDaftar);
            this.grpSebelumLogin.Controls.Add(this.lblJuduldiDaftar);
            this.grpSebelumLogin.Controls.Add(this.pctDaftarPelanggan);
            this.grpSebelumLogin.Location = new System.Drawing.Point(-5, -11);
            this.grpSebelumLogin.Name = "grpSebelumLogin";
            this.grpSebelumLogin.Size = new System.Drawing.Size(657, 258);
            this.grpSebelumLogin.TabIndex = 0;
            this.grpSebelumLogin.TabStop = false;
            // 
            // btnKeluardiDaftar
            // 
            this.btnKeluardiDaftar.BackColor = System.Drawing.Color.IndianRed;
            this.btnKeluardiDaftar.ForeColor = System.Drawing.Color.Transparent;
            this.btnKeluardiDaftar.Image = global::Aplikasi_PenjualanPC.Properties.Resources.cancel__1_;
            this.btnKeluardiDaftar.Location = new System.Drawing.Point(584, 34);
            this.btnKeluardiDaftar.Name = "btnKeluardiDaftar";
            this.btnKeluardiDaftar.Size = new System.Drawing.Size(56, 51);
            this.btnKeluardiDaftar.TabIndex = 10;
            this.btnKeluardiDaftar.UseVisualStyleBackColor = false;
            this.btnKeluardiDaftar.Click += new System.EventHandler(this.btnKeluardiDaftar_Click);
            // 
            // lblJuduldiDaftar
            // 
            this.lblJuduldiDaftar.AutoSize = true;
            this.lblJuduldiDaftar.Font = new System.Drawing.Font("Roboto Bk", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuduldiDaftar.ForeColor = System.Drawing.Color.White;
            this.lblJuduldiDaftar.Location = new System.Drawing.Point(161, 181);
            this.lblJuduldiDaftar.Name = "lblJuduldiDaftar";
            this.lblJuduldiDaftar.Size = new System.Drawing.Size(388, 48);
            this.lblJuduldiDaftar.TabIndex = 1;
            this.lblJuduldiDaftar.Text = "DAFTAR PENGGUNA";
            // 
            // pctDaftarPelanggan
            // 
            this.pctDaftarPelanggan.Image = global::Aplikasi_PenjualanPC.Properties.Resources.man;
            this.pctDaftarPelanggan.Location = new System.Drawing.Point(283, 23);
            this.pctDaftarPelanggan.Name = "pctDaftarPelanggan";
            this.pctDaftarPelanggan.Size = new System.Drawing.Size(133, 139);
            this.pctDaftarPelanggan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDaftarPelanggan.TabIndex = 0;
            this.pctDaftarPelanggan.TabStop = false;
            // 
            // lblNamaDaftarPelanggan
            // 
            this.lblNamaDaftarPelanggan.AutoSize = true;
            this.lblNamaDaftarPelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaDaftarPelanggan.Location = new System.Drawing.Point(144, 289);
            this.lblNamaDaftarPelanggan.Name = "lblNamaDaftarPelanggan";
            this.lblNamaDaftarPelanggan.Size = new System.Drawing.Size(59, 24);
            this.lblNamaDaftarPelanggan.TabIndex = 1;
            this.lblNamaDaftarPelanggan.Text = "Nama";
            // 
            // lblUsernameDaftarPelanggan
            // 
            this.lblUsernameDaftarPelanggan.AutoSize = true;
            this.lblUsernameDaftarPelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameDaftarPelanggan.Location = new System.Drawing.Point(144, 364);
            this.lblUsernameDaftarPelanggan.Name = "lblUsernameDaftarPelanggan";
            this.lblUsernameDaftarPelanggan.Size = new System.Drawing.Size(95, 24);
            this.lblUsernameDaftarPelanggan.TabIndex = 2;
            this.lblUsernameDaftarPelanggan.Text = "Username";
            // 
            // lblEmailDaftarPelanggan
            // 
            this.lblEmailDaftarPelanggan.AutoSize = true;
            this.lblEmailDaftarPelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDaftarPelanggan.Location = new System.Drawing.Point(144, 439);
            this.lblEmailDaftarPelanggan.Name = "lblEmailDaftarPelanggan";
            this.lblEmailDaftarPelanggan.Size = new System.Drawing.Size(56, 24);
            this.lblEmailDaftarPelanggan.TabIndex = 3;
            this.lblEmailDaftarPelanggan.Text = "Email";
            // 
            // lblPasswordDaftarPelanggan
            // 
            this.lblPasswordDaftarPelanggan.AutoSize = true;
            this.lblPasswordDaftarPelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordDaftarPelanggan.Location = new System.Drawing.Point(144, 508);
            this.lblPasswordDaftarPelanggan.Name = "lblPasswordDaftarPelanggan";
            this.lblPasswordDaftarPelanggan.Size = new System.Drawing.Size(91, 24);
            this.lblPasswordDaftarPelanggan.TabIndex = 4;
            this.lblPasswordDaftarPelanggan.Text = "Password";
            // 
            // txtDaftarNamaPelanggan
            // 
            this.txtDaftarNamaPelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaftarNamaPelanggan.Location = new System.Drawing.Point(263, 286);
            this.txtDaftarNamaPelanggan.Name = "txtDaftarNamaPelanggan";
            this.txtDaftarNamaPelanggan.Size = new System.Drawing.Size(265, 32);
            this.txtDaftarNamaPelanggan.TabIndex = 5;
            // 
            // txtDaftarUsernamePelanggan
            // 
            this.txtDaftarUsernamePelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaftarUsernamePelanggan.Location = new System.Drawing.Point(263, 361);
            this.txtDaftarUsernamePelanggan.Name = "txtDaftarUsernamePelanggan";
            this.txtDaftarUsernamePelanggan.Size = new System.Drawing.Size(265, 32);
            this.txtDaftarUsernamePelanggan.TabIndex = 6;
            // 
            // txtDaftarEmailPelanggan
            // 
            this.txtDaftarEmailPelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaftarEmailPelanggan.Location = new System.Drawing.Point(263, 436);
            this.txtDaftarEmailPelanggan.Name = "txtDaftarEmailPelanggan";
            this.txtDaftarEmailPelanggan.Size = new System.Drawing.Size(265, 32);
            this.txtDaftarEmailPelanggan.TabIndex = 7;
            // 
            // mtxDaftarPasswordPelanggan
            // 
            this.mtxDaftarPasswordPelanggan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxDaftarPasswordPelanggan.Location = new System.Drawing.Point(263, 505);
            this.mtxDaftarPasswordPelanggan.Name = "mtxDaftarPasswordPelanggan";
            this.mtxDaftarPasswordPelanggan.PasswordChar = '*';
            this.mtxDaftarPasswordPelanggan.Size = new System.Drawing.Size(265, 32);
            this.mtxDaftarPasswordPelanggan.TabIndex = 8;
            // 
            // btnDaftarPelanggan
            // 
            this.btnDaftarPelanggan.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDaftarPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftarPelanggan.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarPelanggan.ForeColor = System.Drawing.Color.White;
            this.btnDaftarPelanggan.Location = new System.Drawing.Point(193, 581);
            this.btnDaftarPelanggan.Name = "btnDaftarPelanggan";
            this.btnDaftarPelanggan.Size = new System.Drawing.Size(281, 53);
            this.btnDaftarPelanggan.TabIndex = 9;
            this.btnDaftarPelanggan.Text = "DAFTAR";
            this.btnDaftarPelanggan.UseVisualStyleBackColor = false;
            this.btnDaftarPelanggan.Click += new System.EventHandler(this.btnDaftarPelanggan_Click);
            // 
            // lblSilahkanLogin
            // 
            this.lblSilahkanLogin.AutoSize = true;
            this.lblSilahkanLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilahkanLogin.Location = new System.Drawing.Point(169, 646);
            this.lblSilahkanLogin.Name = "lblSilahkanLogin";
            this.lblSilahkanLogin.Size = new System.Drawing.Size(344, 24);
            this.lblSilahkanLogin.TabIndex = 11;
            this.lblSilahkanLogin.Text = "Silahkan Login di menu Login Pelanggan";
            // 
            // FormDaftarPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 688);
            this.Controls.Add(this.lblSilahkanLogin);
            this.Controls.Add(this.btnDaftarPelanggan);
            this.Controls.Add(this.mtxDaftarPasswordPelanggan);
            this.Controls.Add(this.txtDaftarEmailPelanggan);
            this.Controls.Add(this.txtDaftarUsernamePelanggan);
            this.Controls.Add(this.txtDaftarNamaPelanggan);
            this.Controls.Add(this.lblPasswordDaftarPelanggan);
            this.Controls.Add(this.lblEmailDaftarPelanggan);
            this.Controls.Add(this.lblUsernameDaftarPelanggan);
            this.Controls.Add(this.lblNamaDaftarPelanggan);
            this.Controls.Add(this.grpSebelumLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaftarPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Daftar Pelanggan";
            this.Load += new System.EventHandler(this.FormDaftarPelanggan_Load);
            this.grpSebelumLogin.ResumeLayout(false);
            this.grpSebelumLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDaftarPelanggan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSebelumLogin;
        private System.Windows.Forms.PictureBox pctDaftarPelanggan;
        private System.Windows.Forms.Button btnKeluardiDaftar;
        private System.Windows.Forms.Label lblJuduldiDaftar;
        private System.Windows.Forms.Label lblNamaDaftarPelanggan;
        private System.Windows.Forms.Label lblUsernameDaftarPelanggan;
        private System.Windows.Forms.Label lblEmailDaftarPelanggan;
        private System.Windows.Forms.Label lblPasswordDaftarPelanggan;
        private System.Windows.Forms.TextBox txtDaftarNamaPelanggan;
        private System.Windows.Forms.TextBox txtDaftarUsernamePelanggan;
        private System.Windows.Forms.TextBox txtDaftarEmailPelanggan;
        private System.Windows.Forms.MaskedTextBox mtxDaftarPasswordPelanggan;
        private System.Windows.Forms.Button btnDaftarPelanggan;
        private System.Windows.Forms.Label lblSilahkanLogin;
    }
}

