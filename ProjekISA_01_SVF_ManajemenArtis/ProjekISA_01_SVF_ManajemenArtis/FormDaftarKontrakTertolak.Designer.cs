
namespace ProjekISA_01_SVF_ManajemenArtis
{
    partial class FormDaftarKontrakTertolak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftarKontrakTertolak));
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewKontrak = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontrak)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 44);
            this.label3.TabIndex = 66;
            this.label3.Text = "DAFTAR KONTRAK TERTOLAK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKontrak
            // 
            this.dataGridViewKontrak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontrak.Location = new System.Drawing.Point(26, 76);
            this.dataGridViewKontrak.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridViewKontrak.Name = "dataGridViewKontrak";
            this.dataGridViewKontrak.RowHeadersWidth = 62;
            this.dataGridViewKontrak.RowTemplate.Height = 28;
            this.dataGridViewKontrak.Size = new System.Drawing.Size(620, 287);
            this.dataGridViewKontrak.TabIndex = 65;
            this.dataGridViewKontrak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKontrak_CellContentClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(506, 383);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 38);
            this.buttonExit.TabIndex = 67;
            this.buttonExit.Text = "Kembali";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormDaftarKontrakTertolak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekISA_01_SVF_ManajemenArtis.Properties.Resources.Bg_basic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 442);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewKontrak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDaftarKontrakTertolak";
            this.Text = "FormDaftarKontrakTertolak";
            this.Load += new System.EventHandler(this.FormDaftarKontrakTertolak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontrak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewKontrak;
        private System.Windows.Forms.Button buttonExit;
    }
}