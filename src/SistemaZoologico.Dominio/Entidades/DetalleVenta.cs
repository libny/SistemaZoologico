namespace SistemaZoologico.Dominio.Entidades
{
    public class DetalleVenta : IEntidad
    {
        public DetalleVenta()
        {
        }

        public DetalleVenta(TipoBoleto tipoBoleto, int cantidad)
        {
            TipoBoleto = tipoBoleto;
            Cantidad = cantidad;
        }

        public virtual int Cantidad { get; set; }

        public virtual TipoBoleto TipoBoleto { get; set; }
        public virtual int Id { get; set; }

        public virtual float CalcularSubTotal()
        {
            return Cantidad*TipoBoleto.Precio;
        }
    }
}