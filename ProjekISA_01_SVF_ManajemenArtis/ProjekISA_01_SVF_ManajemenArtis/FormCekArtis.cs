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
        public Manager manager = new Manager();

        private void FormCekArtis_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            if (manager.Title == jabatan.biasa)
            {
                listArtis = Artis.BacaData("a.status_manajer", "kosong");
            }
            else if (manager.Title == jabatan.superAdmin)
            {
                listArtis = Artis.BacaData("", "");
            }

            dataGridViewArtis.Rows.Clear();

            if (listArtis != null && listArtis.Count > 0)
            {
                foreach (Artis a in listArtis)
                {
                    dataGridViewArtis.Rows.Add(a.Id, a.Nama, a.Tanggal_lahir, a.Tanggal_masuk, a.Username, a.Status, a.Manager.Nama);
                    {
                        if (dataGridViewArtis.ColumnCount > 6)
                        {
                            CreateGridButtons();
                        }
                    }
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
                //Grid Button for kontrak
                DataGridViewButtonColumn gridButton1 = new DataGridViewButtonColumn();
                gridButton1.HeaderText = "Actions";
                gridButton1.Name = "gridButtonKontrak";
                gridButton1.Text = "Kontrak";
                gridButton1.UseColumnTextForButtonValue = true;
                dataGridViewArtis.Columns.Add(gridButton1);
            }
        }

        private void FormatDataGrid()
        {
            //kosongi semua kolom di datagrid
            dataGridViewArtis.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewArtis.Columns.Add("id", "Id");
            dataGridViewArtis.Columns.Add("nama", "Nama");
            dataGridViewArtis.Columns.Add("tanggal_lahir", "Tanggal Lahir");
            dataGridViewArtis.Columns.Add("tanggal_masuk", "Tanggal Masuk");
            dataGridViewArtis.Columns.Add("username", "Username");
            dataGridViewArtis.Columns.Add("status_manajer", "Status Manager");
            dataGridViewArtis.Columns.Add("manajer_id", "Manager");

            //agar lebar kolom dapat emnyesuaikan panjang/isi data
            dataGridViewArtis.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewArtis.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewArtis.Columns["tanggal_lahir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewArtis.Columns["tanggal_masuk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewArtis.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewArtis.Columns["status_manajer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewArtis.Columns["manajer_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di dgv
            dataGridViewArtis.AllowUserToAddRows = false;
            dataGridViewArtis.ReadOnly = true;
            dataGridViewArtis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewArtis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewArtis.Columns["gridButtonKontrak"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Apakah anda mau mengkontrak artis ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Artis tmpArtis = new Artis(
                            int.Parse(dataGridViewArtis.CurrentRow.Cells["id"].Value.ToString()),
                            dataGridViewArtis.CurrentRow.Cells["nama"].Value.ToString(),
                            DateTime.Parse(dataGridViewArtis.CurrentRow.Cells["tanggal_lahir"].Value.ToString()),
                            DateTime.Parse(dataGridViewArtis.CurrentRow.Cells["tanggal_masuk"].Value.ToString()),
                            dataGridViewArtis.CurrentRow.Cells["username"].Value.ToString(),
                            "",
                            Artis.status_manajer.aktif,
                            manager);

                        Artis.KontrakArtis(tmpArtis, manager.Id);
                        MessageBox.Show("Artis berhasil dikontrak, Silahkan login ulang untuk membuka akses lainnya", "Informasi");

                        FormCekArtis_Load(sender, e);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

