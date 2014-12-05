namespace SistemaZoologico.Dominio.Aplicacion.Usuarios.Commandos
{
    public class CrearUsuario
    {
        
        public CrearUsuario(string nombre, string telefono, string contrasena, string usuario, int idRol)
        {
            Nombre = nombre;
            Telefono = telefono;
            Contrasena = contrasena;
            Usuario = usuario;
            IdRol = idRol;
        }

        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }
        public string Usuario { get; set; }
        public int IdRol { get; set; }
    }
}