using System.Collections.Generic;

namespace SistemaZoologico.Dominio.Aplicacion.VentaBoletos.Commandos
{
    public class CrearVenta
    {
        public CrearVenta(string nombreCliente, string apellidoCliente, string telefonoCliente, IList<DatosDetalleVenta> detalleVentas)
        {
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            TelefonoCliente = telefonoCliente;
            DetalleVentas = detalleVentas;
        }

        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public double Total { get; set; }

        public IList<DatosDetalleVenta> DetalleVentas { get; set; }
    }
}