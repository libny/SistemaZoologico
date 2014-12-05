using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.Animales;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Animales
{
    public partial class ListarAnimales : Form
    {
        public ListarAnimales()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListarAnimales_Load(object sender, EventArgs e)
        {
            var servicio = new ServiciosAnimales();
            listAnimales.DataSource = servicio.ObtenerAnimales();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var animal = listAnimales.SelectedItem as Animal;
           
            using (var modificar = new ModificacionAnimales(animal))
            {
                modificar.ShowDialog();
            }
        }
    }
}