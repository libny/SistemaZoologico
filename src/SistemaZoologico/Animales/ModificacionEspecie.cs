using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.Animales;
using SistemaZoologico.Dominio.Aplicacion.Animales.Comandos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Animales
{
    public partial class ModificacionEspecie : Form
    {
        private readonly Especie _especie;
        private readonly ServiciosAnimales _serviciosAnimales = new ServiciosAnimales();

        public ModificacionEspecie(int idEspecie)
        {
            InitializeComponent();

            _especie = _serviciosAnimales.ObtenerEspecie(idEspecie);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var serviciosAnimales = new ServiciosAnimales();
            serviciosAnimales.ModificarEspecie(new ModificarEspecie(_especie.Id,textnombre.Text, textnombrecientifico.Text,
                textdescripcion.Text));

            Close();

        }

        private void ModificacionEspecie_Load(object sender, EventArgs e)
        {
            textdescripcion.Text = _especie.Descripcion;
            textnombre.Text = _especie.Nombre;
            textnombrecientifico.Text = _especie.NombreCientifico;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}