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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Koneksi koneksi = new Koneksi();
                MessageBox.Show("Koneksi Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Artis tmpUser = Artis.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
                if (tmpUser != null)
                {
                    FormMenu frmMenu = (FormMenu)this.Owner;
                    frmMenu.artis = tmpUser;

                    MessageBox.Show("Selamat menggunakan aplikasi.", "Informasi");

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    throw new Exception("Kombinasi username dan password tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
