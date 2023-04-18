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

            FormLogin frmLogin = new FormLogin();
            frmLogin.Owner = this;
            try
            {              
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    //check artis atau manager
                    if (artis != null) labelNama.Text = artis.Nama;
                    else if (manager != null) labelNama.Text = manager.Nama;
                    CekAccessControl();
                }
                else
                {//jika login gagal
                    MessageBox.Show("Gagal Login");
                    Application.Exit();
                }
            }
            catch
            {
                this.Close();
            }
        }

        private void CekAccessControl()
        {
            if (manager != null)
            {
                if (manager.Title == jabatan.manager)
                {
                    homeToolStripMenuItem.Visible = true;
                    
                }
                else if (manager.Title == jabatan.superAdmin)
                {
                    homeToolStripMenuItem.Visible = true;
                }
            }
            else
            {
                //kalau login sebagai artis
                homeToolStripMenuItem.Visible = true;
            }
        }
    }
} 
