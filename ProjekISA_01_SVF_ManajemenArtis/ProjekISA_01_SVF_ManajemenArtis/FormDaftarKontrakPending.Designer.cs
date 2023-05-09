
namespace ProjekISA_01_SVF_ManajemenArtis
{
    partial class FormDaftarKontrakPending
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewKontrak = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontrak)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(698, 55);
            this.label3.TabIndex = 66;
            this.label3.Text = "DAFTAR KONTRAK PENDING";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKontrak
            // 
            this.dataGridViewKontrak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKontrak.Location = new System.Drawing.Point(27, 94);
            this.dataGridViewKontrak.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridViewKontrak.Name = "dataGridViewKontrak";
            this.dataGridViewKontrak.RowHeadersWidth = 62;
            this.dataGridViewKontrak.RowTemplate.Height = 28;
            this.dataGridViewKontrak.Size = new System.Drawing.Size(698, 359);
            this.dataGridViewKontrak.TabIndex = 65;
            this.dataGridViewKontrak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKontrak_CellContentClick);
            // 
            // FormDaftarKontrakPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekISA_01_SVF_ManajemenArtis.Properties.Resources.Bg_basic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 482);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewKontrak);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDaftarKontrakPending";
            this.Text = "FormDaftarKontrakPending";
            this.Load += new System.EventHandler(this.FormDaftarKontrakPending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKontrak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewKontrak;
    }
}