using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos;

namespace SistemaZoologico.VentaBoletos
{
    public partial class ListarTipoDeBoletos : Form
    {
        private readonly ServicioVentaBoletos _servicioVentaBoletos = new ServicioVentaBoletos();
        public ListarTipoDeBoletos()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListarTipoDeBoletos_Load(object sender, EventArgs e)
        {
        listTipoBoleto.DataSource = _servicioVentaBoletos.ObtenerTipoBoletos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
