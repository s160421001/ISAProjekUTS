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
    public partial class FormDaftarKontrakTertolak : Form
    {
        public FormDaftarKontrakTertolak()
        {
            InitializeComponent();
        }
        public Artis artis;
        public Manager manager;
        private void FormDaftarKontrakTertolak_Load(object sender, EventArgs e)
        {
            List<Kontrak_kerja> list = new List<Kontrak_kerja>();
            if (artis != null)
            {
                list = Kontrak_kerja.BacaDataSpesifikKontrakTertolakArtis(artis.Id);
            }
            else if (manager != null)
            {
                artis = new Artis();
                if (manager.Title == jabatan.biasa)
                {
                    list = Kontrak_kerja.BacaDataSpesifikKontrakTertolakManajer(manager.Id);
                }
                else
                {
                    list = Kontrak_kerja.BacaData("k.status_artis", "tolak");
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
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
