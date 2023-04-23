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
    public partial class FormDaftarKontrakPending : Form
    {
        public FormDaftarKontrakPending()
        {
            InitializeComponent();
        }
        public Artis artis;
        public Manager manager;
        private void FormDaftarKontrakPending_Load(object sender, EventArgs e)
        {
            List<Kontrak_kerja> list = new List<Kontrak_kerja>();
            if (manager != null)
            {
                artis = new Artis();
                if (manager.Title == jabatan.biasa)
                {
                    list = Kontrak_kerja.BacaDataSpesifikManajer(manager.Id);
                }
                else
                {
                    list = Kontrak_kerja.BacaData("k.status_artis", "proses");
                }
            }

            if (list.Count > 0)
            {
                dataGridViewKontrak.DataSource = list;
                if (dataGridViewKontrak.ColumnCount > 8)
                {
                    CreateGridButtons();
                }
            }
            else
            {
                dataGridViewKontrak.DataSource = null;
            }

            dataGridViewKontrak.AllowUserToAddRows = false;
            dataGridViewKontrak.ReadOnly = true;
            dataGridViewKontrak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CreateGridButtons()
        {
            if (dataGridViewKontrak.Columns.Contains("gridButtonLihat") != true)
            {
                //Grid Button for kontrak
                DataGridViewButtonColumn gridButton1 = new DataGridViewButtonColumn();
                gridButton1.HeaderText = "Actions";
                gridButton1.Name = "gridButtonLihat";
                gridButton1.Text = "Lihat";
                gridButton1.UseColumnTextForButtonValue = true;
                dataGridViewKontrak.Columns.Add(gridButton1);
            }
            if (dataGridViewKontrak.Columns.Contains("gridButtonTambahJadwal") != true)
            {
                //Grid Button for kontrak
                DataGridViewButtonColumn gridButton2 = new DataGridViewButtonColumn();
                gridButton2.HeaderText = "Actions";
                gridButton2.Name = "gridButtonTambahJadwal";
                gridButton2.Text = "Tambah Jadwal";
                gridButton2.UseColumnTextForButtonValue = true;
                dataGridViewKontrak.Columns.Add(gridButton2);
            }
        }

        private void dataGridViewKontrak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewKontrak.Columns["gridButtonLihat"].Index && e.RowIndex >= 0)
            {
                try
                {
                    Kontrak_kerja tmpKontrak = new Kontrak_kerja(
                        int.Parse(dataGridViewKontrak.CurrentRow.Cells["id"].Value.ToString()),
                        dataGridViewKontrak.CurrentRow.Cells["judul"].Value.ToString(),
                        dataGridViewKontrak.CurrentRow.Cells["pengaju"].Value.ToString(),
                        dataGridViewKontrak.CurrentRow.Cells["lokasi"].Value.ToString(),
                        dataGridViewKontrak.CurrentRow.Cells["deskripsi"].Value.ToString(),
                        DateTime.Parse(dataGridViewKontrak.CurrentRow.Cells["tglbuat"].Value.ToString()),
                        DateTime.Parse(dataGridViewKontrak.CurrentRow.Cells["tglacara"].Value.ToString()),
                        dataGridViewKontrak.CurrentRow.Cells["status"].Value.ToString(),
                        artis.Manager, artis);

                    FormDetailKontrak formDetailKontrak = new FormDetailKontrak();
                    formDetailKontrak.Owner = this;
                    formDetailKontrak.kontrak = tmpKontrak;
                    formDetailKontrak.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

            if (e.ColumnIndex == dataGridViewKontrak.Columns["gridButtonTambahJadwal"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Apakah anda mau menambahkan ke jadwal artis?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Kontrak_kerja tmpKontrak = new Kontrak_kerja(
                            int.Parse(dataGridViewKontrak.CurrentRow.Cells["id"].Value.ToString()),
                            dataGridViewKontrak.CurrentRow.Cells["judul"].Value.ToString(),
                            dataGridViewKontrak.CurrentRow.Cells["pengaju"].Value.ToString(),
                            dataGridViewKontrak.CurrentRow.Cells["lokasi"].Value.ToString(),
                            dataGridViewKontrak.CurrentRow.Cells["deskripsi"].Value.ToString(),
                            DateTime.Parse(dataGridViewKontrak.CurrentRow.Cells["tglbuat"].Value.ToString()),
                            DateTime.Parse(dataGridViewKontrak.CurrentRow.Cells["tglacara"].Value.ToString()),
                            dataGridViewKontrak.CurrentRow.Cells["status"].Value.ToString(),
                            artis.Manager, artis);

                        Kontrak_kerja.UpdateStatusKontrak(tmpKontrak, "terima");
                        MessageBox.Show("Kontrak berhasil ditambahkan ke jadwal artis");
                        FormDaftarKontrakPending_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }
    }
}
