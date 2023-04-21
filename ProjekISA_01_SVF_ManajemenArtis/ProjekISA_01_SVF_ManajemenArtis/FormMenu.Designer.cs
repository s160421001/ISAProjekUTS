
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cekJadwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cekKontrakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahKontrakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manajemenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesanMasukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cekArtisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selamat Datang,";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(363, 157);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(123, 46);
            this.labelNama.TabIndex = 3;
            this.labelNama.Text = "nama";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.jadwalToolStripMenuItem,
            this.kontrakToolStripMenuItem,
            this.manajemenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(917, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(91, 31);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // jadwalToolStripMenuItem
            // 
            this.jadwalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cekJadwalToolStripMenuItem});
            this.jadwalToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jadwalToolStripMenuItem.Name = "jadwalToolStripMenuItem";
            this.jadwalToolStripMenuItem.Size = new System.Drawing.Size(103, 31);
            this.jadwalToolStripMenuItem.Text = "Jadwal";
            this.jadwalToolStripMenuItem.Visible = false;
            // 
            // cekJadwalToolStripMenuItem
            // 
            this.cekJadwalToolStripMenuItem.Name = "cekJadwalToolStripMenuItem";
            this.cekJadwalToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.cekJadwalToolStripMenuItem.Text = "Cek Jadwal";
            // 
            // kontrakToolStripMenuItem
            // 
            this.kontrakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cekKontrakToolStripMenuItem,
            this.tambahKontrakToolStripMenuItem});
            this.kontrakToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontrakToolStripMenuItem.Name = "kontrakToolStripMenuItem";
            this.kontrakToolStripMenuItem.Size = new System.Drawing.Size(111, 31);
            this.kontrakToolStripMenuItem.Text = "Kontrak";
            this.kontrakToolStripMenuItem.Visible = false;
            // 
            // cekKontrakToolStripMenuItem
            // 
            this.cekKontrakToolStripMenuItem.Name = "cekKontrakToolStripMenuItem";
            this.cekKontrakToolStripMenuItem.Size = new System.Drawing.Size(289, 36);
            this.cekKontrakToolStripMenuItem.Text = "Cek Kontrak";
            this.cekKontrakToolStripMenuItem.Click += new System.EventHandler(this.cekKontrakToolStripMenuItem_Click);
            // 
            // tambahKontrakToolStripMenuItem
            // 
            this.tambahKontrakToolStripMenuItem.Name = "tambahKontrakToolStripMenuItem";
            this.tambahKontrakToolStripMenuItem.Size = new System.Drawing.Size(289, 36);
            this.tambahKontrakToolStripMenuItem.Text = "Tambah Kontrak";
            this.tambahKontrakToolStripMenuItem.Visible = false;
            // 
            // manajemenToolStripMenuItem
            // 
            this.manajemenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesanMasukToolStripMenuItem,
            this.cekArtisToolStripMenuItem});
            this.manajemenToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manajemenToolStripMenuItem.Name = "manajemenToolStripMenuItem";
            this.manajemenToolStripMenuItem.Size = new System.Drawing.Size(153, 31);
            this.manajemenToolStripMenuItem.Text = "Manajemen";
            this.manajemenToolStripMenuItem.Visible = false;
            // 
            // pesanMasukToolStripMenuItem
            // 
            this.pesanMasukToolStripMenuItem.Name = "pesanMasukToolStripMenuItem";
            this.pesanMasukToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.pesanMasukToolStripMenuItem.Text = "Pesan Masuk";
            this.pesanMasukToolStripMenuItem.Visible = false;
            // 
            // cekArtisToolStripMenuItem
            // 
            this.cekArtisToolStripMenuItem.Name = "cekArtisToolStripMenuItem";
            this.cekArtisToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.cekArtisToolStripMenuItem.Text = "Cek Artis";
            this.cekArtisToolStripMenuItem.Visible = false;
            this.cekArtisToolStripMenuItem.Click += new System.EventHandler(this.cekArtisToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(641, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manager:";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManager.Location = new System.Drawing.Point(781, 443);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(90, 33);
            this.labelManager.TabIndex = 6;
            this.labelManager.Text = "nama";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(917, 501);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenu";
            this.Text = "Menu Utama";
            this.Load += new System.EventHandler(this.FormMenu_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jadwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cekJadwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cekKontrakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahKontrakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manajemenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesanMasukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cekArtisToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelManager;
    }
}