using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaZoologico.Dominio.Aplicacion.Animales;

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
    }
}
