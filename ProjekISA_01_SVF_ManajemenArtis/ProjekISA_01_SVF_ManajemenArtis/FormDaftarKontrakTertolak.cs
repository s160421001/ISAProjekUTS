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
        public Artis artis = new Artis();
        public Manager manager = new Manager();
        private void FormDaftarKontrakTertolak_Load(object sender, EventArgs e)
        {
            List<Kontrak_kerja> list = new List<Kontrak_kerja>();
            if (artis != null)
            {
                list = Kontrak_kerja.BacaDataSpesifikKontrakTertolakArtis(artis.Id);
            }
            else if (manager != null)
            {
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
            }
            else
            {
                dataGridViewKontrak.DataSource = null;
            }
        }
    }
}
