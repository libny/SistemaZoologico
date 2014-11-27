using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos;

namespace SistemaZoologico.VentaBoletos
{
    public partial class VentaBoletos : Form
    {
        
        private readonly ServicioVentaBoletos _servicioVentaBoletos =new ServicioVentaBoletos();

        public VentaBoletos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           comboxtipodeboleto.DataSource = _servicioVentaBoletos.ObtenerTipoBoletos() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}