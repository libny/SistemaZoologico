using System.Collections.Generic;

namespace SistemaZoologico.Dominio.Entidades
{
    public class Venta : IEntidad
    {
        public Venta()
        {
            Detalle = new List<DetalleVenta>();
        }

        public Venta(Cliente cliente)
        {
            Detalle = new List<DetalleVenta>();
            Cliente = cliente;
        }

        public virtual Cliente Cliente { get; set; }

        public virtual IList<DetalleVenta> Detalle { get; set; }

        public virtual float Total { get; set; }

        public virtual int Id { get; set; }

        public virtual void AgregarDetalle(TipoBoleto tipoBoleto, int cantidad)
        {
            Detalle.Add(new DetalleVenta(tipoBoleto, cantidad));
        
        }

        public virtual void CalcularTotal()
        {
            foreach (var detalleVenta in Detalle)
            {
                Total = Total + (detalleVenta.CalcularSubTotal());
            }
        }
    }
}