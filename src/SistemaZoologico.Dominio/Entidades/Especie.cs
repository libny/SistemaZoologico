namespace SistemaZoologico.Dominio.Entidades
{
    public class Especie : IEntidad
    {
        public virtual string Nombre { get; set; }
        public virtual string NombreCientifico { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual int Id { get; set; }
    }
}