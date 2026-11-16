namespace SistemaPubs.CapaPresentacion
{
    partial class FrmAuthors
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.chkContrato = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.SuspendLayout();

            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.lblId.Text = "ID Autor:";
            this.txtId.Location = new System.Drawing.Point(100, 17);
            this.txtId.Size = new System.Drawing.Size(140, 23);

            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 55);
            this.lblApellido.Text = "Apellido:";
            this.txtApellido.Location = new System.Drawing.Point(100, 52);
            this.txtApellido.Size = new System.Drawing.Size(140, 23);

            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 90);
            this.lblNombre.Text = "Nombre:";
            this.txtNombre.Location = new System.Drawing.Point(100, 87);
            this.txtNombre.Size = new System.Drawing.Size(140, 23);

            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(20, 125);
            this.lblTelefono.Text = "Teléfono:";
            this.txtTelefono.Location = new System.Drawing.Point(100, 122);
            this.txtTelefono.Size = new System.Drawing.Size(140, 23);

            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(270, 20);
            this.lblDireccion.Text = "Dirección:";
            this.txtDireccion.Location = new System.Drawing.Point(350, 17);
            this.txtDireccion.Size = new System.Drawing.Size(180, 23);

            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(270, 55);
            this.lblCiudad.Text = "Ciudad:";
            this.txtCiudad.Location = new System.Drawing.Point(350, 52);
            this.txtCiudad.Size = new System.Drawing.Size(180, 23);

            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(270, 90);
            this.lblEstado.Text = "Estado:";
            this.txtEstado.Location = new System.Drawing.Point(350, 87);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Size = new System.Drawing.Size(60, 23);

            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(270, 125);
            this.lblZip.Text = "Cód. Postal:";
            this.txtZip.Location = new System.Drawing.Point(350, 122);
            this.txtZip.MaxLength = 5;
            this.txtZip.Size = new System.Drawing.Size(80, 23);

            this.chkContrato.AutoSize = true;
            this.chkContrato.Location = new System.Drawing.Point(450, 124);
            this.chkContrato.Text = "Contrato";

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

            this.dgvAuthors.AllowUserToAddRows = false;
            this.dgvAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthors.Location = new System.Drawing.Point(20, 170);
            this.dgvAuthors.ReadOnly = true;
            this.dgvAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthors.Size = new System.Drawing.Size(780, 250);
            this.dgvAuthors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthors_CellClick);

            this.ClientSize = new System.Drawing.Size(820, 440);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblId, this.txtId, this.lblApellido, this.txtApellido,
                this.lblNombre, this.txtNombre, this.lblTelefono, this.txtTelefono,
                this.lblDireccion, this.txtDireccion, this.lblCiudad, this.txtCiudad,
                this.lblEstado, this.txtEstado, this.lblZip, this.txtZip,
                this.chkContrato, this.btnGuardar, this.btnActualizar,
                this.btnEliminar, this.btnLimpiar, this.dgvAuthors
            });
            this.Name = "FrmAuthors";
            this.Text = "Mantenimiento de Autores (Authors)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblId, lblApellido, lblNombre, lblTelefono, lblDireccion, lblCiudad, lblEstado, lblZip;
        private System.Windows.Forms.TextBox txtId, txtApellido, txtNombre, txtTelefono, txtDireccion, txtCiudad, txtEstado, txtZip;
        private System.Windows.Forms.CheckBox chkContrato;
        private System.Windows.Forms.Button btnGuardar, btnActualizar, btnEliminar, btnLimpiar;
        private System.Windows.Forms.DataGridView dgvAuthors;
    }
}