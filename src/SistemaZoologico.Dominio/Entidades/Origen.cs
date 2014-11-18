namespace SistemaZoologico.Dominio.Entidades
{
    public class Origen : IEntidad
    {
        public virtual string Descripcion { get; set; }
        public virtual int Id { get; set; }
    }
}