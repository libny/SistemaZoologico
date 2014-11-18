using System.Collections.Generic;

namespace SistemaZoologico.Dominio.Entidades
{
    public class Venta : IEntidad
    {
        public virtual Cliente Cliente { get; set; }
        public virtual int Id { get; set; }

        public virtual IEnumerable<DetalleVenta> Detalle { get; set; } 
    }

    public class DetalleVenta:IEntidad
    {
        public virtual int Id { get; set; }
    }

    public class Cliente : IEntidad
    {
        public virtual string Nombre { get; set; }
        public virtual string Telefono { get; set; }
        public virtual int Id { get; set; }
    }

    public class TipoBoleto : IEntidad
    {
        protected TipoBoleto()
        {
        }

        public TipoBoleto(string nombre, float precio)
        {
            Nombre = nombre;
            Precio = precio;
        }


        public virtual string Nombre { get; set; }

        public virtual float Precio { get; set; }

        public virtual int Id { get; set; }
    }
}