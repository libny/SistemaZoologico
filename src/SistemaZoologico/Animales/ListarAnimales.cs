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

        void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void ListarAnimales_Load(object sender, EventArgs e)
        {
            var servicio = new ServiciosAnimales();
            listAnimales.DataSource = servicio.ObtenerAnimales();
        }

        void button1_Click(object sender, EventArgs e)
        {
            var animal = listAnimales.SelectedItem as Animal;

            using (var modificar = new ModificacionAnimales(animal))
            {
                modificar.ShowDialog();
            }
        }

        void button3_Click(object sender, EventArgs e)
        {
            using (var report = new VistaPreviaAnimales())
            {
                report.ShowDialog();
            }
        }
    }
}