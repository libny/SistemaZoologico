using System.Collections.Generic;

namespace SistemaZoologico.Dominio.Entidades
{
    public class Venta : IEntidad
    {
        public virtual Cliente Cliente { get; set; }

        public virtual IEnumerable<DetalleVenta> Detalle { get; set; }
        public virtual float Total { get; set; }
        
        public virtual int Id { get; set; }
    }
}