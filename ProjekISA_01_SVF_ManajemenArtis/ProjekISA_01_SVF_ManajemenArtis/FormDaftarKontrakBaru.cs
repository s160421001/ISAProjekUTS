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
    public partial class FormDaftarKontrakBaru : Form
    {
        public Artis artis;
        public Manager manager;
        public FormDaftarKontrakBaru()
        {
            InitializeComponent();
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
            
            if (e.ColumnIndex == dataGridViewKontrak.Columns["gridButtonEdit"].Index && e.RowIndex >= 0)
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

                    FormDetailKontrakEdit formDetailKontrakEdit = new FormDetailKontrakEdit();
                    formDetailKontrakEdit.Owner = this;
                    formDetailKontrakEdit.kontrak = tmpKontrak;
                    formDetailKontrakEdit.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

            if (e.ColumnIndex == dataGridViewKontrak.Columns["gridButtonTerima"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Apakah anda mau menerima kontrak ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                        Kontrak_kerja.UpdateStatusKontrak(tmpKontrak, "proses");
                        MessageBox.Show("Kontrak diterima");
                        FormDaftarKontrak_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }

            if (e.ColumnIndex == dataGridViewKontrak.Columns["gridButtonTolak"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Apakah anda mau menolak kontrak ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                        Kontrak_kerja.UpdateStatusKontrak(tmpKontrak, "tolak");
                        MessageBox.Show("Kontrak ditolak");
                        FormDaftarKontrak_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }

        public void FormDaftarKontrak_Load(object sender, EventArgs e)
        {
            List<Kontrak_kerja> list = new List<Kontrak_kerja>();
            if (artis != null)
            {
                list = Kontrak_kerja.BacaDataSpesifikArtis(artis.Id);
            }
            else if (manager != null)
            {
                artis = new Artis();
                if (manager.Title == jabatan.superAdmin)
                {
                    list = Kontrak_kerja.BacaData("k.status_artis", "kosong");
                    //list = list.OrderBy(k => k.Judul).ToList();
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
            if (dataGridViewKontrak.Columns.Contains("gridButtonEdit") != true)
            {
                //Grid Button for kontrak
                DataGridViewButtonColumn gridButton2 = new DataGridViewButtonColumn();
                gridButton2.HeaderText = "Actions";
                gridButton2.Name = "gridButtonEdit";
                gridButton2.Text = "Edit";
                gridButton2.UseColumnTextForButtonValue = true;
                dataGridViewKontrak.Columns.Add(gridButton2);
            }
            if (dataGridViewKontrak.Columns.Contains("gridButtonTerima") != true)
            {
                //Grid Button for kontrak
                DataGridViewButtonColumn gridButton3 = new DataGridViewButtonColumn();
                gridButton3.HeaderText = "Actions";
                gridButton3.Name = "gridButtonTerima";
                gridButton3.Text = "Terima";
                gridButton3.UseColumnTextForButtonValue = true;
                dataGridViewKontrak.Columns.Add(gridButton3);
            }
            if (dataGridViewKontrak.Columns.Contains("gridButtonTolak") != true)
            {
                //Grid Button for kontrak
                DataGridViewButtonColumn gridButton4 = new DataGridViewButtonColumn();
                gridButton4.HeaderText = "Actions";
                gridButton4.Name = "gridButtonTolak";
                gridButton4.Text = "Tolak";
                gridButton4.UseColumnTextForButtonValue = true;
                dataGridViewKontrak.Columns.Add(gridButton4);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
