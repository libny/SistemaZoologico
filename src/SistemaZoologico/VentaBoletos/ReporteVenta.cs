using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;

using SistemaZoologico.Dominio.Aplicacion.VentaBoletos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.VentaBoletos
{
    public partial class ReporteVenta : Form
    {
        readonly ServicioVentaBoletos _servicioVentaBoletos = new ServicioVentaBoletos();

        readonly Venta _venta;

        public ReporteVenta(int idVenta)
        {
            InitializeComponent();

            _venta = _servicioVentaBoletos.ObtenerVenta(idVenta);
        }

        void ReporteVenta_Load(object sender, EventArgs e)
        {
            var report = new ReporteVentas();
            report.DetalleReportes =
                _venta.Detalle.ToList()
                      .Select(
                          venta =>
                          new DetalleReporte
                              {
                                  Cantidad = venta.Cantidad.ToString(CultureInfo.InvariantCulture),
                                  NombreCliente = _venta.Cliente.Nombre + " " + _venta.Cliente.Apellido,
                                  DescripcionTipoBoleto = venta.TipoBoleto.Descripcion,
                                  SubTotal = venta.CalcularSubTotal(),
                                  Total = _venta.Total
                              })
                      .ToList();

            LocalReport localReport = reportViewer1.LocalReport;

            var bindig = (BindingSource)localReport.DataSources[0].Value;

            foreach (DetalleReporte detalleReporte in report.DetalleReportes)
            {
                bindig.Add(detalleReporte);
            }

            reportViewer1.RefreshReport();
        }
    }
}