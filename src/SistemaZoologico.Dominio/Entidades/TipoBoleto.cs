namespace SistemaZoologico.Dominio.Entidades
{
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