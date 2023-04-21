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
    public partial class FormMenu : Form
    {
        public Artis artis;
        public Manager manager;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            if(artis != null)
            {
                labelNama.Text = artis.Nama;
                labelManager.Text = artis.Manager.Nama;
            }
            else
            {
                labelNama.Text = manager.Nama;
                label2.Visible = false;
                labelManager.Visible = false;
            }
            CekAccessControl();

        }

        private void CekAccessControl()
        {
            if (manager != null)
            {
                if (manager.Title == jabatan.biasa)
                {
                    homeToolStripMenuItem.Visible = true;

                    List<Artis> listArtis = new List<Artis>();
                    listArtis = Artis.BacaData("", "");

                    foreach(Artis a in listArtis)
                    {
                        if(a.Manager.Id == manager.Id)
                        {
                            kontrakToolStripMenuItem.Visible = true;
                            tambahKontrakToolStripMenuItem.Visible = true;
                            jadwalToolStripMenuItem.Visible = true;
                            manajemenToolStripMenuItem.Visible = true;
                            cekArtisToolStripMenuItem.Visible = true;
                            pesanMasukToolStripMenuItem.Visible = true;
                            break;
                        }
                        else
                        {
                            manajemenToolStripMenuItem.Visible = true;
                            cekArtisToolStripMenuItem.Visible = true;
                        }
                    }
                }
                else if (manager.Title == jabatan.superAdmin)
                {
                    homeToolStripMenuItem.Visible = true;
                    kontrakToolStripMenuItem.Visible = true;
                    tambahKontrakToolStripMenuItem.Visible = true;
                    jadwalToolStripMenuItem.Visible = true;
                    manajemenToolStripMenuItem.Visible = true;
                    pesanMasukToolStripMenuItem.Visible = true;
                    cekArtisToolStripMenuItem.Visible = true;
                    cekManajerToolStripMenuItem.Visible = true;
                }
            }
            else
            {
                //kalau login sebagai artis
                homeToolStripMenuItem.Visible = true;
                if(artis.Manager.Id != 0)
                {
                    kontrakToolStripMenuItem.Visible = true;
                    jadwalToolStripMenuItem.Visible = true;
                    manajemenToolStripMenuItem.Visible = true;
                    pesanMasukToolStripMenuItem.Visible = true;
                    cekManajerToolStripMenuItem.Visible = true;
                }
                else
                {
                    manajemenToolStripMenuItem.Visible = true;
                    cekManajerToolStripMenuItem.Visible = true;
                }
            }
        }

        private void cekArtisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormCekArtis"];
            if (form == null)
            {
                FormCekArtis formCekArtis = new FormCekArtis();
                formCekArtis.MdiParent = this;
                formCekArtis.manager = manager;
                formCekArtis.Show();
                
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void cekKontrakToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cekManajerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormCekManajer"];
            if (form == null)
            {
                FormCekManajer formCekManajer = new FormCekManajer();
                formCekManajer.MdiParent = this;
                formCekManajer.manager = manager;
                formCekManajer.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
} 
