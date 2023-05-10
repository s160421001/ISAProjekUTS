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
    public partial class FormTambahKontrak : Form
    {
        public Manager manager = new Manager();
        public Artis artis = new Artis();
        private List<Artis> listArtis = new List<Artis>();

        public FormTambahKontrak()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Kontrak_kerja tmp = new Kontrak_kerja(0,
                    textBoxJudul.Text,
                    textBoxPengaju.Text,
                    textBoxLokasi.Text,
                    textBoxIsi.Text,
                    DateTime.Now,
                    dateTimePickerAcara.Value,
                    "kosong", 
                    manager,
                    artis
                    );

                if (MessageBox.Show("Apakah anda yakin menambah kontrak?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Kontrak_kerja.TambahKontrak(tmp))
                    {
                        MessageBox.Show("kontrak telah berhasil disimpan", "Information");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void FormTambahKontrak_Load(object sender, EventArgs e)
        {
            listArtis = Artis.BacaData("a.manajer_id", manager.Id.ToString());
            comboBoxArtis.DataSource = listArtis;
            comboBoxArtis.DisplayMember = "nama"; 
            comboBoxArtis.SelectedIndex = 0;            
        }

        private void comboBoxArtis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArtis.SelectedItem != null)
            {
                artis = (Artis)comboBoxArtis.SelectedItem;
            }
        }
    }
}
