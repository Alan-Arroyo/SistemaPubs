using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaPubs.CapaDatos;

namespace SistemaPubs.CapaPresentacion
{
    public partial class FrmAuthors : Form
    {
        private ConexionBD conexion = new ConexionBD();

        public FrmAuthors()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                string query = "SELECT * FROM authors";
                dgvAuthors.DataSource = conexion.EjecutarConsulta(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtEstado.Clear();
            txtZip.Clear();
            chkContrato.Checked = false;
            txtId.Enabled = true;
            txtId.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO authors (au_id, au_lname, au_fname, phone, address, city, state, zip, contract) " +
                               "VALUES (@id, @lname, @fname, @phone, @address, @city, @state, @zip, @contract)";

                MySqlParameter[] parametros = {
                    new MySqlParameter("@id", txtId.Text.Trim()),
                    new MySqlParameter("@lname", txtApellido.Text.Trim()),
                    new MySqlParameter("@fname", txtNombre.Text.Trim()),
                    new MySqlParameter("@phone", txtTelefono.Text.Trim()),
                    new MySqlParameter("@address", txtDireccion.Text.Trim()),
                    new MySqlParameter("@city", txtCiudad.Text.Trim()),
                    new MySqlParameter("@state", txtEstado.Text.Trim()),
                    new MySqlParameter("@zip", txtZip.Text.Trim()),
                    new MySqlParameter("@contract", chkContrato.Checked ? 1 : 0)
                };

                conexion.EjecutarComando(query, parametros);
                MessageBox.Show("Autor guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE authors SET au_lname=@lname, au_fname=@fname, phone=@phone, address=@address, " +
                               "city=@city, state=@state, zip=@zip, contract=@contract WHERE au_id=@id";

                MySqlParameter[] parametros = {
                    new MySqlParameter("@id", txtId.Text.Trim()),
                    new MySqlParameter("@lname", txtApellido.Text.Trim()),
                    new MySqlParameter("@fname", txtNombre.Text.Trim()),
                    new MySqlParameter("@phone", txtTelefono.Text.Trim()),
                    new MySqlParameter("@address", txtDireccion.Text.Trim()),
                    new MySqlParameter("@city", txtCiudad.Text.Trim()),
                    new MySqlParameter("@state", txtEstado.Text.Trim()),
                    new MySqlParameter("@zip", txtZip.Text.Trim()),
                    new MySqlParameter("@contract", chkContrato.Checked ? 1 : 0)
                };

                conexion.EjecutarComando(query, parametros);
                MessageBox.Show("Autor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)) return;

            if (MessageBox.Show("¿Desea eliminar este autor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM authors WHERE au_id=@id";
                    MySqlParameter[] parametros = { new MySqlParameter("@id", txtId.Text.Trim()) };

                    conexion.EjecutarComando(query, parametros);
                    MessageBox.Show("Autor eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvAuthors.Rows[e.RowIndex];
                txtId.Text = fila.Cells["au_id"].Value.ToString();
                txtApellido.Text = fila.Cells["au_lname"].Value.ToString();
                txtNombre.Text = fila.Cells["au_fname"].Value.ToString();
                txtTelefono.Text = fila.Cells["phone"].Value.ToString();
                txtDireccion.Text = fila.Cells["address"].Value.ToString();
                txtCiudad.Text = fila.Cells["city"].Value.ToString();
                txtEstado.Text = fila.Cells["state"].Value.ToString();
                txtZip.Text = fila.Cells["zip"].Value.ToString();
                chkContrato.Checked = Convert.ToBoolean(fila.Cells["contract"].Value);
                txtId.Enabled = false;
            }
        }
    }
}