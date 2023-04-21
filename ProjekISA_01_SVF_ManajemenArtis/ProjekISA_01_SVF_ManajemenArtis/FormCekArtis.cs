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

        }

        //    if (e.ColumnIndex == dataGridViewArtis.Columns["gridButtonKontrak"].Index && e.RowIndex >= 0)
        //    {
        //        FormUpdateUser form = new FormUpdateUser();
        //        form.Owner = this;
        //        form.dataGrid = dataGridViewResults;
        //        form.objUpdate = new Pengguna();
        //        form.objUpdate.Nik = dataGridViewResults.CurrentRow.Cells["Nik"].Value.ToString();
        //        form.objUpdate.NamaDepan = dataGridViewResults.CurrentRow.Cells["Nama_depan"].Value.ToString();
        //        form.objUpdate.NamaKeluarga = dataGridViewResults.CurrentRow.Cells["Nama_keluarga"].Value.ToString();
        //        form.objUpdate.Alamat = dataGridViewResults.CurrentRow.Cells["Alamat"].Value.ToString();
        //        form.objUpdate.Email = dataGridViewResults.CurrentRow.Cells["Email"].Value.ToString();
        //        form.objUpdate.NoTelepon = dataGridViewResults.CurrentRow.Cells["No_telepon"].Value.ToString();
        //        //Password not included
        //        //Pin not included
        //        form.objUpdate.TanggalBuat = DateTime.Parse(dataGridViewResults.CurrentRow.Cells["Tgl_buat"].Value.ToString());
        //        form.objUpdate.TanggalUbah = DateTime.Parse(dataGridViewResults.CurrentRow.Cells["Tgl_perubahan"].Value.ToString());
        //        form.ShowDialog();
        //    }
    }
}
