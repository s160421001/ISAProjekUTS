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
                Artis tmpArtis = Artis.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
                if (tmpArtis.Username == "")
                {
                    Manager tmpManager = Manager.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
                    if (tmpManager.Username == "")
                    {
                        MessageBox.Show("Kombinasi username dan password tidak ditemukan", "Informasi");
                    }
                    else
                    {
                        MessageBox.Show("Selamat menggunakan aplikasi.", "Informasi");
                        FormMenu frmMenu = new FormMenu();

                        frmMenu.manager = tmpManager;
                        frmMenu.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Selamat menggunakan aplikasi.", "Informasi");
                    FormMenu frmMenu = new FormMenu();

                    frmMenu.artis = tmpArtis;
                    frmMenu.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
