using System.Collections.Generic;

namespace SistemaZoologico.Dominio.Aplicacion.VentaBoletos.Commandos
{
    public class CrearVenta
    {
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public double Total { get; set; }

        public List<DatosDetalleVenta> DetalleVentas { get; set; }
    }
}