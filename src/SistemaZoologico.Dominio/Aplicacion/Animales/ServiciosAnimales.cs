using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate;
using NHibernate.Linq;
using SistemaZoologico.Dominio.Aplicacion.Animales.Comandos;
using SistemaZoologico.Dominio.Datos;
using SistemaZoologico.Dominio.Entidades;

namespace SistemaZoologico.Dominio.Aplicacion.Animales
{
    public class ServiciosAnimales
    {
        public void CrearAnimal(Crearanimales datosanimales)

        {
            using (ISession session = FabricaSession.Crear())
            {
                using (ITransaction trasancion = session.BeginTransaction())
                {
                    var especie = session.Get<Especie>(datosanimales.IdEspecie);
                    var animal = new Animal(datosanimales.Nombre, datosanimales.Edad, especie,
                        datosanimales.FechaIngreso,
                        datosanimales.FechaNacimiento, datosanimales.OrigenAnimal);
                    session.SaveOrUpdate(animal);
                    trasancion.Commit();
                }
            }
        }


        public IEnumerable<Especie> ObtenerEspecies()
        {
            using (ISession session = FabricaSession.Crear())
            {
                return session.Query<Especie>().ToList();
            }
        }

        public void Crearespecie(Crearespecie datosespecie)
        {
            using (ISession session = FabricaSession.Crear()) 
            {
                using (ITransaction trasancion = session.BeginTransaction())
                {
                    var especie = new Especie(datosespecie.Nombre,datosespecie.Nombrecientifico,datosespecie.Descripcion);
            session.SaveOrUpdate(especie);
            trasancion.Commit();
                }
            }
           
        }
    }
}
