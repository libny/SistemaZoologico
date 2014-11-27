using System.ComponentModel;

namespace SistemaZoologico.Dominio.Aplicacion.VentaBoletos.Commandos
{
    public class DatosDetalleVenta
    {
        public DatosDetalleVenta(int idTipoBoleto, string descripcion, int cantidad, double precio)
        {
            Precio = precio;
            IdTipoBoleto = idTipoBoleto;
            Descripcion = descripcion;
            Cantidad = cantidad;
        }

        [Browsable(false)]
        public int IdTipoBoleto { get; private set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; private set; }

        public double Precio { get; private set; }
        [DisplayName("Cantidad")]
        public int Cantidad { get; set; }

        public double CalcularTotal()
        {
            return Precio*Cantidad;
        }
    }
}