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
    public partial class FormDetailKontrakEdit : Form
    {
        public FormDetailKontrakEdit()
        {
            InitializeComponent();
        }
        public Kontrak_kerja kontrak = new Kontrak_kerja();
        private void FormDetailKontrakEdit_Load(object sender, EventArgs e)
        {
            //extract message from stegano
            Bitmap imgEmbed = new Bitmap(kontrak.Lokasi);
            string lokasi = Steganography.SteganographyHelper.extractText(imgEmbed);

            labelJudul.Text = kontrak.Judul;
            labelNamaArtis.Text = kontrak.Artis.Nama;
            labelNamaPengaju.Text = kontrak.Pengaju;
            labelTanggalAcara.Text = kontrak.TglAcara.ToString();
            labelLokasi.Text = lokasi;
            textBoxIsi.Text = kontrak.Deskripsi;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIsi.Text == "")
                {
                    textBoxIsi.Focus();
                    throw new Exception("Deskri[psi harus diisi");
                }
                else
                {
                    //ciptakan objek yang akan ditambahkan
                    Kontrak_kerja k = new Kontrak_kerja(kontrak.Id, kontrak.Judul, kontrak.Pengaju, kontrak.Lokasi, textBoxIsi.Text, kontrak.TglBuat, kontrak.TglAcara, kontrak.Status, kontrak.Manager, kontrak.Artis);

                    //panggil method TambahData di class Kategori
                    Kontrak_kerja.EditData(k);

                    MessageBox.Show("Kontrak telah diperbarui", "Information");

                    FormDaftarKontrakBaru formDaftarKontrakBaru = (FormDaftarKontrakBaru)this.Owner;
                    formDaftarKontrakBaru.FormDaftarKontrak_Load(this, e);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pengubahan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
