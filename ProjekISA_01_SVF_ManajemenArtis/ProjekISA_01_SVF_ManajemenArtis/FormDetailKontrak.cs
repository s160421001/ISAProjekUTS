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
            if(kontrak.Artis.Nama == "")
            {
                int idArtis = Kontrak_kerja.AmbilIdArtisDariKontrak(kontrak);
                string namaArtis = Artis.AmbilNamaArtis(idArtis);

                labelNamaArtis.Text = namaArtis;
            }
            else
            {
                labelNamaArtis.Text = kontrak.Artis.Nama;
            }

            //extract lokasi from stegano
            Bitmap imgEmbed = new Bitmap(kontrak.Lokasi);
            string lokasi = Steganography.SteganographyHelper.extractText(imgEmbed);

            labelJudul.Text = kontrak.Judul;
            labelNamaPengaju.Text = kontrak.Pengaju;
            labelTanggalAcara.Text = kontrak.TglAcara.ToString();
            labelLokasi.Text = lokasi;
            textBoxIsi.Text = kontrak.Deskripsi;


        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
