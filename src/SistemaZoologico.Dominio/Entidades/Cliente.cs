namespace SistemaZoologico.Dominio.Entidades
{
    public class Cliente : IEntidad
    {
        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
        public virtual string Telefono { get; set; }
        public virtual int Id { get; set; }
    }
}