namespace SistemaZoologico.Dominio.Entidades
{
    public class Cliente : IEntidad
    {
        public Cliente()
        {
            
        }
        public Cliente(string nombre, string apellido, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
        }

        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
        public virtual string Telefono { get; set; }
        public virtual int Id { get; set; }
    }
}