namespace SistemaZoologico.Dominio.Entidades
{
    public class Usuario : IEntidad
    {
        public virtual string Nombre { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string NombreUsuario { get; set; }
        public virtual string Contrasena { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual int Id { get; set; }
    }
}