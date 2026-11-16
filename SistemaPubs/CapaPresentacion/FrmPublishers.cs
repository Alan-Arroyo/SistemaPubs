using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaPubs.CapaDatos;

namespace SistemaPubs.CapaPresentacion
{
    public partial class FrmPublishers : Form
    {
        private ConexionBD conexion = new ConexionBD();

        public FrmPublishers()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                string query = "SELECT * FROM publishers";
                dgvPublishers.DataSource = conexion.EjecutarConsulta(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCiudad.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtId.Enabled = true;
            txtId.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO publishers (pub_id, pub_name, city, state, country) " +
                               "VALUES (@id, @name, @city, @state, @country)";

                MySqlParameter[] parametros = {
                    new MySqlParameter("@id", txtId.Text.Trim()),
                    new MySqlParameter("@name", txtNombre.Text.Trim()),
                    new MySqlParameter("@city", txtCiudad.Text.Trim()),
                    new MySqlParameter("@state", string.IsNullOrWhiteSpace(txtEstado.Text) ? (object)DBNull.Value : txtEstado.Text.Trim()),
                    new MySqlParameter("@country", txtPais.Text.Trim())
                };

                conexion.EjecutarComando(query, parametros);
                MessageBox.Show("Editorial guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "UPDATE publishers SET pub_name=@name, city=@city, state=@state, country=@country WHERE pub_id=@id";

                MySqlParameter[] parametros = {
                    new MySqlParameter("@id", txtId.Text.Trim()),
                    new MySqlParameter("@name", txtNombre.Text.Trim()),
                    new MySqlParameter("@city", txtCiudad.Text.Trim()),
                    new MySqlParameter("@state", string.IsNullOrWhiteSpace(txtEstado.Text) ? (object)DBNull.Value : txtEstado.Text.Trim()),
                    new MySqlParameter("@country", txtPais.Text.Trim())
                };

                conexion.EjecutarComando(query, parametros);
                MessageBox.Show("Editorial actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (MessageBox.Show("¿Desea eliminar esta editorial?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM publishers WHERE pub_id=@id";
                    MySqlParameter[] parametros = { new MySqlParameter("@id", txtId.Text.Trim()) };

                    conexion.EjecutarComando(query, parametros);
                    MessageBox.Show("Editorial eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvPublishers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPublishers.Rows[e.RowIndex];
                txtId.Text = fila.Cells["pub_id"].Value.ToString();
                txtNombre.Text = fila.Cells["pub_name"].Value.ToString();
                txtCiudad.Text = fila.Cells["city"].Value.ToString();
                txtEstado.Text = fila.Cells["state"].Value?.ToString() ?? "";
                txtPais.Text = fila.Cells["country"].Value.ToString();
                txtId.Enabled = false;
            }
        }
    }
}