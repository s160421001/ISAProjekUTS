
namespace ProjekISA_01_SVF_ManajemenArtis
{
    partial class FormDetailJadwal_Kegiatan
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
            this.labelNamaPartner = new System.Windows.Forms.Label();
            this.labelNamaAcara = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxRincianKegiatan = new System.Windows.Forms.ListBox();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNamaPartner
            // 
            this.labelNamaPartner.AutoSize = true;
            this.labelNamaPartner.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPartner.Location = new System.Drawing.Point(271, 88);
            this.labelNamaPartner.Name = "labelNamaPartner";
            this.labelNamaPartner.Size = new System.Drawing.Size(191, 33);
            this.labelNamaPartner.TabIndex = 19;
            this.labelNamaPartner.Text = "NamaPartner";
            // 
            // labelNamaAcara
            // 
            this.labelNamaAcara.AutoSize = true;
            this.labelNamaAcara.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaAcara.Location = new System.Drawing.Point(271, 40);
            this.labelNamaAcara.Name = "labelNamaAcara";
            this.labelNamaAcara.Size = new System.Drawing.Size(167, 33);
            this.labelNamaAcara.TabIndex = 18;
            this.labelNamaAcara.Text = "JudulAcara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Partner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nama Acara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rincian Kegiatan";
            // 
            // listBoxRincianKegiatan
            // 
            this.listBoxRincianKegiatan.FormattingEnabled = true;
            this.listBoxRincianKegiatan.ItemHeight = 20;
            this.listBoxRincianKegiatan.Location = new System.Drawing.Point(33, 199);
            this.listBoxRincianKegiatan.Name = "listBoxRincianKegiatan";
            this.listBoxRincianKegiatan.Size = new System.Drawing.Size(753, 424);
            this.listBoxRincianKegiatan.TabIndex = 21;
            // 
            // buttonKembali
            // 
            this.buttonKembali.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKembali.Location = new System.Drawing.Point(628, 652);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(158, 48);
            this.buttonKembali.TabIndex = 22;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            // 
            // FormDetailJadwal_Kegiatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 722);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.listBoxRincianKegiatan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNamaPartner);
            this.Controls.Add(this.labelNamaAcara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDetailJadwal_Kegiatan";
            this.Text = "Detail Kegiatan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaPartner;
        private System.Windows.Forms.Label labelNamaAcara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxRincianKegiatan;
        private System.Windows.Forms.Button buttonKembali;
    }
}