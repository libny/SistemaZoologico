using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.Usuarios;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Usuarios
{
    public partial class IniciarSesion : Form
    {
        private readonly ServicioUsuarios _servicioUsuarios = new ServicioUsuarios();
        private Usuario _usario;

        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _usario = _servicioUsuarios.ObtenerUsuario(textContrasena.Text, textUsuario.Text);
            if (_usario !=null)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Error en el usuario y contrasena", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
        }

        public Usuario ObtenerUsuario()
        {
            ShowDialog();

            return _usario;
        }
    }
}