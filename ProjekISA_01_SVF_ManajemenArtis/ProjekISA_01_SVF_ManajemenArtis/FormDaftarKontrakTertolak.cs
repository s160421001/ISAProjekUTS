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

        }
    }
}
