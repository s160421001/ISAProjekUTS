using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ManajemenArtis_Lib;

namespace ProjekISA_01_SVF_ManajemenArtis
{
    public partial class FormDetailKontrak : Form
    {
        public FormDetailKontrak()
        {
            InitializeComponent();
        }
        public Kontrak_kerja kontrak = new Kontrak_kerja();
        private void FormDetailKontrak_Load(object sender, EventArgs e)
        {
            labelJudul.Text = kontrak.Judul;
            labelNamaArtis.Text = kontrak.Artis.Nama;
            labelNamaPengaju.Text = kontrak.Pengaju;
            labelTanggalAcara.Text = kontrak.TglAcara.ToString();
            labelLokasi.Text = kontrak.Lokasi;
            textBoxIsi.Text = kontrak.Deskripsi;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
