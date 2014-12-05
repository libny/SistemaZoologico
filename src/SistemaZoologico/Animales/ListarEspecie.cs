using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.Animales;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Animales
{
    public partial class ListarEspecie : Form
    {
        private readonly ServiciosAnimales _serviciosAnimales = new ServiciosAnimales();

        public ListarEspecie()
        {
            InitializeComponent();
        }

        private void ListarEspecie_Load(object sender, EventArgs e)
        {
            listEspecie.DataSource = _serviciosAnimales.ObtenerEspecies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var especie = listEspecie.SelectedItem as Especie;
            if (especie == null) return;
            using (var modificacion = new ModificacionEspecie(especie.Id))
            {
                modificacion.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}