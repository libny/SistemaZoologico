using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.Animales;
using SistemaZoologico.Dominio.Aplicacion.Animales.Comandos;

namespace SistemaZoologico.Animales
{
    public partial class CrearEspecie : Form
    {
        public CrearEspecie()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var serviciosAnimales = new ServiciosAnimales();
            serviciosAnimales.Crearespecie(new Crearespecie(textnombre.Text, textnombrecientifico.Text,
                textdescripcion.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

