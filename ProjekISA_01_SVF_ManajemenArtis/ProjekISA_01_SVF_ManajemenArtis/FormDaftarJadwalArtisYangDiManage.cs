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
    public partial class FormDaftarJadwalArtisYangDiManage : Form
    {
        public Artis artis;
        public Manager manager;
        private List<Artis> listArtis = new List<Artis>();
        List<Kontrak_kerja> list = new List<Kontrak_kerja>();
        public FormDaftarJadwalArtisYangDiManage()
        {
            InitializeComponent();
        }

        private void FormDaftarJadwalArtisYangDiManage_Load(object sender, EventArgs e)
        {
            if (manager != null)
            {
                artis = new Artis();
                if (manager.Title == jabatan.biasa)
                {
                    listArtis = Artis.BacaData("a.manajer_id", manager.Id.ToString());
                    comboBoxArtis.DataSource = listArtis;
                    comboBoxArtis.DisplayMember = "nama";
                    comboBoxArtis.SelectedIndex = 0;
                }
                else
                {
                    comboBoxArtis.Enabled = false;
                    list = Kontrak_kerja.BacaData("k.status_artis", "terima");

                    if (list.Count > 0)
                    {
                        dataGridViewJadwal.DataSource = list;
                        if (dataGridViewJadwal.ColumnCount > 8)
                        {
                            CreateGridButtons();
                        }
                    }
                    else
                    {
                        dataGridViewJadwal.DataSource = null;
                    }
                }
            }

            dataGridViewJadwal.AllowUserToAddRows = false;
            dataGridViewJadwal.ReadOnly = true;
            dataGridViewJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void comboBoxArtis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArtis.SelectedItem != null)
            {
                artis = (Artis)comboBoxArtis.SelectedItem;

                list = Kontrak_kerja.BacaDataSpesifikKontrakTerimaArtis(artis.Id);

                if (list.Count > 0)
                {
                    dataGridViewJadwal.DataSource = list;
                    if (dataGridViewJadwal.ColumnCount > 8)
                    {
                        CreateGridButtons();
                    }
                }
                else
                {
                    dataGridViewJadwal.DataSource = null;
                }

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }

            dataGridViewJadwal.AllowUserToAddRows = false;
            dataGridViewJadwal.ReadOnly = true;
            dataGridViewJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CreateGridButtons()
        {
            if (dataGridViewJadwal.Columns.Contains("gridButtonLihat") != true)
            {
                //Grid Button for kontrak
                DataGridViewButtonColumn gridButton1 = new DataGridViewButtonColumn();
                gridButton1.HeaderText = "Actions";
                gridButton1.Name = "gridButtonLihat";
                gridButton1.Text = "Lihat";
                gridButton1.UseColumnTextForButtonValue = true;
                dataGridViewJadwal.Columns.Add(gridButton1);
            }
            if (dataGridViewJadwal.Columns.Contains("gridButtonCetak") != true)
            {
                //Grid Button for kontrak
                DataGridViewButtonColumn gridButton1 = new DataGridViewButtonColumn();
                gridButton1.HeaderText = "Actions";
                gridButton1.Name = "gridButtonCetak";
                gridButton1.Text = "Lihat";
                gridButton1.UseColumnTextForButtonValue = true;
                dataGridViewJadwal.Columns.Add(gridButton1);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            List<Kontrak_kerja> list = new List<Kontrak_kerja>();
            if(manager.Title == jabatan.biasa)
            {
                list = Kontrak_kerja.BacaDataSpesifikKontrakTerimaArtis(artis.Id);
            }
            else
            {
                list = Kontrak_kerja.BacaData("k.status_artis", "terima");
            }
            
            list = list.OrderBy(k => k.TglAcara).ToList();

            if (list.Count > 0)
            {
                dataGridViewJadwal.DataSource = list;
                if (dataGridViewJadwal.ColumnCount > 8)
                {
                    CreateGridButtons();
                }
            }
            else
            {
                dataGridViewJadwal.DataSource = null;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            List<Kontrak_kerja> list = new List<Kontrak_kerja>();
            if (manager.Title == jabatan.biasa)
            {
                list = Kontrak_kerja.BacaDataSpesifikKontrakTerimaArtis(artis.Id);
            }
            else
            {
                list = Kontrak_kerja.BacaData("k.status_artis", "terima");
            }
            list = list.OrderBy(k => k.TglBuat).ToList();

            if (list.Count > 0)
            {
                dataGridViewJadwal.DataSource = list;
                if (dataGridViewJadwal.ColumnCount > 8)
                {
                    CreateGridButtons();
                }
            }
            else
            {
                dataGridViewJadwal.DataSource = null;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            List<Kontrak_kerja> list = new List<Kontrak_kerja>();
            if (manager.Title == jabatan.biasa)
            {
                list = Kontrak_kerja.BacaDataSpesifikKontrakTerimaArtis(artis.Id);
            }
            else
            {
                list = Kontrak_kerja.BacaData("k.status_artis", "terima");
            }
            list = list.OrderBy(k => k.Judul).ToList();

            if (list.Count > 0)
            {
                dataGridViewJadwal.DataSource = list;
                if (dataGridViewJadwal.ColumnCount > 8)
                {
                    CreateGridButtons();
                }
            }
            else
            {
                dataGridViewJadwal.DataSource = null;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            List<Kontrak_kerja> list = new List<Kontrak_kerja>();
            if (manager.Title == jabatan.biasa)
            {
                list = Kontrak_kerja.BacaDataSpesifikKontrakTerimaArtis(artis.Id);
            }
            else
            {
                list = Kontrak_kerja.BacaData("k.status_artis", "terima");
            }
            list = list.OrderByDescending(k => k.Judul).ToList();

            if (list.Count > 0)
            {
                dataGridViewJadwal.DataSource = list;
                if (dataGridViewJadwal.ColumnCount > 8)
                {
                    CreateGridButtons();
                }
            }
            else
            {
                dataGridViewJadwal.DataSource = null;
            }
        }

        private void dataGridViewJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewJadwal.Columns["gridButtonLihat"].Index && e.RowIndex >= 0)
            {
                try
                {
                    Kontrak_kerja tmpKontrak = new Kontrak_kerja(
                        int.Parse(dataGridViewJadwal.CurrentRow.Cells["id"].Value.ToString()),
                        dataGridViewJadwal.CurrentRow.Cells["judul"].Value.ToString(),
                        dataGridViewJadwal.CurrentRow.Cells["pengaju"].Value.ToString(),
                        dataGridViewJadwal.CurrentRow.Cells["lokasi"].Value.ToString(),
                        dataGridViewJadwal.CurrentRow.Cells["deskripsi"].Value.ToString(),
                        DateTime.Parse(dataGridViewJadwal.CurrentRow.Cells["tglbuat"].Value.ToString()),
                        DateTime.Parse(dataGridViewJadwal.CurrentRow.Cells["tglacara"].Value.ToString()),
                        dataGridViewJadwal.CurrentRow.Cells["status"].Value.ToString(),
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
        }
    }
}
