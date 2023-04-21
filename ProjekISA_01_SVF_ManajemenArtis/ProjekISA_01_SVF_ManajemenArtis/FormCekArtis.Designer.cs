
namespace ProjekISA_01_SVF_ManajemenArtis
{
    partial class FormCekArtis
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
            this.dataGridViewArtis = new System.Windows.Forms.DataGridView();
            this.textBoxKriteria = new System.Windows.Forms.TextBox();
            this.labelNamaArtis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArtis
            // 
            this.dataGridViewArtis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtis.Location = new System.Drawing.Point(29, 77);
            this.dataGridViewArtis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewArtis.Name = "dataGridViewArtis";
            this.dataGridViewArtis.RowHeadersWidth = 62;
            this.dataGridViewArtis.RowTemplate.Height = 28;
            this.dataGridViewArtis.Size = new System.Drawing.Size(620, 286);
            this.dataGridViewArtis.TabIndex = 9;
            this.dataGridViewArtis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtis_CellContentClick);
            // 
            // textBoxKriteria
            // 
            this.textBoxKriteria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKriteria.Location = new System.Drawing.Point(174, 26);
            this.textBoxKriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKriteria.Name = "textBoxKriteria";
            this.textBoxKriteria.Size = new System.Drawing.Size(476, 30);
            this.textBoxKriteria.TabIndex = 8;
            // 
            // labelNamaArtis
            // 
            this.labelNamaArtis.AutoSize = true;
            this.labelNamaArtis.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaArtis.Location = new System.Drawing.Point(24, 26);
            this.labelNamaArtis.Name = "labelNamaArtis";
            this.labelNamaArtis.Size = new System.Drawing.Size(144, 29);
            this.labelNamaArtis.TabIndex = 7;
            this.labelNamaArtis.Text = "Nama Artis:";
            // 
            // FormCekArtis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 389);
            this.Controls.Add(this.dataGridViewArtis);
            this.Controls.Add(this.textBoxKriteria);
            this.Controls.Add(this.labelNamaArtis);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCekArtis";
            this.Text = "FormCekArtis";
            this.Load += new System.EventHandler(this.FormCekArtis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArtis;
        private System.Windows.Forms.TextBox textBoxKriteria;
        private System.Windows.Forms.Label labelNamaArtis;
    }
}