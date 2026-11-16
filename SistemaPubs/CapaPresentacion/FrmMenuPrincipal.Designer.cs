namespace SistemaPubs.CapaPresentacion
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTablas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPublishers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTitles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTitleAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoysched = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiscounts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPubInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuTablas, this.mnuSalir });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);

            this.mnuTablas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuAuthors, this.mnuPublishers, this.mnuTitles, this.mnuTitleAuthor,
                this.mnuStores, this.mnuSales, this.mnuRoysched, this.mnuDiscounts,
                this.mnuJobs, this.mnuPubInfo, this.mnuEmployee
            });
            this.mnuTablas.Name = "mnuTablas";
            this.mnuTablas.Text = "Mantenimiento de Tablas";

            this.mnuAuthors.Name = "mnuAuthors";
            this.mnuAuthors.Text = "Authors (Autores)";
            this.mnuPublishers.Name = "mnuPublishers";
            this.mnuPublishers.Text = "Publishers (Editoriales)";
            this.mnuTitles.Name = "mnuTitles";
            this.mnuTitles.Text = "Titles (Títulos)";
            this.mnuTitleAuthor.Name = "mnuTitleAuthor";
            this.mnuTitleAuthor.Text = "TitleAuthor (Título - Autor)";
            this.mnuStores.Name = "mnuStores";
            this.mnuStores.Text = "Stores (Tiendas)";
            this.mnuSales.Name = "mnuSales";
            this.mnuSales.Text = "Sales (Ventas)";
            this.mnuRoysched.Name = "mnuRoysched";
            this.mnuRoysched.Text = "Roysched (Regalías)";
            this.mnuDiscounts.Name = "mnuDiscounts";
            this.mnuDiscounts.Text = "Discounts (Descuentos)";
            this.mnuJobs.Name = "mnuJobs";
            this.mnuJobs.Text = "Jobs (Cargos)";
            this.mnuPubInfo.Name = "mnuPubInfo";
            this.mnuPubInfo.Text = "PubInfo (Info Editorial)";
            this.mnuEmployee.Name = "mnuEmployee";
            this.mnuEmployee.Text = "Employee (Empleados)";

            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Text = "Cerrar Sesión / Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);

            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión - Base de Datos Pubs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTablas;
        private System.Windows.Forms.ToolStripMenuItem mnuAuthors;
        private System.Windows.Forms.ToolStripMenuItem mnuPublishers;
        private System.Windows.Forms.ToolStripMenuItem mnuTitles;
        private System.Windows.Forms.ToolStripMenuItem mnuTitleAuthor;
        private System.Windows.Forms.ToolStripMenuItem mnuStores;
        private System.Windows.Forms.ToolStripMenuItem mnuSales;
        private System.Windows.Forms.ToolStripMenuItem mnuRoysched;
        private System.Windows.Forms.ToolStripMenuItem mnuDiscounts;
        private System.Windows.Forms.ToolStripMenuItem mnuJobs;
        private System.Windows.Forms.ToolStripMenuItem mnuPubInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}