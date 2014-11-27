namespace SistemaZoologico.Dominio.Entidades
{
    public class TipoBoleto : IEntidad
    {
        protected TipoBoleto()
        {
        }

        public TipoBoleto(string descripcion, float precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }


        public virtual string Descripcion { get; set; }

        public virtual float Precio { get; set; }

        public virtual int Id { get; set; }
    }
}