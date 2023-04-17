
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArtis
            // 
            this.dataGridViewArtis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtis.Location = new System.Drawing.Point(33, 96);
            this.dataGridViewArtis.Name = "dataGridViewArtis";
            this.dataGridViewArtis.RowHeadersWidth = 62;
            this.dataGridViewArtis.RowTemplate.Height = 28;
            this.dataGridViewArtis.Size = new System.Drawing.Size(698, 358);
            this.dataGridViewArtis.TabIndex = 9;
            // 
            // textBoxKriteria
            // 
            this.textBoxKriteria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKriteria.Location = new System.Drawing.Point(153, 32);
            this.textBoxKriteria.Name = "textBoxKriteria";
            this.textBoxKriteria.Size = new System.Drawing.Size(578, 35);
            this.textBoxKriteria.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kriteria";
            // 
            // FormCekArtis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 486);
            this.Controls.Add(this.dataGridViewArtis);
            this.Controls.Add(this.textBoxKriteria);
            this.Controls.Add(this.label1);
            this.Name = "FormCekArtis";
            this.Text = "FormCekArtis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArtis;
        private System.Windows.Forms.TextBox textBoxKriteria;
        private System.Windows.Forms.Label label1;
    }
}