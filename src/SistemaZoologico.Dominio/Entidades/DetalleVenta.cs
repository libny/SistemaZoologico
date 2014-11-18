namespace SistemaZoologico.Dominio.Entidades
{
    public class DetalleVenta : IEntidad
    {
        public virtual int Cantidad { get; set; }

        public virtual TipoBoleto TipoBoleto { get; set; }
        public virtual int Id { get; set; }
    }
}