using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.Animales;
using SistemaZoologico.Dominio.Aplicacion.Animales.Comandos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Animales
{
    public partial class CreacionAnimales : Form
    {
        private readonly ServiciosAnimales serviciosAnimales = new ServiciosAnimales();

        public CreacionAnimales()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var especie = (Especie) combEspecie.SelectedItem;
            Origen origen = null;

            if (radioCautiverio.Checked)
                origen = Origen.Cautiverio;
            else
            {
                origen = Origen.Salvaje;
            }
            serviciosAnimales.CrearAnimal(new Crearanimales(textNombre.Text, Convert.ToInt32(numEdad.Value),
                dateFechaIn.Value, dateFechaNa.Value, origen, especie.Id));

            Close();
        }

        private void CreacionAnimales_Load(object sender, EventArgs e)
        {
            combEspecie.DataSource = serviciosAnimales.ObtenerEspecies();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}