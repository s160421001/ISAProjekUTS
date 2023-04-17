
namespace ProjekISA_01_SVF_ManajemenArtis
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelCekJadwal = new System.Windows.Forms.Label();
            this.labelCekKontrak = new System.Windows.Forms.Label();
            this.labelTambahKontrak = new System.Windows.Forms.Label();
            this.labelPesanMasuk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selamat Datang,";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(255, 24);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(90, 33);
            this.labelNama.TabIndex = 3;
            this.labelNama.Text = "nama";
            // 
            // labelCekJadwal
            // 
            this.labelCekJadwal.AutoSize = true;
            this.labelCekJadwal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCekJadwal.Location = new System.Drawing.Point(60, 145);
            this.labelCekJadwal.Name = "labelCekJadwal";
            this.labelCekJadwal.Size = new System.Drawing.Size(170, 33);
            this.labelCekJadwal.TabIndex = 4;
            this.labelCekJadwal.Text = "Cek Jadwal";
            // 
            // labelCekKontrak
            // 
            this.labelCekKontrak.AutoSize = true;
            this.labelCekKontrak.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCekKontrak.Location = new System.Drawing.Point(478, 145);
            this.labelCekKontrak.Name = "labelCekKontrak";
            this.labelCekKontrak.Size = new System.Drawing.Size(181, 33);
            this.labelCekKontrak.TabIndex = 5;
            this.labelCekKontrak.Text = "Cek Kontrak";
            // 
            // labelTambahKontrak
            // 
            this.labelTambahKontrak.AutoSize = true;
            this.labelTambahKontrak.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambahKontrak.Location = new System.Drawing.Point(478, 310);
            this.labelTambahKontrak.Name = "labelTambahKontrak";
            this.labelTambahKontrak.Size = new System.Drawing.Size(237, 33);
            this.labelTambahKontrak.TabIndex = 6;
            this.labelTambahKontrak.Text = "Tambah Kontrak";
            // 
            // labelPesanMasuk
            // 
            this.labelPesanMasuk.AutoSize = true;
            this.labelPesanMasuk.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesanMasuk.Location = new System.Drawing.Point(60, 310);
            this.labelPesanMasuk.Name = "labelPesanMasuk";
            this.labelPesanMasuk.Size = new System.Drawing.Size(194, 33);
            this.labelPesanMasuk.TabIndex = 7;
            this.labelPesanMasuk.Text = "Pesan Masuk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cek Artis";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPesanMasuk);
            this.Controls.Add(this.labelTambahKontrak);
            this.Controls.Add(this.labelCekKontrak);
            this.Controls.Add(this.labelCekJadwal);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.label1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelCekJadwal;
        private System.Windows.Forms.Label labelCekKontrak;
        private System.Windows.Forms.Label labelTambahKontrak;
        private System.Windows.Forms.Label labelPesanMasuk;
        private System.Windows.Forms.Label label2;
    }
}