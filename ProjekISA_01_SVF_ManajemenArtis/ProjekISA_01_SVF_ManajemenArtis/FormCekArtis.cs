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
    public partial class FormCekArtis : Form
    {
        public FormCekArtis()
        {
            InitializeComponent();
        }
        public List<Artis> listArtis = new List<Artis>();

        private void FormCekArtis_Load(object sender, EventArgs e)
        {
            //tampilkan semua data user
            listArtis = Artis.BacaData("", "");
            dataGridViewArtis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (listArtis != null && listArtis.Count > 0)
            {
                dataGridViewArtis.DataSource = listArtis;
                if (dataGridViewArtis.ColumnCount > 1)
                {
                    CreateGridButtons();
                }
            }
            else
            {
                dataGridViewArtis.DataSource = null;
            }
        }

        private void CreateGridButtons()
        {
            if (dataGridViewArtis.Columns.Contains("gridButtonKontrak") != true)
            {
                //Grid Button for Update
                DataGridViewButtonColumn gridButton1 = new DataGridViewButtonColumn();
                gridButton1.HeaderText = "Actions";
                gridButton1.Name = "gridButtonKontrak";
                gridButton1.Text = "Kontrak";
                gridButton1.UseColumnTextForButtonValue = true;
                dataGridViewArtis.Columns.Add(gridButton1);
            }
        }

        private void dataGridViewArtis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewArtis.Columns["gridButtonKontrak"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Apakah anda mau mengkontrak artis ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        List<Artis> tmpArtis = Film.BacaData("judul_film",
                            dataGridViewTiket.CurrentRow.Cells["film"].Value.ToString());

                        string statusManajer = "aktif";

                        Tiket tmpTiket = new Tiket(
                            int.Parse(dataGridViewTiket.CurrentRow.Cells["id"].Value.ToString()),
                            DateTime.Parse(dataGridViewTiket.CurrentRow.Cells["tgl_beli"].Value.ToString()),
                            int.Parse(dataGridViewTiket.CurrentRow.Cells["slot_jadwal"].Value.ToString()),
                            int.Parse(dataGridViewTiket.CurrentRow.Cells["no_kursi"].Value.ToString()),
                            int.Parse(dataGridViewTiket.CurrentRow.Cells["ruang_bioskop"].Value.ToString()),
                            tmpFilm[0], pengguna, statusTiket);

                        Tiket.KonfrimasiTiket(tmpTiket);
                        MessageBox.Show("Tiket telah terkonfirmasi.");

                        FormKonfirmTiket_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
        }
    }
}
