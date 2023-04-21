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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxPosisi.SelectedItem.ToString() == "Artis")
                {
                    Artis newArtis = new Artis();
                    newArtis.Nama = textBoxNama.Text;
                    newArtis.Tanggal_lahir = dateTimePickerTanggalLahir.Value;
                    newArtis.Tanggal_masuk = DateTime.Now;
                    newArtis.Username = textBoxUsername.Text;
                    newArtis.Password = textBoxPassword.Text;
                    newArtis.Status = Artis.status_manajer.kosong;

                    List<Artis> listArtis = new List<Artis>();
                    listArtis = Artis.BacaData("", "");

                    bool cek = true;
                    foreach (Artis a in listArtis)
                    {
                        if(a.Username == newArtis.Username)
                        {
                            cek = false;
                            break;
                        }
                        else
                        {
                            cek = true;
                        }
                    }

                    if(cek == true)
                    {
                        Artis.TambahData(newArtis);
                        MessageBox.Show("Akun berhasil dibuat!");
                    }
                    else
                    {
                        MessageBox.Show("Username telah digunakan, Silahkan gunakan username lainnya", "Information");
                    }
                }
                else if(comboBoxPosisi.SelectedItem.ToString() == "Manajer")
                {
                    Manager newManajer = new Manager();
                    newManajer.Nama = textBoxNama.Text;
                    newManajer.TglLahir = dateTimePickerTanggalLahir.Value;
                    newManajer.TglMasuk = DateTime.Now;
                    newManajer.Username = textBoxUsername.Text;
                    newManajer.Password = textBoxPassword.Text;
                    newManajer.Title = jabatan.biasa;

                    List<Manager> listManajer = new List<Manager>();
                    listManajer = Manager.BacaData("", "");

                    bool cek = true;
                    foreach (Manager m in listManajer)
                    {
                        if (m.Username == newManajer.Username)
                        {
                            cek = false;
                            break;
                        }
                        else
                        {
                            cek = true;
                        }
                    }

                    if (cek == true)
                    {
                        Manager.TambahData(newManajer);
                        MessageBox.Show("Akun berhasil dibuat!");
                    }
                    else
                    {
                        MessageBox.Show("Username telah digunakan, Silahkan gunakan username lainnya", "Information");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
