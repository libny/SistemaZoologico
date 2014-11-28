using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos.Commandos;

namespace SistemaZoologico.VentaBoletos
{
    public partial class CrearTipoBoletos : Form
    {
        private readonly ServicioVentaBoletos _servicioVentaBoletos = new ServicioVentaBoletos();

        public CrearTipoBoletos()
        {
            InitializeComponent();
        }

        private void CrearTipoBoletos_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _servicioVentaBoletos.CrearTipoBoleto(new CrearTipoBoleto(txtDescripcion.Text,
                Convert.ToSingle(numPrecio.Value)));

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}