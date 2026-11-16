using System;
using System.Windows.Forms;

namespace SistemaPubs.CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();

            // Aquí conectamos los clics del menú con sus respectivos formularios
            this.mnuAuthors.Click += new EventHandler(this.mnuAuthors_Click);
            this.mnuPublishers.Click += new EventHandler(this.mnuPublishers_Click);
            this.mnuTitles.Click += new EventHandler(this.mnuTitles_Click);
        }

        private void mnuAuthors_Click(object sender, EventArgs e)
        {
            FrmAuthors frm = new FrmAuthors();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuPublishers_Click(object sender, EventArgs e)
        {
            FrmPublishers frm = new FrmPublishers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTitles_Click(object sender, EventArgs e)
        {
            FrmTitles frm = new FrmTitles();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}