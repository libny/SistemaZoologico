using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.Usuarios;
using SistemaZoologico.Dominio.Aplicacion.Usuarios.Commandos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Usuarios
{
    public partial class CreacionUsuarios : Form
    {
        private readonly ServicioUsuarios _servicioUsuarios = new ServicioUsuarios();

        public CreacionUsuarios()
        {
            InitializeComponent();
        }

        private void CreacionUsuarios_Load(object sender, EventArgs e)
        {
            comboRol.DataSource = _servicioUsuarios.ObtenerRoles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rol = (Rol) comboRol.SelectedItem;
            _servicioUsuarios.CrearUsuario(new CrearUsuario(textNombre.Text, textTelefono.Text, textContrasena.Text,
                textUsurio.Text, rol.Id));

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}