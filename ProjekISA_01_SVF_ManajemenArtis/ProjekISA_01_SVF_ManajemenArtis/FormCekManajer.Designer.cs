
namespace ProjekISA_01_SVF_ManajemenArtis
{
    partial class FormCekManajer
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
            this.dataGridViewManajer = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManajer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManajer
            // 
            this.dataGridViewManajer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManajer.Location = new System.Drawing.Point(26, 72);
            this.dataGridViewManajer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewManajer.Name = "dataGridViewManajer";
            this.dataGridViewManajer.RowHeadersWidth = 62;
            this.dataGridViewManajer.RowTemplate.Height = 28;
            this.dataGridViewManajer.Size = new System.Drawing.Size(620, 286);
            this.dataGridViewManajer.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(620, 44);
            this.label3.TabIndex = 64;
            this.label3.Text = "DAFTAR MANAJER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCekManajer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 385);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewManajer);
            this.Name = "FormCekManajer";
            this.Text = "FormCekManajer";
            this.Load += new System.EventHandler(this.FormCekManajer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManajer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManajer;
        private System.Windows.Forms.Label label3;
    }
}