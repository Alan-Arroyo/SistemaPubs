namespace SistemaPubs.CapaPresentacion
{
    partial class FrmPublishers
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvPublishers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).BeginInit();
            this.SuspendLayout();

            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.lblId.Text = "ID Editorial:";
            this.txtId.Location = new System.Drawing.Point(100, 17);
            this.txtId.MaxLength = 4;
            this.txtId.Size = new System.Drawing.Size(120, 23);

            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 55);
            this.lblNombre.Text = "Nombre:";
            this.txtNombre.Location = new System.Drawing.Point(100, 52);
            this.txtNombre.Size = new System.Drawing.Size(200, 23);

            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(20, 90);
            this.lblCiudad.Text = "Ciudad:";
            this.txtCiudad.Location = new System.Drawing.Point(100, 87);
            this.txtCiudad.Size = new System.Drawing.Size(200, 23);

            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(330, 20);
            this.lblEstado.Text = "Estado:";
            this.txtEstado.Location = new System.Drawing.Point(390, 17);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Size = new System.Drawing.Size(60, 23);

            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(330, 55);
            this.lblPais.Text = "País:";
            this.txtPais.Location = new System.Drawing.Point(390, 52);
            this.txtPais.Size = new System.Drawing.Size(140, 23);

            this.btnGuardar.Location = new System.Drawing.Point(560, 17);
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnActualizar.Location = new System.Drawing.Point(560, 52);
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnEliminar.Location = new System.Drawing.Point(560, 87);
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            this.btnLimpiar.Location = new System.Drawing.Point(560, 122);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.dgvPublishers.AllowUserToAddRows = false;
            this.dgvPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublishers.Location = new System.Drawing.Point(20, 165);
            this.dgvPublishers.ReadOnly = true;
            this.dgvPublishers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublishers.Size = new System.Drawing.Size(640, 230);
            this.dgvPublishers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublishers_CellClick);

            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblId, this.txtId, this.lblNombre, this.txtNombre,
                this.lblCiudad, this.txtCiudad, this.lblEstado, this.txtEstado,
                this.lblPais, this.txtPais, this.btnGuardar, this.btnActualizar,
                this.btnEliminar, this.btnLimpiar, this.dgvPublishers
            });
            this.Name = "FrmPublishers";
            this.Text = "Mantenimiento de Editoriales (Publishers)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblId, lblNombre, lblCiudad, lblEstado, lblPais;
        private System.Windows.Forms.TextBox txtId, txtNombre, txtCiudad, txtEstado, txtPais;
        private System.Windows.Forms.Button btnGuardar, btnActualizar, btnEliminar, btnLimpiar;
        private System.Windows.Forms.DataGridView dgvPublishers;
    }
}