namespace SistemaZoologico.Dominio.Entidades
{
    public class Rol : IEntidad
    {
        public  virtual string Descripcion { get; set; }
        public virtual int Id { get; set; }
    }
}