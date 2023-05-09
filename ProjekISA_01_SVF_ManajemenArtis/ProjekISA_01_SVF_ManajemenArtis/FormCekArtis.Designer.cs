
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCekArtis));
            this.dataGridViewArtis = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 44);
            this.label3.TabIndex = 63;
            this.label3.Text = "DAFTAR ARTIS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCekArtis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ProjekISA_01_SVF_ManajemenArtis.Properties.Resources.otherbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewArtis);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCekArtis";
            this.Text = "Cek Artis";
            this.Load += new System.EventHandler(this.FormCekArtis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArtis;
        private System.Windows.Forms.Label label3;
    }
}