
namespace Aplikasi_PenjualanPC
{
    partial class FormLoginAdmin
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
            this.grpLoginAdmin = new System.Windows.Forms.GroupBox();
            this.btnKeluarLoginAdmin = new System.Windows.Forms.Button();
            this.lblJudulLoginAdmin = new System.Windows.Forms.Label();
            this.pctLoginAdmin = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblUsernameLoginAdmin = new System.Windows.Forms.Label();
            this.lblPasswordLoginAdmin = new System.Windows.Forms.Label();
            this.txtUsernameLoginAdmin = new System.Windows.Forms.TextBox();
            this.mtxPasswordLoginAdmin = new System.Windows.Forms.MaskedTextBox();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.grpLoginAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLoginAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLoginAdmin
            // 
            this.grpLoginAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpLoginAdmin.Controls.Add(this.btnKeluarLoginAdmin);
            this.grpLoginAdmin.Controls.Add(this.lblJudulLoginAdmin);
            this.grpLoginAdmin.Controls.Add(this.pctLoginAdmin);
            this.grpLoginAdmin.Location = new System.Drawing.Point(-1, -10);
            this.grpLoginAdmin.Name = "grpLoginAdmin";
            this.grpLoginAdmin.Size = new System.Drawing.Size(515, 138);
            this.grpLoginAdmin.TabIndex = 0;
            this.grpLoginAdmin.TabStop = false;
            // 
            // btnKeluarLoginAdmin
            // 
            this.btnKeluarLoginAdmin.BackColor = System.Drawing.Color.IndianRed;
            this.btnKeluarLoginAdmin.ForeColor = System.Drawing.Color.White;
            this.btnKeluarLoginAdmin.Image = global::Aplikasi_PenjualanPC.Properties.Resources.cancel__1_;
            this.btnKeluarLoginAdmin.Location = new System.Drawing.Point(450, 21);
            this.btnKeluarLoginAdmin.Name = "btnKeluarLoginAdmin";
            this.btnKeluarLoginAdmin.Size = new System.Drawing.Size(50, 45);
            this.btnKeluarLoginAdmin.TabIndex = 2;
            this.btnKeluarLoginAdmin.UseVisualStyleBackColor = false;
            this.btnKeluarLoginAdmin.Click += new System.EventHandler(this.btnKeluarLoginAdmin_Click);
            // 
            // lblJudulLoginAdmin
            // 
            this.lblJudulLoginAdmin.AutoSize = true;
            this.lblJudulLoginAdmin.Font = new System.Drawing.Font("Roboto Bk", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulLoginAdmin.ForeColor = System.Drawing.Color.White;
            this.lblJudulLoginAdmin.Location = new System.Drawing.Point(147, 56);
            this.lblJudulLoginAdmin.Name = "lblJudulLoginAdmin";
            this.lblJudulLoginAdmin.Size = new System.Drawing.Size(191, 34);
            this.lblJudulLoginAdmin.TabIndex = 1;
            this.lblJudulLoginAdmin.Text = "LOGIN ADMIN";
            // 
            // pctLoginAdmin
            // 
            this.pctLoginAdmin.Image = global::Aplikasi_PenjualanPC.Properties.Resources.unauthorized_person__1_;
            this.pctLoginAdmin.Location = new System.Drawing.Point(30, 22);
            this.pctLoginAdmin.Name = "pctLoginAdmin";
            this.pctLoginAdmin.Size = new System.Drawing.Size(91, 98);
            this.pctLoginAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLoginAdmin.TabIndex = 0;
            this.pctLoginAdmin.TabStop = false;
            // 
            // lblUsernameLoginAdmin
            // 
            this.lblUsernameLoginAdmin.AutoSize = true;
            this.lblUsernameLoginAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLoginAdmin.Location = new System.Drawing.Point(74, 148);
            this.lblUsernameLoginAdmin.Name = "lblUsernameLoginAdmin";
            this.lblUsernameLoginAdmin.Size = new System.Drawing.Size(95, 24);
            this.lblUsernameLoginAdmin.TabIndex = 1;
            this.lblUsernameLoginAdmin.Text = "Username";
            // 
            // lblPasswordLoginAdmin
            // 
            this.lblPasswordLoginAdmin.AutoSize = true;
            this.lblPasswordLoginAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLoginAdmin.Location = new System.Drawing.Point(74, 202);
            this.lblPasswordLoginAdmin.Name = "lblPasswordLoginAdmin";
            this.lblPasswordLoginAdmin.Size = new System.Drawing.Size(91, 24);
            this.lblPasswordLoginAdmin.TabIndex = 2;
            this.lblPasswordLoginAdmin.Text = "Password";
            // 
            // txtUsernameLoginAdmin
            // 
            this.txtUsernameLoginAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameLoginAdmin.Location = new System.Drawing.Point(197, 145);
            this.txtUsernameLoginAdmin.Name = "txtUsernameLoginAdmin";
            this.txtUsernameLoginAdmin.Size = new System.Drawing.Size(202, 32);
            this.txtUsernameLoginAdmin.TabIndex = 3;
            // 
            // mtxPasswordLoginAdmin
            // 
            this.mtxPasswordLoginAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxPasswordLoginAdmin.Location = new System.Drawing.Point(197, 199);
            this.mtxPasswordLoginAdmin.Name = "mtxPasswordLoginAdmin";
            this.mtxPasswordLoginAdmin.PasswordChar = '*';
            this.mtxPasswordLoginAdmin.Size = new System.Drawing.Size(202, 32);
            this.mtxPasswordLoginAdmin.TabIndex = 4;
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLoginAdmin.Location = new System.Drawing.Point(197, 252);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(133, 47);
            this.btnLoginAdmin.TabIndex = 5;
            this.btnLoginAdmin.Text = "LOGIN";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // FormLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 311);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.mtxPasswordLoginAdmin);
            this.Controls.Add(this.txtUsernameLoginAdmin);
            this.Controls.Add(this.lblPasswordLoginAdmin);
            this.Controls.Add(this.lblUsernameLoginAdmin);
            this.Controls.Add(this.grpLoginAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Login Admin";
            this.grpLoginAdmin.ResumeLayout(false);
            this.grpLoginAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLoginAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoginAdmin;
        private System.Windows.Forms.PictureBox pctLoginAdmin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnKeluarLoginAdmin;
        private System.Windows.Forms.Label lblJudulLoginAdmin;
        private System.Windows.Forms.Label lblUsernameLoginAdmin;
        private System.Windows.Forms.Label lblPasswordLoginAdmin;
        private System.Windows.Forms.TextBox txtUsernameLoginAdmin;
        private System.Windows.Forms.MaskedTextBox mtxPasswordLoginAdmin;
        private System.Windows.Forms.Button btnLoginAdmin;
    }
}