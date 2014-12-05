using System;
using System.Windows.Forms;
using SistemaZoologico.Dominio.Aplicacion.VentaBoletos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.VentaBoletos
{
    public partial class ReporteVenta : Form
    {
        private ServicioVentaBoletos _servicioVentaBoletos = new ServicioVentaBoletos();
        private Venta _venta;

        public ReporteVenta(int idVenta)
        {
            InitializeComponent();

            _venta = _servicioVentaBoletos.ObtenerVenta(idVenta);
        }

        private void ReporteVenta_Load(object sender, EventArgs e)
        {
           
            
            reportViewer1.RefreshReport();
        }
    }
}