
namespace ProjekISA_01_SVF_ManajemenArtis
{
    partial class FormTambahKontrak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahKontrak));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.textBoxJudul = new System.Windows.Forms.TextBox();
            this.textBoxPengaju = new System.Windows.Forms.TextBox();
            this.textBoxIsi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxArtis = new System.Windows.Forms.ComboBox();
            this.dateTimePickerAcara = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLokasi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Judul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pengaju";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Isi Kontrak";
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(636, 781);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(158, 48);
            this.buttonTambah.TabIndex = 3;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // textBoxJudul
            // 
            this.textBoxJudul.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJudul.Location = new System.Drawing.Point(231, 101);
            this.textBoxJudul.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxJudul.Name = "textBoxJudul";
            this.textBoxJudul.Size = new System.Drawing.Size(563, 35);
            this.textBoxJudul.TabIndex = 4;
            // 
            // textBoxPengaju
            // 
            this.textBoxPengaju.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPengaju.Location = new System.Drawing.Point(231, 165);
            this.textBoxPengaju.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxPengaju.Name = "textBoxPengaju";
            this.textBoxPengaju.Size = new System.Drawing.Size(563, 35);
            this.textBoxPengaju.TabIndex = 5;
            // 
            // textBoxIsi
            // 
            this.textBoxIsi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIsi.Location = new System.Drawing.Point(231, 345);
            this.textBoxIsi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxIsi.Multiline = true;
            this.textBoxIsi.Name = "textBoxIsi";
            this.textBoxIsi.Size = new System.Drawing.Size(563, 426);
            this.textBoxIsi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Artis";
            // 
            // comboBoxArtis
            // 
            this.comboBoxArtis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArtis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArtis.FormattingEnabled = true;
            this.comboBoxArtis.Location = new System.Drawing.Point(231, 41);
            this.comboBoxArtis.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBoxArtis.Name = "comboBoxArtis";
            this.comboBoxArtis.Size = new System.Drawing.Size(563, 35);
            this.comboBoxArtis.TabIndex = 8;
            this.comboBoxArtis.SelectedIndexChanged += new System.EventHandler(this.comboBoxArtis_SelectedIndexChanged);
            // 
            // dateTimePickerAcara
            // 
            this.dateTimePickerAcara.CalendarFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAcara.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAcara.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAcara.Location = new System.Drawing.Point(231, 225);
            this.dateTimePickerAcara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerAcara.Name = "dateTimePickerAcara";
            this.dateTimePickerAcara.Size = new System.Drawing.Size(244, 40);
            this.dateTimePickerAcara.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 33);
            this.label6.TabIndex = 31;
            this.label6.Text = "Lokasi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tanggal Acara";
            // 
            // textBoxLokasi
            // 
            this.textBoxLokasi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLokasi.Location = new System.Drawing.Point(231, 285);
            this.textBoxLokasi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxLokasi.Name = "textBoxLokasi";
            this.textBoxLokasi.Size = new System.Drawing.Size(563, 35);
            this.textBoxLokasi.TabIndex = 34;
            // 
            // FormTambahKontrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekISA_01_SVF_ManajemenArtis.Properties.Resources.Bg_basic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 842);
            this.Controls.Add(this.textBoxLokasi);
            this.Controls.Add(this.dateTimePickerAcara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxArtis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIsi);
            this.Controls.Add(this.textBoxPengaju);
            this.Controls.Add(this.textBoxJudul);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "FormTambahKontrak";
            this.Text = "Tambah Kontrak";
            this.Load += new System.EventHandler(this.FormTambahKontrak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.TextBox textBoxJudul;
        private System.Windows.Forms.TextBox textBoxPengaju;
        private System.Windows.Forms.TextBox textBoxIsi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxArtis;
        private System.Windows.Forms.DateTimePicker dateTimePickerAcara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLokasi;
    }
}