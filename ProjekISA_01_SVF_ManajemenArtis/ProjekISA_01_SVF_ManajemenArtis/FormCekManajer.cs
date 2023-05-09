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
    public partial class FormCekManajer : Form
    {
        public FormCekManajer()
        {
            InitializeComponent();
        }
        public List<Manager> listManager = new List<Manager>();
        public Manager manager = new Manager();
        private void FormCekManajer_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            if(manager != null)
            {
                listManager = Manager.BacaData("", "");
            }
            else
            {
                listManager = Manager.BacaDataKhususArtis();
            }
            
            dataGridViewManajer.Rows.Clear();

            if (listManager != null && listManager.Count > 0)
            {
                foreach (Manager m in listManager)
                {
                    dataGridViewManajer.Rows.Add(m.Id, m.Nama, m.TglLahir, m.TglMasuk, m.Username);
                }
            }
            else
            {
                dataGridViewManajer.DataSource = null;
            }
        }

        private void FormatDataGrid()
        {
            //kosongi semua kolom di datagrid
            dataGridViewManajer.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewManajer.Columns.Add("id", "Id");
            dataGridViewManajer.Columns.Add("nama", "Nama");
            dataGridViewManajer.Columns.Add("tanggal_lahir", "Tanggal Lahir");
            dataGridViewManajer.Columns.Add("tanggal_masuk", "Tanggal Masuk");
            dataGridViewManajer.Columns.Add("username", "Username");

            //agar lebar kolom dapat emnyesuaikan panjang/isi data
            dataGridViewManajer.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewManajer.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewManajer.Columns["tanggal_lahir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewManajer.Columns["tanggal_masuk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewManajer.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di dgv
            dataGridViewManajer.AllowUserToAddRows = false;
            dataGridViewManajer.ReadOnly = true;
            dataGridViewManajer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
