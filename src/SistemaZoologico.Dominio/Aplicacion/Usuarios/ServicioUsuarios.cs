using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using SistemaZoologico.Dominio.Aplicacion.Usuarios.Commandos;
using SistemaZoologico.Dominio.Datos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Dominio.Aplicacion.Usuarios
{
    public class ServicioUsuarios
    {
        public IEnumerable<Rol> ObtenerRoles()
        {
            using (ISession session = FabricaSession.Crear())
            {
                return session.Query<Rol>().ToList();
            }
        }

        public void CrearUsuario(CrearUsuario datodUsuario)
        {
            using (ISession session = FabricaSession.Crear())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    var rol = session.Get<Rol>(datodUsuario.IdRol);

                    var usuario = new Usuario(datodUsuario.Nombre, datodUsuario.Telefono, datodUsuario.Usuario,
                        datodUsuario.Contrasena, rol);

                    session.SaveOrUpdate(usuario);

                    transaccion.Commit();
                }
            }
        }

        public Usuario ObtenerUsuario(string contrasena, string nombreUsuario)
        {
            ISession session = FabricaSession.Crear();

            Usuario usuario =
                session.Query<Usuario>()
                    .SingleOrDefault(
                        usuario1 => usuario1.NombreUsuario == nombreUsuario && usuario1.Contrasena == contrasena);


            return usuario;
        }
    }
}