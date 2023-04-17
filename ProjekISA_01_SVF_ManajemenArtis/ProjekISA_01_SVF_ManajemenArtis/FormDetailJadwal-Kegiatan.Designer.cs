
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
            this.SuspendLayout();
            // 
            // labelNamaPartner
            // 
            this.labelNamaPartner.AutoSize = true;
            this.labelNamaPartner.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPartner.Location = new System.Drawing.Point(221, 88);
            this.labelNamaPartner.Name = "labelNamaPartner";
            this.labelNamaPartner.Size = new System.Drawing.Size(191, 33);
            this.labelNamaPartner.TabIndex = 19;
            this.labelNamaPartner.Text = "NamaPartner";
            // 
            // labelNamaAcara
            // 
            this.labelNamaAcara.AutoSize = true;
            this.labelNamaAcara.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaAcara.Location = new System.Drawing.Point(221, 40);
            this.labelNamaAcara.Name = "labelNamaAcara";
            this.labelNamaAcara.Size = new System.Drawing.Size(167, 33);
            this.labelNamaAcara.TabIndex = 18;
            this.labelNamaAcara.Text = "JudulAcara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Partner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nama Acara";
            // 
            // FormDetailJadwal_Kegiatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}