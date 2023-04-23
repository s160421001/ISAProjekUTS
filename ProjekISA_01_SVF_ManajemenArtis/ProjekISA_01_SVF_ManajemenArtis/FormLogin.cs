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

                Random rand = new Random();
                int num = rand.Next(6, 9);
                string captcha = "";
                int total = 0;

                do
                {
                    int chr = rand.Next(48, 122);
                    if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                    {
                        captcha = captcha + (char)chr;
                        total++;
                        if (total == num)
                        {
                            break;
                        }
                    }
                } while (true);
                labelCaptcha.Text = captcha;
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
                if(labelCaptcha.Text == textBoxCaptcha.Text)
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
                else
                {
                    MessageBox.Show("Captcha is incorrect, please try again!", "Information");
                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.ShowDialog();
        }
    }
}
