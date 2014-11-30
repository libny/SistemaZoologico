namespace SistemaZoologico.Dominio.Entidades
{
    public class Origen : IEntidad
    {
        public static Origen Cautiverio = new Origen(1,"Cautiverio");
        public static Origen Salvaje = new Origen(2,"Salvaje");

        public Origen()
        {
            
        }
        private Origen(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public virtual string Descripcion { get; set; }
        public virtual int Id { get; set; }
    }
}