using System;
using System.Windows.Forms;
using SistemaPubs.CapaPresentacion;

namespace SistemaPubs
{
    public partial class FrmLogin : Form
    {
        private int intentosFallidos = 0;
        private const int MAX_INTENTOS = 3;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (usuario == "admin" && clave == "1234")
            {
                MessageBox.Show("Bienvenido al sistema.", "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                intentosFallidos++;
                int restantes = MAX_INTENTOS - intentosFallidos;

                if (intentosFallidos >= MAX_INTENTOS)
                {
                    MessageBox.Show("Superó los 3 intentos permitidos. El programa se cerrará.",
                                    "Acceso Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    lblIntentos.Text = $"Intentos restantes: {restantes}";
                    MessageBox.Show($"Datos incorrectos. Le quedan {restantes} intento(s).",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Clear();
                    txtClave.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}